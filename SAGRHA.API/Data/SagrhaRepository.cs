using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SAGRHA.API.Models;

//TODO Change this Repository and IDatingRepository to current program
namespace SAGRHA.API.Data
{

    public class SagrhaRepository : ISagrhaRepository
    {
        private readonly DataContext _context;
        public SagrhaRepository(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<User> GetById(int id)
        {
            var user = await _context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);

            return user;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var users = await _context.Users.Include(p => p.Photos).ToListAsync();
            
            return users;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Photo> GetPhoto(int id)
        {
            var photo = await _context.Photos.FirstOrDefaultAsync(p => p.Id == id);

            return photo;
        }

        public async Task<Photo> GetMainPhotoForUser(int userId)
        {
            return await _context.Photos.Where( u => u.UserId == userId)
                .FirstOrDefaultAsync(p => p.IsMain);
        }
    }
}