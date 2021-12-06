using ApplicantManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantManagement.DataBase
{
    public partial class Application
    {
        public bool IsMine
        {
            get
            {
                return this.UserID == GlobalSettings.LoggedUser.ID;
            }
        }
    }
}
