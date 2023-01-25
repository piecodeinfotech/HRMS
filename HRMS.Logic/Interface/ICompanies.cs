using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface ICompanies
    {

        void SaveCompanies(CompaniesVM obj);
        void UpdateCompanies(CompaniesVM obj);
        void DeleteCompanies(int id);
        CompaniesVM GetCompaniesByid(int id);
        List<CompaniesVM> Companieslist();
    }
}
