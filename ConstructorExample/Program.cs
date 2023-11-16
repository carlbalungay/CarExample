namespace ConstructorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("Harold");
        
            person.Speak();
            person.Dance();

            Person person2 = new Person("Rose");

            person2.Speak();
            person2.Dance();

        }
    }
}