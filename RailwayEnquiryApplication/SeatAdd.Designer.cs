namespace RailwayEnquiryApplication
{
    partial class SeatAdd
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
            this.backbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.Pricetbox = new System.Windows.Forms.TextBox();
            this.Snametbox = new System.Windows.Forms.TextBox();
            this.Sidtbox = new System.Windows.Forms.TextBox();
            this.fromlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.SeatAddGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SeatAddGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(236, 305);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(90, 33);
            this.backbtn.TabIndex = 25;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.BackbtnClicked);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(134, 305);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(90, 33);
            this.addbtn.TabIndex = 24;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.AddbtnClicked);
            // 
            // Pricetbox
            // 
            this.Pricetbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricetbox.Location = new System.Drawing.Point(146, 198);
            this.Pricetbox.Name = "Pricetbox";
            this.Pricetbox.Size = new System.Drawing.Size(159, 29);
            this.Pricetbox.TabIndex = 23;
            // 
            // Snametbox
            // 
            this.Snametbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snametbox.Location = new System.Drawing.Point(146, 152);
            this.Snametbox.Name = "Snametbox";
            this.Snametbox.Size = new System.Drawing.Size(159, 29);
            this.Snametbox.TabIndex = 22;
            // 
            // Sidtbox
            // 
            this.Sidtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sidtbox.Location = new System.Drawing.Point(146, 104);
            this.Sidtbox.Name = "Sidtbox";
            this.Sidtbox.Size = new System.Drawing.Size(159, 29);
            this.Sidtbox.TabIndex = 21;
            // 
            // fromlbl
            // 
            this.fromlbl.AutoSize = true;
            this.fromlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromlbl.Location = new System.Drawing.Point(36, 206);
            this.fromlbl.Name = "fromlbl";
            this.fromlbl.Size = new System.Drawing.Size(44, 21);
            this.fromlbl.TabIndex = 20;
            this.fromlbl.Text = "Price";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(36, 160);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(86, 21);
            this.Namelbl.TabIndex = 19;
            this.Namelbl.Text = "Seat Name";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlbl.Location = new System.Drawing.Point(36, 112);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(59, 21);
            this.IDlbl.TabIndex = 18;
            this.IDlbl.Text = "Seat ID";
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(229, 32);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(72, 21);
            this.Titlelbl.TabIndex = 17;
            this.Titlelbl.Text = "Seat Add";
            // 
            // Loadbtn
            // 
            this.Loadbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbtn.Location = new System.Drawing.Point(545, 305);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(90, 33);
            this.Loadbtn.TabIndex = 27;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.LoadbtnClicked);
            // 
            // SeatAddGridView
            // 
            this.SeatAddGridView.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.SeatAddGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeatAddGridView.Location = new System.Drawing.Point(326, 61);
            this.SeatAddGridView.Name = "SeatAddGridView";
            this.SeatAddGridView.Size = new System.Drawing.Size(309, 207);
            this.SeatAddGridView.TabIndex = 26;
            // 
            // SeatAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(647, 350);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.SeatAddGridView);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.Pricetbox);
            this.Controls.Add(this.Snametbox);
            this.Controls.Add(this.Sidtbox);
            this.Controls.Add(this.fromlbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.Titlelbl);
            this.Name = "SeatAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeatAdd";
            ((System.ComponentModel.ISupportInitialize)(this.SeatAddGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox Pricetbox;
        private System.Windows.Forms.TextBox Snametbox;
        private System.Windows.Forms.TextBox Sidtbox;
        private System.Windows.Forms.Label fromlbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.DataGridView SeatAddGridView;
    }
}