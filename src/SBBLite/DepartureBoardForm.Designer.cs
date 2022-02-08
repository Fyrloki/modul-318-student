namespace SBBLite
{
    partial class DepartureBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartureBoardForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStationName = new System.Windows.Forms.Label();
            this.cbSearchValue = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.HomePicture = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvConnectionList = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnectionList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStationName
            // 
            this.lblStationName.AutoSize = true;
            this.lblStationName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStationName.Location = new System.Drawing.Point(12, 14);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(78, 28);
            this.lblStationName.TabIndex = 0;
            this.lblStationName.Tag = "lblStation";
            this.lblStationName.Text = "Station:";
            // 
            // cbSearchValue
            // 
            this.cbSearchValue.FormattingEnabled = true;
            this.cbSearchValue.Location = new System.Drawing.Point(96, 18);
            this.cbSearchValue.Name = "cbSearchValue";
            this.cbSearchValue.Size = new System.Drawing.Size(216, 28);
            this.cbSearchValue.TabIndex = 1;
            this.cbSearchValue.TextChanged += new System.EventHandler(this.SearchValue_Changed);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(336, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Tag = "Search";
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.SearchButton_Clicked);
            // 
            // HomePicture
            // 
            this.HomePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomePicture.Image = ((System.Drawing.Image)(resources.GetObject("HomePicture.Image")));
            this.HomePicture.Location = new System.Drawing.Point(735, 12);
            this.HomePicture.Name = "HomePicture";
            this.HomePicture.Size = new System.Drawing.Size(40, 42);
            this.HomePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePicture.TabIndex = 104;
            this.HomePicture.TabStop = false;
            this.HomePicture.Click += new System.EventHandler(this.HomeIcon_Clicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(793, 22);
            this.statusStrip1.TabIndex = 105;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.ForeColor = System.Drawing.Color.Blue;
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(0, 16);
            this.statusStrip.Tag = "StatusStrip";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConnectionList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConnectionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnectionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Number,
            this.Operator,
            this.DepartureTime,
            this.ArrivalStation});
            this.dgvConnectionList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConnectionList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConnectionList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvConnectionList.Location = new System.Drawing.Point(6, 62);
            this.dgvConnectionList.MultiSelect = false;
            this.dgvConnectionList.Name = "dgvConnectionList";
            this.dgvConnectionList.ReadOnly = true;
            this.dgvConnectionList.RowHeadersVisible = false;
            this.dgvConnectionList.RowHeadersWidth = 51;
            this.dgvConnectionList.RowTemplate.Height = 29;
            this.dgvConnectionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConnectionList.Size = new System.Drawing.Size(769, 278);
            this.dgvConnectionList.TabIndex = 101;
            this.dgvConnectionList.TabStop = false;
            // 
            // Category
            // 
            this.Category.HeaderText = "Kategorie";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.HeaderText = "Nummer";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Operator
            // 
            this.Operator.HeaderText = "Firma";
            this.Operator.MinimumWidth = 6;
            this.Operator.Name = "Operator";
            this.Operator.ReadOnly = true;
            // 
            // DepartureTime
            // 
            this.DepartureTime.HeaderText = "Abfahrtzeit";
            this.DepartureTime.MinimumWidth = 6;
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.ReadOnly = true;
            // 
            // ArrivalStation
            // 
            this.ArrivalStation.HeaderText = "Ankunftsort";
            this.ArrivalStation.MinimumWidth = 6;
            this.ArrivalStation.Name = "ArrivalStation";
            this.ArrivalStation.ReadOnly = true;
            // 
            // DepartureBoardForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 371);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.HomePicture);
            this.Controls.Add(this.dgvConnectionList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearchValue);
            this.Controls.Add(this.lblStationName);
            this.Name = "DepartureBoardForm";
            this.Text = "Abfahrtstafel";
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnectionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStationName;
        private ComboBox cbSearchValue;
        private Button btnSearch;
        private PictureBox HomePicture;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusStrip;
        private DataGridView dgvConnectionList;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Operator;
        private DataGridViewTextBoxColumn DepartureTime;
        private DataGridViewTextBoxColumn ArrivalStation;
    }
}