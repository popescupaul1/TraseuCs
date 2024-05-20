namespace Traseu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.harta = new System.Windows.Forms.PictureBox();
            this.traseuButton = new System.Windows.Forms.Button();
            this.hartaButton = new System.Windows.Forms.Button();
            this.coord = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiseazaHartaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiseazaTraseuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.harta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // harta
            // 
            this.harta.Location = new System.Drawing.Point(13, 127);
            this.harta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.harta.Name = "harta";
            this.harta.Size = new System.Drawing.Size(1411, 818);
            this.harta.TabIndex = 0;
            this.harta.TabStop = false;
            // 
            // traseuButton
            // 
            this.traseuButton.Location = new System.Drawing.Point(407, 63);
            this.traseuButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.traseuButton.Name = "traseuButton";
            this.traseuButton.Size = new System.Drawing.Size(112, 35);
            this.traseuButton.TabIndex = 1;
            this.traseuButton.Text = "Traseu";
            this.traseuButton.UseVisualStyleBackColor = true;
            this.traseuButton.Click += new System.EventHandler(this.traseuButton_Click);
            // 
            // hartaButton
            // 
            this.hartaButton.Location = new System.Drawing.Point(210, 63);
            this.hartaButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hartaButton.Name = "hartaButton";
            this.hartaButton.Size = new System.Drawing.Size(112, 35);
            this.hartaButton.TabIndex = 2;
            this.hartaButton.Text = "Harta";
            this.hartaButton.UseVisualStyleBackColor = true;
            this.hartaButton.Click += new System.EventHandler(this.hartaButton_Click);
            // 
            // coord
            // 
            this.coord.AutoSize = true;
            this.coord.Location = new System.Drawing.Point(249, 968);
            this.coord.Name = "coord";
            this.coord.Size = new System.Drawing.Size(52, 20);
            this.coord.TabIndex = 3;
            this.coord.Text = "Coord";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicatieToolStripMenuItem,
            this.instrumenteToolStripMenuItem,
            this.ajutorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1422, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplicatieToolStripMenuItem
            // 
            this.aplicatieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem});
            this.aplicatieToolStripMenuItem.Name = "aplicatieToolStripMenuItem";
            this.aplicatieToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.aplicatieToolStripMenuItem.Text = "Aplicatie";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(155, 34);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // instrumenteToolStripMenuItem
            // 
            this.instrumenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afiseazaHartaToolStripMenuItem,
            this.afiseazaTraseuToolStripMenuItem});
            this.instrumenteToolStripMenuItem.Name = "instrumenteToolStripMenuItem";
            this.instrumenteToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.instrumenteToolStripMenuItem.Text = "Instrumente";
            // 
            // afiseazaHartaToolStripMenuItem
            // 
            this.afiseazaHartaToolStripMenuItem.Name = "afiseazaHartaToolStripMenuItem";
            this.afiseazaHartaToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.afiseazaHartaToolStripMenuItem.Text = "Afiseaza harta";
            this.afiseazaHartaToolStripMenuItem.Click += new System.EventHandler(this.afiseazaHartaToolStripMenuItem_Click);
            // 
            // afiseazaTraseuToolStripMenuItem
            // 
            this.afiseazaTraseuToolStripMenuItem.Name = "afiseazaTraseuToolStripMenuItem";
            this.afiseazaTraseuToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.afiseazaTraseuToolStripMenuItem.Text = "Afiseaza traseu";
            this.afiseazaTraseuToolStripMenuItem.Click += new System.EventHandler(this.traseuButton_Click);
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despreToolStripMenuItem});
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1422, 1005);
            this.Controls.Add(this.coord);
            this.Controls.Add(this.hartaButton);
            this.Controls.Add(this.traseuButton);
            this.Controls.Add(this.harta);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Traseu";
            ((System.ComponentModel.ISupportInitialize)(this.harta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox harta;
        private System.Windows.Forms.Button traseuButton;
        private System.Windows.Forms.Button hartaButton;
        private System.Windows.Forms.Label coord;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplicatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiseazaHartaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiseazaTraseuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
    }
}

