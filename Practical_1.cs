using System;

namespace StudentAdmission
{
    class Student
    {
        // Private Data Members
        private int id;
        private string name;
        private int age;
        private string course;

        // Constructor
        public Student(int sid, string sname, int sage, string scourse)
        {
            id = sid;
            name = sname;
            age = sage;
            course = scourse;
        }

        // 1. Display Student Details
        public void Display()
        {
            Console.WriteLine("\nStudent ID : " + id);
            Console.WriteLine("Name       : " + name);
            Console.WriteLine("Age        : " + age);
            Console.WriteLine("Course     : " + course);
        }

        // 2. Update Name
        public void UpdateName()
        {
            Console.Write("Enter New Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Name Updated Successfully.");
        }

        // 3. Update Course
        public void UpdateCourse()
        {
            Console.Write("Enter New Course: ");
            course = Console.ReadLine();
            Console.WriteLine("Course Updated Successfully.");
        }

        // 4. Search by ID
        public void Search(int sid)
        {
            if (id == sid)
                Display();
            else
                Console.WriteLine("Student Not Found.");
        }

        // 5. Check Eligibility
        public void CheckEligibility()
        {
            if (age >= 17)
                Console.WriteLine("Eligible for Admission.");
            else
                Console.WriteLine("Not Eligible for Admission.");
        }

        // 6. Show Course
        public void ShowCourse()
        {
            Console.WriteLine("Selected Course: " + course);
        }

        // 7. Delete Record
        public void DeleteRecord()
        {
            id = 0;
            name = "";
            age = 0;
            course = "";
            Console.WriteLine("Record Deleted Successfully.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Student Admission Management System =====");

            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            // Object Creation
            Student s = new Student(id, name, age, course);

            int choice;

            do
            {
                Console.WriteLine("\n------ MENU ------");
                Console.WriteLine("1. Display Student");
                Console.WriteLine("2. Update Name");
                Console.WriteLine("3. Update Course");
                Console.WriteLine("4. Search Student");
                Console.WriteLine("5. Check Eligibility");
                Console.WriteLine("6. Show Course");
                Console.WriteLine("7. Delete Record");
                Console.WriteLine("8. Exit");

                Console.Write("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        s.Display();
                        break;

                    case 2:
                        s.UpdateName();
                        break;

                    case 3:
                        s.UpdateCourse();
                        break;

                    case 4:
                        Console.Write("Enter Student ID to Search: ");
                        int sid = Convert.ToInt32(Console.ReadLine());
                        s.Search(sid);
                        break;

                    case 5:
                        s.CheckEligibility();
                        break;

                    case 6:
                        s.ShowCourse();
                        break;

                    case 7:
                        s.DeleteRecord();
                        break;

                    case 8:
                        Console.WriteLine("Thank You!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }

            } while (choice != 8);

            Console.ReadKey();
        }
    }
}