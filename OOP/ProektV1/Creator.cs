using System;

public abstract class Creator
{
    private string _name;
    private int _creativityLevel = 100;
    private int _energy = 100;

    public Creator(string name)
    {
        Name = name;
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {

            if (value is null)
            {
                // Here is good to use some constants for messages
                throw new Exception("The field name should not be empty and should be between 1 and 20 characters long");
            }

            _name = value;
        }
    }

    public int CreativityLevel
    {
        get { return _creativityLevel; }
        set
        {
            if (value < 0 || value > 100)
            {
                // Here is good to use some constants for message
                throw new Exception("Creativity level can only be a value between 0 and 100.");
            }

            _creativityLevel = value;
        }

    }

    public int Energy
    {
        get { return _energy; }
        set
        {
            if (value < 0 || value > 100)
            {
                // Here is good to use some constants messages for message
                throw new Exception("Energy level can only be a value between 0 and 100.");
            }

            _energy = value;
        }
    }

    public abstract void Act();

    public abstract void Create();
}