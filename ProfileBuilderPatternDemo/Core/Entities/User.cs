using ProfileBuilderPatternDemo.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileBuilderPatternDemo.Core.Entities
{
    public class User
    {
        // Required properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Optional properties
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }

        private User() { }
        public class Builder
        {
            private readonly User _user = new User();
            public Builder(string firstName, string lastName)
            {
                _user.FirstName = firstName;
                _user.LastName = lastName;
            }

            public Builder WithAge(int age)
            {
                _user.Age = age;
                return this;
            }

            public Builder WithEmail(string email)
            {
                _user.Email = email;
                return this;
            }

            public Builder WithPhoneNumber(string phoneNumber)
            {
                _user.PhoneNumber = phoneNumber;
                return this;
            }

            public Builder WithAddress(string address)
            {
                _user.Address = address;
                return this;
            }

            public Builder WithGender(Gender gender)
            {
                _user.Gender = gender;
                return this;
            }

            public User Build()
            {
                return _user;
            }
        }
    }
}
