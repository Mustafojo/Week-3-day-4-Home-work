public class Student: Person
{

    public void Study()
    {
        System.Console.WriteLine("The student is studying");
    }
    public Student(string name):base(name){}
}