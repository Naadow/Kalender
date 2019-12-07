namespace Kalender
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnl_Register = new System.Windows.Forms.Panel();
            this.btn_AlreadySignUp_Register = new System.Windows.Forms.Button();
            this.bMT_Password_Register = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Register_Register = new System.Windows.Forms.Button();
            this.bMT_Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_Email_PNL_Register = new System.Windows.Forms.Label();
            this.bMT_RePassword_Register = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_ReenterPassword = new System.Windows.Forms.Label();
            this.lbl_Password_Register = new System.Windows.Forms.Label();
            this.bMT_userName_Register = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_UserName_Register = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_SignUp = new System.Windows.Forms.Panel();
            this.btn_BackToRegister_Register = new System.Windows.Forms.Button();
            this.bMT_Password_SignUp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_SignUp_SignUp = new System.Windows.Forms.Button();
            this.lbl_Password_SignUp = new System.Windows.Forms.Label();
            this.bMT_userName_SignUp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_UserName_SignUp = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lbl_Status = new System.Windows.Forms.Label();
            this.pb_error = new System.Windows.Forms.PictureBox();
            this.pnl_Register.SuspendLayout();
            this.pnl_SignUp.SuspendLayout();
            this.pnl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_error)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnl_Register;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnl_Register
            // 
            this.pnl_Register.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnl_Register.Controls.Add(this.btn_AlreadySignUp_Register);
            this.pnl_Register.Controls.Add(this.bMT_Password_Register);
            this.pnl_Register.Controls.Add(this.label7);
            this.pnl_Register.Controls.Add(this.btn_Register_Register);
            this.pnl_Register.Controls.Add(this.bMT_Email);
            this.pnl_Register.Controls.Add(this.lbl_Email_PNL_Register);
            this.pnl_Register.Controls.Add(this.bMT_RePassword_Register);
            this.pnl_Register.Controls.Add(this.lbl_ReenterPassword);
            this.pnl_Register.Controls.Add(this.lbl_Password_Register);
            this.pnl_Register.Controls.Add(this.bMT_userName_Register);
            this.pnl_Register.Controls.Add(this.lbl_UserName_Register);
            this.pnl_Register.Controls.Add(this.label2);
            this.pnl_Register.Controls.Add(this.pnl_SignUp);
            this.pnl_Register.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Register.Location = new System.Drawing.Point(272, 0);
            this.pnl_Register.Name = "pnl_Register";
            this.pnl_Register.Size = new System.Drawing.Size(528, 450);
            this.pnl_Register.TabIndex = 1;
            // 
            // btn_AlreadySignUp_Register
            // 
            this.btn_AlreadySignUp_Register.BackColor = System.Drawing.Color.Crimson;
            this.btn_AlreadySignUp_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AlreadySignUp_Register.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlreadySignUp_Register.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_AlreadySignUp_Register.Location = new System.Drawing.Point(269, 393);
            this.btn_AlreadySignUp_Register.Name = "btn_AlreadySignUp_Register";
            this.btn_AlreadySignUp_Register.Size = new System.Drawing.Size(245, 32);
            this.btn_AlreadySignUp_Register.TabIndex = 14;
            this.btn_AlreadySignUp_Register.Text = "Already Sign Up";
            this.btn_AlreadySignUp_Register.UseVisualStyleBackColor = false;
            this.btn_AlreadySignUp_Register.Click += new System.EventHandler(this.Button2_Click);
            // 
            // bMT_Password_Register
            // 
            this.bMT_Password_Register.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bMT_Password_Register.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bMT_Password_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bMT_Password_Register.HintForeColor = System.Drawing.Color.Empty;
            this.bMT_Password_Register.HintText = "Password";
            this.bMT_Password_Register.isPassword = true;
            this.bMT_Password_Register.LineFocusedColor = System.Drawing.Color.Crimson;
            this.bMT_Password_Register.LineIdleColor = System.Drawing.Color.Crimson;
            this.bMT_Password_Register.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.bMT_Password_Register.LineThickness = 3;
            this.bMT_Password_Register.Location = new System.Drawing.Point(19, 170);
            this.bMT_Password_Register.Margin = new System.Windows.Forms.Padding(4);
            this.bMT_Password_Register.Name = "bMT_Password_Register";
            this.bMT_Password_Register.Size = new System.Drawing.Size(301, 38);
            this.bMT_Password_Register.TabIndex = 13;
            this.bMT_Password_Register.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(497, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // btn_Register_Register
            // 
            this.btn_Register_Register.BackColor = System.Drawing.Color.Crimson;
            this.btn_Register_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register_Register.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register_Register.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Register_Register.Location = new System.Drawing.Point(18, 393);
            this.btn_Register_Register.Name = "btn_Register_Register";
            this.btn_Register_Register.Size = new System.Drawing.Size(245, 32);
            this.btn_Register_Register.TabIndex = 11;
            this.btn_Register_Register.Text = "Register";
            this.btn_Register_Register.UseVisualStyleBackColor = false;
            this.btn_Register_Register.Click += new System.EventHandler(this.Btn_Register_Register_Click);
            // 
            // bMT_Email
            // 
            this.bMT_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bMT_Email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bMT_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bMT_Email.HintForeColor = System.Drawing.Color.Empty;
            this.bMT_Email.HintText = "someone@example.com";
            this.bMT_Email.isPassword = false;
            this.bMT_Email.LineFocusedColor = System.Drawing.Color.Crimson;
            this.bMT_Email.LineIdleColor = System.Drawing.Color.Crimson;
            this.bMT_Email.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.bMT_Email.LineThickness = 3;
            this.bMT_Email.Location = new System.Drawing.Point(19, 335);
            this.bMT_Email.Margin = new System.Windows.Forms.Padding(4);
            this.bMT_Email.Name = "bMT_Email";
            this.bMT_Email.Size = new System.Drawing.Size(301, 38);
            this.bMT_Email.TabIndex = 10;
            this.bMT_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_Email_PNL_Register
            // 
            this.lbl_Email_PNL_Register.AutoSize = true;
            this.lbl_Email_PNL_Register.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email_PNL_Register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_PNL_Register.ForeColor = System.Drawing.Color.Red;
            this.lbl_Email_PNL_Register.Location = new System.Drawing.Point(15, 310);
            this.lbl_Email_PNL_Register.Name = "lbl_Email_PNL_Register";
            this.lbl_Email_PNL_Register.Size = new System.Drawing.Size(59, 21);
            this.lbl_Email_PNL_Register.TabIndex = 9;
            this.lbl_Email_PNL_Register.Text = "Email :";
            // 
            // bMT_RePassword_Register
            // 
            this.bMT_RePassword_Register.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bMT_RePassword_Register.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bMT_RePassword_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bMT_RePassword_Register.HintForeColor = System.Drawing.Color.Empty;
            this.bMT_RePassword_Register.HintText = "Password";
            this.bMT_RePassword_Register.isPassword = true;
            this.bMT_RePassword_Register.LineFocusedColor = System.Drawing.Color.Crimson;
            this.bMT_RePassword_Register.LineIdleColor = System.Drawing.Color.Crimson;
            this.bMT_RePassword_Register.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.bMT_RePassword_Register.LineThickness = 3;
            this.bMT_RePassword_Register.Location = new System.Drawing.Point(19, 255);
            this.bMT_RePassword_Register.Margin = new System.Windows.Forms.Padding(4);
            this.bMT_RePassword_Register.Name = "bMT_RePassword_Register";
            this.bMT_RePassword_Register.Size = new System.Drawing.Size(301, 38);
            this.bMT_RePassword_Register.TabIndex = 8;
            this.bMT_RePassword_Register.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_ReenterPassword
            // 
            this.lbl_ReenterPassword.AutoSize = true;
            this.lbl_ReenterPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ReenterPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReenterPassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_ReenterPassword.Location = new System.Drawing.Point(15, 230);
            this.lbl_ReenterPassword.Name = "lbl_ReenterPassword";
            this.lbl_ReenterPassword.Size = new System.Drawing.Size(161, 21);
            this.lbl_ReenterPassword.TabIndex = 7;
            this.lbl_ReenterPassword.Text = "Re-enter Password :";
            // 
            // lbl_Password_Register
            // 
            this.lbl_Password_Register.AutoSize = true;
            this.lbl_Password_Register.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password_Register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password_Register.ForeColor = System.Drawing.Color.Red;
            this.lbl_Password_Register.Location = new System.Drawing.Point(15, 145);
            this.lbl_Password_Register.Name = "lbl_Password_Register";
            this.lbl_Password_Register.Size = new System.Drawing.Size(90, 21);
            this.lbl_Password_Register.TabIndex = 5;
            this.lbl_Password_Register.Text = "Password :";
            // 
            // bMT_userName_Register
            // 
            this.bMT_userName_Register.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bMT_userName_Register.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bMT_userName_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bMT_userName_Register.HintForeColor = System.Drawing.Color.Empty;
            this.bMT_userName_Register.HintText = "User Name";
            this.bMT_userName_Register.isPassword = false;
            this.bMT_userName_Register.LineFocusedColor = System.Drawing.Color.Crimson;
            this.bMT_userName_Register.LineIdleColor = System.Drawing.Color.Crimson;
            this.bMT_userName_Register.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.bMT_userName_Register.LineThickness = 3;
            this.bMT_userName_Register.Location = new System.Drawing.Point(18, 92);
            this.bMT_userName_Register.Margin = new System.Windows.Forms.Padding(4);
            this.bMT_userName_Register.Name = "bMT_userName_Register";
            this.bMT_userName_Register.Size = new System.Drawing.Size(301, 38);
            this.bMT_userName_Register.TabIndex = 4;
            this.bMT_userName_Register.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_UserName_Register
            // 
            this.lbl_UserName_Register.AutoSize = true;
            this.lbl_UserName_Register.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UserName_Register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName_Register.ForeColor = System.Drawing.Color.Red;
            this.lbl_UserName_Register.Location = new System.Drawing.Point(14, 67);
            this.lbl_UserName_Register.Name = "lbl_UserName_Register";
            this.lbl_UserName_Register.Size = new System.Drawing.Size(102, 21);
            this.lbl_UserName_Register.TabIndex = 3;
            this.lbl_UserName_Register.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Register";
            // 
            // pnl_SignUp
            // 
            this.pnl_SignUp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnl_SignUp.Controls.Add(this.pb_error);
            this.pnl_SignUp.Controls.Add(this.lbl_Status);
            this.pnl_SignUp.Controls.Add(this.btn_BackToRegister_Register);
            this.pnl_SignUp.Controls.Add(this.bMT_Password_SignUp);
            this.pnl_SignUp.Controls.Add(this.label8);
            this.pnl_SignUp.Controls.Add(this.btn_SignUp_SignUp);
            this.pnl_SignUp.Controls.Add(this.lbl_Password_SignUp);
            this.pnl_SignUp.Controls.Add(this.bMT_userName_SignUp);
            this.pnl_SignUp.Controls.Add(this.lbl_UserName_SignUp);
            this.pnl_SignUp.Controls.Add(this.label13);
            this.pnl_SignUp.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_SignUp.Location = new System.Drawing.Point(0, 0);
            this.pnl_SignUp.Name = "pnl_SignUp";
            this.pnl_SignUp.Size = new System.Drawing.Size(528, 450);
            this.pnl_SignUp.TabIndex = 15;
            // 
            // btn_BackToRegister_Register
            // 
            this.btn_BackToRegister_Register.BackColor = System.Drawing.Color.Crimson;
            this.btn_BackToRegister_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackToRegister_Register.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackToRegister_Register.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_BackToRegister_Register.Location = new System.Drawing.Point(269, 393);
            this.btn_BackToRegister_Register.Name = "btn_BackToRegister_Register";
            this.btn_BackToRegister_Register.Size = new System.Drawing.Size(245, 32);
            this.btn_BackToRegister_Register.TabIndex = 14;
            this.btn_BackToRegister_Register.Text = "Back to Register";
            this.btn_BackToRegister_Register.UseVisualStyleBackColor = false;
            this.btn_BackToRegister_Register.Click += new System.EventHandler(this.Button3_Click);
            // 
            // bMT_Password_SignUp
            // 
            this.bMT_Password_SignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bMT_Password_SignUp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bMT_Password_SignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bMT_Password_SignUp.HintForeColor = System.Drawing.Color.Empty;
            this.bMT_Password_SignUp.HintText = "Password";
            this.bMT_Password_SignUp.isPassword = true;
            this.bMT_Password_SignUp.LineFocusedColor = System.Drawing.Color.Crimson;
            this.bMT_Password_SignUp.LineIdleColor = System.Drawing.Color.Crimson;
            this.bMT_Password_SignUp.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.bMT_Password_SignUp.LineThickness = 3;
            this.bMT_Password_SignUp.Location = new System.Drawing.Point(19, 170);
            this.bMT_Password_SignUp.Margin = new System.Windows.Forms.Padding(4);
            this.bMT_Password_SignUp.Name = "bMT_Password_SignUp";
            this.bMT_Password_SignUp.Size = new System.Drawing.Size(301, 38);
            this.bMT_Password_SignUp.TabIndex = 13;
            this.bMT_Password_SignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(497, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // btn_SignUp_SignUp
            // 
            this.btn_SignUp_SignUp.BackColor = System.Drawing.Color.Crimson;
            this.btn_SignUp_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp_SignUp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp_SignUp.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_SignUp_SignUp.Location = new System.Drawing.Point(18, 393);
            this.btn_SignUp_SignUp.Name = "btn_SignUp_SignUp";
            this.btn_SignUp_SignUp.Size = new System.Drawing.Size(245, 32);
            this.btn_SignUp_SignUp.TabIndex = 11;
            this.btn_SignUp_SignUp.Text = "Sign Up";
            this.btn_SignUp_SignUp.UseVisualStyleBackColor = false;
            // 
            // lbl_Password_SignUp
            // 
            this.lbl_Password_SignUp.AutoSize = true;
            this.lbl_Password_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password_SignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password_SignUp.ForeColor = System.Drawing.Color.Red;
            this.lbl_Password_SignUp.Location = new System.Drawing.Point(15, 145);
            this.lbl_Password_SignUp.Name = "lbl_Password_SignUp";
            this.lbl_Password_SignUp.Size = new System.Drawing.Size(90, 21);
            this.lbl_Password_SignUp.TabIndex = 5;
            this.lbl_Password_SignUp.Text = "Password :";
            // 
            // bMT_userName_SignUp
            // 
            this.bMT_userName_SignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bMT_userName_SignUp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bMT_userName_SignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bMT_userName_SignUp.HintForeColor = System.Drawing.Color.Empty;
            this.bMT_userName_SignUp.HintText = "User Name";
            this.bMT_userName_SignUp.isPassword = false;
            this.bMT_userName_SignUp.LineFocusedColor = System.Drawing.Color.Crimson;
            this.bMT_userName_SignUp.LineIdleColor = System.Drawing.Color.Crimson;
            this.bMT_userName_SignUp.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.bMT_userName_SignUp.LineThickness = 3;
            this.bMT_userName_SignUp.Location = new System.Drawing.Point(18, 92);
            this.bMT_userName_SignUp.Margin = new System.Windows.Forms.Padding(4);
            this.bMT_userName_SignUp.Name = "bMT_userName_SignUp";
            this.bMT_userName_SignUp.Size = new System.Drawing.Size(301, 38);
            this.bMT_userName_SignUp.TabIndex = 4;
            this.bMT_userName_SignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_UserName_SignUp
            // 
            this.lbl_UserName_SignUp.AutoSize = true;
            this.lbl_UserName_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UserName_SignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName_SignUp.ForeColor = System.Drawing.Color.Red;
            this.lbl_UserName_SignUp.Location = new System.Drawing.Point(14, 67);
            this.lbl_UserName_SignUp.Name = "lbl_UserName_SignUp";
            this.lbl_UserName_SignUp.Size = new System.Drawing.Size(102, 21);
            this.lbl_UserName_SignUp.TabIndex = 3;
            this.lbl_UserName_SignUp.Text = "User Name :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(15, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "Sign Up";
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.Crimson;
            this.pnl_left.Controls.Add(this.label1);
            this.pnl_left.Controls.Add(this.pictureBox1);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(271, 450);
            this.pnl_left.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calender";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pnl_left;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.pnl_SignUp;
            this.bunifuDragControl3.Vertical = true;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Status.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.Black;
            this.lbl_Status.Location = new System.Drawing.Point(337, 64);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 22);
            this.lbl_Status.TabIndex = 16;
            // 
            // pb_error
            // 
            this.pb_error.Image = ((System.Drawing.Image)(resources.GetObject("pb_error.Image")));
            this.pb_error.Location = new System.Drawing.Point(341, 128);
            this.pb_error.Name = "pb_error";
            this.pb_error.Size = new System.Drawing.Size(148, 123);
            this.pb_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_error.TabIndex = 17;
            this.pb_error.TabStop = false;
            this.pb_error.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Register);
            this.Controls.Add(this.pnl_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_Register.ResumeLayout(false);
            this.pnl_Register.PerformLayout();
            this.pnl_SignUp.ResumeLayout(false);
            this.pnl_SignUp.PerformLayout();
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel pnl_Register;
        private System.Windows.Forms.Panel pnl_left;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bMT_userName_Register;
        private System.Windows.Forms.Label lbl_UserName_Register;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bMT_Email;
        private System.Windows.Forms.Label lbl_Email_PNL_Register;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bMT_RePassword_Register;
        private System.Windows.Forms.Label lbl_ReenterPassword;
        private System.Windows.Forms.Label lbl_Password_Register;
        private System.Windows.Forms.Button btn_Register_Register;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bMT_Password_Register;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnl_SignUp;
        private System.Windows.Forms.Button btn_BackToRegister_Register;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bMT_Password_SignUp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_SignUp_SignUp;
        private System.Windows.Forms.Label lbl_Password_SignUp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bMT_userName_SignUp;
        private System.Windows.Forms.Label lbl_UserName_SignUp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_AlreadySignUp_Register;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.PictureBox pb_error;
    }
}

