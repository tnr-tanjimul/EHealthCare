using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHealthCare.Interfaces
{
    

    public interface IPatient<TypeEntity> where TypeEntity : class
    {
        List<TypeEntity> GetAll();
        List<TypeEntity> GetByText(string text);
        int Count();
        int Insert(TypeEntity entity);
        int Update(TypeEntity entity);
        int Delete(int id);

    }
}
