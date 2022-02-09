namespace SBBLite
{
    partial class NearStationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NearStationsForm));
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvStationView = new System.Windows.Forms.DataGridView();
            this.HomePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(606, 340);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 29);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvStationView
            // 
            this.dgvStationView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStationView.BackgroundColor = System.Drawing.Color.White;
            this.dgvStationView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStationView.Location = new System.Drawing.Point(12, 12);
            this.dgvStationView.Name = "dgvStationView";
            this.dgvStationView.RowHeadersWidth = 51;
            this.dgvStationView.RowTemplate.Height = 29;
            this.dgvStationView.Size = new System.Drawing.Size(757, 322);
            this.dgvStationView.TabIndex = 1;
            // 
            // HomePicture
            // 
            this.HomePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomePicture.Image = ((System.Drawing.Image)(resources.GetObject("HomePicture.Image")));
            this.HomePicture.Location = new System.Drawing.Point(734, 340);
            this.HomePicture.Name = "HomePicture";
            this.HomePicture.Size = new System.Drawing.Size(35, 32);
            this.HomePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePicture.TabIndex = 104;
            this.HomePicture.TabStop = false;
            this.HomePicture.Click += new System.EventHandler(this.HomePicture_Click);
            // 
            // NearStationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 381);
            this.Controls.Add(this.HomePicture);
            this.Controls.Add(this.dgvStationView);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NearStationsForm";
            this.Text = "Stationen in der Nähe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSearch;
        private DataGridView dgvStationView;
        private PictureBox HomePicture;
    }
}