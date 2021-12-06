using ApplicantManagement.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantManagement.Models
{
    public static class GlobalSettings
    {
        public static EducationEntities DB = new EducationEntities();
        public static User LoggedUser;
    }
}
