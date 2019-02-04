using System.Collections.Generic;
using BusinessLayer;
using DataAccessLayer;
using Dapper;
namespace Services
{
    /// <summary>
    /// Service class used for Notes related operation
    /// </summary>
    public class NoteService
    {
        IRepository<Notes> repository = null;

        /// <summary>
        /// Constructor which initialize repository for database operation
        /// </summary>
        public NoteService()
        {
            repository = new Repository<Notes>();
        }

        /// <summary>
        /// Get All Notes data 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Notes> GetNotes()
        {            
            var result = repository.GetAll("Notes_GetAll", null);                    
            return result;            
        }

        /// <summary>
        /// Delete Note
        /// </summary>
        /// <param name="id"></param>
        public void DeleteNotes(int id)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("NoteId", id);
            repository.Delete("Notes_Delete_ById", dynamicParameters);
        }

        /// <summary>
        /// Get Note By passing Id value
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Notes GetNotesById(int id)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("NoteId", id);
            Notes notes = repository.GetByParam("Notes_GetById", dynamicParameters);
            return notes;
        }

        /// <summary>
        /// Update note by passing required parameter
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="body"></param>
        public void UpdateNote(int id, string title,string body)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@Id", id);
            dynamicParameters.Add("@Title", title);
            dynamicParameters.Add("@Body", body);
            repository.UpdateByParams("Notes_UpdateByParam", dynamicParameters);
        }

        /// <summary>
        /// Insert Note
        /// </summary>
        /// <param name="title"></param>
        /// <param name="body"></param>
        /// <param name="userId"></param>
        public void InsertNote(string title, string body, int userId)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();            
            dynamicParameters.Add("@Title", title);
            dynamicParameters.Add("@Body", body);
            dynamicParameters.Add("@UserId", userId);
            repository.UpdateByParams("Notes_InsertByParam", dynamicParameters);
        }
    }
}
