namespace RailwayEnquiryApplication
{
    partial class Notice_ADD
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
            this.Ndetailstbox = new System.Windows.Forms.TextBox();
            this.NoticeSubjecttbox = new System.Windows.Forms.TextBox();
            this.Nidtbox = new System.Windows.Forms.TextBox();
            this.fromlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.noticetitlelbl = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ndetailstbox
            // 
            this.Ndetailstbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ndetailstbox.Location = new System.Drawing.Point(209, 134);
            this.Ndetailstbox.Multiline = true;
            this.Ndetailstbox.Name = "Ndetailstbox";
            this.Ndetailstbox.Size = new System.Drawing.Size(251, 114);
            this.Ndetailstbox.TabIndex = 16;
            // 
            // NoticeSubjecttbox
            // 
            this.NoticeSubjecttbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoticeSubjecttbox.Location = new System.Drawing.Point(209, 99);
            this.NoticeSubjecttbox.Name = "NoticeSubjecttbox";
            this.NoticeSubjecttbox.Size = new System.Drawing.Size(251, 29);
            this.NoticeSubjecttbox.TabIndex = 15;
            // 
            // Nidtbox
            // 
            this.Nidtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nidtbox.Location = new System.Drawing.Point(209, 64);
            this.Nidtbox.Name = "Nidtbox";
            this.Nidtbox.Size = new System.Drawing.Size(251, 29);
            this.Nidtbox.TabIndex = 14;
            // 
            // fromlbl
            // 
            this.fromlbl.AutoSize = true;
            this.fromlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromlbl.Location = new System.Drawing.Point(71, 181);
            this.fromlbl.Name = "fromlbl";
            this.fromlbl.Size = new System.Drawing.Size(106, 21);
            this.fromlbl.TabIndex = 13;
            this.fromlbl.Text = "Notice Details";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(71, 107);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(110, 21);
            this.Namelbl.TabIndex = 12;
            this.Namelbl.Text = "Notice Subject";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlbl.Location = new System.Drawing.Point(71, 72);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(74, 21);
            this.IDlbl.TabIndex = 11;
            this.IDlbl.Text = "Notice ID";
            // 
            // noticetitlelbl
            // 
            this.noticetitlelbl.AutoSize = true;
            this.noticetitlelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticetitlelbl.Location = new System.Drawing.Point(190, 21);
            this.noticetitlelbl.Name = "noticetitlelbl";
            this.noticetitlelbl.Size = new System.Drawing.Size(141, 21);
            this.noticetitlelbl.TabIndex = 10;
            this.noticetitlelbl.Text = "Notice Information";
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(323, 279);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(90, 33);
            this.backbtn.TabIndex = 18;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.BackbtnClicked);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(221, 279);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(90, 33);
            this.addbtn.TabIndex = 17;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.NoticeAssClicked);
            // 
            // Notice_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(490, 337);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.Ndetailstbox);
            this.Controls.Add(this.NoticeSubjecttbox);
            this.Controls.Add(this.Nidtbox);
            this.Controls.Add(this.fromlbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.noticetitlelbl);
            this.Name = "Notice_ADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notice_ADD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ndetailstbox;
        private System.Windows.Forms.TextBox NoticeSubjecttbox;
        private System.Windows.Forms.TextBox Nidtbox;
        private System.Windows.Forms.Label fromlbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label noticetitlelbl;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button addbtn;
    }
}