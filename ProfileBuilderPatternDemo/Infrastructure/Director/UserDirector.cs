using ProfileBuilderPatternDemo.Core.Entities;
using ProfileBuilderPatternDemo.Core.Enums;
using ProfileBuilderPatternDemo.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileBuilderPatternDemo.Infrastructure.Director
{
    public class UserDirector : IUserDirector
    {
        public User ConstructBasicUser(string firstName, string lastName)
        {
            return new User.Builder(firstName, lastName).WithEmail($"{firstName.ToLower()}.{lastName.ToLower()}@demo.com").Build();
        }

        public User ConstructFullUser(string firstName, string lastName)
        {
            return new User.Builder(firstName, lastName)
                .WithAge(30)
                .WithEmail($"{firstName.ToLower()}.{lastName.ToLower()}@demo.com")
                .WithPhoneNumber("123-456-7890")
                .WithAddress("123 Main St, Anytown, USA")
                .WithGender(Gender.Male)
                .Build();
        }
    }
}
