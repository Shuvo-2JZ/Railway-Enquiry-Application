namespace RailwayEnquiryApplication
{
    partial class TrainSchedule
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
            this.TraindataGridView = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TraindataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TraindataGridView
            // 
            this.TraindataGridView.BackgroundColor = System.Drawing.Color.Peru;
            this.TraindataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TraindataGridView.Location = new System.Drawing.Point(39, 42);
            this.TraindataGridView.Name = "TraindataGridView";
            this.TraindataGridView.Size = new System.Drawing.Size(469, 220);
            this.TraindataGridView.TabIndex = 0;
            // 
            // backbtn
            // 
            this.backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(237, 281);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 29);
            this.backbtn.TabIndex = 7;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.BackbtnClicked);
            // 
            // TrainSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(545, 334);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.TraindataGridView);
            this.Name = "TrainSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.TraindataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TraindataGridView;
        private System.Windows.Forms.Button backbtn;
    }
}