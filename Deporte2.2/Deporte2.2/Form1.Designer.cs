﻿namespace Deporte2._2
{
        partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smiEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.smiNacional = new System.Windows.Forms.ToolStripMenuItem();
            this.smiRegional = new System.Windows.Forms.ToolStripMenuItem();
            this.smiGlobal = new System.Windows.Forms.ToolStripMenuItem();
            this.smiDeportes = new System.Windows.Forms.ToolStripMenuItem();
            this.smiEquipos = new System.Windows.Forms.ToolStripMenuItem();
            this.smiDeportista = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1109, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiEvento,
            this.smiDeportes,
            this.smiEquipos,
            this.smiDeportista});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(160, 741);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smiEvento
            // 
            this.smiEvento.DoubleClickEnabled = true;
            this.smiEvento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiNacional,
            this.smiRegional,
            this.smiGlobal});
            this.smiEvento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.smiEvento.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.smiEvento.Name = "smiEvento";
            this.smiEvento.Size = new System.Drawing.Size(147, 23);
            this.smiEvento.Text = "Eventos  Deportivos";
            this.smiEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.smiEvento.Click += new System.EventHandler(this.smiEvento_Click);
            // 
            // smiNacional
            // 
            this.smiNacional.DoubleClickEnabled = true;
            this.smiNacional.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.smiNacional.Name = "smiNacional";
            this.smiNacional.Size = new System.Drawing.Size(210, 24);
            this.smiNacional.Text = "Eventos  Nacionales";
            this.smiNacional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.smiNacional.Click += new System.EventHandler(this.smiNacional_Click);
            // 
            // smiRegional
            // 
            this.smiRegional.DoubleClickEnabled = true;
            this.smiRegional.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.smiRegional.Name = "smiRegional";
            this.smiRegional.Size = new System.Drawing.Size(210, 24);
            this.smiRegional.Text = "Eventos  Regionales";
            this.smiRegional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.smiRegional.Click += new System.EventHandler(this.smiRegional_Click);
            // 
            // smiGlobal
            // 
            this.smiGlobal.DoubleClickEnabled = true;
            this.smiGlobal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.smiGlobal.Name = "smiGlobal";
            this.smiGlobal.Size = new System.Drawing.Size(210, 24);
            this.smiGlobal.Text = "Eventos  Mundiales";
            this.smiGlobal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.smiGlobal.Click += new System.EventHandler(this.smiGlobal_Click);
            // 
            // smiDeportes
            // 
            this.smiDeportes.DoubleClickEnabled = true;
            this.smiDeportes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.smiDeportes.Name = "smiDeportes";
            this.smiDeportes.Size = new System.Drawing.Size(147, 23);
            this.smiDeportes.Text = "Deportes";
            this.smiDeportes.Click += new System.EventHandler(this.smiDeportes_Click);
            // 
            // smiEquipos
            // 
            this.smiEquipos.DoubleClickEnabled = true;
            this.smiEquipos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.smiEquipos.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.smiEquipos.Name = "smiEquipos";
            this.smiEquipos.Size = new System.Drawing.Size(147, 23);
            this.smiEquipos.Text = "Equipos";
            this.smiEquipos.Click += new System.EventHandler(this.smiEquipos_Click);
            // 
            // smiDeportista
            // 
            this.smiDeportista.DoubleClickEnabled = true;
            this.smiDeportista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.smiDeportista.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.smiDeportista.Name = "smiDeportista";
            this.smiDeportista.Size = new System.Drawing.Size(147, 23);
            this.smiDeportista.Text = "Deportistas";
            this.smiDeportista.Click += new System.EventHandler(this.smiDeportista_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(391, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 519);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DataGridView
            // 
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.ColumnHeadersVisible = false;
            this.DataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataGridView.Location = new System.Drawing.Point(333, 152);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ShowCellErrors = false;
            this.DataGridView.ShowRowErrors = false;
            this.DataGridView.Size = new System.Drawing.Size(753, 548);
            this.DataGridView.TabIndex = 3;
            this.DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.MenuStrip menuStrip1;
            private System.Windows.Forms.ToolStripMenuItem smiEvento;
            private System.Windows.Forms.ToolStripMenuItem smiNacional;
            private System.Windows.Forms.ToolStripMenuItem smiRegional;
            private System.Windows.Forms.ToolStripMenuItem smiGlobal;
            private System.Windows.Forms.ToolStripMenuItem smiDeportes;
            private System.Windows.Forms.ToolStripMenuItem smiEquipos;
            private System.Windows.Forms.ToolStripMenuItem smiDeportista;
            private System.Windows.Forms.PictureBox pictureBox1;
            private System.Windows.Forms.DataGridView DataGridView;
        }
    }
