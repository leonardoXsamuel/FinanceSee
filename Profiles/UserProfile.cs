using AutoMapper;
using PjtFinanceSee.Model;
using PjtFinanceSee.DTOs;
using PjtFinanceSee.DTOs.User;
using PjtFinanceSee.DTOs.Budget;

namespace PjtFinanceSee.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserCreateDTO, User>();
        CreateMap<UserUpdateDTO, User>();
        CreateMap<User, UserResponseDTO>();
    }
}
