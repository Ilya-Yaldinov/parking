class MyClass
{
    static void Main()
    {
        int time = Convert.ToInt32(Console.ReadLine());
        if (time % 24 <= 5)
        {
            Console.WriteLine(Convert.ToDouble((time/24)*15 + (time%24)));
        }
        else
        {
            Console.WriteLine(Convert.ToDouble((time/24)*15 + 5 + ((time%24)-5)*0.5));
        }
    }
}