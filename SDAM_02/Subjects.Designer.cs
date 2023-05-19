namespace SDAM_02
{
    partial class Subjects
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            this.subjectsgridview = new System.Windows.Forms.DataGridView();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtsubjectname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.navexit = new System.Windows.Forms.PictureBox();
            this.navstud = new System.Windows.Forms.PictureBox();
            this.navsub = new System.Windows.Forms.PictureBox();
            this.navq = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsgridview)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navstud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navsub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectsgridview
            // 
            this.subjectsgridview.AllowUserToResizeColumns = false;
            this.subjectsgridview.AllowUserToResizeRows = false;
            this.subjectsgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subjectsgridview.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subjectsgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.subjectsgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.subjectsgridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.subjectsgridview.Location = new System.Drawing.Point(262, 366);
            this.subjectsgridview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subjectsgridview.Name = "subjectsgridview";
            this.subjectsgridview.ReadOnly = true;
            this.subjectsgridview.RowHeadersVisible = false;
            this.subjectsgridview.RowHeadersWidth = 51;
            this.subjectsgridview.RowTemplate.Height = 25;
            this.subjectsgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectsgridview.Size = new System.Drawing.Size(907, 360);
            this.subjectsgridview.TabIndex = 41;
            this.subjectsgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectsgridview_CellContentClick);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.CadetBlue;
            this.btnreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreset.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnreset.Location = new System.Drawing.Point(487, 186);
            this.btnreset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(107, 43);
            this.btnreset.TabIndex = 40;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnedit.Location = new System.Drawing.Point(328, 186);
            this.btnedit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(107, 43);
            this.btnedit.TabIndex = 39;
            this.btnedit.Text = "Update";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.CadetBlue;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnsave.Location = new System.Drawing.Point(173, 186);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(107, 43);
            this.btnsave.TabIndex = 38;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtsubjectname
            // 
            this.txtsubjectname.BackColor = System.Drawing.Color.CadetBlue;
            this.txtsubjectname.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtsubjectname.Location = new System.Drawing.Point(165, 91);
            this.txtsubjectname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsubjectname.Name = "txtsubjectname";
            this.txtsubjectname.Size = new System.Drawing.Size(685, 25);
            this.txtsubjectname.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Subject Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Subjects";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.CadetBlue;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndelete.Location = new System.Drawing.Point(649, 186);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(107, 43);
            this.btndelete.TabIndex = 42;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtsubjectname);
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Location = new System.Drawing.Point(262, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 314);
            this.panel2.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(54, 697);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 26);
            this.label9.TabIndex = 48;
            this.label9.Text = "Version 2.0";
            // 
            // navexit
            // 
            this.navexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navexit.Image = ((System.Drawing.Image)(resources.GetObject("navexit.Image")));
            this.navexit.Location = new System.Drawing.Point(54, 568);
            this.navexit.Name = "navexit";
            this.navexit.Size = new System.Drawing.Size(159, 62);
            this.navexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.navexit.TabIndex = 47;
            this.navexit.TabStop = false;
            this.navexit.Click += new System.EventHandler(this.navexit_Click);
            // 
            // navstud
            // 
            this.navstud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navstud.Image = ((System.Drawing.Image)(resources.GetObject("navstud.Image")));
            this.navstud.Location = new System.Drawing.Point(54, 456);
            this.navstud.Name = "navstud";
            this.navstud.Size = new System.Drawing.Size(159, 62);
            this.navstud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.navstud.TabIndex = 46;
            this.navstud.TabStop = false;
            this.navstud.Click += new System.EventHandler(this.navstud_Click);
            // 
            // navsub
            // 
            this.navsub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navsub.Image = ((System.Drawing.Image)(resources.GetObject("navsub.Image")));
            this.navsub.Location = new System.Drawing.Point(54, 347);
            this.navsub.Name = "navsub";
            this.navsub.Size = new System.Drawing.Size(159, 62);
            this.navsub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.navsub.TabIndex = 45;
            this.navsub.TabStop = false;
            this.navsub.Click += new System.EventHandler(this.navsub_Click);
            // 
            // navq
            // 
            this.navq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navq.Image = ((System.Drawing.Image)(resources.GetObject("navq.Image")));
            this.navq.Location = new System.Drawing.Point(54, 238);
            this.navq.Name = "navq";
            this.navq.Size = new System.Drawing.Size(159, 62);
            this.navq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.navq.TabIndex = 44;
            this.navq.TabStop = false;
            this.navq.Click += new System.EventHandler(this.navq_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(55, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(159, 145);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 759);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.navexit);
            this.Controls.Add(this.navstud);
            this.Controls.Add(this.navsub);
            this.Controls.Add(this.navq);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.subjectsgridview);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsgridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navstud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navsub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView subjectsgridview;
        private Button btnreset;
        private Button btnedit;
        private Button btnsave;
        private TextBox txtsubjectname;
        private Label label2;
        private Label label1;
        private Button btndelete;
        private Panel panel2;
        private Label label9;
        private PictureBox navexit;
        private PictureBox navstud;
        private PictureBox navsub;
        private PictureBox navq;
        private PictureBox pictureBox4;
    }
}