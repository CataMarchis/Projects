
Person Mihai = new Person(100);
Console.WriteLine(Mihai.Age);
Person Andrei = new Person();
Console.WriteLine(Andrei.Age);
Andrei.Age = 1000;
Console.WriteLine(Andrei.Age);







class Person
{
    private int age;


    public Person(int age)
    { Age = age; }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 90)
                age = 90;
            else age = value;
        }
    }

    public Person()
    {
        Age = 1;
    }
}
