using System;

namespace staff_details
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            staff stf = new staff();
            Console.WriteLine("Enter the first name");
            stf.fname = Console.ReadLine();
            Console.WriteLine("Enter the middle name");
            stf.mname = Console.ReadLine();
            Console.WriteLine("Enter the  last name");
            stf.lname = Console.ReadLine();
            Console.WriteLine("Enter the adress");
            stf.adress = Console.ReadLine();
            Console.WriteLine("Enter the jobtype");
            stf.jobtype = Console.ReadLine();
            Console.WriteLine("Enter the age(only in numbers)");
            stf.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no. of years of experinece that you have(only in numbers)");
            stf.exp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the salary in Rupees(only in numbers)");
            string val= Console.ReadLine();
            stf.salary = Convert.ToInt32(val);
            
            
            stf.display_details();
            
           
        }
    }
    class staff
    {
        public string fname,mname,lname;
        public string adress;
        public string jobtype;
        public int age,exp,salary;
        

        public void display_details()
        {
            
            string full_name = fname + ' ' +  mname +' ' + lname;
            Console.WriteLine("");
            Console.WriteLine("=========================");
            Console.WriteLine($"Details about Mr.{fname}");
            Console.WriteLine("=========================");
            Console.WriteLine("");
            Console.WriteLine($"full name: {full_name} ");
            Console.WriteLine($"Adress: {adress} ");
            Console.WriteLine($"jobtype: {jobtype} ");
            Console.WriteLine($"Age: {age} ");
            Console.WriteLine($"Years of experience: {exp} ");
            Console.WriteLine($"Current salary: Rs.{salary} ");
           
        }
    }
}
