using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IProductions
    {
        void SaveProductions(ProductionsVM obj);
        void UpdateProductions(ProductionsVM obj);
        void DeleteProductions(int id);
        ProductionsVM GetProductionsByid(int id);
        List<ProductionsVM> ProductionsList();
    }
}
