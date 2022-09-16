using System;
using System.Collections.Generic;
public class Programmer : Creator
{
    public Programmer(string name) : base(name)
    {

    }


    public override void Act()
    {
        if (CreativityLevel >= 70 && Energy >= 80)
        {
            this.BrainstormSoluttions();
            this.PickMostOptimalSolution();
            this.WriteCode();
            this.TestCode();
        }
        else
        {
            throw new Exception("Cannot create program. Out of ideas and/or tired.");
        }

    }

    protected void BrainstormSoluttions()
    {
        CreativityLevel -= 15;
        Energy -= 10;

        Console.WriteLine("Brainstorming solution....");

    }
    protected void PickMostOptimalSolution()
    {
        CreativityLevel -= 5;
        Energy -= 5;

        Console.WriteLine("Picking most optimal solution....");
    }
    protected void WriteCode()
    {
        CreativityLevel -= 7;
        Energy -= 5;

        Console.WriteLine("Writing code....");
    }
    private void TestCode()
    {
        CreativityLevel -= 3;
        Energy -= 3;

        Console.WriteLine("Testing code....");
    }
   
    public override string ToString()
        => $"Hello I am Programmer.My name is {Name}.";

    public override void Create()
    {
        throw new NotImplementedException();
    }
}