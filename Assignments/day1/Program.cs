using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee111
{
    class Program
    {
        static void Main()
        {

            /*Employee e = new Employee("maya", 123456, 10);
            Console.WriteLine("Employee No:" + e.EMPNO + " Employee name: " + e.NAME + "     Basic salary: " + e.BASIC + "     Department number: " + e.DEPTNO + "    Employee Netsalary: " + e.GetNetSalary());

            Employee e1 = new Employee("nobi", 123456);
            Console.WriteLine("Employee No:" + e1.EMPNO + " Employee name: " + e1.NAME + "     Basic salary: " + e1.BASIC + "     Employee Netsalary: " + e1.GetNetSalary());

            Employee e2 = new Employee("sandy");
            Console.WriteLine("Employee No:" + e2.EMPNO + " Employee name: " + e2.NAME);*/

            


            Console.WriteLine("<--------------------------------Test case--------------------------------->");

            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();
            Console.WriteLine(o1.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o3.EMPNO);

            Console.WriteLine(o3.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o1.EMPNO);
            Console.ReadLine();

        }
    }

}

    public class Employee
{
    private string name;
    private int empNo;
    private decimal basic;
    private short deptNo;

    #region Constructors

    public Employee(string name, decimal basic, short deptNo)
    {
        count++;
        empNo = count;
        this.NAME = name;
        this.BASIC = basic;
        this.DEPTNO = deptNo;
       
    }

    public Employee(string name, decimal basic)
    {
        count++;
        empNo = count;
        this.NAME = name;
        this.BASIC = basic;
        
    }

    public Employee(string name)
    {
        count++;
        empNo = count;
        this.NAME = name;
        
    }

    public Employee()
    {
        count++;
        empNo = count;
    }
    #endregion


    #region Properties
    public string NAME
    {
        set
        {
            if (value != " ")
            {
                name = value;
            }

            else
            {
                Console.WriteLine("Re-enter Name");
            }
        }
        get
        {
            return name;
        }
    }
    static int count = 0;
    public int EMPNO
    {
        get
        {
            return empNo;
        }
    }

    public decimal BASIC
    {
        set
        {
            if (value > 100000 && value < 1000000)
            {
                basic = value;
            }
        }
        get
        {
            return basic;
        }
    }

    public short DEPTNO
    {
        set
        {
            if (value > 0)
            {
                deptNo = value;
            }
            else
                Console.WriteLine("Department number must be < zero");
        }
        get
        {
            return deptNo;
        }
    }

    #endregion


    #region Methods
    public decimal GetNetSalary()
    {
        return basic + (basic / 10);
    }
    #endregion


}

