namespace Ejertcicio3_Sueldo_neto
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
            this.txt_Pago = new System.Windows.Forms.TextBox();
            this.lbl_pago = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_sueldo = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_AFP = new System.Windows.Forms.Label();
            this.lbl_SFS = new System.Windows.Forms.Label();
            this.lbl_desceunto = new System.Windows.Forms.Label();
            this.lbl_Neto = new System.Windows.Forms.Label();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.txt_descuentos = new System.Windows.Forms.TextBox();
            this.txt_neto = new System.Windows.Forms.TextBox();
            this.txt_AFP = new System.Windows.Forms.TextBox();
            this.txt_SFS = new System.Windows.Forms.TextBox();
            this.txt_Sueldo = new System.Windows.Forms.TextBox();
            this.txt_Horas = new System.Windows.Forms.TextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Pago
            // 
            this.txt_Pago.Location = new System.Drawing.Point(217, 96);
            this.txt_Pago.Name = "txt_Pago";
            this.txt_Pago.Size = new System.Drawing.Size(100, 20);
            this.txt_Pago.TabIndex = 0;
            // 
            // lbl_pago
            // 
            this.lbl_pago.AutoSize = true;
            this.lbl_pago.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pago.Location = new System.Drawing.Point(127, 98);
            this.lbl_pago.Name = "lbl_pago";
            this.lbl_pago.Size = new System.Drawing.Size(84, 16);
            this.lbl_pago.TabIndex = 1;
            this.lbl_pago.Text = "Pago por hora";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Calcular.Location = new System.Drawing.Point(217, 456);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(100, 26);
            this.btn_Calcular.TabIndex = 2;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_sueldo
            // 
            this.lbl_sueldo.AutoSize = true;
            this.lbl_sueldo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sueldo.Location = new System.Drawing.Point(339, 171);
            this.lbl_sueldo.Name = "lbl_sueldo";
            this.lbl_sueldo.Size = new System.Drawing.Size(79, 16);
            this.lbl_sueldo.TabIndex = 3;
            this.lbl_sueldo.Text = "Sueldo Bruto";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(232, 23);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(315, 26);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Sueldo Neto del empleado";
            // 
            // lbl_AFP
            // 
            this.lbl_AFP.AutoSize = true;
            this.lbl_AFP.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AFP.Location = new System.Drawing.Point(184, 242);
            this.lbl_AFP.Name = "lbl_AFP";
            this.lbl_AFP.Size = new System.Drawing.Size(28, 16);
            this.lbl_AFP.TabIndex = 5;
            this.lbl_AFP.Text = "AFP";
            // 
            // lbl_SFS
            // 
            this.lbl_SFS.AutoSize = true;
            this.lbl_SFS.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SFS.Location = new System.Drawing.Point(425, 238);
            this.lbl_SFS.Name = "lbl_SFS";
            this.lbl_SFS.Size = new System.Drawing.Size(27, 16);
            this.lbl_SFS.TabIndex = 6;
            this.lbl_SFS.Text = "SFS";
            // 
            // lbl_desceunto
            // 
            this.lbl_desceunto.AutoSize = true;
            this.lbl_desceunto.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desceunto.Location = new System.Drawing.Point(330, 314);
            this.lbl_desceunto.Name = "lbl_desceunto";
            this.lbl_desceunto.Size = new System.Drawing.Size(99, 16);
            this.lbl_desceunto.TabIndex = 7;
            this.lbl_desceunto.Text = "Total descuentos";
            // 
            // lbl_Neto
            // 
            this.lbl_Neto.AutoSize = true;
            this.lbl_Neto.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Neto.Location = new System.Drawing.Point(344, 369);
            this.lbl_Neto.Name = "lbl_Neto";
            this.lbl_Neto.Size = new System.Drawing.Size(74, 16);
            this.lbl_Neto.TabIndex = 8;
            this.lbl_Neto.Text = "Sueldo Neto";
            // 
            // lbl_horas
            // 
            this.lbl_horas.AutoSize = true;
            this.lbl_horas.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horas.Location = new System.Drawing.Point(352, 100);
            this.lbl_horas.Name = "lbl_horas";
            this.lbl_horas.Size = new System.Drawing.Size(100, 16);
            this.lbl_horas.TabIndex = 9;
            this.lbl_horas.Text = "Horas Trabajadas";
            // 
            // txt_descuentos
            // 
            this.txt_descuentos.Location = new System.Drawing.Point(329, 333);
            this.txt_descuentos.Name = "txt_descuentos";
            this.txt_descuentos.Size = new System.Drawing.Size(100, 20);
            this.txt_descuentos.TabIndex = 10;
            // 
            // txt_neto
            // 
            this.txt_neto.Location = new System.Drawing.Point(329, 388);
            this.txt_neto.Name = "txt_neto";
            this.txt_neto.Size = new System.Drawing.Size(100, 20);
            this.txt_neto.TabIndex = 11;
            // 
            // txt_AFP
            // 
            this.txt_AFP.Location = new System.Drawing.Point(217, 239);
            this.txt_AFP.Name = "txt_AFP";
            this.txt_AFP.Size = new System.Drawing.Size(100, 20);
            this.txt_AFP.TabIndex = 13;
            // 
            // txt_SFS
            // 
            this.txt_SFS.Location = new System.Drawing.Point(458, 235);
            this.txt_SFS.Name = "txt_SFS";
            this.txt_SFS.Size = new System.Drawing.Size(100, 20);
            this.txt_SFS.TabIndex = 14;
            // 
            // txt_Sueldo
            // 
            this.txt_Sueldo.Location = new System.Drawing.Point(329, 187);
            this.txt_Sueldo.Name = "txt_Sueldo";
            this.txt_Sueldo.Size = new System.Drawing.Size(100, 20);
            this.txt_Sueldo.TabIndex = 15;
            // 
            // txt_Horas
            // 
            this.txt_Horas.Location = new System.Drawing.Point(458, 96);
            this.txt_Horas.Name = "txt_Horas";
            this.txt_Horas.Size = new System.Drawing.Size(100, 20);
            this.txt_Horas.TabIndex = 16;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_limpiar.Location = new System.Drawing.Point(342, 456);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(87, 26);
            this.btn_limpiar.TabIndex = 17;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cerrar.Location = new System.Drawing.Point(458, 456);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(89, 26);
            this.btn_cerrar.TabIndex = 18;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(712, 513);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.txt_Horas);
            this.Controls.Add(this.txt_Sueldo);
            this.Controls.Add(this.txt_SFS);
            this.Controls.Add(this.txt_AFP);
            this.Controls.Add(this.txt_neto);
            this.Controls.Add(this.txt_descuentos);
            this.Controls.Add(this.lbl_horas);
            this.Controls.Add(this.lbl_Neto);
            this.Controls.Add(this.lbl_desceunto);
            this.Controls.Add(this.lbl_SFS);
            this.Controls.Add(this.lbl_AFP);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.lbl_sueldo);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lbl_pago);
            this.Controls.Add(this.txt_Pago);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Pago;
        private System.Windows.Forms.Label lbl_pago;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_sueldo;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_AFP;
        private System.Windows.Forms.Label lbl_SFS;
        private System.Windows.Forms.Label lbl_desceunto;
        private System.Windows.Forms.Label lbl_Neto;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.TextBox txt_descuentos;
        private System.Windows.Forms.TextBox txt_neto;
        private System.Windows.Forms.TextBox txt_AFP;
        private System.Windows.Forms.TextBox txt_SFS;
        private System.Windows.Forms.TextBox txt_Sueldo;
        private System.Windows.Forms.TextBox txt_Horas;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}

