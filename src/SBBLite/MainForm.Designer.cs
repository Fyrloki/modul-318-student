namespace SBBLite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnLeavingBoard = new System.Windows.Forms.Button();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnShowNearStations = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusOfConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(155, 221);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(76, 29);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "Beenden";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnLeavingBoard
            // 
            this.btnLeavingBoard.Location = new System.Drawing.Point(29, 90);
            this.btnLeavingBoard.Name = "btnLeavingBoard";
            this.btnLeavingBoard.Size = new System.Drawing.Size(202, 34);
            this.btnLeavingBoard.TabIndex = 1;
            this.btnLeavingBoard.Text = "Abfahrtstafel";
            this.btnLeavingBoard.UseVisualStyleBackColor = true;
            this.btnLeavingBoard.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Location = new System.Drawing.Point(29, 48);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(202, 34);
            this.btnSearchConnection.TabIndex = 0;
            this.btnSearchConnection.Text = "Verbindung Suchen";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(29, 131);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(202, 34);
            this.btnMap.TabIndex = 2;
            this.btnMap.Text = "Karte mit Stationen";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnShowNearStations
            // 
            this.btnShowNearStations.Location = new System.Drawing.Point(29, 171);
            this.btnShowNearStations.Name = "btnShowNearStations";
            this.btnShowNearStations.Size = new System.Drawing.Size(202, 34);
            this.btnShowNearStations.TabIndex = 3;
            this.btnShowNearStations.Text = "Stationen in der Umgebung";
            this.btnShowNearStations.UseVisualStyleBackColor = true;
            this.btnShowNearStations.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(43, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 20);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Was wollen Sie machen?";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.StatusOfConnection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 257);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(261, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            this.toolStripStatusLabel1.Visible = false;
            // 
            // StatusOfConnection
            // 
            this.StatusOfConnection.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.StatusOfConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StatusOfConnection.Name = "StatusOfConnection";
            this.StatusOfConnection.Size = new System.Drawing.Size(80, 20);
            this.StatusOfConnection.Text = "Verbunden";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnEnd;
            this.ClientSize = new System.Drawing.Size(261, 283);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnShowNearStations);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnSearchConnection);
            this.Controls.Add(this.btnLeavingBoard);
            this.Controls.Add(this.btnEnd);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hauptmenu";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEnd;
        private Button btnLeavingBoard;
        private Button btnSearchConnection;
        private Button btnMap;
        private Button btnShowNearStations;
        private Label lblTitle;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel StatusOfConnection;
    }
}