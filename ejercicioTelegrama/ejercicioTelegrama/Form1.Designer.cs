﻿namespace ejercicioTelegrama
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.labelCoste = new System.Windows.Forms.Label();
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.radioOrdinario = new System.Windows.Forms.RadioButton();
            this.radioUrgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto";
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(79, 89);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(744, 220);
            this.txtTelegrama.TabIndex = 1;
            // 
            // labelCoste
            // 
            this.labelCoste.AutoSize = true;
            this.labelCoste.Location = new System.Drawing.Point(81, 377);
            this.labelCoste.Name = "labelCoste";
            this.labelCoste.Size = new System.Drawing.Size(51, 20);
            this.labelCoste.TabIndex = 3;
            this.labelCoste.Text = "Coste";
            this.labelCoste.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.Location = new System.Drawing.Point(715, 338);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(108, 45);
            this.btnCalcularPrecio.TabIndex = 4;
            this.btnCalcularPrecio.Text = "Calcular";
            this.btnCalcularPrecio.UseVisualStyleBackColor = true;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularprecio_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(157, 371);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(285, 26);
            this.txtPrecio.TabIndex = 5;
            // 
            // radioOrdinario
            // 
            this.radioOrdinario.AutoSize = true;
            this.radioOrdinario.Location = new System.Drawing.Point(85, 338);
            this.radioOrdinario.Name = "radioOrdinario";
            this.radioOrdinario.Size = new System.Drawing.Size(95, 24);
            this.radioOrdinario.TabIndex = 6;
            this.radioOrdinario.TabStop = true;
            this.radioOrdinario.Text = "ordinario";
            this.radioOrdinario.UseVisualStyleBackColor = true;
            this.radioOrdinario.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioUrgente
            // 
            this.radioUrgente.AutoSize = true;
            this.radioUrgente.Location = new System.Drawing.Point(186, 338);
            this.radioUrgente.Name = "radioUrgente";
            this.radioUrgente.Size = new System.Drawing.Size(92, 24);
            this.radioUrgente.TabIndex = 7;
            this.radioUrgente.TabStop = true;
            this.radioUrgente.Text = "Urgente";
            this.radioUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 422);
            this.Controls.Add(this.radioUrgente);
            this.Controls.Add(this.radioOrdinario);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Controls.Add(this.labelCoste);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label labelCoste;
        private System.Windows.Forms.Button btnCalcularPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton radioOrdinario;
        private System.Windows.Forms.RadioButton radioUrgente;
    }
}

