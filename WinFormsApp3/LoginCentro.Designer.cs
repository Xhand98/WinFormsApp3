﻿namespace Windows_Forms_Prueba
{
    partial class LoginCentro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCentro));
            LabelCentro = new Label();
            BoxCentro = new TextBox();
            LabelPassword = new Label();
            BoxPassword = new TextBox();
            CheckRecordar = new CheckBox();
            ButtonInicio = new Button();
            LabelRegister = new Label();
            ButtonRegister = new Button();
            pictureBox1 = new PictureBox();
            BoxUser = new TextBox();
            LabelUser = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LabelCentro
            // 
            resources.ApplyResources(LabelCentro, "LabelCentro");
            LabelCentro.BackColor = Color.Transparent;
            LabelCentro.ForeColor = Color.White;
            LabelCentro.Name = "LabelCentro";
            // 
            // BoxCentro
            // 
            resources.ApplyResources(BoxCentro, "BoxCentro");
            BoxCentro.Name = "BoxCentro";
            BoxCentro.Enter += EntrarACaja_Enter;
            BoxCentro.Leave += SalirDeCaja_Leave;
            // 
            // LabelPassword
            // 
            resources.ApplyResources(LabelPassword, "LabelPassword");
            LabelPassword.BackColor = Color.Transparent;
            LabelPassword.ForeColor = Color.White;
            LabelPassword.Name = "LabelPassword";
            // 
            // BoxPassword
            // 
            resources.ApplyResources(BoxPassword, "BoxPassword");
            BoxPassword.Name = "BoxPassword";
            BoxPassword.Enter += EntrarAPass_Enter;
            BoxPassword.Leave += SalirDePass_Leave;
            // 
            // CheckRecordar
            // 
            resources.ApplyResources(CheckRecordar, "CheckRecordar");
            CheckRecordar.Cursor = Cursors.Hand;
            CheckRecordar.ForeColor = Color.White;
            CheckRecordar.Name = "CheckRecordar";
            CheckRecordar.UseVisualStyleBackColor = true;
            // 
            // ButtonInicio
            // 
            resources.ApplyResources(ButtonInicio, "ButtonInicio");
            ButtonInicio.Name = "ButtonInicio";
            ButtonInicio.UseVisualStyleBackColor = true;
            ButtonInicio.Click += IniciandoSesion_Click;
            // 
            // LabelRegister
            // 
            resources.ApplyResources(LabelRegister, "LabelRegister");
            LabelRegister.ForeColor = Color.White;
            LabelRegister.Name = "LabelRegister";
            // 
            // ButtonRegister
            // 
            resources.ApplyResources(ButtonRegister, "ButtonRegister");
            ButtonRegister.Name = "ButtonRegister";
            ButtonRegister.UseVisualStyleBackColor = true;
            ButtonRegister.Click += CambiarARegistro_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // BoxUser
            // 
            resources.ApplyResources(BoxUser, "BoxUser");
            BoxUser.Name = "BoxUser";
            BoxUser.Enter += EntrarAUser_Enter;
            BoxUser.Leave += SalirDeUser_Leave;
            // 
            // LabelUser
            // 
            resources.ApplyResources(LabelUser, "LabelUser");
            LabelUser.BackColor = Color.Transparent;
            LabelUser.ForeColor = Color.White;
            LabelUser.Name = "LabelUser";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Name = "label3";
            // 
            // LoginCentro
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 31, 48);
            Controls.Add(LabelUser);
            Controls.Add(BoxUser);
            Controls.Add(ButtonRegister);
            Controls.Add(LabelRegister);
            Controls.Add(LabelPassword);
            Controls.Add(LabelCentro);
            Controls.Add(ButtonInicio);
            Controls.Add(CheckRecordar);
            Controls.Add(BoxPassword);
            Controls.Add(BoxCentro);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "LoginCentro";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelCentro;
        private TextBox BoxCentro;
        private Label LabelPassword;
        private TextBox BoxPassword;
        private CheckBox CheckRecordar;
        private Button ButtonInicio;
        private Label LabelRegister;
        private Button ButtonRegister;
        private PictureBox pictureBox1;
        private TextBox BoxUser;
        private Label LabelUser;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}