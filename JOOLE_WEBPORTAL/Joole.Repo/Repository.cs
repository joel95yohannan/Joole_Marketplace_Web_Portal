using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joole.Data;
/*Uses Data Context Class(JooleModel.Context.cs) From Joole.Data*/

namespace Joole.Repo
{
    public class Repository<T> : IRepository<T> where T : tblUser //Repository Class Implements The Interface
                                                                  //WHERE T is tblUser TEMPORARY To See If It WORKS !!!!!!!!!!
    {
        private readonly JooleDataBaseEntities context;
        private readonly DbSet<T> entities;

        public Repository(JooleDataBaseEntities context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public IEnumerable<T> getAll()
        {
            return entities.AsEnumerable();
        }

        public T Get(int id)
        {
            return entities.SingleOrDefault(s => s.UserID == id);
        }
    }
}