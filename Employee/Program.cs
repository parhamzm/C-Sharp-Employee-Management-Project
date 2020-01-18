using System;

namespace Employee
{
    class Program
    {
        class Member
        {

            // member variables
            string name;
            string position;
            int emp_base;
            double salery;
            bool gender;

            public void Acceptdetails()
            {
                
            }
            public void GetInfo()
            {
                Console.WriteLine("Enter Name of the Employee :");
                this.name = Console.ReadLine();
                Console.WriteLine("Enter position of the Employee :");
                this.position = Console.ReadLine();
                Console.WriteLine("Enter the emp_base of the Employee : {must be between 1 and 6}");
                this.emp_base = Convert.ToInt32(Console.ReadLine());
                if(emp_base>6 || emp_base < 1)
                {
                    while(emp_base > 6 || emp_base < 1)
                    {
                        Console.WriteLine(">> Your answer is out of range please try again!");
                        Console.WriteLine("Enter the emp_base of the Employee :");
                        this.emp_base = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Enter the salery of the Employee :");
                this.salery = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Gender of the Employee : {Enter '1' for Male & '0' for Female!}");
                int gender1 = Convert.ToInt32(Console.ReadLine());
                if (gender1 == 1)
                {
                    this.gender = true;
                }
                else
                {
                    this.gender = false;
                }
            }
            public void Display()
            {
                Console.WriteLine("Name => {0} : Job Position => {1}.", this.name, this.position);
            }

            public bool Getgender()
            {
                return this.gender;
            }

            public int Getbase()
            {
                return this.emp_base;
            }

            public double GetSalary()
            {
                return this.salery;
            }
        }
        static void Main(string[] args)
        {
            Member[] emp = new Member[20];
            int num_of_female = 0;
            int num_of_male_4 = 0;
            int num_of_1 = 0;
            double sum_of_salary = 0;
            double avg;
            Console.WriteLine("Enter the Informations of the Employees : ");
            for (int j=0; j<5; j++)
            {
                Console.WriteLine("************************************************");
                Console.WriteLine("Enter the Information of the {0} Employee : =>", j+1);
                emp[j] = new Member();
                emp[j].GetInfo();
                if(emp[j].Getgender() == false)
                {
                    num_of_female++;
                }
                if(emp[j].Getbase() == 1)
                {
                    num_of_1++;
                }
                if(emp[j].Getbase() == 4 && emp[j].Getgender() == true)
                {
                    num_of_male_4++;
                }
                sum_of_salary += emp[j].GetSalary();
                
            }
            avg = (sum_of_salary / 5);
            Console.WriteLine("Number of Females = {0}", num_of_female);
            Console.WriteLine("Number of Females with Base 4 = {0}", num_of_male_4);
            Console.WriteLine("Number of Employees with base 1 = {0}", num_of_1);
            Console.WriteLine("Average Salary = {0}", avg);
            Console.WriteLine("############################################");
            Console.WriteLine("Employees Are : =>");
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Employees {0} : => ", i+1);
                emp[i].Display();
            }
        }
    }
}
