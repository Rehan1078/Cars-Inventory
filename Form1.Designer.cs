namespace Project
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panelsidebar = new System.Windows.Forms.Panel();
            this.btlogout = new System.Windows.Forms.Button();
            this.btaboutus = new System.Windows.Forms.Button();
            this.panelsettings = new System.Windows.Forms.Panel();
            this.btdeletesettings = new System.Windows.Forms.Button();
            this.btupdatesettings = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btshowroom = new System.Windows.Forms.Button();
            this.bthome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.panelsidebar.SuspendLayout();
            this.panelsettings.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelsidebar
            // 
            this.panelsidebar.AllowDrop = true;
            this.panelsidebar.AutoScroll = true;
            this.panelsidebar.BackColor = System.Drawing.Color.Black;
            this.panelsidebar.Controls.Add(this.btlogout);
            this.panelsidebar.Controls.Add(this.btaboutus);
            this.panelsidebar.Controls.Add(this.panelsettings);
            this.panelsidebar.Controls.Add(this.btUpdate);
            this.panelsidebar.Controls.Add(this.btAdd);
            this.panelsidebar.Controls.Add(this.btshowroom);
            this.panelsidebar.Controls.Add(this.bthome);
            this.panelsidebar.Controls.Add(this.panel1);
            this.panelsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsidebar.Location = new System.Drawing.Point(0, 0);
            this.panelsidebar.Name = "panelsidebar";
            this.panelsidebar.Size = new System.Drawing.Size(235, 686);
            this.panelsidebar.TabIndex = 0;
            // 
            // btlogout
            // 
            this.btlogout.BackColor = System.Drawing.Color.Silver;
            this.btlogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogout.Location = new System.Drawing.Point(0, 520);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(235, 58);
            this.btlogout.TabIndex = 8;
            this.btlogout.Text = "Logout";
            this.btlogout.UseVisualStyleBackColor = false;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click_1);
            // 
            // btaboutus
            // 
            this.btaboutus.BackColor = System.Drawing.Color.Silver;
            this.btaboutus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btaboutus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaboutus.Location = new System.Drawing.Point(0, 462);
            this.btaboutus.Name = "btaboutus";
            this.btaboutus.Size = new System.Drawing.Size(235, 58);
            this.btaboutus.TabIndex = 7;
            this.btaboutus.Text = "About Us";
            this.btaboutus.UseVisualStyleBackColor = false;
            this.btaboutus.Click += new System.EventHandler(this.btaboutus_Click_1);
            // 
            // panelsettings
            // 
            this.panelsettings.Controls.Add(this.btdeletesettings);
            this.panelsettings.Controls.Add(this.btupdatesettings);
            this.panelsettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsettings.Location = new System.Drawing.Point(0, 384);
            this.panelsettings.Name = "panelsettings";
            this.panelsettings.Size = new System.Drawing.Size(235, 78);
            this.panelsettings.TabIndex = 6;
            // 
            // btdeletesettings
            // 
            this.btdeletesettings.BackColor = System.Drawing.Color.Silver;
            this.btdeletesettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btdeletesettings.Image = ((System.Drawing.Image)(resources.GetObject("btdeletesettings.Image")));
            this.btdeletesettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdeletesettings.Location = new System.Drawing.Point(0, 37);
            this.btdeletesettings.Name = "btdeletesettings";
            this.btdeletesettings.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btdeletesettings.Size = new System.Drawing.Size(235, 37);
            this.btdeletesettings.TabIndex = 2;
            this.btdeletesettings.Text = "Delete";
            this.btdeletesettings.UseVisualStyleBackColor = false;
            this.btdeletesettings.Click += new System.EventHandler(this.btdeletesettings_Click);
            // 
            // btupdatesettings
            // 
            this.btupdatesettings.BackColor = System.Drawing.Color.Silver;
            this.btupdatesettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btupdatesettings.Image = ((System.Drawing.Image)(resources.GetObject("btupdatesettings.Image")));
            this.btupdatesettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btupdatesettings.Location = new System.Drawing.Point(0, 0);
            this.btupdatesettings.Name = "btupdatesettings";
            this.btupdatesettings.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btupdatesettings.Size = new System.Drawing.Size(235, 37);
            this.btupdatesettings.TabIndex = 1;
            this.btupdatesettings.Text = "Update";
            this.btupdatesettings.UseVisualStyleBackColor = false;
            this.btupdatesettings.Click += new System.EventHandler(this.btupdatesettings_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.Silver;
            this.btUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(0, 326);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(235, 58);
            this.btUpdate.TabIndex = 5;
            this.btUpdate.Text = "Manage";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Silver;
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(0, 268);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(235, 58);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btshowroom
            // 
            this.btshowroom.BackColor = System.Drawing.Color.Silver;
            this.btshowroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btshowroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btshowroom.Location = new System.Drawing.Point(0, 210);
            this.btshowroom.Name = "btshowroom";
            this.btshowroom.Size = new System.Drawing.Size(235, 58);
            this.btshowroom.TabIndex = 3;
            this.btshowroom.Text = "Showroom";
            this.btshowroom.UseVisualStyleBackColor = false;
            this.btshowroom.Click += new System.EventHandler(this.btshowroom_Click);
            // 
            // bthome
            // 
            this.bthome.BackColor = System.Drawing.Color.Silver;
            this.bthome.Dock = System.Windows.Forms.DockStyle.Top;
            this.bthome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthome.Location = new System.Drawing.Point(0, 152);
            this.bthome.Name = "bthome";
            this.bthome.Size = new System.Drawing.Size(235, 58);
            this.bthome.TabIndex = 2;
            this.bthome.Text = "Home";
            this.bthome.UseVisualStyleBackColor = false;
            this.bthome.Click += new System.EventHandler(this.bthome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 152);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormPanel
            // 
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(235, 0);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(872, 686);
            this.FormPanel.TabIndex = 1;
            this.FormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPanel_Paint);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 686);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.panelsidebar);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMS";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panelsidebar.ResumeLayout(false);
            this.panelsettings.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelsidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bthome;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btshowroom;
        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Panel panelsettings;
        private System.Windows.Forms.Button btdeletesettings;
        private System.Windows.Forms.Button btupdatesettings;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Button btaboutus;
    }
}

