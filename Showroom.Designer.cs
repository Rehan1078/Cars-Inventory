namespace Project
{
    partial class Showroom
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
            this.dataViewshowroom = new System.Windows.Forms.DataGridView();
            this.pictureShowroomcar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxEngine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxcolor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxseatcapa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxenginetype = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxtransmission = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxmaxspeed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxgearbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxvehicleid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewshowroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowroomcar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewshowroom
            // 
            this.dataViewshowroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewshowroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataViewshowroom.Location = new System.Drawing.Point(0, 0);
            this.dataViewshowroom.Name = "dataViewshowroom";
            this.dataViewshowroom.RowHeadersWidth = 62;
            this.dataViewshowroom.RowTemplate.Height = 28;
            this.dataViewshowroom.Size = new System.Drawing.Size(872, 310);
            this.dataViewshowroom.TabIndex = 0;
            this.dataViewshowroom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewshowroom_CellClick);
           // this.dataViewshowroom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewshowroom_CellContentClick);
           // this.dataViewshowroom.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataViewshowroom_RowHeaderMouseClick);
            // 
            // pictureShowroomcar
            // 
            this.pictureShowroomcar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureShowroomcar.Location = new System.Drawing.Point(459, 330);
            this.pictureShowroomcar.Name = "pictureShowroomcar";
            this.pictureShowroomcar.Size = new System.Drawing.Size(390, 288);
            this.pictureShowroomcar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShowroomcar.TabIndex = 1;
            this.pictureShowroomcar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Model";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(150, 362);
            this.textBoxModel.Multiline = true;
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.ReadOnly = true;
            this.textBoxModel.Size = new System.Drawing.Size(303, 26);
            this.textBoxModel.TabIndex = 3;
            // 
            // textBoxEngine
            // 
            this.textBoxEngine.Location = new System.Drawing.Point(150, 394);
            this.textBoxEngine.Name = "textBoxEngine";
            this.textBoxEngine.ReadOnly = true;
            this.textBoxEngine.Size = new System.Drawing.Size(303, 26);
            this.textBoxEngine.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Engine";
            // 
            // textBoxcolor
            // 
            this.textBoxcolor.Location = new System.Drawing.Point(150, 426);
            this.textBoxcolor.Name = "textBoxcolor";
            this.textBoxcolor.ReadOnly = true;
            this.textBoxcolor.Size = new System.Drawing.Size(303, 26);
            this.textBoxcolor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color";
            // 
            // textBoxseatcapa
            // 
            this.textBoxseatcapa.Location = new System.Drawing.Point(150, 458);
            this.textBoxseatcapa.Name = "textBoxseatcapa";
            this.textBoxseatcapa.ReadOnly = true;
            this.textBoxseatcapa.Size = new System.Drawing.Size(303, 26);
            this.textBoxseatcapa.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "SeatingCapacity";
            // 
            // textBoxenginetype
            // 
            this.textBoxenginetype.Location = new System.Drawing.Point(150, 490);
            this.textBoxenginetype.Name = "textBoxenginetype";
            this.textBoxenginetype.ReadOnly = true;
            this.textBoxenginetype.Size = new System.Drawing.Size(303, 26);
            this.textBoxenginetype.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "EngineType";
            // 
            // textBoxtransmission
            // 
            this.textBoxtransmission.Location = new System.Drawing.Point(150, 522);
            this.textBoxtransmission.Name = "textBoxtransmission";
            this.textBoxtransmission.ReadOnly = true;
            this.textBoxtransmission.Size = new System.Drawing.Size(303, 26);
            this.textBoxtransmission.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Transmission";
            // 
            // textBoxmaxspeed
            // 
            this.textBoxmaxspeed.Location = new System.Drawing.Point(150, 560);
            this.textBoxmaxspeed.Name = "textBoxmaxspeed";
            this.textBoxmaxspeed.ReadOnly = true;
            this.textBoxmaxspeed.Size = new System.Drawing.Size(303, 26);
            this.textBoxmaxspeed.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "MaxSpeed";
            // 
            // textBoxgearbox
            // 
            this.textBoxgearbox.Location = new System.Drawing.Point(150, 592);
            this.textBoxgearbox.Name = "textBoxgearbox";
            this.textBoxgearbox.ReadOnly = true;
            this.textBoxgearbox.Size = new System.Drawing.Size(303, 26);
            this.textBoxgearbox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 595);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "GearBox";
            // 
            // textBoxvehicleid
            // 
            this.textBoxvehicleid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxvehicleid.Location = new System.Drawing.Point(150, 330);
            this.textBoxvehicleid.Name = "textBoxvehicleid";
            this.textBoxvehicleid.ReadOnly = true;
            this.textBoxvehicleid.Size = new System.Drawing.Size(303, 26);
            this.textBoxvehicleid.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "VehicleID";
            // 
            // Showroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 686);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxvehicleid);
            this.Controls.Add(this.textBoxgearbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxmaxspeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxtransmission);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxenginetype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxseatcapa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxcolor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEngine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureShowroomcar);
            this.Controls.Add(this.dataViewshowroom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Showroom";
            this.Text = "Showroom";
            this.Load += new System.EventHandler(this.Showroom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewshowroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowroomcar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViewshowroom;
        private System.Windows.Forms.PictureBox pictureShowroomcar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxEngine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxcolor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxseatcapa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxenginetype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxtransmission;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxmaxspeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxgearbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxvehicleid;
        private System.Windows.Forms.Label label9;
    }
}