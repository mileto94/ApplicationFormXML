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
        private String xsd, xml, error_log;

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
            this.facNumber.Text = "";
            this.mainCourse.Text = "";
            this.clearCheckboxes();
            this.course1.Checked = false;
            this.course2.Checked = false;
            this.course3.Checked = false;
            this.course4.Checked = false;
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

            personalInfo.AppendChild(address);
            personalInfo.AppendChild(phoneNumber);

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
                    Console.WriteLine(error.Severity);

                    using (StreamWriter sw = File.AppendText(error_log))
                    {
                        sw.WriteLine(String.Format(
                            "{0}: {1}",
                            error.Severity,
                            error.Message
                        ));
                    }
                }
            });

            Console.WriteLine("doc1 {0}", hasErrors ? "did not validate" : "validated");
            return hasErrors;
        }

        private void appForm_Load(object sender, EventArgs e)
        {
            xsd = @".\..\..\schema.xsd";
            xml = @".\created_doc.xml";
            error_log = @".\error_log.txt";
            doc = new XmlDocument();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void readFile_Click(object sender, EventArgs e)
        {
            doc.Load(xml);
            XmlNode applicants = doc.FirstChild;
            List<String> data = new List<String>();
            foreach (XmlNode applicant in applicants.ChildNodes)
            {
                XmlNode personalInfo = applicant.FirstChild;
                data.Add(String.Format("First Name: {0}", personalInfo.Attributes["FirstName"].Value));
                data.Add(String.Format("Last Name: {0}", personalInfo.Attributes["LastName"].Value));
                data.Add(String.Format("Age: {0}", personalInfo.Attributes["Age"].Value));
                data.Add(String.Format("Email: {0}", personalInfo.Attributes["Email"].Value));
                XmlNode address = personalInfo.FirstChild;
                data.Add(String.Format("Country: {0}", address.Attributes["Country"].Value));
                data.Add(String.Format("State: {0}", address.Attributes["State"].Value));
                data.Add(String.Format("City: {0}", address.Attributes["City"].Value));
                XmlNode phone = address.NextSibling;
                data.Add(String.Format("Phone Number: {0}", address.InnerText));

                XmlNode studentInfo = personalInfo.NextSibling;
                data.Add(String.Format("FacultyNumber: {0}", studentInfo.Attributes["FacultyNumber"].Value));
                data.Add(String.Format("Course: {0}", studentInfo.Attributes["Course"].Value));
                XmlNode mainCourse = studentInfo.FirstChild;
                data.Add(String.Format("Main Course: {0}", mainCourse.InnerText));
                XmlNode optionalCourses = mainCourse.NextSibling;
                if(optionalCourses.ChildNodes.Count > 0)
                    data.Add("Optional Courses");
                foreach(XmlNode optionalCourse in optionalCourses.ChildNodes)
                {
                    data.Add(String.Format("   Course Name: {0}", optionalCourse.Attributes["Name"].Value));
                    data.Add(String.Format("   Credits: {0}", optionalCourse.Attributes["Credits"].Value));
                    XmlNode professor = optionalCourse.FirstChild;
                    data.Add(String.Format(
                        "   Professor: {0} {1}",
                        professor.Attributes["FirstName"].Value,
                        professor.Attributes["LastName"].Value));
                }
                data.Add("---------------------------------");
            }
            Form2 readForm = new Form2();
            readForm.Show();
            readForm.containerInterface = String.Join("\n", data);
        }
    }
}
