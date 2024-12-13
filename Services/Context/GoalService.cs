using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using seiteAPI.Models;

namespace seiteAPI.Services.Context
{
    public class GoalService
    {
        private readonly DataContext _context;

         public GoalService(DataContext context)
    {
        _context = context;
    }

    public bool AddGoal(GoalsModel newGoal)
    {
        bool result = false;
        _context.Add(newGoal);
        result = _context.SaveChanges() != 0;
        return result;
    }

    public bool DeleteGoal(int GoalToDeleteId)
    {
        bool result = false;
        GoalsModel foundGoal = GetGoalById(GoalToDeleteId);
        if(foundGoal != null)
        {
            _context.Remove<GoalsModel>(foundGoal);
            result = _context.SaveChanges() !=0;
        }
        return result;
    }
    public IEnumerable<GoalsModel> GetAllGoals()
    {
        return _context.GoalInfo;
    }

    public GoalsModel GetGoalById(int id)
    {
        return _context.GoalInfo.SingleOrDefault(goal => goal.Id == id);
    }

    public IEnumerable<GoalsModel>GetGoalByStudentId(int goalId)
        {
            return _context.GoalInfo.Where(goal => goal.StudentId == goalId);
        }
    }

    
   
}