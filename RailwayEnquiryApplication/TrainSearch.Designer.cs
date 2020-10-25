namespace RailwayEnquiryApplication
{
    partial class TrainSearch
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
            this.TrainSearchGridView = new System.Windows.Forms.DataGridView();
            this.Searchtbox = new System.Windows.Forms.TextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.Loadbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrainSearchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TrainSearchGridView
            // 
            this.TrainSearchGridView.BackgroundColor = System.Drawing.Color.Peru;
            this.TrainSearchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainSearchGridView.Location = new System.Drawing.Point(29, 93);
            this.TrainSearchGridView.Name = "TrainSearchGridView";
            this.TrainSearchGridView.Size = new System.Drawing.Size(463, 208);
            this.TrainSearchGridView.TabIndex = 0;
            // 
            // Searchtbox
            // 
            this.Searchtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtbox.Location = new System.Drawing.Point(148, 51);
            this.Searchtbox.Name = "Searchtbox";
            this.Searchtbox.Size = new System.Drawing.Size(137, 29);
            this.Searchtbox.TabIndex = 1;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(309, 51);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(79, 29);
            this.Searchbtn.TabIndex = 2;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.SearchbtnClicked);
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(206, 320);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(79, 29);
            this.Backbtn.TabIndex = 3;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtnclicked);
            // 
            // Loadbtn
            // 
            this.Loadbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbtn.Location = new System.Drawing.Point(403, 320);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(79, 29);
            this.Loadbtn.TabIndex = 4;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.LoadbtnClicked);
            // 
            // TrainSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(517, 361);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Searchtbox);
            this.Controls.Add(this.TrainSearchGridView);
            this.Name = "TrainSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainSearch";
            ((System.ComponentModel.ISupportInitialize)(this.TrainSearchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TrainSearchGridView;
        private System.Windows.Forms.TextBox Searchtbox;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button Loadbtn;
    }
}