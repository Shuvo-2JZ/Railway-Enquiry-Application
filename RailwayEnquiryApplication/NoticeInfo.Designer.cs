namespace RailwayEnquiryApplication
{
    partial class NoticeInfo
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
            this.NoticedataGridView = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            this.Ndetailstbox = new System.Windows.Forms.TextBox();
            this.NSubjecttbox = new System.Windows.Forms.TextBox();
            this.Nidtbox = new System.Windows.Forms.TextBox();
            this.fromlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.noticetitlelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NoticedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NoticedataGridView
            // 
            this.NoticedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NoticedataGridView.BackgroundColor = System.Drawing.Color.Peru;
            this.NoticedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoticedataGridView.Location = new System.Drawing.Point(445, 67);
            this.NoticedataGridView.Name = "NoticedataGridView";
            this.NoticedataGridView.Size = new System.Drawing.Size(408, 184);
            this.NoticedataGridView.TabIndex = 40;
            this.NoticedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cellclicked);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(388, 280);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(90, 33);
            this.backbtn.TabIndex = 39;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.BackClicked);
            // 
            // Ndetailstbox
            // 
            this.Ndetailstbox.Enabled = false;
            this.Ndetailstbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ndetailstbox.Location = new System.Drawing.Point(170, 137);
            this.Ndetailstbox.Multiline = true;
            this.Ndetailstbox.Name = "Ndetailstbox";
            this.Ndetailstbox.Size = new System.Drawing.Size(251, 114);
            this.Ndetailstbox.TabIndex = 37;
            // 
            // NSubjecttbox
            // 
            this.NSubjecttbox.Enabled = false;
            this.NSubjecttbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSubjecttbox.Location = new System.Drawing.Point(170, 102);
            this.NSubjecttbox.Name = "NSubjecttbox";
            this.NSubjecttbox.Size = new System.Drawing.Size(251, 29);
            this.NSubjecttbox.TabIndex = 36;
            // 
            // Nidtbox
            // 
            this.Nidtbox.Enabled = false;
            this.Nidtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nidtbox.Location = new System.Drawing.Point(170, 67);
            this.Nidtbox.Name = "Nidtbox";
            this.Nidtbox.Size = new System.Drawing.Size(251, 29);
            this.Nidtbox.TabIndex = 35;
            // 
            // fromlbl
            // 
            this.fromlbl.AutoSize = true;
            this.fromlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromlbl.Location = new System.Drawing.Point(32, 184);
            this.fromlbl.Name = "fromlbl";
            this.fromlbl.Size = new System.Drawing.Size(106, 21);
            this.fromlbl.TabIndex = 34;
            this.fromlbl.Text = "Notice Details";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(32, 110);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(110, 21);
            this.Namelbl.TabIndex = 33;
            this.Namelbl.Text = "Notice Subject";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlbl.Location = new System.Drawing.Point(32, 75);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(74, 21);
            this.IDlbl.TabIndex = 32;
            this.IDlbl.Text = "Notice ID";
            // 
            // noticetitlelbl
            // 
            this.noticetitlelbl.AutoSize = true;
            this.noticetitlelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticetitlelbl.Location = new System.Drawing.Point(151, 24);
            this.noticetitlelbl.Name = "noticetitlelbl";
            this.noticetitlelbl.Size = new System.Drawing.Size(141, 21);
            this.noticetitlelbl.TabIndex = 31;
            this.noticetitlelbl.Text = "Notice Information";
            // 
            // NoticeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(884, 337);
            this.Controls.Add(this.NoticedataGridView);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Ndetailstbox);
            this.Controls.Add(this.NSubjecttbox);
            this.Controls.Add(this.Nidtbox);
            this.Controls.Add(this.fromlbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.noticetitlelbl);
            this.Name = "NoticeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoticeInfo";
            ((System.ComponentModel.ISupportInitialize)(this.NoticedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NoticedataGridView;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox Ndetailstbox;
        private System.Windows.Forms.TextBox NSubjecttbox;
        private System.Windows.Forms.TextBox Nidtbox;
        private System.Windows.Forms.Label fromlbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label noticetitlelbl;
    }
}