using AutoMapper;
using HRMS.Logic.Database;
using HRMS.Logic.Database.Entities;
using HRMS.Logic.Interface;
using HRMS.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Service
{
    public class ProductionsService : IProductions
    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        public ProductionsService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;
        }
    
        public void DeleteProductions(int id)
        {
            try
            {

                var record = _hRMSContext.Productions.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.Productions.Remove(record);
                    _hRMSContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Record Not Found");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<ProductionsVM> ProductionsList()
        {
            return _mapper.Map<List<ProductionsVM>>(_hRMSContext.Productions.ToList());
        }

        public ProductionsVM GetProductionsByid(int id)
        {
            try
            {
                var data = _mapper.Map<ProductionsVM>(_hRMSContext.Productions.Where(x => x.Id == id).FirstOrDefault());
                if (data == null)
                {
                    throw new Exception("Invalid Id");
                }
                return data;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public void SaveProductions(ProductionsVM obj)
        {
            try
            {
                var productions  = _mapper.Map<Productions>(obj);
                _hRMSContext.Productions.Add(productions);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateProductions(ProductionsVM obj)
        {
            try
            {
                var update = _mapper.Map<Productions>(obj);
                var record = _hRMSContext.Productions.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.Productions.Update(update);
                    _hRMSContext.SaveChanges();

                }
                else
                {
                    throw new Exception("Reocord Not Update");
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}