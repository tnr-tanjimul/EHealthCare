using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHealthCare.Interfaces
{
    public interface IRepository<TypeEntity> where TypeEntity : class
    {
        List<TypeEntity> GetAll();
        TypeEntity Get(int id);
        int Insert(TypeEntity entity);
        int Update(TypeEntity entity);
        int Delete(int id);

    }
}