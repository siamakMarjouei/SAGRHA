using System.Collections.Generic;
using System.Threading.Tasks;
using SAGRHA.API.Helpers;
using SAGRHA.API.Models;

//TODO change this Interface and implementation to current program
namespace SAGRHA.API.Data
{
    public interface ISagrhaRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<PagedList<User>> GetUsers( UserParams userParams);
         Task<User> GetUser(int id);
         Task<Photo> GetPhoto(int id);
         Task<Photo> GetMainPhotoForUser(int userId);
         Task<List<Employee>> GetEmployees();
         Task<bool> EmployeeExist(string DNI);
         
    }
}