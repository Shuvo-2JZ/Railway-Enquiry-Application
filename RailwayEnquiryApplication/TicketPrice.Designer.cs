namespace RailwayEnquiryApplication
{
    partial class TicketPrice
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
            this.PricedataGridView = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Searchtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PricedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PricedataGridView
            // 
            this.PricedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PricedataGridView.BackgroundColor = System.Drawing.Color.Peru;
            this.PricedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PricedataGridView.Location = new System.Drawing.Point(23, 81);
            this.PricedataGridView.Name = "PricedataGridView";
            this.PricedataGridView.Size = new System.Drawing.Size(482, 222);
            this.PricedataGridView.TabIndex = 0;
            // 
            // backbtn
            // 
            this.backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(226, 321);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 29);
            this.backbtn.TabIndex = 8;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.BackbtnClicked);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(301, 34);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(109, 29);
            this.Searchbtn.TabIndex = 10;
            this.Searchbtn.Text = "Search Price";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.SearchSeatPriceClicked);
            // 
            // Searchtbox
            // 
            this.Searchtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtbox.Location = new System.Drawing.Point(140, 34);
            this.Searchtbox.Name = "Searchtbox";
            this.Searchtbox.Size = new System.Drawing.Size(137, 29);
            this.Searchtbox.TabIndex = 9;
            // 
            // TicketPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(527, 373);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Searchtbox);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.PricedataGridView);
            this.Name = "TicketPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketPrice";
            ((System.ComponentModel.ISupportInitialize)(this.PricedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PricedataGridView;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox Searchtbox;
    }
}