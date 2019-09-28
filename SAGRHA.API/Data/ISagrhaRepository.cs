using System.Collections.Generic;
using System.Threading.Tasks;
using SAGRHA.API.Models;

//TODO change this Interface and implementation to current program
namespace SAGRHA.API.Data
{
    public interface ISagrhaRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetAll();
         Task<User> GetById(int id);
         Task<Photo> GetPhoto(int id);
         Task<Photo> GetMainPhotoForUser(int userId);
    }
}