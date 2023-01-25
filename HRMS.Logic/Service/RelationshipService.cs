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
    public class RelationshipService : IRelationship

    {
        HRMSContext _hRMSContext;
        IMapper _mapper;
        
        public RelationshipService(HRMSContext hRMSContext,IMapper mapper)
        {
            _hRMSContext = hRMSContext;
            _mapper=mapper;
        }

        public void DeleteRelationship(int id)
        {
            try
            {

                var record = _hRMSContext.Relationship.Where(x => x.Id == id).FirstOrDefault();
                if (record != null)

                {
                    _hRMSContext.Relationship.Remove(record);
                    _hRMSContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Record NOt Found");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public RelationshipVM GetRelationshipByid(int id)
        {
            try
            {
                var data= _mapper.Map<RelationshipVM>(_hRMSContext.Relationship.Where(x => x.Id == id).FirstOrDefault());
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

        public List<RelationshipVM> RelationshipList()
        {
            try
            {
                return _mapper.Map<List<RelationshipVM>>(_hRMSContext.Relationship.ToList());


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void SaveRelationship(RelationshipVM obj)
        {
            try
            {
                var relation = _mapper.Map<Relationship>(obj);
                _hRMSContext.Relationship.Add(relation);
                _hRMSContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateRelationship(RelationshipVM obj)
        {
            try
            {
                var update = _mapper.Map<Relationship>(obj);
                var record = _hRMSContext.Relationship.Where(x => x.Id == obj.Id).AsNoTracking().FirstOrDefault();
                if (record != null)
                {
                    _hRMSContext.Relationship.Update(update);
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
