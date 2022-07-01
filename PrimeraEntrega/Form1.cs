using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PrimeraEntrega
{
    public partial class Form1 : Form
    {
        ArrayList Username = new ArrayList();
        ArrayList Pasword = new ArrayList();
        List<String> Lista = new List<String>();
        int TempPub = 0;

        /*public class Usuarios
        {
            public string Name { get; set; }
            public string Pwd { get; set; }

            public Usuarios(string Name, string Pwd)
            {
                this.Name = Name;
                this.Pwd = Pwd;
            }
        }*/
        public Form1()
        {
            InitializeComponent();
        }       

        public void AddUser (String x, string y)
        {
            Username.Add(x);
            Pasword.Add(y);
            Lista.Add(x);
            lbxAUser.ValueMember = Name;
            lbxAUser.DisplayMember = Name;
            lbxAUser.DataSource = Lista;
        }

        private void Visual(Boolean x)
        {
            lblAdmin.Visible = x;
            lblIniciar.Visible = x;
            lblCrear.Visible = false;
            lblCode.Visible = x;
            txtCode.Visible = x;
            lblUser.Visible = x;
            txtUser.Visible = x;
            lblPwd.Visible = x;
            txtPwd.Visible = x;
            btnCrear.Visible = false;
            btnIniciar.Visible = x;
            lnkRegistrar.Visible = x;
            boxPermisos.Visible = false;
            pbxPub1.Visible = x;
            pbxPub2.Visible = x;
            pbxPub3.Visible = x;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string UserN = txtUser.Text;
            string Pwd = txtPwd.Text;
            Boolean validacion = false;
            foreach (String i in Username)
            {
                if (UserN == i)
                {
                    int index = Username.IndexOf(i);
                    string pwdActual = Pasword[index].ToString();

                    if (Pwd == pwdActual)
                    {
                        pnlLogin.Visible = false;
                        pbxPub1.Visible = true;
                        pbxPub2.Visible = true;
                        pbxPub3.Visible = true;
                        validacion = true;
                        MessageBox.Show("SESION INICIADA");
                    }else MessageBox.Show("Contraseña incorrecta");
                }
            }

            if (txtUser.Text == "Cachalote" && txtPwd.Text == "1234")
            {

                pnlLogin.Visible = true;
                Visual(false);
                lblAdmin.Visible = true;
                lblCode.Visible = true;
                txtCode.Visible = true;
                btnCode.Visible = true;
                validacion = true;
  
           }
            if (validacion == false)
           {
                MessageBox.Show("ERROR");
            }

            /*Usuarios logIn = new Usuarios(txtUser.Text, txtPwd.Text);
            AddUser(logIn);

            if (User.Contains(logIn))
            {
                pnlLogin.Visible = false;
                pbxPub1.Visible = true;
                pbxPub2.Visible = true;
                pbxPub3.Visible = true;
                MessageBox.Show("SESION INICIADA");
            }
            
            foreach (Usuarios i in User)
            {
                if (logIn == i)
                {
                    Visual(false);
                }
            }*/

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string UserN = txtUser.Text;
            string Pwd = txtPwd.Text;
            AddUser(UserN, Pwd);
            /*Usuarios LogIn = new Usuarios(txtUser.Text, txtPwd.Text);
            AddUser(LogIn);*/
            Visual(true);
            lblAdmin.Visible = false;
            lblCode.Visible = false;
            txtCode.Visible = false;
            txtUser.Text = "";
            txtPwd.Text = "";

        }

        private void lnkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Visual(true);
            btnCrear.Visible = true;
            lblCrear.Visible = true;
            lblAdmin.Visible = false;
            lblIniciar.Visible = false;
            lblCode.Visible = false;
            txtCode.Visible = false;
            btnIniciar.Visible = false;
            lnkRegistrar.Visible = false;
            boxPermisos.Visible = true;

        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "G54t15")
            {
                pnlLogin.Visible = false;
                pnlAdmin.Visible = true;
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pbxPub1.Image = imlPubLateral.Images[TempPub];
            pbxPub2.Image = imlPubLateral.Images[imlPubInferior.Images.Count - (TempPub + 1)];
            pbxPub3.Image = imlPubInferior.Images[TempPub];
            if (TempPub == imlPubLateral.Images.Count - 1)
            {
                TempPub = 0;
            }
            else
            {
                if (TempPub == imlPubInferior.Images.Count - 1)
                {
                    TempPub = 0;
                }
                else TempPub++;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbxAUser.DataSource = null;
            lbxAUser.DataSource = Lista;
            lbxAUser.Visible = !lbxAUser.Visible;
            btnDUser.Visible =! btnDUser.Visible;
            btnHUser.Visible =! btnHUser.Visible;
            btnDadd.Visible = false;
            trvImage.Visible = false;
        }

        private void btnDUser_Click(object sender, EventArgs e)
        {
            int UserSelected = lbxAUser.SelectedIndex;

            if (UserSelected != -1)
            {
                Username.RemoveAt(UserSelected);
                Pasword.RemoveAt(UserSelected);
                Lista.RemoveAt(UserSelected);
                /*lbxAUser.Items.RemoveAt(UserSelected);*/
                lbxAUser.DataSource = null;
                lbxAUser.DataSource = Lista;
            }
        }

        private void lblABackofice_Click(object sender, EventArgs e)
        {

        }

        private void btnLadd_Click(object sender, EventArgs e)
        {
            btnDadd.Visible =! btnDadd.Visible;
            btnDUser.Visible = false;
            btnHUser.Visible = false;
            lbxAUser.Visible = false;
            trvImage.Visible =! trvImage.Visible;
        }

        private void btnDadd_Click(object sender, EventArgs e)
        {
            int LateralSelected = trvImage.SelectedImageIndex;
            int infSelected = trvImgInf.SelectedImageIndex;
            trvImage.ImageList = null;
            trvImage.ImageList = imlPubLateral;
            trvImgInf.ImageList = null;
            trvImgInf.ImageList = imlPubInferior;
            
            if (LateralSelected != -1)
            {
                imlPubLateral.Images.RemoveAt(infSelected);
                trvImage.ImageList = null;
                trvImage.ImageList = imlPubLateral;
            }
            if (infSelected != -1)
            {
                imlPubLateral.Images.RemoveAt(infSelected);
                trvImgInf.ImageList = null;
                trvImgInf.ImageList = imlPubInferior;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnDadd.Visible = !btnDadd.Visible;
            btnDUser.Visible = false;
            btnHUser.Visible = false;
            lbxAUser.Visible = false;
            trvImgInf.Visible = !trvImgInf.Visible;
        }
    }
}
