using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ApplicationForm
{
    public partial class appForm : Form
    {
        private XmlDocument doc;
        private String xsd, xml;

        public appForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void clearCheckboxes()
        {
            for (int i = 0; i < optionalCourses.Items.Count; i++)
                optionalCourses.SetItemCheckState(i, CheckState.Unchecked);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.firstName.Text = "";
            this.lastName.Text = "";
            this.email.Text = "";
            this.country.Text = "";
            this.state.Text = "";
            this.city.Text = "";
            this.phoneNumber.Text = "";
            this.age.Text = "";
            this.password.Text = "";
            this.confirmPassword.Text = "";
            this.facNumber.Text = "";
            this.mainCourse.Text = "";
            this.clearCheckboxes();
        }

        //private void loadFile(XmlDocument doc, String fileName)
        //{
        //    doc.Load(fileName);
        //    XmlNode root = doc.FirstChild;
        //}

        private void createFile()
        {
            XmlElement applicants = doc.CreateElement("Applicants");
            XmlElement applicant = doc.CreateElement("Applicant");
            XmlElement personalInfo = doc.CreateElement("PersonalInfo");
            personalInfo.SetAttribute("FirstName", this.firstName.Text);
            personalInfo.SetAttribute("LastName", this.lastName.Text);
            personalInfo.SetAttribute("Age", this.age.Text);
            personalInfo.SetAttribute("Email", this.email.Text);

            XmlElement address = doc.CreateElement("Address");
            address.SetAttribute("Country", this.country.Text);
            address.SetAttribute("State", this.state.Text);
            address.SetAttribute("City", this.city.Text);

            XmlElement phoneNumber = doc.CreateElement("PhoneNumber");
            phoneNumber.InnerText = this.phoneNumber.Text;

            XmlElement passwords = doc.CreateElement("Passwords");
            XmlElement password = doc.CreateElement("Password");
            password.InnerText = this.password.Text;
            XmlElement confirmPassword = doc.CreateElement("ConfirmPassword");
            confirmPassword.InnerText = this.confirmPassword.Text;
            passwords.AppendChild(password);
            passwords.AppendChild(confirmPassword);

            personalInfo.AppendChild(address);
            personalInfo.AppendChild(phoneNumber);
            personalInfo.AppendChild(passwords);

            XmlElement studentInfo = doc.CreateElement("StudentInfo");
            studentInfo.SetAttribute("FacultyNumber", this.facNumber.Text);
            studentInfo.SetAttribute("Course", this.getCourse());

            XmlElement mainCourse = doc.CreateElement("MainCourse");
            mainCourse.InnerText = this.mainCourse.Text;

            XmlElement optionalCourses = doc.CreateElement("OptionalCourses");
            foreach(String optCourse in this.optionalCourses.CheckedItems) {
                XmlElement optionalCourse = doc.CreateElement("OptionalCourse");
                String[] text = optCourse.Split('/');
                //int credits = int.Parse(text[1]);
                String credits = text[1];
                String[] names = text[2].Split(' ');
                optionalCourse.SetAttribute("Name", text[0]);
                optionalCourse.SetAttribute("Credits", credits);
                XmlElement professor = doc.CreateElement("Professor");
                professor.SetAttribute("FirstName", names[0]);
                professor.SetAttribute("LastName", names[1]);
                optionalCourse.AppendChild(professor);
                optionalCourses.AppendChild(optionalCourse);
            }
            if (this.optionalCourses.CheckedItems.Count > 0)
            {
                this.clearCheckboxes();
            }

            studentInfo.AppendChild(mainCourse);
            studentInfo.AppendChild(optionalCourses);

            applicant.AppendChild(personalInfo);
            applicant.AppendChild(studentInfo);
            applicants.AppendChild(applicant);
            if (File.Exists(xml))
            {
                doc.Load(xml);
                XmlNode root = doc.FirstChild;
                root.AppendChild(applicant);
            }
            else
            {
                doc.AppendChild(applicants);
            }
            doc.Save(xml);
        }

        private String getCourse()
        {
            foreach (Control c in this.Controls)
            {
                if ((c is RadioButton)  && ((RadioButton)c).Checked)
                {
                    ((RadioButton)c).Checked = false;
                    return c.Text;
                }
            }
            return "";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            errorsContainer.Visible = false;
            errorsContainer.Text = "";

            createFile();
            if (validate())
            {
                this.clear.PerformClick();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private bool validate()
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", xsd);

            XDocument document = XDocument.Load(xml);

            bool hasErrors = false;
            document.Validate(schemas, (output, error) =>
            {
                Console.WriteLine("{0}", error.Message);
                hasErrors = true;
                if (hasErrors)
                {
                    errorsContainer.Visible = true;
                    errorsContainer.Text = error.Message;
                }
            });

            Console.WriteLine("doc1 {0}", hasErrors ? "did not validate" : "validated");
            return hasErrors;
        }

        private void appForm_Load(object sender, EventArgs e)
        {
            xsd = @".\..\..\schema.xsd";
            xml = @".\created_doc.xml";
            doc = new XmlDocument();
        }
    }
}
