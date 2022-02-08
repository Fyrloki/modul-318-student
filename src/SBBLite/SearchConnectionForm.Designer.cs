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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ConnectinoSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.radioArrive = new System.Windows.Forms.RadioButton();
            this.radioDepart = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtPDate = new System.Windows.Forms.DateTimePicker();
            this.lblDestinationStation = new System.Windows.Forms.Label();
            this.lblStartStation = new System.Windows.Forms.Label();
            this.SwitchPicture = new System.Windows.Forms.PictureBox();
            this.txtDestinationStation = new System.Windows.Forms.TextBox();
            this.txtStartStation = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvConnectionList = new System.Windows.Forms.DataGridView();
            this.platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Starttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrivetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomePicture = new System.Windows.Forms.PictureBox();
            this.MailPicture = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStriplableOne = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConnectinoSearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnectionList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailPicture)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectinoSearchGroupBox
            // 
            this.ConnectinoSearchGroupBox.Controls.Add(this.dtpTime);
            this.ConnectinoSearchGroupBox.Controls.Add(this.radioArrive);
            this.ConnectinoSearchGroupBox.Controls.Add(this.radioDepart);
            this.ConnectinoSearchGroupBox.Controls.Add(this.lblDate);
            this.ConnectinoSearchGroupBox.Controls.Add(this.dtPDate);
            this.ConnectinoSearchGroupBox.Controls.Add(this.lblDestinationStation);
            this.ConnectinoSearchGroupBox.Controls.Add(this.lblStartStation);
            this.ConnectinoSearchGroupBox.Controls.Add(this.SwitchPicture);
            this.ConnectinoSearchGroupBox.Controls.Add(this.txtDestinationStation);
            this.ConnectinoSearchGroupBox.Controls.Add(this.txtStartStation);
            this.ConnectinoSearchGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConnectinoSearchGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ConnectinoSearchGroupBox.MinimumSize = new System.Drawing.Size(640, 172);
            this.ConnectinoSearchGroupBox.Name = "ConnectinoSearchGroupBox";
            this.ConnectinoSearchGroupBox.Size = new System.Drawing.Size(661, 175);
            this.ConnectinoSearchGroupBox.TabIndex = 0;
            this.ConnectinoSearchGroupBox.TabStop = false;
            this.ConnectinoSearchGroupBox.Text = "Verbindung suchen";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(311, 131);
            this.dtpTime.MinDate = new System.DateTime(2022, 2, 8, 0, 0, 0, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(90, 30);
            this.dtpTime.TabIndex = 106;
            this.dtpTime.Tag = "Time";
            // 
            // radioArrive
            // 
            this.radioArrive.AutoSize = true;
            this.radioArrive.Location = new System.Drawing.Point(546, 133);
            this.radioArrive.Name = "radioArrive";
            this.radioArrive.Size = new System.Drawing.Size(91, 27);
            this.radioArrive.TabIndex = 106;
            this.radioArrive.Tag = "Arrive";
            this.radioArrive.Text = "Ankunft";
            this.radioArrive.UseVisualStyleBackColor = true;
            // 
            // radioDepart
            // 
            this.radioDepart.AutoSize = true;
            this.radioDepart.Checked = true;
            this.radioDepart.Location = new System.Drawing.Point(432, 133);
            this.radioDepart.Name = "radioDepart";
            this.radioDepart.Size = new System.Drawing.Size(88, 27);
            this.radioDepart.TabIndex = 106;
            this.radioDepart.TabStop = true;
            this.radioDepart.Tag = "Depart";
            this.radioDepart.Text = "Abfahrt";
            this.radioDepart.UseVisualStyleBackColor = true;
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
            this.dtPDate.MinDate = new System.DateTime(2022, 2, 8, 0, 0, 0, 0);
            this.dtPDate.Name = "dtPDate";
            this.dtPDate.Size = new System.Drawing.Size(297, 30);
            this.dtPDate.TabIndex = 200;
            this.dtPDate.Value = new System.DateTime(2022, 2, 8, 0, 0, 0, 0);
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
            this.txtDestinationStation.MaximumSize = new System.Drawing.Size(262, 30);
            this.txtDestinationStation.MinimumSize = new System.Drawing.Size(262, 30);
            this.txtDestinationStation.Name = "txtDestinationStation";
            this.txtDestinationStation.Size = new System.Drawing.Size(262, 30);
            this.txtDestinationStation.TabIndex = 1;
            this.txtDestinationStation.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtStartStation
            // 
            this.txtStartStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartStation.Location = new System.Drawing.Point(8, 59);
            this.txtStartStation.MaximumSize = new System.Drawing.Size(262, 30);
            this.txtStartStation.MinimumSize = new System.Drawing.Size(262, 30);
            this.txtStartStation.Name = "txtStartStation";
            this.txtStartStation.Size = new System.Drawing.Size(262, 30);
            this.txtStartStation.TabIndex = 0;
            this.txtStartStation.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(724, 147);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Verbindung suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConnectionList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConnectionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnectionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.platform,
            this.Abfahrtstation,
            this.Endstation,
            this.Starttime,
            this.Arrivetime});
            this.dgvConnectionList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConnectionList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvConnectionList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvConnectionList.Location = new System.Drawing.Point(12, 193);
            this.dgvConnectionList.MultiSelect = false;
            this.dgvConnectionList.Name = "dgvConnectionList";
            this.dgvConnectionList.ReadOnly = true;
            this.dgvConnectionList.RowHeadersWidth = 51;
            this.dgvConnectionList.RowTemplate.Height = 29;
            this.dgvConnectionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConnectionList.Size = new System.Drawing.Size(881, 256);
            this.dgvConnectionList.TabIndex = 100;
            this.dgvConnectionList.TabStop = false;
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
            // HomePicture
            // 
            this.HomePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomePicture.Image = ((System.Drawing.Image)(resources.GetObject("HomePicture.Image")));
            this.HomePicture.Location = new System.Drawing.Point(813, 21);
            this.HomePicture.Name = "HomePicture";
            this.HomePicture.Size = new System.Drawing.Size(57, 57);
            this.HomePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePicture.TabIndex = 103;
            this.HomePicture.TabStop = false;
            this.HomePicture.Click += new System.EventHandler(this.Icon_Click);
            // 
            // MailPicture
            // 
            this.MailPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MailPicture.Image = ((System.Drawing.Image)(resources.GetObject("MailPicture.Image")));
            this.MailPicture.Location = new System.Drawing.Point(724, 21);
            this.MailPicture.Name = "MailPicture";
            this.MailPicture.Size = new System.Drawing.Size(57, 57);
            this.MailPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MailPicture.TabIndex = 104;
            this.MailPicture.TabStop = false;
            this.MailPicture.Click += new System.EventHandler(this.Icon_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStriplableOne});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(905, 22);
            this.statusStrip1.TabIndex = 105;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStriplableOne
            // 
            this.statusStriplableOne.ActiveLinkColor = System.Drawing.Color.Blue;
            this.statusStriplableOne.ForeColor = System.Drawing.Color.Blue;
            this.statusStriplableOne.Name = "statusStriplableOne";
            this.statusStriplableOne.Size = new System.Drawing.Size(0, 16);
            this.statusStriplableOne.Visible = false;
            // 
            // SearchConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 484);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MailPicture);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.HomePicture);
            this.Controls.Add(this.dgvConnectionList);
            this.Controls.Add(this.ConnectinoSearchGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(923, 531);
            this.MinimumSize = new System.Drawing.Size(923, 531);
            this.Name = "SearchConnectionForm";
            this.Text = "Verbindungen";
            this.Shown += new System.EventHandler(this.SearchConnectionForm_Shown);
            this.ConnectinoSearchGroupBox.ResumeLayout(false);
            this.ConnectinoSearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnectionList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailPicture)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private PictureBox HomePicture;
        private PictureBox MailPicture;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusStriplableOne;
        private DateTimePicker dtpTime;
        private RadioButton radioArrive;
        private RadioButton radioDepart;
    }
}