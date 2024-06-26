using Windows_Forms_Prueba;

namespace WinFormsApp3
{
    public partial class GradeMaster : Form
    {
        private bool isLogged = false;
        public GradeMaster()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!isLogged)
            {
                regBtn.Hide();
                logBtn.Hide();
                notLogged.Hide();
                Application.Exit();
                RegisterLogin registerLogin = new RegisterLogin();
                registerLogin.Show();
            }
        }

        public bool IsUserLogged()
        {
            return isLogged;
        }


        private void mainCont_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            subMenuPro.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            subMenuPro.Visible = false;
        }

        private void mainCont_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Form5());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subMenuPro.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            subMenuPro.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Form2());
        }

        private void appTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private Form formActual = null;
        public void AbrirFormHijo(object formHijo)
        {
            if (formActual != null)
            {
                this.mainCont.Controls.Remove(formActual);
            }

            Form? fH = formHijo as Form;
            fH.TopLevel = false;
            fH.Dock = DockStyle.Fill;
            this.mainCont.Controls.Add(fH);
            this.mainCont.Tag = fH;
            fH.Show();
            formActual = fH as Form;
            appTitle.Hide();
            fastAcc.Hide();
            presentTxt.Hide();
            subMenuPro.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homePage_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Form3());
            appTitle.Hide();
            presentTxt.Hide();
            fastAcc.Hide();
        }

        private void logOut_Click(object sender, EventArgs e)
        {

        }

        private void btnEst_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Form6());
        }
    }
}