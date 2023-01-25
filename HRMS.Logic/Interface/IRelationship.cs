using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Logic.Interface
{
    public interface IRelationship
    {
        void SaveRelationship(RelationshipVM obj);
        void UpdateRelationship(RelationshipVM obj);
        void DeleteRelationship(int id);
        RelationshipVM GetRelationshipByid(int id);
        List<RelationshipVM> RelationshipList();
    }
}
