using System.Collections.Generic;

namespace solid.example.ISP.good
{
    public interface IQueryReadDao<TConcept>
    {
        IList<TConcept> GetAll();
    }
}