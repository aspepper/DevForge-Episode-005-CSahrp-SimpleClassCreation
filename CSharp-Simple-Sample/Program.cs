// Definition of the Person class
class Person
{
    // Person class properties
    public required string Name { get; set; }
    public int Age { get; set; }

    // Method for introducing the person
    public void Greeting()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the Person class
        Person person1 = new()
        {
            // Assigning values to person1 properties
            Name = "Alex Pimenta",
            Age = 51
        };

        // Chamando o método Apresentar da pessoa1
        person1.Greeting();
    }
}
