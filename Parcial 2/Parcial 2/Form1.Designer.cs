
using System;

namespace Parcial_2
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
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.textBoxArchivo = new System.Windows.Forms.TextBox();
            this.buttonPromedioporParcial = new System.Windows.Forms.Button();
            this.buttonPromedioporSeccion = new System.Windows.Forms.Button();
            this.buttonClasificarAlumnos = new System.Windows.Forms.Button();
            this.buttonNotaMayor = new System.Windows.Forms.Button();
            this.buttonNotaMayorGeneral = new System.Windows.Forms.Button();
            this.buttonCargarArchivo = new System.Windows.Forms.Button();
            this.buttonPromedioGeneralSeccion = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 16;
            this.listBoxResultado.Location = new System.Drawing.Point(39, 33);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(545, 308);
            this.listBoxResultado.TabIndex = 0;
            // 
            // textBoxArchivo
            // 
            this.textBoxArchivo.Location = new System.Drawing.Point(806, 36);
            this.textBoxArchivo.Multiline = true;
            this.textBoxArchivo.Name = "textBoxArchivo";
            this.textBoxArchivo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxArchivo.Size = new System.Drawing.Size(558, 305);
            this.textBoxArchivo.TabIndex = 1;
            // 
            // buttonPromedioporParcial
            // 
            this.buttonPromedioporParcial.Location = new System.Drawing.Point(123, 404);
            this.buttonPromedioporParcial.Name = "buttonPromedioporParcial";
            this.buttonPromedioporParcial.Size = new System.Drawing.Size(117, 59);
            this.buttonPromedioporParcial.TabIndex = 2;
            this.buttonPromedioporParcial.Text = "Promedio por Parcial";
            this.buttonPromedioporParcial.UseVisualStyleBackColor = true;
            this.buttonPromedioporParcial.Click += new System.EventHandler(this.buttonPromedioporParcial_Click);
            // 
            // buttonPromedioporSeccion
            // 
            this.buttonPromedioporSeccion.Location = new System.Drawing.Point(302, 404);
            this.buttonPromedioporSeccion.Name = "buttonPromedioporSeccion";
            this.buttonPromedioporSeccion.Size = new System.Drawing.Size(117, 59);
            this.buttonPromedioporSeccion.TabIndex = 3;
            this.buttonPromedioporSeccion.Text = "Promedio por Seccion";
            this.buttonPromedioporSeccion.UseVisualStyleBackColor = true;
            this.buttonPromedioporSeccion.Click += new System.EventHandler(this.buttonPromedioporSeccion_Click);
            // 
            // buttonClasificarAlumnos
            // 
            this.buttonClasificarAlumnos.Location = new System.Drawing.Point(663, 404);
            this.buttonClasificarAlumnos.Name = "buttonClasificarAlumnos";
            this.buttonClasificarAlumnos.Size = new System.Drawing.Size(129, 59);
            this.buttonClasificarAlumnos.TabIndex = 5;
            this.buttonClasificarAlumnos.Text = "Clasificar Alumnos";
            this.buttonClasificarAlumnos.UseVisualStyleBackColor = true;
            this.buttonClasificarAlumnos.Click += new System.EventHandler(this.buttonClasificarAlumnos_Click);
            // 
            // buttonNotaMayor
            // 
            this.buttonNotaMayor.Location = new System.Drawing.Point(856, 404);
            this.buttonNotaMayor.Name = "buttonNotaMayor";
            this.buttonNotaMayor.Size = new System.Drawing.Size(129, 59);
            this.buttonNotaMayor.TabIndex = 6;
            this.buttonNotaMayor.Text = "Promedio Mayor General";
            this.buttonNotaMayor.UseVisualStyleBackColor = true;
            this.buttonNotaMayor.Click += new System.EventHandler(this.buttonNotaMayor_Click);
            // 
            // buttonNotaMayorGeneral
            // 
            this.buttonNotaMayorGeneral.Location = new System.Drawing.Point(1057, 404);
            this.buttonNotaMayorGeneral.Name = "buttonNotaMayorGeneral";
            this.buttonNotaMayorGeneral.Size = new System.Drawing.Size(129, 59);
            this.buttonNotaMayorGeneral.TabIndex = 7;
            this.buttonNotaMayorGeneral.Text = "Promedio Mayor Seccion";
            this.buttonNotaMayorGeneral.UseVisualStyleBackColor = true;
            this.buttonNotaMayorGeneral.Click += new System.EventHandler(this.buttonNotaMayorGeneral_Click);
            // 
            // buttonCargarArchivo
            // 
            this.buttonCargarArchivo.Location = new System.Drawing.Point(618, 57);
            this.buttonCargarArchivo.Name = "buttonCargarArchivo";
            this.buttonCargarArchivo.Size = new System.Drawing.Size(141, 91);
            this.buttonCargarArchivo.TabIndex = 8;
            this.buttonCargarArchivo.Text = "Cargar Archivo";
            this.buttonCargarArchivo.UseVisualStyleBackColor = true;
            this.buttonCargarArchivo.Click += new System.EventHandler(this.buttonCargarArchivo_Click);
            // 
            // buttonPromedioGeneralSeccion
            // 
            this.buttonPromedioGeneralSeccion.Location = new System.Drawing.Point(486, 404);
            this.buttonPromedioGeneralSeccion.Name = "buttonPromedioGeneralSeccion";
            this.buttonPromedioGeneralSeccion.Size = new System.Drawing.Size(117, 59);
            this.buttonPromedioGeneralSeccion.TabIndex = 9;
            this.buttonPromedioGeneralSeccion.Text = "Promedio General Seccion";
            this.buttonPromedioGeneralSeccion.UseVisualStyleBackColor = true;
            this.buttonPromedioGeneralSeccion.Click += new System.EventHandler(this.buttonPromedioGeneralSeccion_Click_1);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(617, 190);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(141, 60);
            this.buttonLimpiar.TabIndex = 10;
            this.buttonLimpiar.Text = "Limpiar Listbox";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 521);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonPromedioGeneralSeccion);
            this.Controls.Add(this.buttonCargarArchivo);
            this.Controls.Add(this.buttonNotaMayorGeneral);
            this.Controls.Add(this.buttonNotaMayor);
            this.Controls.Add(this.buttonClasificarAlumnos);
            this.Controls.Add(this.buttonPromedioporSeccion);
            this.Controls.Add(this.buttonPromedioporParcial);
            this.Controls.Add(this.textBoxArchivo);
            this.Controls.Add(this.listBoxResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonPromedioGeneralSeccion_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.TextBox textBoxArchivo;
        private System.Windows.Forms.Button buttonPromedioporParcial;
        private System.Windows.Forms.Button buttonPromedioporSeccion;
        private System.Windows.Forms.Button buttonClasificarAlumnos;
        private System.Windows.Forms.Button buttonNotaMayor;
        private System.Windows.Forms.Button buttonNotaMayorGeneral;
        private System.Windows.Forms.Button buttonCargarArchivo;
        private System.Windows.Forms.Button buttonPromedioGeneralSeccion;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}

