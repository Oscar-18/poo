namespace PaísesCentroAmericanos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Introduccion = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IniciarPrograma = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreditos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.picUNI = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUNI)).BeginInit();
            this.SuspendLayout();
            // 
            // Introduccion
            // 
            this.Introduccion.Location = new System.Drawing.Point(44, 26);
            this.Introduccion.Name = "Introduccion";
            this.Introduccion.Size = new System.Drawing.Size(600, 20);
            this.Introduccion.TabIndex = 0;
            this.Introduccion.Text = "Países Centroamericanos";
            this.Introduccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // IniciarPrograma
            // 
            this.IniciarPrograma.Location = new System.Drawing.Point(76, 26);
            this.IniciarPrograma.Name = "IniciarPrograma";
            this.IniciarPrograma.Size = new System.Drawing.Size(123, 52);
            this.IniciarPrograma.TabIndex = 2;
            this.IniciarPrograma.Text = "Iniciar";
            this.IniciarPrograma.UseVisualStyleBackColor = true;
            this.IniciarPrograma.Click += new System.EventHandler(this.IniciarPrograma_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(232, 26);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 52);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.Location = new System.Drawing.Point(388, 26);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(123, 52);
            this.btnCreditos.TabIndex = 4;
            this.btnCreditos.Text = "Créditos";
            this.btnCreditos.UseVisualStyleBackColor = true;
            this.btnCreditos.Click += new System.EventHandler(this.BtnCreditos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreditos);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.IniciarPrograma);
            this.groupBox1.Location = new System.Drawing.Point(40, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 97);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(539, 399);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(0, 13);
            this.labelFecha.TabIndex = 6;
            // 
            // picUNI
            // 
            this.picUNI.Image = global::PaísesCentroAmericanos.Properties.Resources.Logo_UNI__1_;
            this.picUNI.Location = new System.Drawing.Point(272, 88);
            this.picUNI.Name = "picUNI";
            this.picUNI.Size = new System.Drawing.Size(144, 92);
            this.picUNI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUNI.TabIndex = 7;
            this.picUNI.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.picUNI);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Introduccion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Paises Centroamericanos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUNI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Introduccion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button IniciarPrograma;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreditos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.PictureBox picUNI;
    }
}

