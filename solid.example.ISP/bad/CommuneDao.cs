using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace solid.example.ISP.bad
{
    public class CommuneDao:IQueryDao<Commune>
    {
        public string _FilePath;
        public CommuneDao()
        {
            _FilePath = @"c:\communes.json";
        }

        public IList<Commune> GetAll()
        {
            if(File.Exists(_FilePath))
            { 
                var jsonString = File.ReadAllText(_FilePath);
                return JsonConvert.DeserializeObject<IList<Commune>>(jsonString);
            }
            return new List<Commune>();
        }

        public void Delete(Commune exp)
        {
            throw new System.NotImplementedException();
        }
        

        public void Insert(Commune exp)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Commune exp)
        {
            throw new System.NotImplementedException();
        }
    }
}
