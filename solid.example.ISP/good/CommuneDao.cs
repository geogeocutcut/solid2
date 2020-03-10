using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace solid.example.ISP.good
{
    public class CommuneDao:IQueryReadDao<Commune>
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
    }
}
