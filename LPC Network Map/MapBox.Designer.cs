namespace LPC_Network_Map
{
    partial class MapBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainMap)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMap
            // 
            this.MainMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMap.Image = global::LPC_Network_Map.Properties.Resources._1stFloor;
            this.MainMap.Location = new System.Drawing.Point(0, 0);
            this.MainMap.Name = "MainMap";
            this.MainMap.Size = new System.Drawing.Size(729, 403);
            this.MainMap.TabIndex = 0;
            this.MainMap.TabStop = false;
            this.MainMap.Click += new System.EventHandler(this.MainMap_Click);
            // 
            // MapBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.MainMap);
            this.Name = "MapBox";
            this.Size = new System.Drawing.Size(729, 403);
            ((System.ComponentModel.ISupportInitialize)(this.MainMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainMap;
    }
}
