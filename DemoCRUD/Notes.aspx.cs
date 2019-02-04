using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services;
using BusinessLayer;
using System.Web.Services;

namespace DemoCRUD
{
    /// <summary>
    /// Used for Notes related CRUD operation
    /// </summary>
    public partial class Notes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Fetch Notes
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public static string GetNotes()
        {
            try
            {
                NoteService noteService = new NoteService();
                IEnumerable<BusinessLayer.Notes> notes = noteService.GetNotes();
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                return serializer.Serialize(notes);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Delete Notes
        /// </summary>
        /// <param name="id"></param>
        [WebMethod]
        public static void DeleteNotes(int id)
        {
            try
            {
                NoteService noteService = new NoteService();
                noteService.DeleteNotes(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// Get Note object using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public static string GetNotesById(int id)
        {
            try
            {
                NoteService noteService = new NoteService();
                BusinessLayer.Notes notes = noteService.GetNotesById(id);
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                return serializer.Serialize(notes); ;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Update note 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="body"></param>
        [WebMethod]
        public static void UpdateNotes(int id, string title, string body)
        {
            try
            {
                NoteService noteService = new NoteService();
                noteService.UpdateNote(id, title, body);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// Insert note
        /// </summary>
        /// <param name="title"></param>
        /// <param name="body"></param>
        /// <param name="userId"></param>
        [WebMethod]
        public static void InsertNotes(string title, string body, int userId)
        {
            try
            {
                NoteService noteService = new NoteService();
                noteService.InsertNote(title, body, userId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}