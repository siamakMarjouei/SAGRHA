using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SAGRHA.API.Models;

namespace SAGRHA.API.Data
{
    public class Seed
    {
        public static void SeedUsers(DataContext context)
        {
            var employeesId = new List<int>();
            var relationTypeId = new List<int>();
            if (!context.Users.Any() && !context.Employees.Any() && !context.Relatives.Any())
            {
                var userData = System.IO.File.ReadAllText("Data/UserSeedData.json");
                var users = JsonConvert.DeserializeObject<List<User>>(userData);

                var employeeData = System.IO.File.ReadAllText("Data/EmployeeSeedData.json");
                var employees = JsonConvert.DeserializeObject<List<Employee>>(employeeData);

                var relationTypeData = System.IO.File.ReadAllText("Data/RelationTypeCatalogData.json");
                var relationTypeCatalogData = JsonConvert.DeserializeObject<List<RelationTypeCatalog>>(relationTypeData);

                var relativeData = System.IO.File.ReadAllText("Data/RelativeSeedData.json");
                var relatives = JsonConvert.DeserializeObject<List<Relative>>(relativeData);

                foreach (var user in users)
                {
                    byte[] passwordHash, passwordSalt;
                    CreatePasswordHash("password", out passwordHash, out passwordSalt);

                    user.PasswordHash = passwordHash;
                    user.PasswordSalt = passwordSalt;
                    user.Username = user.Username.ToLower();
                    context.Users.Add(user);
                }

                foreach (var employee in employees)
                {
                    context.Employees.Add(employee);
                    employeesId.Add(employee.Id);
                }

                foreach (var relationType in relationTypeCatalogData)
                {
                    context.RelationTypes.Add(relationType);
                    relationTypeId.Add(relationType.Id);
                }

                context.SaveChanges();
                var random = new Random();
                foreach (var relative in relatives)
                {

                    // relative.EmployeeId = random.Next(employeesId.Min(), employeesId.Max());
                    // relative.RelationTypeCatalogId = random.Next(relationTypeId.Min(), relationTypeId.Max());
                    relative.EmployeeId = 1;
                    relative.RelationTypeCatalogId= 1;
                    context.Relatives.Add(relative);
                }

                context.SaveChanges();
            }
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

        }
    }
}