using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateApp.Entities;

namespace DateApp.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}