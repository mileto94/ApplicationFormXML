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
            this.password = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
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
            this.container = new System.Windows.Forms.RichTextBox();
            this.errorsContainer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstName.Location = new System.Drawing.Point(37, 39);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 29);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "First Name";
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastName.Location = new System.Drawing.Point(185, 39);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 29);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "Last Name";
            this.lastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.Location = new System.Drawing.Point(345, 39);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 29);
            this.email.TabIndex = 2;
            this.email.Text = "Email";
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city.Location = new System.Drawing.Point(345, 122);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 29);
            this.city.TabIndex = 3;
            this.city.Text = "City";
            // 
            // country
            // 
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.country.Location = new System.Drawing.Point(37, 122);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(100, 29);
            this.country.TabIndex = 4;
            this.country.Text = "Country";
            // 
            // state
            // 
            this.state.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.state.Location = new System.Drawing.Point(185, 122);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(100, 29);
            this.state.TabIndex = 5;
            this.state.Text = "State";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumber.Location = new System.Drawing.Point(25, 177);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(165, 29);
            this.phoneNumber.TabIndex = 6;
            this.phoneNumber.Text = "Phone Number";
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age.Location = new System.Drawing.Point(220, 177);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 29);
            this.age.TabIndex = 7;
            this.age.Text = "Age";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(468, 177);
            this.password.Name = "password";
            this.password.ShortcutsEnabled = false;
            this.password.Size = new System.Drawing.Size(100, 29);
            this.password.TabIndex = 8;
            this.password.Text = "Password";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // confirmPassword
            // 
            this.confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPassword.Location = new System.Drawing.Point(591, 177);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(213, 29);
            this.confirmPassword.TabIndex = 9;
            this.confirmPassword.Text = "Confirm Password";
            // 
            // facNumber
            // 
            this.facNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facNumber.Location = new System.Drawing.Point(345, 177);
            this.facNumber.Name = "facNumber";
            this.facNumber.Size = new System.Drawing.Size(100, 29);
            this.facNumber.TabIndex = 10;
            this.facNumber.Text = "FacNumber";
            // 
            // optionalCourses
            // 
            this.optionalCourses.CheckOnClick = true;
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
            this.optionalCourses.Location = new System.Drawing.Point(428, 232);
            this.optionalCourses.Name = "optionalCourses";
            this.optionalCourses.Size = new System.Drawing.Size(376, 184);
            this.optionalCourses.TabIndex = 12;
            this.optionalCourses.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // mainCourse
            // 
            this.mainCourse.FormattingEnabled = true;
            this.mainCourse.Items.AddRange(new object[] {
            "Applied Mathematics",
            "Computer Science",
            "Informatics",
            "Information System",
            "Мathematics",
            "Mathematics and Informatics",
            "Software Engineering",
            "Statistics"});
            this.mainCourse.Location = new System.Drawing.Point(196, 232);
            this.mainCourse.Name = "mainCourse";
            this.mainCourse.Size = new System.Drawing.Size(216, 21);
            this.mainCourse.TabIndex = 13;
            this.mainCourse.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(515, 69);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 14;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(663, 69);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 15;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.cancel_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(591, 122);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 16;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // course4
            // 
            this.course4.AutoSize = true;
            this.course4.Location = new System.Drawing.Point(159, 232);
            this.course4.Name = "course4";
            this.course4.Size = new System.Drawing.Size(31, 17);
            this.course4.TabIndex = 3;
            this.course4.TabStop = true;
            this.course4.Text = "4";
            this.course4.UseVisualStyleBackColor = true;
            // 
            // course3
            // 
            this.course3.AutoSize = true;
            this.course3.Location = new System.Drawing.Point(116, 232);
            this.course3.Name = "course3";
            this.course3.Size = new System.Drawing.Size(31, 17);
            this.course3.TabIndex = 2;
            this.course3.TabStop = true;
            this.course3.Text = "3";
            this.course3.UseVisualStyleBackColor = true;
            // 
            // course2
            // 
            this.course2.AutoSize = true;
            this.course2.Location = new System.Drawing.Point(68, 232);
            this.course2.Name = "course2";
            this.course2.Size = new System.Drawing.Size(31, 17);
            this.course2.TabIndex = 1;
            this.course2.TabStop = true;
            this.course2.Text = "2";
            this.course2.UseVisualStyleBackColor = true;
            // 
            // course1
            // 
            this.course1.AutoSize = true;
            this.course1.Location = new System.Drawing.Point(25, 232);
            this.course1.Name = "course1";
            this.course1.Size = new System.Drawing.Size(31, 17);
            this.course1.TabIndex = 1;
            this.course1.TabStop = true;
            this.course1.Text = "1";
            this.course1.UseVisualStyleBackColor = true;
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(25, 259);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(387, 157);
            this.container.TabIndex = 17;
            this.container.Text = "";
            this.container.Visible = false;
            // 
            // errorsContainer
            // 
            this.errorsContainer.BackColor = System.Drawing.Color.Bisque;
            this.errorsContainer.Location = new System.Drawing.Point(25, 433);
            this.errorsContainer.Name = "errorsContainer";
            this.errorsContainer.Size = new System.Drawing.Size(779, 54);
            this.errorsContainer.TabIndex = 18;
            this.errorsContainer.Text = "";
            this.errorsContainer.Visible = false;
            // 
            // appForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 499);
            this.Controls.Add(this.errorsContainer);
            this.Controls.Add(this.container);
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
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.age);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.state);
            this.Controls.Add(this.country);
            this.Controls.Add(this.city);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "appForm";
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
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox confirmPassword;
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
        private System.Windows.Forms.RichTextBox container;
        private System.Windows.Forms.RichTextBox errorsContainer;
    }
}

