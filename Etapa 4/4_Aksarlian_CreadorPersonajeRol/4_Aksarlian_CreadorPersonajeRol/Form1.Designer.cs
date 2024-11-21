namespace _4_Aksarlian_CreadorPersonajeRol
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
            this.label3 = new System.Windows.Forms.Label();
            this.text_n = new System.Windows.Forms.TextBox();
            this.text_v = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_r = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.frz = new System.Windows.Forms.CheckBox();
            this.invs = new System.Windows.Forms.CheckBox();
            this.cur = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creacion de PJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vida";
            // 
            // text_n
            // 
            this.text_n.Location = new System.Drawing.Point(19, 99);
            this.text_n.Name = "text_n";
            this.text_n.Size = new System.Drawing.Size(100, 20);
            this.text_n.TabIndex = 1;
            // 
            // text_v
            // 
            this.text_v.Location = new System.Drawing.Point(19, 153);
            this.text_v.Name = "text_v";
            this.text_v.Size = new System.Drawing.Size(100, 20);
            this.text_v.TabIndex = 4;
            this.text_v.TextChanged += new System.EventHandler(this.text_v_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Raza";
            // 
            // text_r
            // 
            this.text_r.FormattingEnabled = true;
            this.text_r.Items.AddRange(new object[] {
            "Humano",
            "Enano",
            "Hobbit"});
            this.text_r.Location = new System.Drawing.Point(19, 207);
            this.text_r.Name = "text_r";
            this.text_r.Size = new System.Drawing.Size(100, 21);
            this.text_r.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Habilidades Extra";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(553, 125);
            this.button1.TabIndex = 12;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frz
            // 
            this.frz.AutoSize = true;
            this.frz.Location = new System.Drawing.Point(19, 255);
            this.frz.Name = "frz";
            this.frz.Size = new System.Drawing.Size(58, 17);
            this.frz.TabIndex = 13;
            this.frz.Text = "Fuerza";
            this.frz.UseVisualStyleBackColor = true;
            // 
            // invs
            // 
            this.invs.AutoSize = true;
            this.invs.Location = new System.Drawing.Point(19, 301);
            this.invs.Name = "invs";
            this.invs.Size = new System.Drawing.Size(80, 17);
            this.invs.TabIndex = 14;
            this.invs.Text = "Invisibilidad";
            this.invs.UseVisualStyleBackColor = true;
            this.invs.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cur
            // 
            this.cur.AutoSize = true;
            this.cur.Location = new System.Drawing.Point(19, 278);
            this.cur.Name = "cur";
            this.cur.Size = new System.Drawing.Size(68, 17);
            this.cur.TabIndex = 15;
            this.cur.Text = "Curacion";
            this.cur.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.cur);
            this.Controls.Add(this.invs);
            this.Controls.Add(this.frz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_r);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_v);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_n);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_n;
        private System.Windows.Forms.TextBox text_v;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox text_r;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox frz;
        private System.Windows.Forms.CheckBox invs;
        private System.Windows.Forms.CheckBox cur;
    }
}

