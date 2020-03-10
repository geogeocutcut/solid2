using System.Collections.Generic;

namespace solid.example.ISP.bad
{
    public interface IQueryDao<TConcept>
    {
        void Insert(TConcept exp);
        void Update(TConcept exp);
        void Delete(TConcept exp);


        IList<TConcept> GetAll();
    }
}