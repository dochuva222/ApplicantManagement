using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantManagement.DataBase
{
    public partial class Speciality
    {
        public string SpecialityFullName
        {
            get
            {
                string specialityFullName = $"{this.Name} ({this.FormOfEducation.Name}, {this.PlaceNumber} мест,";
                if (this.IsBudgetForm)
                    specialityFullName += " Бюджет)";
                else
                    specialityFullName += " Коммерция)";
                return specialityFullName;
            }
        }
    }
}
