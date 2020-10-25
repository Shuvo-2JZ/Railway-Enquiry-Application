namespace RailwayEnquiryApplication
{
    partial class UpdateTrain
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
            this.UpdateTrainGridView = new System.Windows.Forms.DataGridView();
            this.RtimeDTP = new System.Windows.Forms.DateTimePicker();
            this.StimeDTP = new System.Windows.Forms.DateTimePicker();
            this.Tnametbox = new System.Windows.Forms.TextBox();
            this.Tidtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Startingtimelbl = new System.Windows.Forms.Label();
            this.tolbl = new System.Windows.Forms.Label();
            this.fromlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.NoStbox = new System.Windows.Forms.TextBox();
            this.noofSeatslbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateTrainGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Loadbtn
            // 
            this.Loadbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbtn.Location = new System.Drawing.Point(633, 344);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(90, 33);
            this.Loadbtn.TabIndex = 34;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.LoadbtnClicked);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(229, 344);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(90, 33);
            this.backbtn.TabIndex = 33;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtnClicked);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(127, 344);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(90, 33);
            this.Updatebtn.TabIndex = 32;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.UdateClicked);
            // 
            // UpdateTrainGridView
            // 
            this.UpdateTrainGridView.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.UpdateTrainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpdateTrainGridView.Location = new System.Drawing.Point(341, 61);
            this.UpdateTrainGridView.Name = "UpdateTrainGridView";
            this.UpdateTrainGridView.Size = new System.Drawing.Size(382, 260);
            this.UpdateTrainGridView.TabIndex = 31;
            this.UpdateTrainGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClicked);
            // 
            // RtimeDTP
            // 
            this.RtimeDTP.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtimeDTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtimeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.RtimeDTP.Location = new System.Drawing.Point(160, 257);
            this.RtimeDTP.Name = "RtimeDTP";
            this.RtimeDTP.Size = new System.Drawing.Size(159, 29);
            this.RtimeDTP.TabIndex = 30;
            // 
            // StimeDTP
            // 
            this.StimeDTP.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StimeDTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StimeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StimeDTP.Location = new System.Drawing.Point(160, 213);
            this.StimeDTP.Name = "StimeDTP";
            this.StimeDTP.Size = new System.Drawing.Size(159, 29);
            this.StimeDTP.TabIndex = 29;
            // 
            // Tnametbox
            // 
            this.Tnametbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tnametbox.Location = new System.Drawing.Point(160, 96);
            this.Tnametbox.Name = "Tnametbox";
            this.Tnametbox.Size = new System.Drawing.Size(159, 29);
            this.Tnametbox.TabIndex = 26;
            // 
            // Tidtbox
            // 
            this.Tidtbox.Enabled = false;
            this.Tidtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tidtbox.Location = new System.Drawing.Point(160, 61);
            this.Tidtbox.Name = "Tidtbox";
            this.Tidtbox.Size = new System.Drawing.Size(159, 29);
            this.Tidtbox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Reaching Time";
            // 
            // Startingtimelbl
            // 
            this.Startingtimelbl.AutoSize = true;
            this.Startingtimelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startingtimelbl.Location = new System.Drawing.Point(22, 219);
            this.Startingtimelbl.Name = "Startingtimelbl";
            this.Startingtimelbl.Size = new System.Drawing.Size(102, 21);
            this.Startingtimelbl.TabIndex = 23;
            this.Startingtimelbl.Text = "Starting Time";
            // 
            // tolbl
            // 
            this.tolbl.AutoSize = true;
            this.tolbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolbl.Location = new System.Drawing.Point(22, 174);
            this.tolbl.Name = "tolbl";
            this.tolbl.Size = new System.Drawing.Size(25, 21);
            this.tolbl.TabIndex = 22;
            this.tolbl.Text = "To";
            // 
            // fromlbl
            // 
            this.fromlbl.AutoSize = true;
            this.fromlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromlbl.Location = new System.Drawing.Point(22, 139);
            this.fromlbl.Name = "fromlbl";
            this.fromlbl.Size = new System.Drawing.Size(47, 21);
            this.fromlbl.TabIndex = 21;
            this.fromlbl.Text = "From";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(22, 104);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(90, 21);
            this.Namelbl.TabIndex = 20;
            this.Namelbl.Text = "Train Name";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlbl.Location = new System.Drawing.Point(22, 69);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(63, 21);
            this.IDlbl.TabIndex = 19;
            this.IDlbl.Text = "Train ID";
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(141, 18);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(98, 21);
            this.Titlelbl.TabIndex = 18;
            this.Titlelbl.Text = "Train Update";
            // 
            // NoStbox
            // 
            this.NoStbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoStbox.Location = new System.Drawing.Point(160, 292);
            this.NoStbox.Name = "NoStbox";
            this.NoStbox.Size = new System.Drawing.Size(159, 29);
            this.NoStbox.TabIndex = 36;
            // 
            // noofSeatslbl
            // 
            this.noofSeatslbl.AutoSize = true;
            this.noofSeatslbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noofSeatslbl.Location = new System.Drawing.Point(22, 300);
            this.noofSeatslbl.Name = "noofSeatslbl";
            this.noofSeatslbl.Size = new System.Drawing.Size(90, 21);
            this.noofSeatslbl.TabIndex = 35;
            this.noofSeatslbl.Text = "No of Seats";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(160, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 29);
            this.textBox1.TabIndex = 37;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(160, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 29);
            this.textBox2.TabIndex = 38;
            // 
            // UpdateTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(745, 393);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NoStbox);
            this.Controls.Add(this.noofSeatslbl);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.UpdateTrainGridView);
            this.Controls.Add(this.RtimeDTP);
            this.Controls.Add(this.StimeDTP);
            this.Controls.Add(this.Tnametbox);
            this.Controls.Add(this.Tidtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Startingtimelbl);
            this.Controls.Add(this.tolbl);
            this.Controls.Add(this.fromlbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.Titlelbl);
            this.Name = "UpdateTrain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateTrain";
            ((System.ComponentModel.ISupportInitialize)(this.UpdateTrainGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.DataGridView UpdateTrainGridView;
        private System.Windows.Forms.DateTimePicker RtimeDTP;
        private System.Windows.Forms.DateTimePicker StimeDTP;
        private System.Windows.Forms.TextBox Tnametbox;
        private System.Windows.Forms.TextBox Tidtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Startingtimelbl;
        private System.Windows.Forms.Label tolbl;
        private System.Windows.Forms.Label fromlbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.TextBox NoStbox;
        private System.Windows.Forms.Label noofSeatslbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}