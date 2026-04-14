namespace Class_0414_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caller c = new Caller();
            c.CallGetNname(new Person());
            c.CallGetNname(new Student());
            c.CallGetNname(new Teacher());
        }
    }
}
