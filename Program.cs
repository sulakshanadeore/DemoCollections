using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary;
namespace GenericCollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // EmployeeOperations();

            Program p = new Program();
            //CallByReferenceDemo(p);
            //ParamsDemo(p);
            int ans;
            bool isEven=p.CheckStatus(11, out ans);
            Console.WriteLine("Is the number even " + isEven);
            Console.WriteLine(ans);
            p.DoCalculations(11, 2, out int rem, out int addAns, out int divAns);
            Console.WriteLine("Addition= " + addAns);
            Console.WriteLine("Division Quotient=" + divAns);
            Console.WriteLine("Division Remainder= " + rem);

            Console.ReadLine();

        }

        public void DoCalculations(int i, int j, out int rem, out int add, out int divAns)
        {
            add = i + j;
            divAns=Math.DivRem(i, j,out rem);
        }




        public bool CheckStatus(int no, out int AdditionofInput)
        { 
            bool status=false;
            AdditionofInput = 0;
            if (no%2== 0) 
            {
                status = true;
                AdditionofInput = 0;
            }
            else {
                while (no != 0)
                {

                    int j = no % 10;
                    AdditionofInput += j;
                    no = no / 10;


                }
            }


        return status;
        
        }





        private static void ParamsDemo(Program p)
        {
            p.DoAddition(11, 1, 2, 3, 4, 5);
        }

        private static void CallByReferenceDemo(Program p)
        {
            int no1, no2;
            no1 = 10;
            no2 = 20;
            p.Swap(ref no1, ref no2);
            Console.WriteLine("No1=" + no1);
            Console.WriteLine("No2=" + no2);
        }

        public void DoAddition(int p1,params int[] nos) 
        {
            Console.WriteLine("P1=" + p1);

            int sum = 0;
            for (int i = 0; i < nos.Length; i++) 
            {
                sum = sum + nos[i];
            
            
            }
            Console.WriteLine(sum);

        }



        public void Swap(ref int i,ref int j)
        {

            int k = i;
            i=j;
            j=k;
            Console.WriteLine(i);
            Console.WriteLine(j);
        }



        private static void EmployeeOperations()
        {
            char ans;
            EmpCRUDOperations operations = new EmpCRUDOperations();
            do
            {

                Console.WriteLine("Menu");
                Console.WriteLine("1.Add Employee 2. Show Employee List 3.Delete Employee");
                int choice = Convert.ToInt32(Console.ReadLine());

                Employee emp = new Employee();

                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Enter First name ");
                        emp.FirstName = Console.ReadLine();
                        Console.WriteLine("enter salary");
                        emp.Salary = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter deptno");
                        emp.Deptno = Convert.ToInt32(Console.ReadLine());
                        operations.AddEmployee(emp);

                        break;
                    case 2:
                        List<Employee> emplist = operations.GetEmployeesList();
                        foreach (var item in emplist)
                        {
                            Console.WriteLine(item.FirstName);
                            Console.WriteLine(item.Deptno);
                            Console.WriteLine(item.Salary);
                            Console.WriteLine();
                        }

                        break;
                    case 3:
                        Console.WriteLine("Enter First name ");
                        emp.FirstName = Console.ReadLine();
                        Console.WriteLine("enter salary");
                        emp.Salary = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter deptno");
                        emp.Deptno = Convert.ToInt32(Console.ReadLine());
                        operations.DeleteEmployee(emp);
                        Console.WriteLine("Successfully removed");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("do you want to continue in the app");
                ans = Convert.ToChar(Console.ReadLine());


            }
            while (ans == 'Y');
            if (ans == 'N')
            {
                Console.WriteLine("Thanks for using the app");
                Console.ReadLine();


                Environment.Exit(1);
            }
        }
    }
}
