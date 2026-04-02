using AutoMapper;
using PjtFinanceSee.Model;
using PjtFinanceSee.DTOs;
using PjtFinanceSee.DTOs.FinancialGoal;

namespace PjtFinanceSee.Profiles;

public class FinancialGoalProfile : Profile
{
    public FinancialGoalProfile()
    {
        CreateMap<UserCreateDTO, User>();
        CreateMap<FinancialGoalUpdateDTO, User>();
        CreateMap<User, FinancialGoalResponseDTO>();
    }
}
