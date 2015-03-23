using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentManagementApp_WebForm.BLL;
using StudentManagementApp_WebForm.Models;

namespace StudentManagementApp_WebForm.UI
{
    public partial class StudentView : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Student> students = studentManager.GetAllStudent();

                regNoDropDownList.DataSource = students;
                regNoDropDownList.DataTextField = "RegNo";
                regNoDropDownList.DataValueField = "ID";
                regNoDropDownList.DataBind();

            }
        }

        protected void showButton_OnClick(object sender, EventArgs e)
        {
            string regNo = regNoDropDownList.SelectedItem.Text;

            Student student = studentManager.GetStudentByRegNo(regNo);

            nameLabel.Text = student.Name;
            emailLabel.Text = student.Email;
        }
    }
}