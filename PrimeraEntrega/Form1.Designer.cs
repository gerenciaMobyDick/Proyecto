namespace PrimeraEntrega
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lnkRegistrar = new System.Windows.Forms.LinkLabel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.boxPermisos = new System.Windows.Forms.CheckBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblCrear = new System.Windows.Forms.Label();
            this.lblIniciar = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnCode = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.pbxLogoEmpreza = new System.Windows.Forms.PictureBox();
            this.btnLUser = new System.Windows.Forms.Button();
            this.lblABackofice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trvImgInf = new System.Windows.Forms.TreeView();
            this.imlPubInferior = new System.Windows.Forms.ImageList(this.components);
            this.trvImage = new System.Windows.Forms.TreeView();
            this.imlPubLateral = new System.Windows.Forms.ImageList(this.components);
            this.lbxAUser = new System.Windows.Forms.ListBox();
            this.btnHUser = new System.Windows.Forms.Button();
            this.btnLadd = new System.Windows.Forms.Button();
            this.btnLatadds = new System.Windows.Forms.Button();
            this.btnDUser = new System.Windows.Forms.Button();
            this.btnDadd = new System.Windows.Forms.Button();
            this.pbxPub3 = new System.Windows.Forms.PictureBox();
            this.pbxPub2 = new System.Windows.Forms.PictureBox();
            this.pbxPub1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlLogin.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoEmpreza)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPub3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPub2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPub1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkRegistrar
            // 
            this.lnkRegistrar.AutoSize = true;
            this.lnkRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRegistrar.LinkColor = System.Drawing.Color.Black;
            this.lnkRegistrar.Location = new System.Drawing.Point(26, 294);
            this.lnkRegistrar.Name = "lnkRegistrar";
            this.lnkRegistrar.Size = new System.Drawing.Size(91, 15);
            this.lnkRegistrar.TabIndex = 1;
            this.lnkRegistrar.TabStop = true;
            this.lnkRegistrar.Text = "Crear Cuenta";
            this.lnkRegistrar.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkRegistrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegistrar_LinkClicked);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(25, 103);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(91, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Username";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.Location = new System.Drawing.Point(25, 183);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(86, 20);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "Password";
            // 
            // boxPermisos
            // 
            this.boxPermisos.AutoSize = true;
            this.boxPermisos.Checked = true;
            this.boxPermisos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boxPermisos.Location = new System.Drawing.Point(37, 237);
            this.boxPermisos.Name = "boxPermisos";
            this.boxPermisos.Size = new System.Drawing.Size(210, 17);
            this.boxPermisos.TabIndex = 4;
            this.boxPermisos.Text = "Permitir enviar mensajes promocionales";
            this.boxPermisos.UseVisualStyleBackColor = true;
            this.boxPermisos.Visible = false;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(132, 145);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(149, 20);
            this.txtCode.TabIndex = 5;
            this.txtCode.Visible = false;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(132, 185);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(149, 20);
            this.txtPwd.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(132, 105);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(149, 20);
            this.txtUser.TabIndex = 7;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(25, 143);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(91, 20);
            this.lblCode.TabIndex = 8;
            this.lblCode.Text = "Codigo    -";
            this.lblCode.Visible = false;
            // 
            // lblCrear
            // 
            this.lblCrear.AutoSize = true;
            this.lblCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblCrear.Location = new System.Drawing.Point(49, 24);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(221, 37);
            this.lblCrear.TabIndex = 10;
            this.lblCrear.Text = "Crear Cuenta";
            this.lblCrear.Visible = false;
            // 
            // lblIniciar
            // 
            this.lblIniciar.AutoSize = true;
            this.lblIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciar.Location = new System.Drawing.Point(49, 24);
            this.lblIniciar.Name = "lblIniciar";
            this.lblIniciar.Size = new System.Drawing.Size(222, 37);
            this.lblIniciar.TabIndex = 11;
            this.lblIniciar.Text = "Iniciar Sesion";
            // 
            // btnIniciar
            // 
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(177, 281);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(120, 41);
            this.btnIniciar.TabIndex = 12;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(177, 281);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(120, 41);
            this.btnCrear.TabIndex = 13;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Visible = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.btnIniciar);
            this.pnlLogin.Controls.Add(this.lblAdmin);
            this.pnlLogin.Controls.Add(this.lblIniciar);
            this.pnlLogin.Controls.Add(this.boxPermisos);
            this.pnlLogin.Controls.Add(this.lblCrear);
            this.pnlLogin.Controls.Add(this.lnkRegistrar);
            this.pnlLogin.Controls.Add(this.lblCode);
            this.pnlLogin.Controls.Add(this.txtPwd);
            this.pnlLogin.Controls.Add(this.lblPwd);
            this.pnlLogin.Controls.Add(this.txtCode);
            this.pnlLogin.Controls.Add(this.txtUser);
            this.pnlLogin.Controls.Add(this.lblUser);
            this.pnlLogin.Controls.Add(this.btnCrear);
            this.pnlLogin.Controls.Add(this.btnCode);
            this.pnlLogin.Location = new System.Drawing.Point(230, 24);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(316, 341);
            this.pnlLogin.TabIndex = 14;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(40, 24);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(230, 37);
            this.lblAdmin.TabIndex = 14;
            this.lblAdmin.Text = "Administrador";
            this.lblAdmin.Visible = false;
            // 
            // btnCode
            // 
            this.btnCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCode.Location = new System.Drawing.Point(177, 281);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(120, 41);
            this.btnCode.TabIndex = 15;
            this.btnCode.Text = "Ingresar";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdmin.Controls.Add(this.pbxLogoEmpreza);
            this.pnlAdmin.Controls.Add(this.btnLUser);
            this.pnlAdmin.Controls.Add(this.lblABackofice);
            this.pnlAdmin.Controls.Add(this.panel1);
            this.pnlAdmin.Controls.Add(this.btnHUser);
            this.pnlAdmin.Controls.Add(this.btnLadd);
            this.pnlAdmin.Controls.Add(this.btnLatadds);
            this.pnlAdmin.Controls.Add(this.btnDUser);
            this.pnlAdmin.Controls.Add(this.btnDadd);
            this.pnlAdmin.Location = new System.Drawing.Point(43, 24);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(709, 399);
            this.pnlAdmin.TabIndex = 15;
            this.pnlAdmin.Visible = false;
            // 
            // pbxLogoEmpreza
            // 
            this.pbxLogoEmpreza.Location = new System.Drawing.Point(7, 135);
            this.pbxLogoEmpreza.Name = "pbxLogoEmpreza";
            this.pbxLogoEmpreza.Size = new System.Drawing.Size(256, 256);
            this.pbxLogoEmpreza.TabIndex = 7;
            this.pbxLogoEmpreza.TabStop = false;
            // 
            // btnLUser
            // 
            this.btnLUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLUser.Location = new System.Drawing.Point(269, 43);
            this.btnLUser.Name = "btnLUser";
            this.btnLUser.Size = new System.Drawing.Size(143, 31);
            this.btnLUser.TabIndex = 4;
            this.btnLUser.Text = "Users List";
            this.btnLUser.UseVisualStyleBackColor = true;
            this.btnLUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblABackofice
            // 
            this.lblABackofice.AutoSize = true;
            this.lblABackofice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABackofice.Location = new System.Drawing.Point(37, 37);
            this.lblABackofice.Name = "lblABackofice";
            this.lblABackofice.Size = new System.Drawing.Size(184, 37);
            this.lblABackofice.TabIndex = 1;
            this.lblABackofice.Text = "Backoffice:";
            this.lblABackofice.Click += new System.EventHandler(this.lblABackofice_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trvImgInf);
            this.panel1.Controls.Add(this.trvImage);
            this.panel1.Controls.Add(this.lbxAUser);
            this.panel1.Location = new System.Drawing.Point(440, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 329);
            this.panel1.TabIndex = 3;
            // 
            // trvImgInf
            // 
            this.trvImgInf.ImageIndex = 0;
            this.trvImgInf.ImageList = this.imlPubInferior;
            this.trvImgInf.Location = new System.Drawing.Point(1, 1);
            this.trvImgInf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trvImgInf.Name = "trvImgInf";
            this.trvImgInf.SelectedImageIndex = 0;
            this.trvImgInf.Size = new System.Drawing.Size(247, 328);
            this.trvImgInf.TabIndex = 5;
            this.trvImgInf.Visible = false;
            // 
            // imlPubInferior
            // 
            this.imlPubInferior.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlPubInferior.ImageStream")));
            this.imlPubInferior.TransparentColor = System.Drawing.Color.Transparent;
            this.imlPubInferior.Images.SetKeyName(0, "1.jpeg");
            this.imlPubInferior.Images.SetKeyName(1, "5.jpeg");
            // 
            // trvImage
            // 
            this.trvImage.ImageIndex = 0;
            this.trvImage.ImageList = this.imlPubLateral;
            this.trvImage.Location = new System.Drawing.Point(0, 0);
            this.trvImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trvImage.Name = "trvImage";
            this.trvImage.SelectedImageIndex = 0;
            this.trvImage.Size = new System.Drawing.Size(247, 328);
            this.trvImage.StateImageList = this.imlPubLateral;
            this.trvImage.TabIndex = 4;
            this.trvImage.Visible = false;
            // 
            // imlPubLateral
            // 
            this.imlPubLateral.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlPubLateral.ImageStream")));
            this.imlPubLateral.TransparentColor = System.Drawing.Color.Transparent;
            this.imlPubLateral.Images.SetKeyName(0, "2.jpeg");
            this.imlPubLateral.Images.SetKeyName(1, "3.jpeg");
            this.imlPubLateral.Images.SetKeyName(2, "4.jpeg");
            // 
            // lbxAUser
            // 
            this.lbxAUser.FormattingEnabled = true;
            this.lbxAUser.Location = new System.Drawing.Point(0, 0);
            this.lbxAUser.Name = "lbxAUser";
            this.lbxAUser.Size = new System.Drawing.Size(248, 329);
            this.lbxAUser.TabIndex = 2;
            this.lbxAUser.Visible = false;
            // 
            // btnHUser
            // 
            this.btnHUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHUser.Location = new System.Drawing.Point(269, 249);
            this.btnHUser.Name = "btnHUser";
            this.btnHUser.Size = new System.Drawing.Size(143, 31);
            this.btnHUser.TabIndex = 6;
            this.btnHUser.Text = "Highlight Users";
            this.btnHUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHUser.UseVisualStyleBackColor = true;
            this.btnHUser.Visible = false;
            // 
            // btnLadd
            // 
            this.btnLadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLadd.Location = new System.Drawing.Point(269, 96);
            this.btnLadd.Name = "btnLadd";
            this.btnLadd.Size = new System.Drawing.Size(143, 31);
            this.btnLadd.TabIndex = 8;
            this.btnLadd.Text = "Low Adds";
            this.btnLadd.UseVisualStyleBackColor = true;
            this.btnLadd.Click += new System.EventHandler(this.btnLadd_Click);
            // 
            // btnLatadds
            // 
            this.btnLatadds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLatadds.Location = new System.Drawing.Point(269, 149);
            this.btnLatadds.Name = "btnLatadds";
            this.btnLatadds.Size = new System.Drawing.Size(143, 31);
            this.btnLatadds.TabIndex = 10;
            this.btnLatadds.Text = "Lateral Adds";
            this.btnLatadds.UseVisualStyleBackColor = true;
            this.btnLatadds.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDUser
            // 
            this.btnDUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDUser.Location = new System.Drawing.Point(269, 200);
            this.btnDUser.Name = "btnDUser";
            this.btnDUser.Size = new System.Drawing.Size(143, 31);
            this.btnDUser.TabIndex = 5;
            this.btnDUser.Text = "Delete User";
            this.btnDUser.UseVisualStyleBackColor = true;
            this.btnDUser.Visible = false;
            this.btnDUser.Click += new System.EventHandler(this.btnDUser_Click);
            // 
            // btnDadd
            // 
            this.btnDadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDadd.Location = new System.Drawing.Point(269, 200);
            this.btnDadd.Name = "btnDadd";
            this.btnDadd.Size = new System.Drawing.Size(143, 31);
            this.btnDadd.TabIndex = 9;
            this.btnDadd.Text = "Delete Add";
            this.btnDadd.UseVisualStyleBackColor = true;
            this.btnDadd.Visible = false;
            this.btnDadd.Click += new System.EventHandler(this.btnDadd_Click);
            // 
            // pbxPub3
            // 
            this.pbxPub3.Location = new System.Drawing.Point(268, 385);
            this.pbxPub3.Name = "pbxPub3";
            this.pbxPub3.Size = new System.Drawing.Size(256, 64);
            this.pbxPub3.TabIndex = 5;
            this.pbxPub3.TabStop = false;
            // 
            // pbxPub2
            // 
            this.pbxPub2.Location = new System.Drawing.Point(588, 69);
            this.pbxPub2.Name = "pbxPub2";
            this.pbxPub2.Size = new System.Drawing.Size(200, 256);
            this.pbxPub2.TabIndex = 3;
            this.pbxPub2.TabStop = false;
            // 
            // pbxPub1
            // 
            this.pbxPub1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbxPub1.Location = new System.Drawing.Point(12, 69);
            this.pbxPub1.Name = "pbxPub1";
            this.pbxPub1.Size = new System.Drawing.Size(200, 256);
            this.pbxPub1.TabIndex = 4;
            this.pbxPub1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.pbxPub2);
            this.Controls.Add(this.pbxPub3);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pbxPub1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoEmpreza)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPub3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPub2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPub1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnkRegistrar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.CheckBox boxPermisos;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblCrear;
        private System.Windows.Forms.Label lblIniciar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.ListBox lbxAUser;
        private System.Windows.Forms.Label lblABackofice;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.PictureBox pbxPub3;
        private System.Windows.Forms.PictureBox pbxPub1;
        private System.Windows.Forms.PictureBox pbxPub2;
        private System.Windows.Forms.ImageList imlPubLateral;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ImageList imlPubInferior;
        private System.Windows.Forms.PictureBox pbxLogoEmpreza;
        private System.Windows.Forms.Button btnHUser;
        private System.Windows.Forms.Button btnDUser;
        private System.Windows.Forms.Button btnLUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLadd;
        private System.Windows.Forms.TreeView trvImage;
        private System.Windows.Forms.Button btnDadd;
        private System.Windows.Forms.TreeView trvImgInf;
        private System.Windows.Forms.Button btnLatadds;
    }
}

