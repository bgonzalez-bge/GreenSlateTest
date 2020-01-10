using GreenSlateChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenSlateChallenge.Services
{
    public interface IDataService
    {
        IEnumerable<User> GetAllUsers();
        IEnumerable<ProjectViewModel> GetProjectsByUser(int userId);
    }
}