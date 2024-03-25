namespace csharp_Mysql_Sample.Controllers.Data
{
    public class SampleTest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Name { get; set; }
        public int CreateUserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int DeleteUserId { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string? DeleteFlg { get; set; }
    }
}