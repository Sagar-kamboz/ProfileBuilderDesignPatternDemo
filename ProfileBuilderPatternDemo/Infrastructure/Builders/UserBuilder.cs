using ProfileBuilderPatternDemo.Core.Entities;
using ProfileBuilderPatternDemo.Core.Enums;
using ProfileBuilderPatternDemo.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileBuilderPatternDemo.Infrastructure.Builders
{
    public class UserBuilder : IUserBuilder
    {
        private readonly User.Builder _builder;
        public UserBuilder(string firstName, string lastName)
        {
            _builder = new User.Builder(firstName, lastName);
        }

        public IUserBuilder WithAge(int age)
        {
            _builder.WithAge(age);
            return this;
        }

        public IUserBuilder WithEmail(string email)
        {
            _builder.WithEmail(email);
            return this;
        }

        public IUserBuilder WithPhoneNumber(string phoneNumber)
        {
            _builder.WithPhoneNumber(phoneNumber);
            return this;
        }

        public IUserBuilder WithAddress(string address)
        {
            _builder.WithAddress(address);
            return this;
        }

        public IUserBuilder WithGender (Gender gender)
        {
            _builder.WithGender(gender);
            return this;
        }

        public User Build()
        {
            return _builder.Build();
        }
    }
}
