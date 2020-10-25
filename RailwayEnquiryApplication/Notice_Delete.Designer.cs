namespace RailwayEnquiryApplication
{
    partial class Notice_Delete
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
            this.deletebtn = new System.Windows.Forms.Button();
            this.Ndetailstbox = new System.Windows.Forms.TextBox();
            this.NSubjecttbox = new System.Windows.Forms.TextBox();
            this.Nidtbox = new System.Windows.Forms.TextBox();
            this.fromlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.noticetitlelbl = new System.Windows.Forms.Label();
            this.NoticedataGridView = new System.Windows.Forms.DataGridView();
            this.Loadbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NoticedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(303, 278);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(90, 33);
            this.backbtn.TabIndex = 27;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.BackbtnClicked);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(201, 278);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(90, 33);
            this.deletebtn.TabIndex = 26;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.DeletebtnClicked);
            // 
            // Ndetailstbox
            // 
            this.Ndetailstbox.Enabled = false;
            this.Ndetailstbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ndetailstbox.Location = new System.Drawing.Point(189, 136);
            this.Ndetailstbox.Multiline = true;
            this.Ndetailstbox.Name = "Ndetailstbox";
            this.Ndetailstbox.Size = new System.Drawing.Size(251, 114);
            this.Ndetailstbox.TabIndex = 25;
            // 
            // NSubjecttbox
            // 
            this.NSubjecttbox.Enabled = false;
            this.NSubjecttbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSubjecttbox.Location = new System.Drawing.Point(189, 101);
            this.NSubjecttbox.Name = "NSubjecttbox";
            this.NSubjecttbox.Size = new System.Drawing.Size(251, 29);
            this.NSubjecttbox.TabIndex = 24;
            // 
            // Nidtbox
            // 
            this.Nidtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nidtbox.Location = new System.Drawing.Point(189, 66);
            this.Nidtbox.Name = "Nidtbox";
            this.Nidtbox.Size = new System.Drawing.Size(251, 29);
            this.Nidtbox.TabIndex = 23;
            // 
            // fromlbl
            // 
            this.fromlbl.AutoSize = true;
            this.fromlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromlbl.Location = new System.Drawing.Point(51, 183);
            this.fromlbl.Name = "fromlbl";
            this.fromlbl.Size = new System.Drawing.Size(106, 21);
            this.fromlbl.TabIndex = 22;
            this.fromlbl.Text = "Notice Details";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(51, 109);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(110, 21);
            this.Namelbl.TabIndex = 21;
            this.Namelbl.Text = "Notice Subject";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlbl.Location = new System.Drawing.Point(51, 74);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(74, 21);
            this.IDlbl.TabIndex = 20;
            this.IDlbl.Text = "Notice ID";
            // 
            // noticetitlelbl
            // 
            this.noticetitlelbl.AutoSize = true;
            this.noticetitlelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticetitlelbl.Location = new System.Drawing.Point(170, 23);
            this.noticetitlelbl.Name = "noticetitlelbl";
            this.noticetitlelbl.Size = new System.Drawing.Size(141, 21);
            this.noticetitlelbl.TabIndex = 19;
            this.noticetitlelbl.Text = "Notice Information";
            // 
            // NoticedataGridView
            // 
            this.NoticedataGridView.BackgroundColor = System.Drawing.Color.GreenYellow;
            this.NoticedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoticedataGridView.Location = new System.Drawing.Point(464, 66);
            this.NoticedataGridView.Name = "NoticedataGridView";
            this.NoticedataGridView.Size = new System.Drawing.Size(408, 184);
            this.NoticedataGridView.TabIndex = 29;
            this.NoticedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClicked);
            // 
            // Loadbtn
            // 
            this.Loadbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbtn.Location = new System.Drawing.Point(782, 278);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(90, 33);
            this.Loadbtn.TabIndex = 30;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.LoadbtnClicked);
            // 
            // Notice_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(884, 337);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.NoticedataGridView);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.Ndetailstbox);
            this.Controls.Add(this.NSubjecttbox);
            this.Controls.Add(this.Nidtbox);
            this.Controls.Add(this.fromlbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.noticetitlelbl);
            this.Name = "Notice_Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notice_Delete";
            ((System.ComponentModel.ISupportInitialize)(this.NoticedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.TextBox Ndetailstbox;
        private System.Windows.Forms.TextBox NSubjecttbox;
        private System.Windows.Forms.TextBox Nidtbox;
        private System.Windows.Forms.Label fromlbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label noticetitlelbl;
        private System.Windows.Forms.DataGridView NoticedataGridView;
        private System.Windows.Forms.Button Loadbtn;
    }
}