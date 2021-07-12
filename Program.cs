using System;

namespace staff_details
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----EMPLOYEE ENROLLING---");
            Console.WriteLine("Select your job type \n1.Teaching staff\n2.Admin. staff\n3.Supporting Staff");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch) 
            {
                case 1:
                    Teaching t = new Teaching();
                    staf_reg(t);
                    teaching_reg(t);
                    staff_display(t);
                    t.display();
                    break;
                case 2:
                    Administrative a = new Administrative();
                    staf_reg(a);
                    administrative_reg(a);
                    staff_display(a);
                    a.display();
                    break;

                case 3:
                    Supporting s = new Supporting();
                    staf_reg(s);
                    supporting_reg(s);
                    staff_display(s);
                    s.display();
                    break;
                default:
                    Console.WriteLine("SELECT A VALID OPTION");
                    break;
            }

           
        }
        public static void staf_reg(staff stf)
        {
            Console.WriteLine("\n\nEnter ur name");
            stf.Name = Console.ReadLine();
            Console.WriteLine("Enter ur Employee Id");
            stf.EmpId = Convert.ToInt32(Console.ReadLine());
                  
        }
        static void staff_display(staff stf)
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("------EPLOYEE DETAIALS------");
            Console.WriteLine($"Employee name: {stf.Name}");
            Console.WriteLine($"Employee id: {stf.EmpId}");
        }
        static void teaching_reg(Teaching stf)
        {
            Console.WriteLine("Enter the subject that u teach");
            stf.Subject = Console.ReadLine();              
        }
        static void administrative_reg(Administrative stf)
        {
            Console.WriteLine("Enter ur admin. no");
            stf.AdmId = Convert.ToInt32(Console.ReadLine());

        }
        static void supporting_reg(Supporting stf)
        {
            Console.WriteLine("Enter your superior name");
            stf.Superior = Console.ReadLine();

        }

    
    }
    class staff
    {
        private string _name;  
        public string Name    
        {
        get => _name;
        set => _name = value;
        }
        private int _empid;  
        public int EmpId    
        {
        get => _empid;
        set => _empid= value;
        }
    }
    class Teaching: staff
    {
        private string _sub;  
        public string Subject    
        {
        get => _sub;
        set => _sub = value;
        }
        public void display()
        {       
            Console.WriteLine($"Staff type: Teaching staff");
            Console.WriteLine($"Teaching subject: {Subject}");
        }
    }
    class Administrative: staff
    { 
        private int _admpid;  
        public int AdmId    
        {
        get => _admpid;
        set => _admpid = value;
        }
        public void display()
        {
            Console.WriteLine($"Staff type: Administrative staff");
            Console.WriteLine($"Administration no.:{AdmId}");
        }
    }
    class Supporting: staff
    {
        private string _sup;  
        public string Superior    
        {
        get => _sup;
        set => _sup = value;
        }
        public void display()
        {
            Console.WriteLine($"Staff type: Supporting staff");
            Console.WriteLine($"Superior name:{Superior}");
        }

    }
}
