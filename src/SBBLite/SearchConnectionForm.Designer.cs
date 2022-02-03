namespace SBBLite
{
    partial class SearchConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchConnectionForm));
            this.ConnectinoSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtPDate = new System.Windows.Forms.DateTimePicker();
            this.lblDestinationStation = new System.Windows.Forms.Label();
            this.lblStartStation = new System.Windows.Forms.Label();
            this.SwitchPicture = new System.Windows.Forms.PictureBox();
            this.txtDestinationStation = new System.Windows.Forms.TextBox();
            this.txtStartStation = new System.Windows.Forms.TextBox();
            this.dgvConnectionList = new System.Windows.Forms.DataGridView();
            this.platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Starttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrivetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.HomePicture = new System.Windows.Forms.PictureBox();
            this.MailPicture = new System.Windows.Forms.PictureBox();
            this.ConnectinoSearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnectionList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectinoSearchGroupBox
            // 
            this.ConnectinoSearchGroupBox.Controls.Add(this.btnSearch);
            this.ConnectinoSearchGroupBox.Controls.Add(this.lblDate);
            this.ConnectinoSearchGroupBox.Controls.Add(this.dtPDate);
            this.ConnectinoSearchGroupBox.Controls.Add(this.lblDestinationStation);
            this.ConnectinoSearchGroupBox.Controls.Add(this.lblStartStation);
            this.ConnectinoSearchGroupBox.Controls.Add(this.SwitchPicture);
            this.ConnectinoSearchGroupBox.Controls.Add(this.txtDestinationStation);
            this.ConnectinoSearchGroupBox.Controls.Add(this.txtStartStation);
            this.ConnectinoSearchGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConnectinoSearchGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ConnectinoSearchGroupBox.MaximumSize = new System.Drawing.Size(640, 172);
            this.ConnectinoSearchGroupBox.MinimumSize = new System.Drawing.Size(640, 172);
            this.ConnectinoSearchGroupBox.Name = "ConnectinoSearchGroupBox";
            this.ConnectinoSearchGroupBox.Size = new System.Drawing.Size(640, 172);
            this.ConnectinoSearchGroupBox.TabIndex = 0;
            this.ConnectinoSearchGroupBox.TabStop = false;
            this.ConnectinoSearchGroupBox.Text = "Verbindung suchen";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(485, 132);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Verbindung suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(6, 100);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 28);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Datum";
            // 
            // dtPDate
            // 
            this.dtPDate.Location = new System.Drawing.Point(8, 131);
            this.dtPDate.Name = "dtPDate";
            this.dtPDate.Size = new System.Drawing.Size(304, 30);
            this.dtPDate.TabIndex = 1;
            this.dtPDate.Value = new System.DateTime(2022, 2, 3, 14, 8, 45, 0);
            // 
            // lblDestinationStation
            // 
            this.lblDestinationStation.AutoSize = true;
            this.lblDestinationStation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestinationStation.Location = new System.Drawing.Point(369, 25);
            this.lblDestinationStation.Name = "lblDestinationStation";
            this.lblDestinationStation.Size = new System.Drawing.Size(105, 28);
            this.lblDestinationStation.TabIndex = 5;
            this.lblDestinationStation.Text = "Endstation";
            // 
            // lblStartStation
            // 
            this.lblStartStation.AutoSize = true;
            this.lblStartStation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStartStation.Location = new System.Drawing.Point(6, 25);
            this.lblStartStation.Name = "lblStartStation";
            this.lblStartStation.Size = new System.Drawing.Size(138, 28);
            this.lblStartStation.TabIndex = 3;
            this.lblStartStation.Text = "Abfahrtstation";
            // 
            // SwitchPicture
            // 
            this.SwitchPicture.Image = ((System.Drawing.Image)(resources.GetObject("SwitchPicture.Image")));
            this.SwitchPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("SwitchPicture.InitialImage")));
            this.SwitchPicture.Location = new System.Drawing.Point(297, 52);
            this.SwitchPicture.Name = "SwitchPicture";
            this.SwitchPicture.Size = new System.Drawing.Size(48, 38);
            this.SwitchPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SwitchPicture.TabIndex = 2;
            this.SwitchPicture.TabStop = false;
            this.SwitchPicture.Click += new System.EventHandler(this.Icon_Click);
            // 
            // txtDestinationStation
            // 
            this.txtDestinationStation.Location = new System.Drawing.Point(369, 57);
            this.txtDestinationStation.Name = "txtDestinationStation";
            this.txtDestinationStation.Size = new System.Drawing.Size(262, 30);
            this.txtDestinationStation.TabIndex = 1;
            this.txtDestinationStation.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtStartStation
            // 
            this.txtStartStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartStation.Location = new System.Drawing.Point(8, 57);
            this.txtStartStation.Name = "txtStartStation";
            this.txtStartStation.Size = new System.Drawing.Size(262, 30);
            this.txtStartStation.TabIndex = 0;
            this.txtStartStation.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // dgvConnectionList
            // 
            this.dgvConnectionList.AllowUserToAddRows = false;
            this.dgvConnectionList.AllowUserToDeleteRows = false;
            this.dgvConnectionList.AllowUserToResizeRows = false;
            this.dgvConnectionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConnectionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConnectionList.BackgroundColor = System.Drawing.Color.White;
            this.dgvConnectionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnectionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.platform,
            this.Abfahrtstation,
            this.Endstation,
            this.Starttime,
            this.Arrivetime});
            this.dgvConnectionList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvConnectionList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvConnectionList.Location = new System.Drawing.Point(12, 209);
            this.dgvConnectionList.MultiSelect = false;
            this.dgvConnectionList.Name = "dgvConnectionList";
            this.dgvConnectionList.ReadOnly = true;
            this.dgvConnectionList.RowHeadersWidth = 51;
            this.dgvConnectionList.RowTemplate.Height = 29;
            this.dgvConnectionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConnectionList.Size = new System.Drawing.Size(815, 271);
            this.dgvConnectionList.TabIndex = 100;
            // 
            // platform
            // 
            this.platform.HeaderText = "Kante";
            this.platform.MinimumWidth = 6;
            this.platform.Name = "platform";
            this.platform.ReadOnly = true;
            // 
            // Abfahrtstation
            // 
            this.Abfahrtstation.HeaderText = "Abfahrtstation";
            this.Abfahrtstation.MinimumWidth = 6;
            this.Abfahrtstation.Name = "Abfahrtstation";
            this.Abfahrtstation.ReadOnly = true;
            // 
            // Endstation
            // 
            this.Endstation.HeaderText = "Endstation";
            this.Endstation.MinimumWidth = 6;
            this.Endstation.Name = "Endstation";
            this.Endstation.ReadOnly = true;
            // 
            // Starttime
            // 
            this.Starttime.HeaderText = "Abfahrtszeit";
            this.Starttime.MinimumWidth = 6;
            this.Starttime.Name = "Starttime";
            this.Starttime.ReadOnly = true;
            // 
            // Arrivetime
            // 
            this.Arrivetime.HeaderText = "Ankunftszeit";
            this.Arrivetime.MinimumWidth = 6;
            this.Arrivetime.Name = "Arrivetime";
            this.Arrivetime.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(839, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.LinkColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // HomePicture
            // 
            this.HomePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomePicture.Image = ((System.Drawing.Image)(resources.GetObject("HomePicture.Image")));
            this.HomePicture.Location = new System.Drawing.Point(757, 21);
            this.HomePicture.Name = "HomePicture";
            this.HomePicture.Size = new System.Drawing.Size(57, 57);
            this.HomePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePicture.TabIndex = 103;
            this.HomePicture.TabStop = false;
            this.HomePicture.Click += new System.EventHandler(this.Icon_Click);
            // 
            // MailPicture
            // 
            this.MailPicture.Image = ((System.Drawing.Image)(resources.GetObject("MailPicture.Image")));
            this.MailPicture.Location = new System.Drawing.Point(681, 21);
            this.MailPicture.Name = "MailPicture";
            this.MailPicture.Size = new System.Drawing.Size(57, 57);
            this.MailPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MailPicture.TabIndex = 104;
            this.MailPicture.TabStop = false;
            this.MailPicture.Click += new System.EventHandler(this.Icon_Click);
            // 
            // SearchConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 515);
            this.Controls.Add(this.MailPicture);
            this.Controls.Add(this.HomePicture);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvConnectionList);
            this.Controls.Add(this.ConnectinoSearchGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchConnectionForm";
            this.Text = "Verbindungen";
            this.Shown += new System.EventHandler(this.SearchConnectionForm_Shown);
            this.ConnectinoSearchGroupBox.ResumeLayout(false);
            this.ConnectinoSearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnectionList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox ConnectinoSearchGroupBox;
        private PictureBox SwitchPicture;
        private TextBox txtDestinationStation;
        private TextBox txtStartStation;
        private Button btnSearch;
        private Label lblDate;
        private DateTimePicker dtPDate;
        private Label lblDestinationStation;
        private Label lblStartStation;
        private DataGridView dgvConnectionList;
        private DataGridViewTextBoxColumn platform;
        private DataGridViewTextBoxColumn Abfahrtstation;
        private DataGridViewTextBoxColumn Endstation;
        private DataGridViewTextBoxColumn Starttime;
        private DataGridViewTextBoxColumn Arrivetime;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox HomePicture;
        private PictureBox MailPicture;
    }
}