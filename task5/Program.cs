
Student student = new Student("Orzu", "Dushanbe", "C#", 2024, 1500);
student.SetYear(2024);
student.SetProgram("C#");
student.SetFee(1500);

System.Console.WriteLine(student.ToString());
System.Console.WriteLine("-------------");
System.Console.WriteLine("Programm: " + student.GetProgram());
System.Console.WriteLine("Year Fee: " + student.GetFee());
System.Console.WriteLine("Year: " + student.GetYear());
System.Console.WriteLine("________________________________________");
System.Console.WriteLine();
Staff staff = new Staff("Maruf", "Dushanbe", "Gagarinskaya shkola", 0);
staff.SetPay(0);
staff.SetSchool("Gagarinskaya shkola");

System.Console.WriteLine(staff.ToString());
System.Console.WriteLine("-------------");
System.Console.WriteLine("School: " + staff.GetSchool());
System.Console.WriteLine("Pay: " + staff.GetPay());