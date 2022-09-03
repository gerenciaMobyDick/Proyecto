namespace WindowsFormsApp2
{
    partial class Deporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deporte));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSunNom = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTypePoint = new System.Windows.Forms.Label();
            this.lblCountEquipo = new System.Windows.Forms.Label();
            this.lblCountDeportista = new System.Windows.Forms.Label();
            this.lblDepNom = new System.Windows.Forms.Label();
            this.lblReglas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 463);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RomanD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDepNom);
            this.panel1.Controls.Add(this.lblCountDeportista);
            this.panel1.Controls.Add(this.lblCountEquipo);
            this.panel1.Controls.Add(this.lblTypePoint);
            this.panel1.Controls.Add(this.lblSunNom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(460, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 226);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblReglas);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(460, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 226);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RomanD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RomanD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Puntuacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("RomanD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Equipos inscriptos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("RomanD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Daportistas Activos:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSunNom
            // 
            this.lblSunNom.AutoSize = true;
            this.lblSunNom.Font = new System.Drawing.Font("RomanD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunNom.Location = new System.Drawing.Point(266, 39);
            this.lblSunNom.MaximumSize = new System.Drawing.Size(450, 29);
            this.lblSunNom.MinimumSize = new System.Drawing.Size(450, 29);
            this.lblSunNom.Name = "lblSunNom";
            this.lblSunNom.Size = new System.Drawing.Size(450, 29);
            this.lblSunNom.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("RomanD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 29);
            this.label11.TabIndex = 2;
            this.label11.Text = "Reglas y Detalles:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("RomanD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 41);
            this.label12.MaximumSize = new System.Drawing.Size(695, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 29);
            this.label12.TabIndex = 3;
            // 
            // lblTypePoint
            // 
            this.lblTypePoint.AutoSize = true;
            this.lblTypePoint.Font = new System.Drawing.Font("RomanD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypePoint.Location = new System.Drawing.Point(266, 97);
            this.lblTypePoint.MaximumSize = new System.Drawing.Size(450, 29);
            this.lblTypePoint.MinimumSize = new System.Drawing.Size(450, 29);
            this.lblTypePoint.Name = "lblTypePoint";
            this.lblTypePoint.Size = new System.Drawing.Size(450, 29);
            this.lblTypePoint.TabIndex = 11;
            // 
            // lblCountEquipo
            // 
            this.lblCountEquipo.AutoSize = true;
            this.lblCountEquipo.Font = new System.Drawing.Font("RomanD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountEquipo.Location = new System.Drawing.Point(267, 126);
            this.lblCountEquipo.MaximumSize = new System.Drawing.Size(450, 29);
            this.lblCountEquipo.MinimumSize = new System.Drawing.Size(450, 29);
            this.lblCountEquipo.Name = "lblCountEquipo";
            this.lblCountEquipo.Size = new System.Drawing.Size(450, 29);
            this.lblCountEquipo.TabIndex = 12;
            // 
            // lblCountDeportista
            // 
            this.lblCountDeportista.AutoSize = true;
            this.lblCountDeportista.Font = new System.Drawing.Font("RomanD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDeportista.Location = new System.Drawing.Point(266, 155);
            this.lblCountDeportista.MaximumSize = new System.Drawing.Size(450, 29);
            this.lblCountDeportista.MinimumSize = new System.Drawing.Size(450, 29);
            this.lblCountDeportista.Name = "lblCountDeportista";
            this.lblCountDeportista.Size = new System.Drawing.Size(450, 29);
            this.lblCountDeportista.TabIndex = 13;
            // 
            // lblDepNom
            // 
            this.lblDepNom.AutoSize = true;
            this.lblDepNom.Font = new System.Drawing.Font("RomanD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepNom.Location = new System.Drawing.Point(266, 68);
            this.lblDepNom.MaximumSize = new System.Drawing.Size(450, 29);
            this.lblDepNom.MinimumSize = new System.Drawing.Size(450, 29);
            this.lblDepNom.Name = "lblDepNom";
            this.lblDepNom.Size = new System.Drawing.Size(450, 29);
            this.lblDepNom.TabIndex = 14;
            // 
            // lblReglas
            // 
            this.lblReglas.AutoSize = true;
            this.lblReglas.Font = new System.Drawing.Font("RomanD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReglas.Location = new System.Drawing.Point(16, 41);
            this.lblReglas.MaximumSize = new System.Drawing.Size(695, 170);
            this.lblReglas.MinimumSize = new System.Drawing.Size(695, 170);
            this.lblReglas.Name = "lblReglas";
            this.lblReglas.Size = new System.Drawing.Size(695, 170);
            this.lblReglas.TabIndex = 15;
            // 
            // Deporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Deporte";
            this.Text = "Deporte";
            this.Load += new System.EventHandler(this.Deporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDepNom;
        private System.Windows.Forms.Label lblCountDeportista;
        private System.Windows.Forms.Label lblCountEquipo;
        private System.Windows.Forms.Label lblTypePoint;
        private System.Windows.Forms.Label lblSunNom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblReglas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}