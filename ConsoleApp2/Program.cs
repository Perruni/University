namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            for (int i = 0; i <= 1000; i++)
            {
                Person persona = new Person();
                persona.Name = "Persona " + i;
                people.Add(persona);
            }

            foreach (var persona in people)
            {
                if (!persona.Name.EndsWith("00"))
                {
                    continue;
                }
                Console.WriteLine(persona.Name);

            }
        }
    }
}
