using csharp_Mysql_Sample.Controllers.Data;
using csharp_Mysql_Sample.DataAccess.V1;
using Microsoft.AspNetCore.Mvc;

namespace csharp_Mysql_Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleTestController : ControllerBase
    {
        private readonly IMySqlClient mySqlClient;

        public SampleTestController(IMySqlClient sqlClient)
        {
            mySqlClient = sqlClient;
        }

        [HttpGet(Name = "GetSampleTest")]
        public IEnumerable<SampleTest> Get()
        {
            mySqlClient.Connect();
            var result = mySqlClient.ExecuteSql<SampleTest>("select id as Id, user_id as UserId, name as Name, create_user_id as CreateUserId, create_date as CreateDate, update_user_id as UpdateUserId, delete_user_id as DeleteUserId, delete_date as DeleteDate, delete_flg as DeleteFlg from SampleTable;");
            return result;
        }
    }
}