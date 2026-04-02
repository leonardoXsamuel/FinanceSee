using AutoMapper;
using FinanceSee.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using PjtFinanceSee.DTOs.User;
using PjtFinanceSee.Model;

namespace PjtFinanceSee.Repository;

public class FinancialGoalRepo
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public FinancialGoalRepo(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<FinancialGoal> CreateFinancialGoal(FinancialGoal fg)
    {
        _context.FinancialGoals.Add(fg);
        await _context.SaveChangesAsync();

        return fg;

        //FinancialGoalResponseDTO dto = _mapper.Map<FinancialGoalResponseDTO>(fg);
        //return dto;
    }

    public async Task DeleteFinancialGoal(FinancialGoal fg)
    {
        _context.FinancialGoals.Remove(fg);
        await _context.SaveChangesAsync();
    }

    public async Task<List<FinancialGoal>> GetAllPaged(int Skip, int Take)
    {
        return await _context
            .FinancialGoals.Skip(Skip).Take(Take).ToListAsync();
    }


    public async Task<FinancialGoal?> GetFinancialGoalById(long Id)
    {
        return await _context.FinancialGoals.FindAsync(Id);
    }

    public async Task<FinancialGoal?> GetFinancialGoalByNameGoal(string NameGoal)
    {
        // criar regra para NameGoal não poder repetir
        return await _context.FinancialGoals
            .FirstOrDefaultAsync(fg => fg.NameGoal == NameGoal);
    }


}
