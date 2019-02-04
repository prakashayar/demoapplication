using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;

namespace DataAccessLayer
{
    /// <summary>
    /// Implementation of IRepository interface. Used Dapper ORM
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T> where T : class
    {
        /// <summary>
        /// Implementation of delete object using parameters
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="dynamicParameters"></param>
        public void Delete(string spName, DynamicParameters dynamicParameters)
        {
            Dapper.SqlMapper.Execute(DapperConnection.SqlConnection, spName, dynamicParameters, commandType: CommandType.StoredProcedure, commandTimeout: 15);
        }

        /// <summary>
        /// Implementation of fetch data
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="dynamicParameters"></param>
        /// <returns></returns>
        public IEnumerable<T> GetAll(string spName, DynamicParameters dynamicParameters)
        {
            if (DapperConnection.SqlConnection.State == ConnectionState.Closed)
            {
                DapperConnection.SqlConnection.Open();
            }

            return  SqlMapper.Query<T>(DapperConnection.SqlConnection, spName, dynamicParameters, commandType: CommandType.StoredProcedure, commandTimeout: 15);            

        }

        /// <summary>
        /// Implementation of Get object value using parameters
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="dynamicParameters"></param>
        /// <returns></returns>
        public T GetByParam(string spName, DynamicParameters dynamicParameters)
        {
            return Dapper.SqlMapper.Query<T>(DapperConnection.SqlConnection, spName, dynamicParameters, commandType: CommandType.StoredProcedure, commandTimeout: 15).First();
        }

        /// <summary>
        /// Implementation of Insert operation
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="dynamicParameters"></param>
        public void InsertByParams(string spName, DynamicParameters dynamicParameters)
        {
            Dapper.SqlMapper.Execute(DapperConnection.SqlConnection, spName, dynamicParameters, commandType: CommandType.StoredProcedure, commandTimeout: 15);
        }

        /// <summary>
        /// Implementation of Update object using passed parameters
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="dynamicParameters"></param>
        public void UpdateByParams(string spName, DynamicParameters dynamicParameters)
        {
            Dapper.SqlMapper.Execute(DapperConnection.SqlConnection, spName, dynamicParameters, commandType: CommandType.StoredProcedure, commandTimeout: 15);
        }
    }
}
