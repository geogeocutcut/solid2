using System.Collections.Generic;

namespace solid.example.ISP.good
{
    public interface IQueryDao<TConcept>:IQueryReadDao<TConcept>
    {
        void Insert(TConcept exp);
        void Update(TConcept exp);
        void Delete(TConcept exp);
        
    }
}