
namespace TextoAbierto
{
    partial class TextoAbiertoCrear
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.boxImagen = new System.Windows.Forms.PictureBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictBoxMostrarIm = new System.Windows.Forms.PictureBox();
            this.labelDes = new System.Windows.Forms.Label();
            this.labelPre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.TextBox();
            this.lbldCodigo = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.openFileImage = new System.Windows.Forms.OpenFileDialog();
            this.lblMostrarPregunta = new System.Windows.Forms.Label();
            this.lblMostrarDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boxImagen)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMostrarIm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Location = new System.Drawing.Point(526, 639);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(228, 49);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // boxImagen
            // 
            this.boxImagen.Location = new System.Drawing.Point(526, 327);
            this.boxImagen.Margin = new System.Windows.Forms.Padding(4);
            this.boxImagen.Name = "boxImagen";
            this.boxImagen.Size = new System.Drawing.Size(531, 207);
            this.boxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxImagen.TabIndex = 38;
            this.boxImagen.TabStop = false;
            this.boxImagen.Click += new System.EventHandler(this.boxImagen_Click);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.ForeColor = System.Drawing.Color.Transparent;
            this.lblImagen.Location = new System.Drawing.Point(521, 288);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(165, 35);
            this.lblImagen.TabIndex = 37;
            this.lblImagen.Text = "Añadir imagen";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(526, 176);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(529, 67);
            this.txtDescripcion.TabIndex = 36;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtPregunta
            // 
            this.txtPregunta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPregunta.Location = new System.Drawing.Point(526, 50);
            this.txtPregunta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(529, 35);
            this.txtPregunta.TabIndex = 35;
            this.txtPregunta.TextChanged += new System.EventHandler(this.txtPregunta_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Location = new System.Drawing.Point(520, 137);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(244, 35);
            this.lblDescripcion.TabIndex = 34;
            this.lblDescripcion.Text = "Añada una descripción";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.ForeColor = System.Drawing.Color.Transparent;
            this.lblPregunta.Location = new System.Drawing.Point(521, 11);
            this.lblPregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(231, 35);
            this.lblPregunta.TabIndex = 33;
            this.lblPregunta.Text = "¿Cuál es su pregunta?";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardar.Location = new System.Drawing.Point(829, 639);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(228, 49);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.lblMostrarDescripcion);
            this.panel1.Controls.Add(this.lblMostrarPregunta);
            this.panel1.Controls.Add(this.pictBoxMostrarIm);
            this.panel1.Controls.Add(this.labelDes);
            this.panel1.Controls.Add(this.labelPre);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.lbldCodigo);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 587);
            this.panel1.TabIndex = 43;
            // 
            // pictBoxMostrarIm
            // 
            this.pictBoxMostrarIm.Location = new System.Drawing.Point(13, 297);
            this.pictBoxMostrarIm.Name = "pictBoxMostrarIm";
            this.pictBoxMostrarIm.Size = new System.Drawing.Size(476, 245);
            this.pictBoxMostrarIm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxMostrarIm.TabIndex = 48;
            this.pictBoxMostrarIm.TabStop = false;
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDes.Location = new System.Drawing.Point(22, 151);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(0, 30);
            this.labelDes.TabIndex = 47;
            // 
            // labelPre
            // 
            this.labelPre.AutoSize = true;
            this.labelPre.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPre.ForeColor = System.Drawing.Color.Transparent;
            this.labelPre.Location = new System.Drawing.Point(28, 65);
            this.labelPre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPre.Name = "labelPre";
            this.labelPre.Size = new System.Drawing.Size(0, 43);
            this.labelPre.TabIndex = 44;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Location = new System.Drawing.Point(272, 22);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(157, 22);
            this.lblCodigo.TabIndex = 45;
            this.lblCodigo.Text = "Código a generar";
            this.lblCodigo.TextChanged += new System.EventHandler(this.lblCodigo_TextChanged);
            // 
            // lbldCodigo
            // 
            this.lbldCodigo.AutoSize = true;
            this.lbldCodigo.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldCodigo.ForeColor = System.Drawing.Color.Transparent;
            this.lbldCodigo.Location = new System.Drawing.Point(31, 17);
            this.lbldCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldCodigo.Name = "lbldCodigo";
            this.lbldCodigo.Size = new System.Drawing.Size(171, 30);
            this.lbldCodigo.TabIndex = 46;
            this.lbldCodigo.Text = "Codigo de ingreso:";
            this.lbldCodigo.Click += new System.EventHandler(this.lbldCodigo_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCargar.Location = new System.Drawing.Point(527, 549);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(225, 49);
            this.btnCargar.TabIndex = 44;
            this.btnCargar.Text = "Cargar Imagen";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblMostrarPregunta
            // 
            this.lblMostrarPregunta.AutoSize = true;
            this.lblMostrarPregunta.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarPregunta.ForeColor = System.Drawing.Color.Transparent;
            this.lblMostrarPregunta.Location = new System.Drawing.Point(48, 89);
            this.lblMostrarPregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMostrarPregunta.Name = "lblMostrarPregunta";
            this.lblMostrarPregunta.Size = new System.Drawing.Size(231, 35);
            this.lblMostrarPregunta.TabIndex = 45;
            this.lblMostrarPregunta.Text = "¿Cuál es su pregunta?";
            // 
            // lblMostrarDescripcion
            // 
            this.lblMostrarDescripcion.AutoSize = true;
            this.lblMostrarDescripcion.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDescripcion.ForeColor = System.Drawing.Color.Transparent;
            this.lblMostrarDescripcion.Location = new System.Drawing.Point(48, 197);
            this.lblMostrarDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMostrarDescripcion.Name = "lblMostrarDescripcion";
            this.lblMostrarDescripcion.Size = new System.Drawing.Size(249, 35);
            this.lblMostrarDescripcion.TabIndex = 49;
            this.lblMostrarDescripcion.Text = "¿Cuál es la descripción?";
            this.lblMostrarDescripcion.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextoAbiertoCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.boxImagen);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TextoAbiertoCrear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TextoAbierto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TextoAbiertoCrear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMostrarIm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox boxImagen;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPre;
        private System.Windows.Forms.TextBox lblCodigo;
        private System.Windows.Forms.Label lbldCodigo;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.PictureBox pictBoxMostrarIm;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.OpenFileDialog openFileImage;
        private System.Windows.Forms.Label lblMostrarDescripcion;
        private System.Windows.Forms.Label lblMostrarPregunta;
    }
}