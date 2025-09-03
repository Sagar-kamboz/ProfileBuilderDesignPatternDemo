using ProfileBuilderPatternDemo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileBuilderPatternDemo.Core.Interfaces
{
    public interface IUserDirector
    {
        User ConstructBasicUser(string firstName, string lastName);
        User ConstructFullUser(string firstName, string lastName);
    }
}
