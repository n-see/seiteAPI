using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using seiteAPI.Models;
using seiteAPI.Services.Context;
using Microsoft.EntityFrameworkCore;

namespace seiteAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GoalsController : ControllerBase
    {
        private readonly GoalService _data;

        public GoalsController(GoalService dataFromService)
        {
            _data = dataFromService;
        }
        [HttpGet("GetAllGoals")]
        public IEnumerable<GoalsModel> GetAllGoals()
        {
            return _data.GetAllGoals();
        }

        [HttpGet("GetGoalsByStudentId/{StudentId}")]
        public IEnumerable<GoalsModel> GetGoalsByStudentId(int StudentId)
        {
            return _data.GetGoalByStudentId(StudentId);
        }
        [HttpPost("AddGoal")]
        public bool AddGoal(GoalsModel GoalToAdd)
        {
            return _data.AddGoal(GoalToAdd);
        }

         [HttpPost("DeleteGoal/{GoalToDelete}")]
        public bool DeleteGoal(GoalsModel GoalToDelete)
        {
            return _data.DeleteGoal(GoalToDelete);
        }
    }
}