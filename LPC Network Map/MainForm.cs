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
        String VisibleArea = "1st Floor";

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

            Size MaxSize = new Size((int)(pictureBox1.Image.Size.Width * 1.25), (int)(pictureBox1.Image.Size.Height * 1.25));
            Size MinSize = new Size((int)(pictureBox1.Image.Size.Width * .5), (int)(pictureBox1.Image.Size.Height * .5));
            pictureBox1.MaximumSize = MaxSize;
            pictureBox1.MinimumSize = MinSize;
        }


        private void firstFloorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Properties.Resources._1stFloorWorkstations);
            VisibleArea = "1st Floor";
            firstFloorOfficeToolStripMenuItem.Checked = true;
            secondFloorOfficeToolStripMenuItem.Checked = false;
        }

        private void secondFloorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Properties.Resources._2ndFloorWorkstations);
            VisibleArea = "2nd Floor";
            firstFloorOfficeToolStripMenuItem.Checked = false;
            secondFloorOfficeToolStripMenuItem.Checked = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //determine where cursor 
            float HorRes = Properties.Resources._1stFloorWorkstations.HorizontalResolution;
            float VerRes = Properties.Resources._1stFloorWorkstations.VerticalResolution;
            MapClickLocation = new Point(((int)(pictureBox1.PointToClient((Cursor.Position)).X * (HorRes / pictureBox1.Width))),
                                          (int)(pictureBox1.PointToClient((Cursor.Position)).Y * (VerRes / pictureBox1.Height)));

            toolStripStatusLabel.Text = MapClickLocation.ToString();

            //determine what room we are in
            //xmlRoom(false);

            //foreach(var room in RoomList)
            //{
            //    if (MapClickLocation.X > room.xcoordmin && MapClickLocation.X < room.xcoordmax && MapClickLocation.Y > room.ycoordmin && MapClickLocation.Y < room.ycoordmax)
            //    {
            //        statusClickLocation.Text = MapClickLocation.ToString() + " " + room.name;
            //    }
            //}

            //determine what device we just clicked and populate the information fields
            foreach (DataGridViewRow row in dataGridDeviceList.Rows)
            {
                int deviceXCoord = Convert.ToInt16(row.Cells["XCoord"].Value);
                int deviceYCoord = Convert.ToInt16(row.Cells["YCoord"].Value);
                String deviceArea = Convert.ToString(row.Cells["Area"].Value);

                int precisionConstant = 1; //this allows a margin of error for where the user clicks so it will still register click if it isn't EXACTLY on the device

                if ((deviceXCoord >= MapClickLocation.X - precisionConstant &&  deviceXCoord <= MapClickLocation.X + precisionConstant) &&
                    (deviceYCoord >= MapClickLocation.Y - precisionConstant && deviceYCoord <= MapClickLocation.Y + precisionConstant) &&
                    (deviceArea == VisibleArea))
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

            //repaint the picturebox
            pictureBox1.Refresh();
        }

        //public void xmlRoom(bool write, string filename = "LPC_Room_Computer_List.xml")
        //{
        //    bool exists = File.Exists(filename); //File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar + filename);

        //    if (exists)
        //    {
        //        using (XmlTextReader xmlreader = new XmlTextReader(filename))
        //        {
        //            while (xmlreader.Read())
        //            {
        //                xmlreader.MoveToElement();
        //                switch (xmlreader.Name)
        //                {
        //                    case "Room":
        //                        {
        //                            RoomInfo room = new RoomInfo();

        //                            while (xmlreader.Read())
        //                            {
        //                                bool dobreak = false;
        //                                xmlreader.MoveToElement();
        //                                switch (xmlreader.Name)
        //                                {
        //                                    case "name":
        //                                        room.name = xmlreader.ReadString();
        //                                        break;
        //                                    case "xcoordmin":
        //                                        room.xcoordmin = float.Parse(xmlreader.ReadString(), new System.Globalization.CultureInfo("en-US"));
        //                                        break;
        //                                    case "xcoordmax":
        //                                        room.xcoordmax = float.Parse(xmlreader.ReadString(), new System.Globalization.CultureInfo("en-US"));
        //                                        break;
        //                                    case "ycoordmin":
        //                                        room.ycoordmin = float.Parse(xmlreader.ReadString(), new System.Globalization.CultureInfo("en-US"));
        //                                        break;
        //                                    case "ycoordmax":
        //                                        room.ycoordmax = float.Parse(xmlreader.ReadString(), new System.Globalization.CultureInfo("en-US"));
        //                                        // populate list with this room once we have all of the info. This method requires the xml info to be in order, with ycoordmax being last
        //                                        RoomList.Add(room);
        //                                        break;
        //                                }
        //                                if (dobreak)
        //                                    break;
        //                            }
        //                            string temp = xmlreader.ReadString();
        //                        }
        //                        break;

        //                    default:
        //                        if (xmlreader.Name == "") // line feeds
        //                            break;
        //                        break;
        //                }
        //            }
        //        }
        //    }
        //}

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
            try
            {
                //first access file in resources and save it as a temp file
                string sPath = Path.GetTempFileName();
                File.WriteAllBytes(sPath, Properties.Resources.Workstation_Inventory);

                String name = "DeviceList";

                String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                                sPath +
                                //Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar + "Workstation Inventory.xlsx" +
                                ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

                OleDbConnection con = new OleDbConnection(constr);
                OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
                con.Open();

                OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridDeviceList.DataSource = data;
            }
            catch (Exception e) { MessageBox.Show("Error loading Workstation Inventory.xlsx: " + e.Message); }
        }

        private void dataGridDeviceList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //int XCoord = Convert.ToInt16(dataGridDeviceList..ToString());
        }

        private void dataGridDeviceList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            float HorRes = Properties.Resources._1stFloorWorkstations.HorizontalResolution;
            float VerRes = Properties.Resources._1stFloorWorkstations.VerticalResolution;


            int SelectedRow = e.RowIndex;
            int XCoordinate = Convert.ToInt16(Convert.ToDouble(dataGridDeviceList.Rows[SelectedRow].Cells["XCoord"].Value) * ((double)pictureBox1.Width/(double)HorRes));
            int YCoordinate = Convert.ToInt16(Convert.ToDouble(dataGridDeviceList.Rows[SelectedRow].Cells["YCoord"].Value) * ((double)pictureBox1.Height/(double)VerRes));
            Point DevicePoint = new Point(XCoordinate, YCoordinate);
            String Area = (dataGridDeviceList.Rows[SelectedRow].Cells["Area"].Value.ToString());

            if(Area == "1st Floor")
            {
                mapToolStripMenuItem.PerformClick();
                firstFloorOfficeToolStripMenuItem.PerformClick();
                Cursor.Position = pictureBox1.PointToScreen(DevicePoint);

            }
            else if (Area == "2nd Floor")
            {
                mapToolStripMenuItem.PerformClick();
                secondFloorOfficeToolStripMenuItem.PerformClick();
                pictureBox1.Cursor = new Cursor(Cursor.Current.Handle);
                //Cursor.Position = new Point(XCoord, YCoord);
            }
            else
            {
                MessageBox.Show("Error: This device's location is unknown.");
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //int XCoord = 0;
            //int YCoord = 0;
            //if (txtDeviceName.Text != "")
            //{
            //    foreach (DataGridViewRow row in dataGridDeviceList.Rows)
            //    {
            //        if (txtDeviceName.Text == (row.Cells["Device Name"].Value).ToString())
            //        {
            //            //check if the serial numbers match. We do this because some devices may have the same name.
            //            //We do not rely only on serial numbers because not all serial numbers are recorded.
            //            if (txtSerial.Text != "" && txtSerial.Text == (row.Cells["Serial"].Value).ToString())
            //            {
            //                float HorRes = Properties.Resources._1stFloorWorkstations.HorizontalResolution;
            //                float VerRes = Properties.Resources._1stFloorWorkstations.VerticalResolution;

            //                XCoord = Convert.ToInt16(Convert.ToDouble(row.Cells["XCoord"].Value) * ((double)pictureBox1.Width / (double)HorRes));
            //                YCoord = Convert.ToInt16(Convert.ToDouble(row.Cells["Ycoord"].Value) * ((double)pictureBox1.Height / (double)VerRes));

            //                Rectangle ee = new Rectangle(XCoord - 10, YCoord - 10, 40, 40);
            //                using (Pen pen = new Pen(Color.Yellow, 2))
            //                {
            //                    e.Graphics.DrawRectangle(pen, ee);
            //                }
            //                break;
            //            }
            //        }
            //    }
            //}
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            pictureBox1.Width = pictureBox1.Image.Width;
            pictureBox1.Height = pictureBox1.Image.Height;
        }
    }
}
