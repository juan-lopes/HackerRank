using System;
using System.Collections.Generic;
using System.IO;

class Person
{
    public int age;
    public Person(int initialAge)
    {
        if (initialAge >= 0)
        {
            age = initialAge;
        }
        else
        {
            print("Age is not valid, setting age to 0.");
            age = 0;
        }
    }
    public void amIOld()
    {
        // Do some computations in here and print out the correct statement to the console 

        if (age < 13)
            print("You are young.");
        else if (age >= 13 && age < 18)
            print("You are a teenager.");
        else
            print("You are old.");
    }

    public void yearPasses()
    {
            // Increment the age of the person in here
            age += 1;
    }

    public void print(string a)
    {
        Console.WriteLine(a);
    }

    static void Main(String[] args)
    {
        int T = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++)
        {
            int age = int.Parse(Console.In.ReadLine());
            Person p = new Person(age);
            p.amIOld();
            for (int j = 0; j < 3; j++)
            {
                p.yearPasses();
            }
            p.amIOld();
            Console.WriteLine();
        }
    }
}
