using ProfileBuilderPatternDemo.Core.Entities;
using ProfileBuilderPatternDemo.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileBuilderPatternDemo.Core.Interfaces
{
    public interface IUserBuilder
    {
        IUserBuilder WithAge(int age);
        IUserBuilder WithEmail(string email);
        IUserBuilder WithPhoneNumber(string phoneNumber);
        IUserBuilder WithAddress(string address);
        IUserBuilder WithGender(Gender gender);
        User Build();
    }
}
