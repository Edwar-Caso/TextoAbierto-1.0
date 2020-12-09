
namespace TextoAbierto
{
    partial class Profesor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cREARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRESENTACIÒNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.cREARToolStripMenuItem,
            this.pRESENTACIÒNToolStripMenuItem,
            this.rEPORTEToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 28);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            // 
            // cREARToolStripMenuItem
            // 
            this.cREARToolStripMenuItem.Name = "cREARToolStripMenuItem";
            this.cREARToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.cREARToolStripMenuItem.Text = "CREAR";
            this.cREARToolStripMenuItem.Click += new System.EventHandler(this.cREARToolStripMenuItem_Click);
            // 
            // pRESENTACIÒNToolStripMenuItem
            // 
            this.pRESENTACIÒNToolStripMenuItem.Name = "pRESENTACIÒNToolStripMenuItem";
            this.pRESENTACIÒNToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.pRESENTACIÒNToolStripMenuItem.Text = "PRESENTACIÒN";
            this.pRESENTACIÒNToolStripMenuItem.Click += new System.EventHandler(this.pRESENTACIÒNToolStripMenuItem_Click);
            // 
            // rEPORTEToolStripMenuItem
            // 
            this.rEPORTEToolStripMenuItem.Name = "rEPORTEToolStripMenuItem";
            this.rEPORTEToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.rEPORTEToolStripMenuItem.Text = "REPORTE";
            this.rEPORTEToolStripMenuItem.Click += new System.EventHandler(this.rEPORTEToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1100, 740);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Profesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentación";
            this.Load += new System.EventHandler(this.Profesor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cREARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRESENTACIÒNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
    }
}