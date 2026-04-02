using AutoMapper;
using PjtFinanceSee.DTOs.FinancialGoal;
using PjtFinanceSee.Model;
using PjtFinanceSee.Repository;

namespace PjtFinanceSee.Service;

public class FinancialGoalService
{

    private readonly FinancialGoalRepo _repository;
    private readonly IMapper _mapper;

    public FinancialGoalService(FinancialGoalRepo repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<FinancialGoalResponseDTO>> GetAllFinancialGoalPaged (int Skip, int Take)
    {

        var ListFGs = await _repository.GetAllPaged(Skip, Take);

        List<FinancialGoalResponseDTO> ListDTO = [];

        foreach (var item in ListFGs)
        {
            var dto =_mapper.Map<FinancialGoalResponseDTO>(item);
            ListDTO.Add(dto);
        }


        return ListDTO;

    }

}

