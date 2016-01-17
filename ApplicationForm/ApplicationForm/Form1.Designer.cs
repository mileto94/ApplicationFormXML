namespace ApplicationForm
{
    partial class appForm
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
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.facNumber = new System.Windows.Forms.TextBox();
            this.optionalCourses = new System.Windows.Forms.CheckedListBox();
            this.mainCourse = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.course4 = new System.Windows.Forms.RadioButton();
            this.course3 = new System.Windows.Forms.RadioButton();
            this.course2 = new System.Windows.Forms.RadioButton();
            this.course1 = new System.Windows.Forms.RadioButton();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.facNumberLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.mainCourseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.readFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.Color.MintCream;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.firstName.Location = new System.Drawing.Point(143, 42);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 26);
            this.firstName.TabIndex = 0;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.Color.MintCream;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lastName.Location = new System.Drawing.Point(143, 78);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 26);
            this.lastName.TabIndex = 1;
            this.lastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.MintCream;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.ForeColor = System.Drawing.SystemColors.Highlight;
            this.email.Location = new System.Drawing.Point(143, 119);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 26);
            this.email.TabIndex = 2;
            // 
            // city
            // 
            this.city.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.city.BackColor = System.Drawing.Color.MintCream;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city.ForeColor = System.Drawing.SystemColors.Highlight;
            this.city.Location = new System.Drawing.Point(369, 116);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 26);
            this.city.TabIndex = 6;
            // 
            // country
            // 
            this.country.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.country.BackColor = System.Drawing.Color.MintCream;
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.country.ForeColor = System.Drawing.SystemColors.Highlight;
            this.country.Location = new System.Drawing.Point(369, 39);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(100, 26);
            this.country.TabIndex = 4;
            // 
            // state
            // 
            this.state.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.state.BackColor = System.Drawing.Color.MintCream;
            this.state.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.state.ForeColor = System.Drawing.SystemColors.Highlight;
            this.state.Location = new System.Drawing.Point(369, 75);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(100, 26);
            this.state.TabIndex = 5;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumber.BackColor = System.Drawing.Color.MintCream;
            this.phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.phoneNumber.Location = new System.Drawing.Point(625, 36);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(192, 26);
            this.phoneNumber.TabIndex = 8;
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.Color.MintCream;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age.ForeColor = System.Drawing.SystemColors.Highlight;
            this.age.Location = new System.Drawing.Point(143, 162);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 26);
            this.age.TabIndex = 3;
            // 
            // facNumber
            // 
            this.facNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.facNumber.BackColor = System.Drawing.Color.MintCream;
            this.facNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.facNumber.Location = new System.Drawing.Point(369, 164);
            this.facNumber.Name = "facNumber";
            this.facNumber.Size = new System.Drawing.Size(100, 26);
            this.facNumber.TabIndex = 7;
            // 
            // optionalCourses
            // 
            this.optionalCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionalCourses.BackColor = System.Drawing.Color.MintCream;
            this.optionalCourses.CheckOnClick = true;
            this.optionalCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optionalCourses.ForeColor = System.Drawing.SystemColors.Highlight;
            this.optionalCourses.FormattingEnabled = true;
            this.optionalCourses.Items.AddRange(new object[] {
            "Programming Languages & Logics/6/John Grisham",
            "Introduction to Compilers/7/Linda Rhymes",
            "Numerical Analysis and Differential Equations  (must take as CS)/4/Joshua Collins" +
                "",
            "Numerical Analysis: Linear and Nonlinear Problems (must take as CS)/5/Phill Baker" +
                "",
            "Information Retrieval (must take as CS)/2/Ron Moss",
            "Web Information Systems (must take as CS)/3/Ben Stiler",
            "Introduction to Database Systems/3/Glen Moss",
            "Computer Architecture (must take as CS)/4/Richard Castle",
            "Computer Graphics I/4/Jack Richer",
            "Introduction to Computer Vision/3/John Puler",
            "Foundations of Artificial Intelligence/6/Jason Adams",
            "Introduction to Natural Language Processing/7/Kim James",
            "Robot Learning/8/Lola Griffin",
            "Machine Learning/8/Robert Finn",
            "Intro Theory of Computing",
            "Quantum Information Processing (must take as CS)",
            "Introduction to Cryptography",
            "Mathematical Foundations for the Information Age",
            "Applied Logic",
            "Software Engineering",
            "Open-Source Software Engineering",
            "Applications of Parallel Computers",
            "Architecture of Large-Scale Information Systems (must take as CS)",
            "Cloud Computing",
            "Distributed Computing",
            "Parallel Computer Architecture (must take as CS)",
            "System Security",
            "Interactive Computer Graphics",
            "Physically Based Animation for Computer Graphics",
            "Heuristic Methods for Optimization (must take as CS)",
            "Evolutionary Computations",
            "Matrix Computations",
            "Advanced Database Systems",
            "Advanced Systems",
            "Computational Photography",
            "Advanced Language Technologies",
            "Theory of Computing",
            "Analysis of Algorithms"});
            this.optionalCourses.Location = new System.Drawing.Point(40, 207);
            this.optionalCourses.Name = "optionalCourses";
            this.optionalCourses.Size = new System.Drawing.Size(636, 172);
            this.optionalCourses.TabIndex = 14;
            this.optionalCourses.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // mainCourse
            // 
            this.mainCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainCourse.BackColor = System.Drawing.Color.MintCream;
            this.mainCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainCourse.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mainCourse.FormattingEnabled = true;
            this.mainCourse.Items.AddRange(new object[] {
            "Applied Mathematics",
            "Computer Science",
            "Informatics",
            "Information System",
            "Мathematics",
            "Mathematics & Informatics",
            "Software Engineering",
            "Statistics"});
            this.mainCourse.Location = new System.Drawing.Point(625, 81);
            this.mainCourse.Name = "mainCourse";
            this.mainCourse.Size = new System.Drawing.Size(192, 28);
            this.mainCourse.TabIndex = 9;
            this.mainCourse.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // submit
            // 
            this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.submit.Location = new System.Drawing.Point(696, 257);
            this.submit.MaximumSize = new System.Drawing.Size(112, 36);
            this.submit.MinimumSize = new System.Drawing.Size(112, 36);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(112, 36);
            this.submit.TabIndex = 15;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.DarkCyan;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(696, 342);
            this.exit.MaximumSize = new System.Drawing.Size(112, 36);
            this.exit.MinimumSize = new System.Drawing.Size(112, 36);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(112, 36);
            this.exit.TabIndex = 17;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.cancel_Click);
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.BackColor = System.Drawing.Color.OrangeRed;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clear.Location = new System.Drawing.Point(696, 299);
            this.clear.MaximumSize = new System.Drawing.Size(112, 36);
            this.clear.MinimumSize = new System.Drawing.Size(112, 36);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(112, 36);
            this.clear.TabIndex = 16;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // course4
            // 
            this.course4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.course4.AutoSize = true;
            this.course4.BackColor = System.Drawing.Color.MintCream;
            this.course4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.course4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.course4.Location = new System.Drawing.Point(729, 164);
            this.course4.Name = "course4";
            this.course4.Size = new System.Drawing.Size(36, 24);
            this.course4.TabIndex = 13;
            this.course4.TabStop = true;
            this.course4.Text = "4";
            this.course4.UseVisualStyleBackColor = false;
            // 
            // course3
            // 
            this.course3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.course3.AutoSize = true;
            this.course3.BackColor = System.Drawing.Color.MintCream;
            this.course3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.course3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.course3.Location = new System.Drawing.Point(656, 165);
            this.course3.Name = "course3";
            this.course3.Size = new System.Drawing.Size(36, 24);
            this.course3.TabIndex = 12;
            this.course3.TabStop = true;
            this.course3.Text = "3";
            this.course3.UseVisualStyleBackColor = false;
            // 
            // course2
            // 
            this.course2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.course2.AutoSize = true;
            this.course2.BackColor = System.Drawing.Color.MintCream;
            this.course2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.course2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.course2.Location = new System.Drawing.Point(729, 126);
            this.course2.Name = "course2";
            this.course2.Size = new System.Drawing.Size(36, 24);
            this.course2.TabIndex = 11;
            this.course2.TabStop = true;
            this.course2.Text = "2";
            this.course2.UseVisualStyleBackColor = false;
            // 
            // course1
            // 
            this.course1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.course1.AutoSize = true;
            this.course1.BackColor = System.Drawing.Color.MintCream;
            this.course1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.course1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.course1.Location = new System.Drawing.Point(656, 126);
            this.course1.Name = "course1";
            this.course1.Size = new System.Drawing.Size(36, 24);
            this.course1.TabIndex = 10;
            this.course1.TabStop = true;
            this.course1.Text = "1";
            this.course1.UseVisualStyleBackColor = false;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.MintCream;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.firstNameLabel.Location = new System.Drawing.Point(36, 42);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.firstNameLabel.TabIndex = 19;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.MintCream;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lastNameLabel.Location = new System.Drawing.Point(36, 89);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 22;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.MintCream;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.emailLabel.Location = new System.Drawing.Point(36, 133);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(48, 20);
            this.emailLabel.TabIndex = 24;
            this.emailLabel.Text = "Email";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.BackColor = System.Drawing.Color.MintCream;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AgeLabel.Location = new System.Drawing.Point(36, 175);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(38, 20);
            this.AgeLabel.TabIndex = 25;
            this.AgeLabel.Text = "Age";
            // 
            // countryLabel
            // 
            this.countryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countryLabel.AutoSize = true;
            this.countryLabel.BackColor = System.Drawing.Color.MintCream;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.countryLabel.Location = new System.Drawing.Point(290, 41);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(64, 20);
            this.countryLabel.TabIndex = 26;
            this.countryLabel.Text = "Country";
            // 
            // CityLabel
            // 
            this.CityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityLabel.AutoSize = true;
            this.CityLabel.BackColor = System.Drawing.Color.MintCream;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CityLabel.Location = new System.Drawing.Point(290, 127);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(35, 20);
            this.CityLabel.TabIndex = 27;
            this.CityLabel.Text = "City";
            // 
            // stateLabel
            // 
            this.stateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stateLabel.AutoSize = true;
            this.stateLabel.BackColor = System.Drawing.Color.MintCream;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.stateLabel.Location = new System.Drawing.Point(290, 83);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(48, 20);
            this.stateLabel.TabIndex = 28;
            this.stateLabel.Text = "State";
            // 
            // facNumberLabel
            // 
            this.facNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.facNumberLabel.AutoSize = true;
            this.facNumberLabel.BackColor = System.Drawing.Color.MintCream;
            this.facNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facNumberLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.facNumberLabel.Location = new System.Drawing.Point(290, 170);
            this.facNumberLabel.Name = "facNumberLabel";
            this.facNumberLabel.Size = new System.Drawing.Size(75, 20);
            this.facNumberLabel.TabIndex = 29;
            this.facNumberLabel.Text = "Faculty N";
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.MintCream;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.phoneLabel.Location = new System.Drawing.Point(521, 41);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(70, 20);
            this.phoneLabel.TabIndex = 30;
            this.phoneLabel.Text = "Phone N";
            // 
            // mainCourseLabel
            // 
            this.mainCourseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainCourseLabel.AutoSize = true;
            this.mainCourseLabel.BackColor = System.Drawing.Color.MintCream;
            this.mainCourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainCourseLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mainCourseLabel.Location = new System.Drawing.Point(521, 94);
            this.mainCourseLabel.Name = "mainCourseLabel";
            this.mainCourseLabel.Size = new System.Drawing.Size(98, 20);
            this.mainCourseLabel.TabIndex = 31;
            this.mainCourseLabel.Text = "Main Course";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(521, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Course N";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(279, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Choose optional courses in FMI";
            // 
            // readFile
            // 
            this.readFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.readFile.BackColor = System.Drawing.Color.Orange;
            this.readFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readFile.ForeColor = System.Drawing.Color.Ivory;
            this.readFile.Location = new System.Drawing.Point(696, 207);
            this.readFile.MaximumSize = new System.Drawing.Size(112, 36);
            this.readFile.MinimumSize = new System.Drawing.Size(112, 36);
            this.readFile.Name = "readFile";
            this.readFile.Size = new System.Drawing.Size(112, 36);
            this.readFile.TabIndex = 15;
            this.readFile.Text = "Read File";
            this.readFile.UseVisualStyleBackColor = false;
            this.readFile.Click += new System.EventHandler(this.readFile_Click);
            // 
            // appForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(845, 406);
            this.Controls.Add(this.readFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainCourseLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.facNumberLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.course4);
            this.Controls.Add(this.course2);
            this.Controls.Add(this.course3);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.course1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.mainCourse);
            this.Controls.Add(this.optionalCourses);
            this.Controls.Add(this.facNumber);
            this.Controls.Add(this.age);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.state);
            this.Controls.Add(this.country);
            this.Controls.Add(this.city);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.MinimumSize = new System.Drawing.Size(861, 444);
            this.Name = "appForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Form";
            this.Load += new System.EventHandler(this.appForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox facNumber;
        private System.Windows.Forms.CheckedListBox optionalCourses;
        private System.Windows.Forms.ComboBox mainCourse;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.RadioButton course1;
        private System.Windows.Forms.RadioButton course4;
        private System.Windows.Forms.RadioButton course3;
        private System.Windows.Forms.RadioButton course2;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label facNumberLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label mainCourseLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button readFile;
    }
}

