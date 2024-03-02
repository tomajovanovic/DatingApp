using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateApp.Entities
{
    public class AppUser
    {

        //[Key] ne treba nam jer po konvenciji pri privodjenju u db zna da je ovo primary key
        public int Id { get; set; }
        public string UserName { get; set; } // ? znaci da je optional jer je string required ili iskljucim u csproj nullable
    }
}