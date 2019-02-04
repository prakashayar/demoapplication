using System.Collections.Generic;
using Dapper;

namespace DataAccessLayer
{
    /// <summary>
    /// Generic Interface for CRUD operations
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T:class
    {        
        /// <summary>
        /// Used for fetch data
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="dynamicParameters"></param>
        /// <returns></returns>
        IEnumerable<T> GetAll(string spName, DynamicParameters dynamicParameters);

        /// <summary>
        /// Get object value using parameters
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="dynamicParameters"></param>
        /// <returns></returns>
        T GetByParam(string spName, DynamicParameters dynamicParameters);

        /// <summary>
        /// Insert operation
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="dynamicParameters"></param>
        void InsertByParams(string spName, DynamicParameters dynamicParameters);

        /// <summary>
        /// Update object using passed parameters
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="dynamicParameters"></param>
        void UpdateByParams(string spName, DynamicParameters dynamicParameters);

        /// <summary>
        /// delete object using parameters
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="dynamicParameters"></param>
        void Delete(string spName, DynamicParameters dynamicParameters);
    }
}
