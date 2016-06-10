namespace LPC_Network_Map
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.optionPanel = new System.Windows.Forms.Panel();
            this.lblDeviceInfo = new System.Windows.Forms.Label();
            this.txtArchitecture = new System.Windows.Forms.RichTextBox();
            this.txtMemory = new System.Windows.Forms.RichTextBox();
            this.txtProcessor = new System.Windows.Forms.RichTextBox();
            this.txtOS = new System.Windows.Forms.RichTextBox();
            this.txtDepartment = new System.Windows.Forms.RichTextBox();
            this.txtSerial = new System.Windows.Forms.RichTextBox();
            this.txtType = new System.Windows.Forms.RichTextBox();
            this.txtModel = new System.Windows.Forms.RichTextBox();
            this.txtMake = new System.Windows.Forms.RichTextBox();
            this.txtUser = new System.Windows.Forms.RichTextBox();
            this.txtDeviceName = new System.Windows.Forms.RichTextBox();
            this.lblArchitecture = new System.Windows.Forms.Label();
            this.lblMemory = new System.Windows.Forms.Label();
            this.lblProcessor = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusClickLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridDeviceList = new System.Windows.Forms.DataGridView();
            this.areaSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstFloorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondFloorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workstationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstFloorOfficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondFloorOfficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeviceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // optionPanel
            // 
            this.optionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionPanel.Controls.Add(this.lblDeviceInfo);
            this.optionPanel.Controls.Add(this.txtArchitecture);
            this.optionPanel.Controls.Add(this.txtMemory);
            this.optionPanel.Controls.Add(this.txtProcessor);
            this.optionPanel.Controls.Add(this.txtOS);
            this.optionPanel.Controls.Add(this.txtDepartment);
            this.optionPanel.Controls.Add(this.txtSerial);
            this.optionPanel.Controls.Add(this.txtType);
            this.optionPanel.Controls.Add(this.txtModel);
            this.optionPanel.Controls.Add(this.txtMake);
            this.optionPanel.Controls.Add(this.txtUser);
            this.optionPanel.Controls.Add(this.txtDeviceName);
            this.optionPanel.Controls.Add(this.lblArchitecture);
            this.optionPanel.Controls.Add(this.lblMemory);
            this.optionPanel.Controls.Add(this.lblProcessor);
            this.optionPanel.Controls.Add(this.lblOS);
            this.optionPanel.Controls.Add(this.lblDepartment);
            this.optionPanel.Controls.Add(this.lblSerial);
            this.optionPanel.Controls.Add(this.lblType);
            this.optionPanel.Controls.Add(this.lblModel);
            this.optionPanel.Controls.Add(this.lblMake);
            this.optionPanel.Controls.Add(this.lblUser);
            this.optionPanel.Controls.Add(this.lblDeviceName);
            this.optionPanel.Location = new System.Drawing.Point(841, 12);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(303, 453);
            this.optionPanel.TabIndex = 3;
            // 
            // lblDeviceInfo
            // 
            this.lblDeviceInfo.AutoSize = true;
            this.lblDeviceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceInfo.Location = new System.Drawing.Point(69, 26);
            this.lblDeviceInfo.Name = "lblDeviceInfo";
            this.lblDeviceInfo.Size = new System.Drawing.Size(212, 26);
            this.lblDeviceInfo.TabIndex = 24;
            this.lblDeviceInfo.Text = "Selected Device Info";
            // 
            // txtArchitecture
            // 
            this.txtArchitecture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArchitecture.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtArchitecture.Location = new System.Drawing.Point(109, 349);
            this.txtArchitecture.Name = "txtArchitecture";
            this.txtArchitecture.ReadOnly = true;
            this.txtArchitecture.Size = new System.Drawing.Size(131, 22);
            this.txtArchitecture.TabIndex = 23;
            this.txtArchitecture.Text = "";
            this.txtArchitecture.WordWrap = false;
            // 
            // txtMemory
            // 
            this.txtMemory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMemory.Location = new System.Drawing.Point(109, 321);
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.ReadOnly = true;
            this.txtMemory.Size = new System.Drawing.Size(131, 22);
            this.txtMemory.TabIndex = 22;
            this.txtMemory.Text = "";
            this.txtMemory.WordWrap = false;
            // 
            // txtProcessor
            // 
            this.txtProcessor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcessor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProcessor.Location = new System.Drawing.Point(109, 293);
            this.txtProcessor.Name = "txtProcessor";
            this.txtProcessor.ReadOnly = true;
            this.txtProcessor.Size = new System.Drawing.Size(131, 22);
            this.txtProcessor.TabIndex = 21;
            this.txtProcessor.Text = "";
            this.txtProcessor.WordWrap = false;
            // 
            // txtOS
            // 
            this.txtOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOS.Location = new System.Drawing.Point(109, 265);
            this.txtOS.Name = "txtOS";
            this.txtOS.ReadOnly = true;
            this.txtOS.Size = new System.Drawing.Size(131, 22);
            this.txtOS.TabIndex = 20;
            this.txtOS.Text = "";
            this.txtOS.WordWrap = false;
            // 
            // txtDepartment
            // 
            this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDepartment.Location = new System.Drawing.Point(109, 237);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(131, 22);
            this.txtDepartment.TabIndex = 19;
            this.txtDepartment.Text = "";
            this.txtDepartment.WordWrap = false;
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSerial.Location = new System.Drawing.Point(109, 209);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(131, 22);
            this.txtSerial.TabIndex = 18;
            this.txtSerial.Text = "";
            this.txtSerial.WordWrap = false;
            // 
            // txtType
            // 
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtType.Location = new System.Drawing.Point(109, 179);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(131, 22);
            this.txtType.TabIndex = 17;
            this.txtType.Text = "";
            this.txtType.WordWrap = false;
            // 
            // txtModel
            // 
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtModel.Location = new System.Drawing.Point(109, 151);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(131, 22);
            this.txtModel.TabIndex = 16;
            this.txtModel.Text = "";
            this.txtModel.WordWrap = false;
            // 
            // txtMake
            // 
            this.txtMake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMake.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMake.Location = new System.Drawing.Point(109, 123);
            this.txtMake.Name = "txtMake";
            this.txtMake.ReadOnly = true;
            this.txtMake.Size = new System.Drawing.Size(131, 22);
            this.txtMake.TabIndex = 15;
            this.txtMake.Text = "";
            this.txtMake.WordWrap = false;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUser.Location = new System.Drawing.Point(109, 95);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(131, 22);
            this.txtUser.TabIndex = 14;
            this.txtUser.Text = "";
            this.txtUser.WordWrap = false;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeviceName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDeviceName.Location = new System.Drawing.Point(109, 67);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.ReadOnly = true;
            this.txtDeviceName.Size = new System.Drawing.Size(131, 22);
            this.txtDeviceName.TabIndex = 13;
            this.txtDeviceName.Text = "";
            this.txtDeviceName.WordWrap = false;
            // 
            // lblArchitecture
            // 
            this.lblArchitecture.AutoSize = true;
            this.lblArchitecture.Location = new System.Drawing.Point(36, 352);
            this.lblArchitecture.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.lblArchitecture.Name = "lblArchitecture";
            this.lblArchitecture.Size = new System.Drawing.Size(67, 13);
            this.lblArchitecture.TabIndex = 12;
            this.lblArchitecture.Text = "Architecture:";
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new System.Drawing.Point(56, 324);
            this.lblMemory.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(47, 13);
            this.lblMemory.TabIndex = 11;
            this.lblMemory.Text = "Memory:";
            // 
            // lblProcessor
            // 
            this.lblProcessor.AutoSize = true;
            this.lblProcessor.Location = new System.Drawing.Point(46, 296);
            this.lblProcessor.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(57, 13);
            this.lblProcessor.TabIndex = 10;
            this.lblProcessor.Text = "Processor:";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(10, 268);
            this.lblOS.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(93, 13);
            this.lblOS.TabIndex = 9;
            this.lblOS.Text = "Operating System:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(38, 240);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 13);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "Department:";
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(27, 212);
            this.lblSerial.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(76, 13);
            this.lblSerial.TabIndex = 7;
            this.lblSerial.Text = "Serial Number:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(69, 182);
            this.lblType.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(64, 154);
            this.lblModel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(66, 126);
            this.lblMake.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 4;
            this.lblMake.Text = "Make:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(71, 98);
            this.lblUser.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User:";
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(28, 70);
            this.lblDeviceName.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(75, 13);
            this.lblDeviceName.TabIndex = 2;
            this.lblDeviceName.Text = "Device Name:";
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.Location = new System.Drawing.Point(0, 455);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1156, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusClickLocation
            // 
            this.statusClickLocation.Name = "statusClickLocation";
            this.statusClickLocation.Size = new System.Drawing.Size(92, 17);
            this.statusClickLocation.Text = "Mouse Location";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mapToolStripMenuItem.Text = "Device Map";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.mapToolStripMenuItem_Click);
            // 
            // deviceListToolStripMenuItem
            // 
            this.deviceListToolStripMenuItem.Name = "deviceListToolStripMenuItem";
            this.deviceListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deviceListToolStripMenuItem.Text = "Device List";
            this.deviceListToolStripMenuItem.Click += new System.EventHandler(this.deviceListToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem1,
            this.LocationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridDeviceList
            // 
            this.dataGridDeviceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDeviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDeviceList.Location = new System.Drawing.Point(12, 27);
            this.dataGridDeviceList.Name = "dataGridDeviceList";
            this.dataGridDeviceList.Size = new System.Drawing.Size(823, 425);
            this.dataGridDeviceList.TabIndex = 7;
            this.dataGridDeviceList.Visible = false;
            // 
            // areaSelectionToolStripMenuItem
            // 
            this.areaSelectionToolStripMenuItem.Name = "areaSelectionToolStripMenuItem";
            this.areaSelectionToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.areaSelectionToolStripMenuItem.Text = "Area Selection";
            // 
            // firstFloorToolStripMenuItem
            // 
            this.firstFloorToolStripMenuItem.Name = "firstFloorToolStripMenuItem";
            this.firstFloorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.firstFloorToolStripMenuItem.Text = "First Floor Office";
            this.firstFloorToolStripMenuItem.Click += new System.EventHandler(this.firstFloorToolStripMenuItem_Click);
            // 
            // secondFloorToolStripMenuItem
            // 
            this.secondFloorToolStripMenuItem.Name = "secondFloorToolStripMenuItem";
            this.secondFloorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.secondFloorToolStripMenuItem.Text = "Second Floor Office";
            this.secondFloorToolStripMenuItem.Click += new System.EventHandler(this.secondFloorToolStripMenuItem_Click);
            // 
            // warehouseToolStripMenuItem
            // 
            this.warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            this.warehouseToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.warehouseToolStripMenuItem.Text = "Warehouse";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // printersToolStripMenuItem
            // 
            this.printersToolStripMenuItem.Name = "printersToolStripMenuItem";
            this.printersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printersToolStripMenuItem.Text = "Printers";
            // 
            // workstationsToolStripMenuItem
            // 
            this.workstationsToolStripMenuItem.Checked = true;
            this.workstationsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.workstationsToolStripMenuItem.Name = "workstationsToolStripMenuItem";
            this.workstationsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.workstationsToolStripMenuItem.Text = "Workstations";
            // 
            // serversToolStripMenuItem
            // 
            this.serversToolStripMenuItem.Name = "serversToolStripMenuItem";
            this.serversToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.serversToolStripMenuItem.Text = "Servers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::LPC_Network_Map.Properties.Resources._1stFloorWorkstations;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(823, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceMapToolStripMenuItem,
            this.deviceListToolStripMenuItem1});
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem1.Text = "View";
            // 
            // deviceMapToolStripMenuItem
            // 
            this.deviceMapToolStripMenuItem.Name = "deviceMapToolStripMenuItem";
            this.deviceMapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deviceMapToolStripMenuItem.Text = "Device Map";
            this.deviceMapToolStripMenuItem.Click += new System.EventHandler(this.mapToolStripMenuItem_Click);
            // 
            // deviceListToolStripMenuItem1
            // 
            this.deviceListToolStripMenuItem1.Name = "deviceListToolStripMenuItem1";
            this.deviceListToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.deviceListToolStripMenuItem1.Text = "Device List";
            this.deviceListToolStripMenuItem1.Click += new System.EventHandler(this.deviceListToolStripMenuItem_Click);
            // 
            // LocationToolStripMenuItem
            // 
            this.LocationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstFloorOfficeToolStripMenuItem,
            this.secondFloorOfficeToolStripMenuItem});
            this.LocationToolStripMenuItem.Name = "LocationToolStripMenuItem";
            this.LocationToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.LocationToolStripMenuItem.Text = "Location";
            // 
            // firstFloorOfficeToolStripMenuItem
            // 
            this.firstFloorOfficeToolStripMenuItem.Name = "firstFloorOfficeToolStripMenuItem";
            this.firstFloorOfficeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.firstFloorOfficeToolStripMenuItem.Text = "First Floor Office";
            this.firstFloorOfficeToolStripMenuItem.Click += new System.EventHandler(this.firstFloorToolStripMenuItem_Click);
            // 
            // secondFloorOfficeToolStripMenuItem
            // 
            this.secondFloorOfficeToolStripMenuItem.Name = "secondFloorOfficeToolStripMenuItem";
            this.secondFloorOfficeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.secondFloorOfficeToolStripMenuItem.Text = "Second Floor Office";
            this.secondFloorOfficeToolStripMenuItem.Click += new System.EventHandler(this.secondFloorToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 477);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.optionPanel);
            this.Controls.Add(this.dataGridDeviceList);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Network Map";
            this.optionPanel.ResumeLayout(false);
            this.optionPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeviceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusClickLocation;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceListToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridDeviceList;
        private System.Windows.Forms.Label lblArchitecture;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Label lblProcessor;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.RichTextBox txtUser;
        private System.Windows.Forms.RichTextBox txtDeviceName;
        private System.Windows.Forms.RichTextBox txtArchitecture;
        private System.Windows.Forms.RichTextBox txtMemory;
        private System.Windows.Forms.RichTextBox txtProcessor;
        private System.Windows.Forms.RichTextBox txtOS;
        private System.Windows.Forms.RichTextBox txtDepartment;
        private System.Windows.Forms.RichTextBox txtSerial;
        private System.Windows.Forms.RichTextBox txtType;
        private System.Windows.Forms.RichTextBox txtModel;
        private System.Windows.Forms.RichTextBox txtMake;
        private System.Windows.Forms.Label lblDeviceInfo;
        private System.Windows.Forms.ToolStripMenuItem areaSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstFloorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondFloorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workstationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deviceMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem LocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstFloorOfficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondFloorOfficeToolStripMenuItem;
    }
}

