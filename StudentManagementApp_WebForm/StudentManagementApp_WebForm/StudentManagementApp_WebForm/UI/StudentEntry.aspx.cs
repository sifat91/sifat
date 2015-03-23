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
    public partial class StudentEntry : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        private DepartmentManager aDepartmentManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Department> departments = aDepartmentManager.GetAllDepartment();

                codeDropDownList.DataSource = departments;
                codeDropDownList.DataTextField = "Code";
                codeDropDownList.DataValueField = "ID";
                codeDropDownList.DataBind();

            }
            msgLabel.Text = "";
        }
        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            try
            {

                var name = txtName.Text;
                var email = txtEmail.Text;
                var regNo = txtRegNo.Text;
                int deptId = Convert.ToInt16(codeDropDownList.SelectedValue);

                Student student = new Student(name, email, regNo, deptId);

                bool isSaved = studentManager.Insert(student);

                if (isSaved)
                {
                    msgLabel.Text = "Saved Successfully!";
                }
                else
                {
                    msgLabel.Text = "Insertion Failed!";
                }

            }
            catch (Exception exception)
            {
                msgLabel.Text = exception.Message;
            }
            
        }
    }
}