namespace MiPrimeraVezConWFroms
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
            this.label2 = new System.Windows.Forms.Label();
            this.temperatura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.farenheit = new System.Windows.Forms.Label();
            this.Kelvin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "conversor de temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese temperatura en Celsius";
            // 
            // temperatura
            // 
            this.temperatura.BackColor = System.Drawing.SystemColors.Window;
            this.temperatura.Location = new System.Drawing.Point(36, 209);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(186, 20);
            this.temperatura.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Farenheit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kelvin";
            // 
            // farenheit
            // 
            this.farenheit.AutoSize = true;
            this.farenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.farenheit.Location = new System.Drawing.Point(491, 186);
            this.farenheit.Name = "farenheit";
            this.farenheit.Size = new System.Drawing.Size(57, 31);
            this.farenheit.TabIndex = 5;
            this.farenheit.Text = "0°F";
            this.farenheit.Click += new System.EventHandler(this.farenheit_Click);
            // 
            // Kelvin
            // 
            this.Kelvin.AutoSize = true;
            this.Kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kelvin.Location = new System.Drawing.Point(491, 247);
            this.Kelvin.Name = "Kelvin";
            this.Kelvin.Size = new System.Drawing.Size(58, 31);
            this.Kelvin.TabIndex = 6;
            this.Kelvin.Text = "0°K";
            this.Kelvin.Click += new System.EventHandler(this.Kelvin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "trasnformar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Kelvin);
            this.Controls.Add(this.farenheit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.temperatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox temperatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label farenheit;
        private System.Windows.Forms.Label Kelvin;
        private System.Windows.Forms.Button button1;
    }
}

