namespace SRP;


class Program
{
    static void Main(string[] args)
    {
        StandardMessage.Welcome();


        var user = UserCreator.Create();

        var isValid =  UserValidator.Validate(user);

        if (!isValid)
        {
            StandardMessage.EndApplication();

        }
        UserValidator.Validate(user);
        StandardMessage.ShowResult(user);
        StandardMessage.EndApplication();

    }
}