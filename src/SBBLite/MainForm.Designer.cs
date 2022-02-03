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
            this.SuspendLayout();
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(155, 241);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(76, 29);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "Beenden";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnLeavingBoard
            // 
            this.btnLeavingBoard.Location = new System.Drawing.Point(29, 110);
            this.btnLeavingBoard.Name = "btnLeavingBoard";
            this.btnLeavingBoard.Size = new System.Drawing.Size(202, 34);
            this.btnLeavingBoard.TabIndex = 1;
            this.btnLeavingBoard.Text = "Abfahrtstafel";
            this.btnLeavingBoard.UseVisualStyleBackColor = true;
            this.btnLeavingBoard.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Location = new System.Drawing.Point(29, 68);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(202, 34);
            this.btnSearchConnection.TabIndex = 0;
            this.btnSearchConnection.Text = "Verbindung Suchen";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(29, 151);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(202, 34);
            this.btnMap.TabIndex = 2;
            this.btnMap.Text = "Karte mit Stationen";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnShowNearStations
            // 
            this.btnShowNearStations.Location = new System.Drawing.Point(29, 191);
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
            this.lblTitle.Location = new System.Drawing.Point(43, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 20);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Was wollen Sie machen?";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnEnd;
            this.ClientSize = new System.Drawing.Size(261, 282);
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
    }
}