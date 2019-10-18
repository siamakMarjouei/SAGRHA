using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SAGRHA.API.Helpers;
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

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);

            return user;
        }

        public async Task<PagedList<User>> GetUsers(UserParams userParams)
        {
            var users = _context.Users.Include(p => p.Photos).AsQueryable();

            users = users.Where(u => u.Id != userParams.UserId);

            users = users.Where(u => u.Gender == userParams.Gender);

            return await PagedList<User>.CreateAsync(users, userParams.PageNumber, userParams.PageSize);
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
            
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
            return await _context.Photos.Where(u => u.UserId == userId)
                .FirstOrDefaultAsync(p => p.IsMain);
        }

        public async Task<bool> EmployeeExist(string DNI)
        {
            if (await _context.Employees.AnyAsync(e => e.DNI == DNI))
                return true;
            return false;

        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.Id==id);
        }

        public async Task<Relative> GetRelative(int id)
        {
            var relative = await _context.Relatives.FirstOrDefaultAsync(r => r.Id == id);

            return relative;
        }
    }
}