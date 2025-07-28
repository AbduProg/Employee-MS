using System.Data;
using System.Drawing;
using System;

namespace EmployeeManagement
{
    class VariablesClass
    {
        public static bool updatePermission, insertPermission, printPermission, usersPermission, settingsPermission;

        public static int userId =1, updateCompanyDataId,OpenInvo = 0;
        public static string userName = "", userPassword, userJob, phoneNum;
        public static Point pos;
        public static bool backupProcess;
        public static bool sw, SwupdateCompanyData = false;
        public static bool IsFrmDialogCloseing;
        public static int Save = -1, OrderNumber = -1;

        public static int PredecessorId = 0; 
        public static  string EmpName = "";

        public static FunctionsClass functionsClass = new FunctionsClass();
        

        public static DataTable dtUserPermissions = new DataTable();
        public static bool isMessageBoxOpen = false;
        public static int mainActiveCounter = 0;

    }
}
