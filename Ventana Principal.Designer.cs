namespace Proyecto_Kamil
{
    partial class VentOpciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.OpE = new System.Windows.Forms.Button();
            this.OpD = new System.Windows.Forms.Button();
            this.OpC = new System.Windows.Forms.Button();
            this.SalirApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opciones \"Proyecto Kamil\"";
            // 
            // OpE
            // 
            this.OpE.BackColor = System.Drawing.Color.PeachPuff;
            this.OpE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpE.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpE.ForeColor = System.Drawing.Color.Gray;
            this.OpE.Location = new System.Drawing.Point(319, 229);
            this.OpE.Name = "OpE";
            this.OpE.Size = new System.Drawing.Size(169, 32);
            this.OpE.TabIndex = 1;
            this.OpE.Text = "Empleados";
            this.OpE.UseVisualStyleBackColor = false;
            this.OpE.Click += new System.EventHandler(this.OpE_Click);
            // 
            // OpD
            // 
            this.OpD.BackColor = System.Drawing.Color.PeachPuff;
            this.OpD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpD.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpD.ForeColor = System.Drawing.Color.Gray;
            this.OpD.Location = new System.Drawing.Point(619, 229);
            this.OpD.Name = "OpD";
            this.OpD.Size = new System.Drawing.Size(169, 32);
            this.OpD.TabIndex = 2;
            this.OpD.Text = "Directivos";
            this.OpD.UseVisualStyleBackColor = false;
            this.OpD.Click += new System.EventHandler(this.OpD_Click);
            // 
            // OpC
            // 
            this.OpC.BackColor = System.Drawing.Color.PeachPuff;
            this.OpC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpC.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpC.ForeColor = System.Drawing.Color.Gray;
            this.OpC.Location = new System.Drawing.Point(12, 229);
            this.OpC.Name = "OpC";
            this.OpC.Size = new System.Drawing.Size(169, 32);
            this.OpC.TabIndex = 3;
            this.OpC.Text = "Centros";
            this.OpC.UseVisualStyleBackColor = false;
            this.OpC.Click += new System.EventHandler(this.OpC_Click);
            // 
            // SalirApp
            // 
            this.SalirApp.BackColor = System.Drawing.Color.LightSalmon;
            this.SalirApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SalirApp.Font = new System.Drawing.Font("Lucida Console", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirApp.Location = new System.Drawing.Point(713, 415);
            this.SalirApp.Name = "SalirApp";
            this.SalirApp.Size = new System.Drawing.Size(75, 23);
            this.SalirApp.TabIndex = 4;
            this.SalirApp.Text = "Salir";
            this.SalirApp.UseVisualStyleBackColor = false;
            this.SalirApp.Click += new System.EventHandler(this.button1_Click);
            // 
            // VentOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalirApp);
            this.Controls.Add(this.OpC);
            this.Controls.Add(this.OpD);
            this.Controls.Add(this.OpE);
            this.Controls.Add(this.label1);
            this.Name = "VentOpciones";
            this.Text = "Opciones ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpE;
        private System.Windows.Forms.Button OpD;
        private System.Windows.Forms.Button OpC;
        private System.Windows.Forms.Button SalirApp;
    }
}

