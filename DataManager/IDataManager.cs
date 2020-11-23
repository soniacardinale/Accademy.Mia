using Academy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public interface IDataManager
    {
        bool LoginIsOK(string username, string password);
        bool UserIsAnOwner(string username);
        DataOperationResult CreateNewCliente(Cliente newCliente);
        ContoCorrente GetContocorrenteByUsername(string username);
    }
}
