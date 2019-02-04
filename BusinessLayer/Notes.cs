namespace BusinessLayer
{
    /// <summary>
    /// class used for Notes related CRUD operation
    /// </summary>
    public class Notes
    {
        public int Note_Id { get; set; }
        public string Note_Title { get; set; }
        public string Note_Body { get; set; }
        public int Note_UserId { get; set; }
        public string Note_UserName { get; set; }

    }
}
