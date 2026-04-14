using System;

public interface IName
{
    string GetName();
}
public class Person : IName
{
    public string GetName()
    {
        return "Person";
    }   
}

public class Student : IName
{
    public string GetName()
    {
        return "Student";
    }
}
public class Teacher : IName
{
    public string GetName()
    {
        return "Teacher";
    }
}
public class Caller
{
    public void CallGetNname(IName name)
    {
        Console.WriteLine(name.GetName());
    }
}
