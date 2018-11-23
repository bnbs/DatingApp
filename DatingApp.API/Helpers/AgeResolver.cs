using AutoMapper;
using DatingApp.API.Models;

namespace DatingApp.API.Helpers
{
    public class AgeResolver : IValueResolver<User, object, int>
    {
        public int Resolve(User user, object dest, int destMember, ResolutionContext context) 
        {
            return user.DateOfBirth.CalculateAge();
        }
    }
}