using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentManagementApp_WebForm.DAL;
using StudentManagementApp_WebForm.Models;

namespace StudentManagementApp_WebForm.BLL
{
    public class DepartmentManager
    {
        DepartmentGateWay aDepartmentGateWay = new DepartmentGateWay();
          public DepartmentManager()
        {
            aDepartmentGateWay = new DepartmentGateWay();
        }


          public bool Insert(Department aDepartment)
          {
              int rowAffected = 0;
              if (!IsCodeExist(aDepartment))
              {
                  rowAffected = aDepartmentGateWay.Insert(aDepartment);
              }
              else
              {
                  throw new Exception("Dept Code No already exists!");
              }

              return rowAffected > 0;

          }

        private bool IsCodeExist(Department aDepartment)
        {
            Department retriveDeptCode = aDepartmentGateWay.GetDepartmentByCode(aDepartment.Code);

            return retriveDeptCode != null;
        }

        public List<Department> GetAllDepartment()
        {
            return aDepartmentGateWay.GetAllDepartment();
        }

     
   }
}