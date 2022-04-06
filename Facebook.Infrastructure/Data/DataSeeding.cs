using Facebook.Domain.Users.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Infrastructure.Data
{
    public class DataSeeding
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                if (!context.Users.Any())
                {
                    context.Users.AddRange(new List<User>()
                    {
                        new User()
                        {
                            FirstName="Trần",
                            LastName = "Quý Vinh",
                            Email="olivervinh@gmail.com",
                            Birthday = DateTime.Parse("20/07/2000"),
                            Address = "Ấp 4, xã An Thái, huyện Phú giáo, tỉnh Bình Dương",
                            Password = "123456",
                            CreatedDate = DateTime.Now,
                             IsDeleted = false,
                        },
                         new User()
                        {
                            FirstName="Trần",
                            LastName = "Chí Nhân",
                            Email="nhan@gmail.com",
                            Birthday = DateTime.Parse("18/04/2010"),
                            Address = "Ấp 4, xã An Thái, huyện Phú giáo, tỉnh Bình Dương",
                            Password = "123456",
                            CreatedDate = DateTime.Now,
                            IsDeleted = false,
                        },
                           new User()
                        {
                            FirstName="Trần",
                            LastName = "Văn Dũng",
                            Email="dung@gmail.com",
                            Birthday = DateTime.Parse("02/04/1973"),
                            Address = "Ấp 4, xã An Thái, huyện Phú giáo, tỉnh Bình Dương",
                            Password = "123456",
                            CreatedDate = DateTime.Now,
                            IsDeleted = false,
                        },
                             new User()
                        {
                            FirstName="Trần",
                            LastName = "Chí Nhân",
                            Email="nhan@gmail.com",
                            Birthday = DateTime.Parse("18/04/2010"),
                            Address = "Ấp 4, xã An Thái, huyện Phú giáo, tỉnh Bình Dương",
                            Password = "123456",
                            CreatedDate = DateTime.Now,
                            IsDeleted = false,
                        },
                            new User()
                        {
                            FirstName="Hán",
                            LastName = "Thị Quang",
                            Email="quang@gmail.com",
                            Birthday = DateTime.Parse("02/12/1969"),
                            Address = "Ấp 4, xã An Thái, huyện Phú giáo, tỉnh Bình Dương",
                            Password = "123456",
                            CreatedDate = DateTime.Now,
                            IsDeleted = false,
                        },
                    }); ;
                    context.SaveChanges();
                }
             
        
            }
        }
    }
}
