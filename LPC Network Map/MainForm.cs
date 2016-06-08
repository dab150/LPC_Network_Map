using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Data.OleDb;

namespace LPC_Network_Map
{
    public partial class MainForm : Form
    {
        //variables
        Point MapClickLocation;

        //structures
        public struct RoomInfo
        {
            public string name;
            public float xcoordmin;
            public float xcoordmax;
            public float ycoordmin;
            public float ycoordmax;
        }

        //lists
        List<RoomInfo> RoomList = new List<RoomInfo> { };
        
        public MainForm()
        {
            //Initialization
            InitializeComponent();
            loadDeviceData();
        }

        private void chkRoomLabels_CheckedChanged(object sender, EventArgs e)
        {
            if(chkRoomLabels.Checked)
            {
                //show room labels
                pictureBox1.Image = (Properties.Resources._1stFloorRoomLabels);
            }
            else
            {
                //hide room labels
                pictureBox1.Image = (Properties.Resources._1stFloorWorkstations);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //determine where cursor is
            float HorRes = Properties.Resources._1stFloorWorkstations.HorizontalResolution;
            float VerRes = Properties.Resources._1stFloorWorkstations.VerticalResolution;
            MapClickLocation = new Point(((int)(pictureBox1.PointToClient(Cursor.Position).X * (HorRes / pictureBox1.Width))),
                                          (int)(pictureBox1.PointToClient(Cursor.Position).Y * (VerRes / pictureBox1.Height)));

            statusClickLocation.Text = MapClickLocation.ToString();

            //determine what room we are in
            xmlRoom(false);

            foreach(var room in RoomList)
            {
                if (MapClickLocation.X > room.xcoordmin && MapClickLocation.X < room.xcoordmax && MapClickLocation.Y > room.ycoordmin && MapClickLocation.Y < room.ycoordmax)
                {
                    statusClickLocation.Text = MapClickLocation.ToString() + " " + room.name;
                }
            }

            //determine what device we just clicked and populate the information fields
            foreach (DataGridViewRow row in dataGridDeviceList.Rows)
            {
                int deviceXCoord = Convert.ToInt16(row.Cells["XCoord"].Value);
                int deviceYCoord = Convert.ToInt16(row.Cells["YCoord"].Value);

                int precisionConstant = 2; //this allows a margin of error for where the user clicks so it will still register click if it isn't EXACTLY on the device

                if ((deviceXCoord >= MapClickLocation.X - precisionConstant &&  deviceXCoord <= MapClickLocation.X + precisionConstant) &&
                    (deviceYCoord >= MapClickLocation.Y - precisionConstant && deviceYCoord <= MapClickLocation.Y + precisionConstant))
                {
                    //populate fields
                    txtDeviceName.Text = row.Cells["Device Name"].Value.ToString();
                    txtUser.Text = row.Cells["User"].Value.ToString();
                    txtMake.Text = row.Cells["Make"].Value.ToString();
                    txtModel.Text = row.Cells["Model"].Value.ToString();
                    txtType.Text = row.Cells["Type"].Value.ToString();
                    txtSerial.Text = row.Cells["Serial"].Value.ToString();
                    txtDepartment.Text = row.Cells["Department"].Value.ToString();
                    txtOS.Text = row.Cells["OS"].Value.ToString();
                    txtProcessor.Text = row.Cells["Processor"].Value.ToString();
                    txtMemory.Text = row.Cells["Memory"].Value.ToString();
                    txtArchitecture.Text = row.Cells["Architecture"].Value.ToString();
                    break;
                }

                else
                {
                    //clear fields
                    txtDeviceName.Clear();
                    txtUser.Clear();
                    txtMake.Clear();
                    txtModel.Clear();
                    txtType.Clear();
                    txtSerial.Clear();
                    txtDepartment.Clear();
                    txtOS.Clear();
                    txtProcessor.Clear();
                    txtMemory.Clear();
                    txtArchitecture.Clear();
                }
            }
        }

        public void xmlRoom(bool write, string filename = "LPC_Room_Computer_List.xml")
        {
            bool exists = File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar + filename);

            if (exists)
            {
                using (XmlTextReader xmlreader = new XmlTextReader(Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar + filename))
                {
                    while (xmlreader.Read())
                    {
                        xmlreader.MoveToElement();
                        switch (xmlreader.Name)
                        {
                            case "Room":
                                {
                                    RoomInfo room = new RoomInfo();

                                    while (xmlreader.Read())
                                    {
                                        bool dobreak = false;
                                        xmlreader.MoveToElement();
                                        switch (xmlreader.Name)
                                        {
                                            case "name":
                                                room.name = xmlreader.ReadString();
                                                break;
                                            case "xcoordmin":
                                                room.xcoordmin = float.Parse(xmlreader.ReadString(), new System.Globalization.CultureInfo("en-US"));
                                                break;
                                            case "xcoordmax":
                                                room.xcoordmax = float.Parse(xmlreader.ReadString(), new System.Globalization.CultureInfo("en-US"));
                                                break;
                                            case "ycoordmin":
                                                room.ycoordmin = float.Parse(xmlreader.ReadString(), new System.Globalization.CultureInfo("en-US"));
                                                break;
                                            case "ycoordmax":
                                                room.ycoordmax = float.Parse(xmlreader.ReadString(), new System.Globalization.CultureInfo("en-US"));
                                                // populate list with this room once we have all of the info. This method requires the xml info to be in order, with ycoordmax being last
                                                RoomList.Add(room);
                                                break;
                                        }
                                        if (dobreak)
                                            break;
                                    }
                                    string temp = xmlreader.ReadString();
                                }
                                break;

                            default:
                                if (xmlreader.Name == "") // line feeds
                                    break;
                                break;
                        }
                    }
                }
            }
        }

        private void deviceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            dataGridDeviceList.Show();
        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Show(); //823, 453
            dataGridDeviceList.Hide();
        }

        //load data from excel file into datagrid
        void loadDeviceData ()
        {
            String name = "DeviceList";
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar + "Workstation Inventory.xlsx" +
                            ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
            con.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridDeviceList.DataSource = data;
        }
    }
}
