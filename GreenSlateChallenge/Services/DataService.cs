using GreenSlateChallenge.Models;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Web;

namespace GreenSlateChallenge.Services
{
    public class DataService : IDataService
    {
        BGE_GreenSlateEntities _dataEntities;

        public DataService(BGE_GreenSlateEntities dataEntities)
        {
            _dataEntities = dataEntities;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _dataEntities.Users;
        }

        public IEnumerable<ProjectViewModel> GetProjectsByUser(int userId)
        {
            var UserProjects = _dataEntities.UserProjects.Where(p => p.UserId == userId).ToList(); ;

            return UserProjects.Select(p => new ProjectViewModel
                                {
                                    Id = p.Project.Id,
                                    StartDate = String.Format("{0:dd MMM yyyy}", p.Project.StartDate),
                                    TimeToStart = (p.Project.StartDate-p.AssignedDate).Days < 0 ? "Started" : (p.Project.StartDate - p.AssignedDate).Days.ToString() + " Days",
                                    EndDate = String.Format("{0:dd MMM yyyy}", p.Project.EndDate),
                                    Credits = p.Project.Credits,
                                    Status = p.isActive ? "Active" : "Inactive"
                                }); 
            
        }
    }
}