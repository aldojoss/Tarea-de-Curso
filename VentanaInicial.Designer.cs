namespace ELECTROCOST
{
    partial class VentanaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaInicial));
            label1 = new Label();
            btnnewelectrocostplan = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            smbarmenu = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            lightToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            smbarmenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(21, 31);
            label1.Name = "label1";
            label1.Size = new Size(186, 42);
            label1.TabIndex = 0;
            label1.Text = " Electro Cost";
            label1.Click += label1_Click;
            // 
            // btnnewelectrocostplan
            // 
            btnnewelectrocostplan.BackColor = SystemColors.ButtonShadow;
            btnnewelectrocostplan.FlatStyle = FlatStyle.Flat;
            btnnewelectrocostplan.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnnewelectrocostplan.ForeColor = SystemColors.Window;
            btnnewelectrocostplan.Location = new Point(26, 54);
            btnnewelectrocostplan.Name = "btnnewelectrocostplan";
            btnnewelectrocostplan.Size = new Size(243, 119);
            btnnewelectrocostplan.TabIndex = 2;
            btnnewelectrocostplan.Text = "New Electrocost House Plan";
            btnnewelectrocostplan.UseVisualStyleBackColor = false;
            btnnewelectrocostplan.Click += btnnewelectrocostplan_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnnewelectrocostplan);
            groupBox1.Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Window;
            groupBox1.Location = new Point(633, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 402);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tasks";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonShadow;
            label4.Font = new Font("Arial Narrow", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(94, 302);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 6;
            label4.Text = "Save energy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.Font = new Font("Arial Narrow", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(40, 142);
            label2.Name = "label2";
            label2.Size = new Size(221, 20);
            label2.TabIndex = 5;
            label2.Text = "Make a new plan of energy control";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.BackColor = SystemColors.ButtonShadow;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Window;
            button3.Location = new Point(26, 222);
            button3.Name = "button3";
            button3.Size = new Size(243, 119);
            button3.TabIndex = 4;
            button3.Text = "Energy Saving Tips";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(200, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // smbarmenu
            // 
            smbarmenu.BackColor = SystemColors.AppWorkspace;
            smbarmenu.Dock = DockStyle.Bottom;
            smbarmenu.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            smbarmenu.ImageScalingSize = new Size(24, 24);
            smbarmenu.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            smbarmenu.Location = new Point(0, 516);
            smbarmenu.Name = "smbarmenu";
            smbarmenu.Size = new Size(956, 37);
            smbarmenu.TabIndex = 6;
            smbarmenu.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { themeToolStripMenuItem, exitToolStripMenuItem });
            opcionesToolStripMenuItem.Image = (Image)resources.GetObject("opcionesToolStripMenuItem.Image");
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(127, 33);
            opcionesToolStripMenuItem.Text = "Options";
            opcionesToolStripMenuItem.Click += opcionesToolStripMenuItem_Click;
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lightToolStripMenuItem, darkToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(270, 38);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // lightToolStripMenuItem
            // 
            lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            lightToolStripMenuItem.Size = new Size(164, 38);
            lightToolStripMenuItem.Text = "Light";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(164, 38);
            darkToolStripMenuItem.Text = "Dark";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 38);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += Exit;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(64, 64, 64);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = SystemColors.Window;
            richTextBox1.Location = new Point(37, 159);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(312, 274);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(37, 111);
            label3.Name = "label3";
            label3.Size = new Size(286, 30);
            label3.TabIndex = 8;
            label3.Text = "¿Por qué usar ElectroCost?";
            label3.Click += label3_Click;
            // 
            // VentanaInicial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(956, 553);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(smbarmenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = smbarmenu;
            MaximizeBox = false;
            Name = "VentanaInicial";
            Text = "VentanaInicial";
            Load += VentanaInicial_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            smbarmenu.ResumeLayout(false);
            smbarmenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnnewelectrocostplan;
        private GroupBox groupBox1;
        private Button button3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label4;
        private MenuStrip smbarmenu;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem lightToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private RichTextBox richTextBox1;
        private Label label3;
    }
}