using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleViewerForm
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "POS";

        public void CreateAccount(Account model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Username", model.Username);
                param.Add("@Password", model.Password);
                param.Add("@AccountID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spAccounts_Insert", param, commandType: CommandType.StoredProcedure);

                model.AccountId = param.Get<int>("@AccountID");
            }
        }
    }
}
