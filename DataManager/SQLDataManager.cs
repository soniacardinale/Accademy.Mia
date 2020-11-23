using Academy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class SQLDataManager : IDataManager
    {
        private string connectionstring = "";
        public DataOperationResult CreateNewCliente(Cliente newCliente)
        {
            throw new NotImplementedException();
        }

        public ContoCorrente GetContocorrenteByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public bool LoginIsOK(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool UserIsAnOwner(string username)
        {
            throw new NotImplementedException();
        }
    }
}
