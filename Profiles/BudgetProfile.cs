using AutoMapper;
using PjtFinanceSee.Model;
using PjtFinanceSee.DTOs;
using PjtFinanceSee.DTOs.FinancialGoal;
using PjtFinanceSee.DTOs.Budget;

namespace PjtFinanceSee.Profiles;

public class BudgetProfile : Profile
{
    public BudgetProfile()
    {
        CreateMap<BudgetCreateDTO, Budget>();
        CreateMap<BudgetUpdateDTO, Budget>();
        CreateMap<Budget, BudgetResponseDTO>();
    }
}
