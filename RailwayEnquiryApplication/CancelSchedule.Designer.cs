namespace RailwayEnquiryApplication
{
    partial class CancelSchedule
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
            this.backbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.CancelScheduleGridView = new System.Windows.Forms.DataGridView();
            this.totbox = new System.Windows.Forms.TextBox();
            this.fromtbox = new System.Windows.Forms.TextBox();
            this.Tnametbox = new System.Windows.Forms.TextBox();
            this.Tidtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Startingtimelbl = new System.Windows.Forms.Label();
            this.tolbl = new System.Windows.Forms.Label();
            this.fromlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.Stimetbox = new System.Windows.Forms.TextBox();
            this.Rtimetbox = new System.Windows.Forms.TextBox();
            this.NoStbox = new System.Windows.Forms.TextBox();
            this.noofSeatslbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CancelScheduleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Loadbtn
            // 
            this.Loadbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbtn.Location = new System.Drawing.Point(633, 354);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(90, 33);
            this.Loadbtn.TabIndex = 51;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.LoadbtnClicked);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(229, 354);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(90, 33);
            this.backbtn.TabIndex = 50;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.BackbtnClicked);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(127, 354);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(90, 33);
            this.Updatebtn.TabIndex = 49;
            this.Updatebtn.Text = "Delete";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.DeletebtnClicked);
            // 
            // CancelScheduleGridView
            // 
            this.CancelScheduleGridView.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.CancelScheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CancelScheduleGridView.Location = new System.Drawing.Point(341, 71);
            this.CancelScheduleGridView.Name = "CancelScheduleGridView";
            this.CancelScheduleGridView.Size = new System.Drawing.Size(382, 265);
            this.CancelScheduleGridView.TabIndex = 48;
            this.CancelScheduleGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClicked);
            // 
            // totbox
            // 
            this.totbox.Enabled = false;
            this.totbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totbox.Location = new System.Drawing.Point(160, 176);
            this.totbox.Name = "totbox";
            this.totbox.Size = new System.Drawing.Size(159, 29);
            this.totbox.TabIndex = 45;
            // 
            // fromtbox
            // 
            this.fromtbox.Enabled = false;
            this.fromtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromtbox.Location = new System.Drawing.Point(160, 141);
            this.fromtbox.Name = "fromtbox";
            this.fromtbox.Size = new System.Drawing.Size(159, 29);
            this.fromtbox.TabIndex = 44;
            // 
            // Tnametbox
            // 
            this.Tnametbox.Enabled = false;
            this.Tnametbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tnametbox.Location = new System.Drawing.Point(160, 106);
            this.Tnametbox.Name = "Tnametbox";
            this.Tnametbox.Size = new System.Drawing.Size(159, 29);
            this.Tnametbox.TabIndex = 43;
            // 
            // Tidtbox
            // 
            this.Tidtbox.Enabled = false;
            this.Tidtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tidtbox.Location = new System.Drawing.Point(160, 71);
            this.Tidtbox.Name = "Tidtbox";
            this.Tidtbox.Size = new System.Drawing.Size(159, 29);
            this.Tidtbox.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 41;
            this.label6.Text = "Reaching Time";
            // 
            // Startingtimelbl
            // 
            this.Startingtimelbl.AutoSize = true;
            this.Startingtimelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startingtimelbl.Location = new System.Drawing.Point(22, 229);
            this.Startingtimelbl.Name = "Startingtimelbl";
            this.Startingtimelbl.Size = new System.Drawing.Size(102, 21);
            this.Startingtimelbl.TabIndex = 40;
            this.Startingtimelbl.Text = "Starting Time";
            // 
            // tolbl
            // 
            this.tolbl.AutoSize = true;
            this.tolbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolbl.Location = new System.Drawing.Point(22, 184);
            this.tolbl.Name = "tolbl";
            this.tolbl.Size = new System.Drawing.Size(25, 21);
            this.tolbl.TabIndex = 39;
            this.tolbl.Text = "To";
            // 
            // fromlbl
            // 
            this.fromlbl.AutoSize = true;
            this.fromlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromlbl.Location = new System.Drawing.Point(22, 149);
            this.fromlbl.Name = "fromlbl";
            this.fromlbl.Size = new System.Drawing.Size(47, 21);
            this.fromlbl.TabIndex = 38;
            this.fromlbl.Text = "From";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(22, 114);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(90, 21);
            this.Namelbl.TabIndex = 37;
            this.Namelbl.Text = "Train Name";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlbl.Location = new System.Drawing.Point(22, 79);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(63, 21);
            this.IDlbl.TabIndex = 36;
            this.IDlbl.Text = "Train ID";
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(141, 28);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(161, 21);
            this.Titlelbl.TabIndex = 35;
            this.Titlelbl.Text = "Train Cancel Schedule";
            // 
            // Stimetbox
            // 
            this.Stimetbox.Enabled = false;
            this.Stimetbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stimetbox.Location = new System.Drawing.Point(160, 221);
            this.Stimetbox.Name = "Stimetbox";
            this.Stimetbox.Size = new System.Drawing.Size(159, 29);
            this.Stimetbox.TabIndex = 52;
            // 
            // Rtimetbox
            // 
            this.Rtimetbox.Enabled = false;
            this.Rtimetbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rtimetbox.Location = new System.Drawing.Point(160, 267);
            this.Rtimetbox.Name = "Rtimetbox";
            this.Rtimetbox.Size = new System.Drawing.Size(159, 29);
            this.Rtimetbox.TabIndex = 53;
            // 
            // NoStbox
            // 
            this.NoStbox.Enabled = false;
            this.NoStbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoStbox.Location = new System.Drawing.Point(160, 307);
            this.NoStbox.Name = "NoStbox";
            this.NoStbox.Size = new System.Drawing.Size(159, 29);
            this.NoStbox.TabIndex = 56;
            // 
            // noofSeatslbl
            // 
            this.noofSeatslbl.AutoSize = true;
            this.noofSeatslbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noofSeatslbl.Location = new System.Drawing.Point(26, 315);
            this.noofSeatslbl.Name = "noofSeatslbl";
            this.noofSeatslbl.Size = new System.Drawing.Size(90, 21);
            this.noofSeatslbl.TabIndex = 55;
            this.noofSeatslbl.Text = "No of Seats";
            // 
            // CancelSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(745, 414);
            this.Controls.Add(this.NoStbox);
            this.Controls.Add(this.noofSeatslbl);
            this.Controls.Add(this.Rtimetbox);
            this.Controls.Add(this.Stimetbox);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.CancelScheduleGridView);
            this.Controls.Add(this.totbox);
            this.Controls.Add(this.fromtbox);
            this.Controls.Add(this.Tnametbox);
            this.Controls.Add(this.Tidtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Startingtimelbl);
            this.Controls.Add(this.tolbl);
            this.Controls.Add(this.fromlbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.Titlelbl);
            this.Name = "CancelSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.CancelScheduleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.DataGridView CancelScheduleGridView;
        private System.Windows.Forms.TextBox totbox;
        private System.Windows.Forms.TextBox fromtbox;
        private System.Windows.Forms.TextBox Tnametbox;
        private System.Windows.Forms.TextBox Tidtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Startingtimelbl;
        private System.Windows.Forms.Label tolbl;
        private System.Windows.Forms.Label fromlbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.TextBox Stimetbox;
        private System.Windows.Forms.TextBox Rtimetbox;
        private System.Windows.Forms.TextBox NoStbox;
        private System.Windows.Forms.Label noofSeatslbl;
    }
}