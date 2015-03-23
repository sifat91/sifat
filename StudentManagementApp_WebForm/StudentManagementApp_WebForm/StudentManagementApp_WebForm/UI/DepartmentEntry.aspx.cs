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
    public partial class DepartmentEntry : System.Web.UI.Page
    {
        private DepartmentManager aDepartmentManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            msgLabel.Text = "";
        }

        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            try
            {

                var code = txtCode.Text;
                var name = txtName.Text;

                Department aDepartment = new Department(code,name);

                bool isSaved = aDepartmentManager.Insert(aDepartment);

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