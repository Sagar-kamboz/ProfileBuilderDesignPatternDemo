using ProfileBuilderPatternDemo.Core.Entities;
using ProfileBuilderPatternDemo.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileBuilderPatternDemo.Services
{
    public class UserService
    {
        private readonly IUserDirector _userDirector;

        public UserService(IUserDirector userDirector)
        {
            this._userDirector = userDirector;
        }

        public void CreateUsers()
        {
            User basicUser = _userDirector.ConstructBasicUser("John", "Doe");

            User fullUser = _userDirector.ConstructFullUser("Jane", "Smith");

            Console.WriteLine($"Basic User: {basicUser.FirstName} {basicUser.LastName}, Email: {basicUser.Email}");
            Console.WriteLine($"Full User: {fullUser.FirstName} {fullUser.LastName}, Age: {fullUser.Age}, Email: {fullUser.Email}, Address: {fullUser.Address}");
        }
    }
}
