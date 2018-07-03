namespace PacMan_Examen
{
    partial class pacman
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rojo = new System.Windows.Forms.PictureBox();
            this.rosado = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guinda = new System.Windows.Forms.PictureBox();
            this.uva = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rosado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guinda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uva)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // rojo
            // 
            this.rojo.Image = global::PacMan_Examen.Properties.Resources.red_left1;
            this.rojo.Location = new System.Drawing.Point(3, 54);
            this.rojo.Name = "rojo";
            this.rojo.Size = new System.Drawing.Size(32, 36);
            this.rojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rojo.TabIndex = 3;
            this.rojo.TabStop = false;
            // 
            // rosado
            // 
            this.rosado.Image = global::PacMan_Examen.Properties.Resources.pink_left1;
            this.rosado.Location = new System.Drawing.Point(364, 349);
            this.rosado.Name = "rosado";
            this.rosado.Size = new System.Drawing.Size(35, 34);
            this.rosado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rosado.TabIndex = 2;
            this.rosado.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PacMan_Examen.Properties.Resources.pacman_right;
            this.pictureBox1.Location = new System.Drawing.Point(188, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guinda
            // 
            this.guinda.Enabled = false;
            this.guinda.Image = global::PacMan_Examen.Properties.Resources.cherry;
            this.guinda.Location = new System.Drawing.Point(12, 253);
            this.guinda.Name = "guinda";
            this.guinda.Size = new System.Drawing.Size(30, 30);
            this.guinda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guinda.TabIndex = 4;
            this.guinda.TabStop = false;
            this.guinda.Visible = false;
            // 
            // uva
            // 
            this.uva.Enabled = false;
            this.uva.Image = global::PacMan_Examen.Properties.Resources.tile114;
            this.uva.Location = new System.Drawing.Point(12, 289);
            this.uva.Name = "uva";
            this.uva.Size = new System.Drawing.Size(30, 30);
            this.uva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uva.TabIndex = 5;
            this.uva.TabStop = false;
            this.uva.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Guardar,
            this.Salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(411, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Guardar
            // 
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(61, 20);
            this.Guardar.Text = "Guardar";
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Salir
            // 
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(41, 20);
            this.Salir.Text = "Salir";
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 30001;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 10000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // pacman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(411, 395);
            this.Controls.Add(this.uva);
            this.Controls.Add(this.guinda);
            this.Controls.Add(this.rojo);
            this.Controls.Add(this.rosado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(427, 434);
            this.MinimumSize = new System.Drawing.Size(427, 434);
            this.Name = "pacman";
            this.Text = "pacman";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.pacman_FormClosing);
            this.Click += new System.EventHandler(this.pacman_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pacman_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.rojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rosado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guinda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uva)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox rosado;
        private System.Windows.Forms.PictureBox rojo;
        private System.Windows.Forms.PictureBox guinda;
        private System.Windows.Forms.PictureBox uva;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Guardar;
        private System.Windows.Forms.ToolStripMenuItem Salir;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}