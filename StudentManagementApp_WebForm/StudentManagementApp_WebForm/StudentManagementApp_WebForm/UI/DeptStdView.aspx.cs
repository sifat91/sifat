using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentManagementApp_WebForm.BLL;
using StudentManagementApp_WebForm.Models;

namespace StudentManagementApp_WebForm.UI
{
    public partial class DeptStdView : System.Web.UI.Page
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
        }

        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            int selectedDeptID = Convert.ToInt32(codeDropDownList.SelectedValue);

            List<Student> students = studentManager.GetStudentRegNoByDeptId(selectedDeptID);
            regNoDropDownList.DataTextField = "RegNo";
            regNoDropDownList.DataValueField = "ID";
            regNoDropDownList.DataSource = students;
           
            regNoDropDownList.DataBind();
        }

        //public event EventHandler SelectedIndexChanged;
        //protected void regNoDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    HandledEventHandler SelectedIndexChanged = regNoDropDownList_SelectedIndexChanged;

        //    Student aStudent = studentManager.GetStudentByRegNo(SelectedIndexChanged.ToString());


        //    txtName.Text = aStudent.Name;
        //    txtEmail.Text = aStudent.Email;


        //}

        protected void btnShow_OnClick(object sender, EventArgs e)
        {
            Student aStudent = new Student();
         
            string selectedRegNo = regNoDropDownList.SelectedItem.Selected.ToString();

            aStudent = studentManager.GetStudentByRegNo(selectedRegNo);

            txtName.Text = aStudent.Name;
            txtEmail.Text = aStudent.Email;

        }
       
    }
}