using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUD.Interface
{
    public interface IDbFunctions<T>
    {
        public void GetAll();
        public void AddData(T DataWrite);

        public void DeleteData(int Id);
        public void UpdateData(T DataWrite);
    }
}
