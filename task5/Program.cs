

Student student = new Student("Maruf","Nodira 78","Coding",2008,1.0);
student.SetProgram("Coding");
student.SetYear(2008);
student.SetFee(1.0);
System.Console.WriteLine(student.GetProgram);
System.Console.WriteLine(student.GetYear);
System.Console.WriteLine(student.GetFee);
System.Console.WriteLine(student.ToString());
Staff staff = new Staff("Maruf","Nodira 78","Coding",1.0);
staff.SetSchool("schkola Gagarina");
staff.SetPay(1.0);
System.Console.WriteLine(staff.GetSchool);
System.Console.WriteLine(staff.GetPay);
System.Console.WriteLine(student.ToString());