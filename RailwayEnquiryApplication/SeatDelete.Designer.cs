namespace RailwayEnquiryApplication
{
    partial class SeatDelete
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
            this.Loadbtn = new System.Windows.Forms.Button();
            this.SeatDeleteGridView = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.Pricetbox = new System.Windows.Forms.TextBox();
            this.Snametbox = new System.Windows.Forms.TextBox();
            this.Sidtbox = new System.Windows.Forms.TextBox();
            this.fromlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.Titlelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SeatDeleteGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Loadbtn
            // 
            this.Loadbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbtn.Location = new System.Drawing.Point(533, 295);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(90, 33);
            this.Loadbtn.TabIndex = 38;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.LoadbtnClicked);
            // 
            // SeatDeleteGridView
            // 
            this.SeatDeleteGridView.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.SeatDeleteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeatDeleteGridView.Location = new System.Drawing.Point(314, 51);
            this.SeatDeleteGridView.Name = "SeatDeleteGridView";
            this.SeatDeleteGridView.Size = new System.Drawing.Size(309, 207);
            this.SeatDeleteGridView.TabIndex = 37;
            this.SeatDeleteGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClicked);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(224, 295);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(90, 33);
            this.backbtn.TabIndex = 36;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.BackbtnClicked);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(122, 295);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(90, 33);
            this.addbtn.TabIndex = 35;
            this.addbtn.Text = "Delete";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.DeletebtnClicked);
            // 
            // Pricetbox
            // 
            this.Pricetbox.Enabled = false;
            this.Pricetbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricetbox.Location = new System.Drawing.Point(134, 188);
            this.Pricetbox.Name = "Pricetbox";
            this.Pricetbox.Size = new System.Drawing.Size(159, 29);
            this.Pricetbox.TabIndex = 34;
            // 
            // Snametbox
            // 
            this.Snametbox.Enabled = false;
            this.Snametbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snametbox.Location = new System.Drawing.Point(134, 142);
            this.Snametbox.Name = "Snametbox";
            this.Snametbox.Size = new System.Drawing.Size(159, 29);
            this.Snametbox.TabIndex = 33;
            // 
            // Sidtbox
            // 
            this.Sidtbox.Enabled = false;
            this.Sidtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sidtbox.Location = new System.Drawing.Point(134, 94);
            this.Sidtbox.Name = "Sidtbox";
            this.Sidtbox.Size = new System.Drawing.Size(159, 29);
            this.Sidtbox.TabIndex = 32;
            // 
            // fromlbl
            // 
            this.fromlbl.AutoSize = true;
            this.fromlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromlbl.Location = new System.Drawing.Point(24, 196);
            this.fromlbl.Name = "fromlbl";
            this.fromlbl.Size = new System.Drawing.Size(44, 21);
            this.fromlbl.TabIndex = 31;
            this.fromlbl.Text = "Price";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(24, 150);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(86, 21);
            this.Namelbl.TabIndex = 30;
            this.Namelbl.Text = "Seat Name";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlbl.Location = new System.Drawing.Point(24, 102);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(59, 21);
            this.IDlbl.TabIndex = 29;
            this.IDlbl.Text = "Seat ID";
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(217, 22);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(88, 21);
            this.Titlelbl.TabIndex = 28;
            this.Titlelbl.Text = "Seat Delete";
            // 
            // SeatDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(647, 350);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.SeatDeleteGridView);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.Pricetbox);
            this.Controls.Add(this.Snametbox);
            this.Controls.Add(this.Sidtbox);
            this.Controls.Add(this.fromlbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.Titlelbl);
            this.Name = "SeatDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeatDelete";
            ((System.ComponentModel.ISupportInitialize)(this.SeatDeleteGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.DataGridView SeatDeleteGridView;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox Pricetbox;
        private System.Windows.Forms.TextBox Snametbox;
        private System.Windows.Forms.TextBox Sidtbox;
        private System.Windows.Forms.Label fromlbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label Titlelbl;
    }
}