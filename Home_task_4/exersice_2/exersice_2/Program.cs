namespace exersice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            EmailValidator emailValidator = new EmailValidator();
            emailValidator.FindEmail(text);
            Console.WriteLine(emailValidator);
        }
    }
}