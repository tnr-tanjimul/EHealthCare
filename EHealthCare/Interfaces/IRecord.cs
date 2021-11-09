using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHealthCare.Interfaces
{


    public interface IRecord<TypeEntity> where TypeEntity : class
    {
        //List<TypeEntity> GetAll();
        List<TypeEntity> Get(int id);
        int Insert(TypeEntity entity);
        int Update(TypeEntity entity);
        int Delete(int id);

    }
}
