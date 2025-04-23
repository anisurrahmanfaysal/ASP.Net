using Demo.Infrastructure.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Seeds
{
    public static class RoleSeed
    {
        public static ApplicationRole[] GetRoles()
        {
            return [
                new ApplicationRole
                {
                    Id = new Guid("63F5EAD6-4119-4063-9F64-82DF67DE00D4"),
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = new DateTime(2025, 4, 19, 1, 2, 1).ToString(),
                },
                new ApplicationRole
                {
                    Id = new Guid("4110987A-9F25-4EA0-A3E1-7CD916BAD7FA"),
                    Name = "HR",
                    NormalizedName = "HR",
                    ConcurrencyStamp = new DateTime(2025, 4, 19, 1, 2, 3).ToString(),
                },
                new ApplicationRole
                {
                    Id = new Guid("630D47DD-8932-434D-ABCD-FCD1EDE0E37C"),
                    Name = "Author",
                    NormalizedName = "AUTHOR",
                    ConcurrencyStamp = new DateTime(2025, 4, 19, 1, 2, 4).ToString(),
                }
            ];
        }
    }
}
