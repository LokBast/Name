namespace Halyava
{
    partial class Window4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TextBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TextBoxFoto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ButtonCheck = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.ComboBoxCountry = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza = new Halyava.Baza();
            this.label19 = new System.Windows.Forms.Label();
            this.PictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxGender = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonRegistration = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.bazaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet1 = new Halyava.BazaDataSet1();
            this.genderTableAdapter = new Halyava.BazaTableAdapters.GenderTableAdapter();
            this.countryTableAdapter = new Halyava.BazaTableAdapters.CountryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(145, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(546, 54);
            this.label2.TabIndex = 52;
            this.label2.Text = "Пожалуйста заполните всю информацию,чтобы\r\n        зарегистрироваться в качестве " +
    "бегуна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Font = new System.Drawing.Font("Arial", 20.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(112, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 33);
            this.label1.TabIndex = 51;
            this.label1.Text = "MARATHON SKILLS 2016";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(15, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 33);
            this.button4.TabIndex = 50;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(334, 586);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(24, 26);
            this.label9.TabIndex = 47;
            this.label9.Text = "и";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(389, 586);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 26);
            this.label8.TabIndex = 46;
            this.label8.Text = "минуты";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(264, 586);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(71, 26);
            this.label7.TabIndex = 45;
            this.label7.Text = "часов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(133, 586);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(48, 26);
            this.label3.TabIndex = 41;
            this.label3.Text = "000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(233, 586);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(36, 26);
            this.label4.TabIndex = 42;
            this.label4.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(473, 586);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(229, 26);
            this.label10.TabIndex = 48;
            this.label10.Text = "до старта марафона!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(176, 586);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(61, 26);
            this.label6.TabIndex = 44;
            this.label6.Text = "дней";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(357, 586);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(36, 26);
            this.label5.TabIndex = 43;
            this.label5.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBoxPassword.Location = new System.Drawing.Point(235, 236);
            this.TextBoxPassword.MaxLength = 100;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(201, 30);
            this.TextBoxPassword.TabIndex = 57;
            this.TextBoxPassword.Text = "Пароль";
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            this.TextBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.TextBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBoxLogin.Location = new System.Drawing.Point(235, 188);
            this.TextBoxLogin.MaxLength = 100;
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(248, 30);
            this.TextBoxLogin.TabIndex = 56;
            this.TextBoxLogin.Text = "Email";
            this.TextBoxLogin.Click += new System.EventHandler(this.TextBoxLogin_Click);
            this.TextBoxLogin.TextChanged += new System.EventHandler(this.TextBoxLogin_TextChanged);
            this.TextBoxLogin.Enter += new System.EventHandler(this.TextBoxLogin_Enter);
            this.TextBoxLogin.Leave += new System.EventHandler(this.TextBoxLogin_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label13.Location = new System.Drawing.Point(123, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 27);
            this.label13.TabIndex = 55;
            this.label13.Text = "Пароль:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label12.Location = new System.Drawing.Point(146, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 27);
            this.label12.TabIndex = 54;
            this.label12.Text = "Email:";
            // 
            // TextBoxRepeatPassword
            // 
            this.TextBoxRepeatPassword.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxRepeatPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBoxRepeatPassword.Location = new System.Drawing.Point(235, 285);
            this.TextBoxRepeatPassword.MaxLength = 100;
            this.TextBoxRepeatPassword.Name = "TextBoxRepeatPassword";
            this.TextBoxRepeatPassword.Size = new System.Drawing.Size(201, 30);
            this.TextBoxRepeatPassword.TabIndex = 61;
            this.TextBoxRepeatPassword.Text = "Повторите пароль";
            this.TextBoxRepeatPassword.TextChanged += new System.EventHandler(this.TextBoxRepeatPassword_TextChanged);
            this.TextBoxRepeatPassword.Enter += new System.EventHandler(this.TextBoxRepeatPassword_Enter);
            this.TextBoxRepeatPassword.Leave += new System.EventHandler(this.TextBoxRepeatPassword_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label14.Location = new System.Drawing.Point(3, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(222, 27);
            this.label14.TabIndex = 60;
            this.label14.Text = "Повторите пароль:";
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBoxFirstName.Location = new System.Drawing.Point(235, 333);
            this.TextBoxFirstName.MaxLength = 100;
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(201, 30);
            this.TextBoxFirstName.TabIndex = 63;
            this.TextBoxFirstName.Text = "Имя";
            this.TextBoxFirstName.TextChanged += new System.EventHandler(this.TextBoxFirstName_TextChanged);
            this.TextBoxFirstName.Enter += new System.EventHandler(this.TextBoxFirstName_Enter);
            this.TextBoxFirstName.Leave += new System.EventHandler(this.TextBoxFirstName_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label15.Location = new System.Drawing.Point(159, 335);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 27);
            this.label15.TabIndex = 62;
            this.label15.Text = "Имя:";
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBoxLastName.Location = new System.Drawing.Point(235, 379);
            this.TextBoxLastName.MaxLength = 100;
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(201, 30);
            this.TextBoxLastName.TabIndex = 65;
            this.TextBoxLastName.Text = "Фамилия";
            this.TextBoxLastName.TextChanged += new System.EventHandler(this.TextBoxLastName_TextChanged);
            this.TextBoxLastName.Enter += new System.EventHandler(this.TextBoxLastName_Enter);
            this.TextBoxLastName.Leave += new System.EventHandler(this.TextBoxLastName_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label16.Location = new System.Drawing.Point(105, 380);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 27);
            this.label16.TabIndex = 64;
            this.label16.Text = "Фамилия:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label17.Location = new System.Drawing.Point(159, 427);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 27);
            this.label17.TabIndex = 66;
            this.label17.Text = "Пол:";
            // 
            // TextBoxFoto
            // 
            this.TextBoxFoto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBoxFoto.Location = new System.Drawing.Point(490, 332);
            this.TextBoxFoto.MaxLength = 100;
            this.TextBoxFoto.Name = "TextBoxFoto";
            this.TextBoxFoto.Size = new System.Drawing.Size(197, 30);
            this.TextBoxFoto.TabIndex = 69;
            this.TextBoxFoto.Text = "Photo_logo.jpg";
            this.TextBoxFoto.TextChanged += new System.EventHandler(this.TextBoxFoto_TextChanged);
            this.TextBoxFoto.Enter += new System.EventHandler(this.TextBoxFoto_Enter);
            this.TextBoxFoto.Leave += new System.EventHandler(this.TextBoxFoto_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(507, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 27);
            this.label11.TabIndex = 68;
            this.label11.Text = "Фото файл:";
            // 
            // ButtonCheck
            // 
            this.ButtonCheck.Location = new System.Drawing.Point(693, 330);
            this.ButtonCheck.Name = "ButtonCheck";
            this.ButtonCheck.Size = new System.Drawing.Size(120, 33);
            this.ButtonCheck.TabIndex = 70;
            this.ButtonCheck.Text = "Посмотреть";
            this.ButtonCheck.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label18.Location = new System.Drawing.Point(485, 378);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(187, 27);
            this.label18.TabIndex = 72;
            this.label18.Text = "Дата рождения:";
            // 
            // ComboBoxCountry
            // 
            this.ComboBoxCountry.DataSource = this.countryBindingSource;
            this.ComboBoxCountry.DisplayMember = "CountryName";
            this.ComboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ComboBoxCountry.FormattingEnabled = true;
            this.ComboBoxCountry.Location = new System.Drawing.Point(675, 425);
            this.ComboBoxCountry.Name = "ComboBoxCountry";
            this.ComboBoxCountry.Size = new System.Drawing.Size(137, 25);
            this.ComboBoxCountry.TabIndex = 75;
            this.ComboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCountry_SelectedIndexChanged);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.baza;
            // 
            // baza
            // 
            this.baza.DataSetName = "Baza";
            this.baza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label19.Location = new System.Drawing.Point(572, 424);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 27);
            this.label19.TabIndex = 76;
            this.label19.Text = "Страна:";
            // 
            // PictureBoxFoto
            // 
            this.PictureBoxFoto.Image = global::Halyava.Properties.Resources.noimg;
            this.PictureBoxFoto.Location = new System.Drawing.Point(693, 158);
            this.PictureBoxFoto.Name = "PictureBoxFoto";
            this.PictureBoxFoto.Size = new System.Drawing.Size(120, 140);
            this.PictureBoxFoto.TabIndex = 71;
            this.PictureBoxFoto.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(840, 79);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 572);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(850, 54);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // DateTimePickerDateOfBirth
            // 
            this.DateTimePickerDateOfBirth.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.DateTimePickerDateOfBirth.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.DateTimePickerDateOfBirth.Cursor = System.Windows.Forms.Cursors.Default;
            this.DateTimePickerDateOfBirth.CustomFormat = "yyyy-MM-dd";
            this.DateTimePickerDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerDateOfBirth.Location = new System.Drawing.Point(675, 379);
            this.DateTimePickerDateOfBirth.Name = "DateTimePickerDateOfBirth";
            this.DateTimePickerDateOfBirth.Size = new System.Drawing.Size(137, 29);
            this.DateTimePickerDateOfBirth.TabIndex = 77;
            // 
            // ComboBoxGender
            // 
            this.ComboBoxGender.DataSource = this.genderBindingSource;
            this.ComboBoxGender.DisplayMember = "Gender";
            this.ComboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ComboBoxGender.FormattingEnabled = true;
            this.ComboBoxGender.Location = new System.Drawing.Point(235, 428);
            this.ComboBoxGender.Name = "ComboBoxGender";
            this.ComboBoxGender.Size = new System.Drawing.Size(100, 24);
            this.ComboBoxGender.TabIndex = 78;
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.baza;
            // 
            // ButtonRegistration
            // 
            this.ButtonRegistration.Location = new System.Drawing.Point(309, 514);
            this.ButtonRegistration.Name = "ButtonRegistration";
            this.ButtonRegistration.Size = new System.Drawing.Size(121, 33);
            this.ButtonRegistration.TabIndex = 79;
            this.ButtonRegistration.Text = "Регистрация";
            this.ButtonRegistration.UseVisualStyleBackColor = true;
            this.ButtonRegistration.Click += new System.EventHandler(this.ButtonRegistration_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(445, 514);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(80, 33);
            this.ButtonCancel.TabIndex = 80;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(238, 221);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 81;
            this.label20.Text = "label20";
            this.label20.Visible = false;
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(238, 317);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 82;
            this.label21.Text = "label21";
            this.label21.Visible = false;
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // bazaDataSet1BindingSource
            // 
            this.bazaDataSet1BindingSource.DataSource = this.bazaDataSet1;
            this.bazaDataSet1BindingSource.Position = 0;
            // 
            // bazaDataSet1
            // 
            this.bazaDataSet1.DataSetName = "BazaDataSet1";
            this.bazaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // Window4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(836, 625);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonRegistration);
            this.Controls.Add(this.ComboBoxGender);
            this.Controls.Add(this.DateTimePickerDateOfBirth);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.ComboBoxCountry);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.PictureBoxFoto);
            this.Controls.Add(this.ButtonCheck);
            this.Controls.Add(this.TextBoxFoto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TextBoxLastName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TextBoxFirstName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TextBoxRepeatPassword);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.Name = "Window4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2016 - Register as a  runner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window4_FormClosing);
            this.Load += new System.EventHandler(this.Window4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TextBoxRepeatPassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TextBoxFoto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ButtonCheck;
        private System.Windows.Forms.PictureBox PictureBoxFoto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox ComboBoxCountry;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker DateTimePickerDateOfBirth;
        private System.Windows.Forms.ComboBox ComboBoxGender;
        private System.Windows.Forms.BindingSource bazaDataSet1BindingSource;
        private BazaDataSet1 bazaDataSet1;
        private System.Windows.Forms.Button ButtonRegistration;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private Baza baza;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private BazaTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private BazaTableAdapters.CountryTableAdapter countryTableAdapter;
    }
}