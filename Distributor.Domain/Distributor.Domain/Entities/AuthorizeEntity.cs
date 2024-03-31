namespace Distributor.Domain.Entities
{
    public class AuthorizeEntity
    {
        #region Properties

        public int Id { get; set; }
        public string? Ip { get; set; }
        public string? KeyPass { get; set; }

        #endregion

        #region Constructors

        public AuthorizeEntity()
        {
            
        }

        public AuthorizeEntity(int id, string? ip, string? key)
        {
            Id = id;
            Ip = ip;
            Key = key;
        }



        #endregion
    }
}
