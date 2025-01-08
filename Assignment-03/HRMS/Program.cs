using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;
namespace HRMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Manager Test
            //Manager manager2 = new Manager()
            Manager manager = new Manager("Jayesh", true, new Date(21,12,2001),"JALNA",20000,"Manager",DeptType.HR,2000.21);
            //manager2.Accept();
            //manager2.Print();
            Console.WriteLine(manager.ToString());
            #endregion

            #region Supervisor Test

            Supervisor supervisor = new Supervisor("jayesh", true, new Date(21, 12, 2001), "Jalna", 20000, "Manager", DeptType.HR, 20);
            Supervisor supervisor1 = new Supervisor();
            //supervisor1.Accept();
            //supervisor1.Print();
            Console.WriteLine(supervisor.ToString());

            #endregion

            #region WageEmp Test

            WageEmp wageEmp = new WageEmp("JAYESH", true, new Date(21, 12, 2001), "Jalna", 20000, "Manager", DeptType.HR,12,300);
            WageEmp wageEmp1 = new WageEmp();
            wageEmp1.Accept();
            wageEmp1.Print();
            Console.WriteLine(wageEmp.ToString());

            #endregion
        }
    }
}
