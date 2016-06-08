using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPC_Network_Map
{
    public partial class MapBox : UserControl
    {
        //global variables
        List<Image> BackgroundLayers = new List<Image>();

        public MapBox()
        {
            InitializeComponent();
        }

        void addLayer(Image layer)
        {
            BackgroundLayers.Add(layer);
        }

        public void showLayer(Image layer)
        {
            MainMap.Image = layer;
        }

        private void MainMap_Click(object sender, EventArgs e)
        {

        }
    }


}

