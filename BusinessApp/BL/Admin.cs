using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace RMS.BL
{
    public class Admin : Employee
    {
        private List <string> Permissions = new List<string>();
        private List<string> ToolsUsed = new List<string>();

        private int EmployeeID;
        private int AdminID;

        public Admin()
        {            
        }

        public Admin(int empid,int adminid,string username, string contact, double salary, DateTime joinDate, string gender, int userID,List<string> t, List<string> p) : base(empid,username, contact, salary, joinDate, gender, userID)
        {
            AdminID = adminid;
            Permissions=p ;
            ToolsUsed = t;
        }

        public Admin(string username, string contact, double salary, DateTime joinDate, string gender, int userID, List<string> t, List<string> p, int employeeID) : base(employeeID,username, contact, salary, joinDate, gender, userID)
        {
            Permissions = p;
            ToolsUsed = t;
            EmployeeID = employeeID;
        }

        public Admin(int id, string username, double salary, List <string> tools, List <string> permissions, int employeeID) : base(username, salary)
        {
            AdminID = id;
            Permissions = permissions;
            ToolsUsed = tools;
            EmployeeID = employeeID;
        }

        public int GetAdminID()
        {
            return AdminID;
        }

        public void AddPermission(string permission)
        {
            Permissions.Add(permission);
        }

        public void AddToolUsed(string tool)
        {
            ToolsUsed.Add(tool);
        }

        public List<string> GetPermissions()
        {
            return Permissions;
        }

        public List<string> GetToolsUsed()
        {
            return ToolsUsed;
        }

        public void SetPermissions(List<string> permissions)
        {
            Permissions = permissions;
        }

        public void SetToolsUsed(List<string> toolsUsed)
        {
            ToolsUsed = toolsUsed;
        }

        public void RemovePermission(string permission)
        {
            Permissions.Remove(permission);
        }

        public void RemoveToolUsed(string tool)
        {
            ToolsUsed.Remove(tool);
        }

        public void UpdatePermission(string oldPermission, string newPermission)
        {
            int index = Permissions.IndexOf(oldPermission);
            Permissions[index] = newPermission;
        }

        public void UpdateToolUsed(string oldTool, string newTool)
        {
            int index = ToolsUsed.IndexOf(oldTool);
            ToolsUsed[index] = newTool;
        }
    }
}
