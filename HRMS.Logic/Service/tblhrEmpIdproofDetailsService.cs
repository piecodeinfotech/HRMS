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
    public class tblhrEmpIdproofDetailsService : IEmpIdProofDetails
    {

        HRMSContext _hRMSContext;
        IMapper _mapper;
        public tblhrEmpIdproofDetailsService(HRMSContext hRMSContext, IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper = mapper;

        }
        public void DeleteEmpIdproofDetails(int id)
        {
            try
            {

                var record = _hRMSContext.EmpIdProofDetails.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.EmpIdProofDetails.Remove(record);
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

        public List<tblhrEmpIdproofDetailsVM> EmpIdproofDetailsList()
        {
            try
            {
                return _mapper.Map<List<tblhrEmpIdproofDetailsVM>>(_hRMSContext.EmpIdProofDetails.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public tblhrEmpIdproofDetailsVM GetEmpIdproofDetailsByid(int id)

        {
            try
            {
                var data = _mapper.Map<tblhrEmpIdproofDetailsVM>(_hRMSContext.EmpIdProofDetails.Where(x => x.Id == id).FirstOrDefault());
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

        public void SaveEmpIdproofDetails(tblhrEmpIdproofDetailsVM obj)
        {
            try
            {
                var empIdProofDetails = _mapper.Map<tblhrEmpIdProofDetails>(obj);
                _hRMSContext.EmpIdProofDetails.Add(empIdProofDetails);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void UpdateEmpIdproofDetails(tblhrEmpIdproofDetailsVM obj)
        {
            try
            {
                var update = _mapper.Map<tblhrEmpIdProofDetails>(obj);
                var record = _hRMSContext.EmpIdProofDetails.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.EmpIdProofDetails.Update(update);
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
