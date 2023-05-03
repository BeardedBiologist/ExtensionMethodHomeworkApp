namespace ExtensionMethodHomework
{
    public static class PersonExtensions
    {
        public static Person SetDefaultAge(this Person person)
        {
            person.Age = 18;
            return person;
        }

        public static void PrintInfo(this Person person)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}