using ProfileBuilderPatternDemo.Infrastructure.Director;
using ProfileBuilderPatternDemo.Services;

class Program
{
    static void Main(string[] args)
    {
        var director = new UserDirector();
        var service = new UserService(director);

        service.CreateUsers();
        Console.ReadLine();
    }
}