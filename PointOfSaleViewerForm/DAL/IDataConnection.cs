using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleViewerForm
{
    public interface IDataConnection
    {
        void CreateAccount(Account model);
    }
}
