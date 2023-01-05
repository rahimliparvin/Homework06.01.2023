
#region
using ConsoleApp2;
using ConsoleApp2.Models;

//GetFibonacci(5);

//void GetFibonacci(int n)
//{
//    int a = 1;
//    int b = 1;
//    int c;

//    Console.WriteLine(a);
//    Console.WriteLine(b);

//    for (int i = 0; i < n; i++)
//    {
//        c = a + b;
//        a = b;
//        b = c;
//        Console.WriteLine(c);
//    }

//}
#endregion


#region impilicit expilicit

Manat manat = new Manat(340);

Dollar dollar = manat;
//Dollar dollar = (Dollar)manat;

//Console.WriteLine(dollar.Usd);

#endregion



StringList list = new StringList();

list.Add("Roya");
list.Add("Konul");
list.Add("Cinare");

//list.ShowStr();

DataList<string> student = new DataList<string>();

student.Add("Fuad");
student.Add("Kamil");
student.Add("Leyla");

//student.GetAll();

DataList<int> number = new DataList<int>();

number.Add(1);
number.Add(2);
number.Add(3);

//number.GetAll();

DataList<Student> studentlist = new DataList<Student>();

studentlist.Add(new Student { Id = 1, Name = "Ali" });
studentlist.Add(new Student { Id = 2, Name = "Cavid" });
studentlist.Add(new Student { Id = 3, Name = "Kemale" });

//studentlist.GetAll();


IntList list1 = new IntList();

list1.Add(1);
list1.Add(2);
list1.Add(3);

//list1.ShowNum();


StudentList list2= new StudentList();

list2.Add(new Student { Id = 1, Name = "Ali" });
list2.Add(new Student { Id = 2, Name = "Mamed" });
list2.Add(new Student { Id = 3, Name = "Vahid" });

//list2.ShowStudent();



//Repository<Student> stu = new Repository<Student>();

//Repository<int> num = new Repository<int>();

//Repository<string> str = new Repository<string>();

//Repository<bool> married = new Repository<bool>();

Repository<Test1, Test2> data = new Repository<Test1, Test2>();



