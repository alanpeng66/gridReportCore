using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult GetReportData()
        {
            return Content(GetJsonStr());
        }

        private string GetJsonStr()
        {
            return "{\"Table\": [{\"CustomerID\": \"HUNGC\", \"CompanyName\": \"五金机械\", \"ContactName\": \"苏先生\", \"ContactTitle\": \"销售代表\", \"Address\": \"德昌路甲 29 号\", \"City\": \"大连\", \"Region\": \"东北\", \"PostalCode\": \"564576\", \"Country\": \"中国\", \"Phone\": \"(053) 5556874\", \"Fax\": \"(053) 5552376\"}, {\"CustomerID\": \"CENTC\", \"CompanyName\": \"三捷实业\", \"ContactName\": \"王先生\", \"ContactTitle\": \"市场经理\", \"Address\": \"英雄山路 84 号\", \"City\": \"大连\", \"Region\": \"东北\", \"PostalCode\": \"130083\", \"Country\": \"中国\", \"Phone\": \"(061) 15553392\", \"Fax\": \"(061) 15557293\"}, {\"CustomerID\": \"CACTU\", \"CompanyName\": \"威航货运有限公司\", \"ContactName\": \"刘先生\", \"ContactTitle\": \"销售代理\", \"Address\": \"经七纬二路 13 号\", \"City\": \"大连\", \"Region\": \"东北\", \"PostalCode\": \"120412\", \"Country\": \"中国\", \"Phone\": \"(061) 11355555\", \"Fax\": \"(061) 11354892\"}, {\"CustomerID\": \"BLONP\", \"CompanyName\": \"国皓\", \"ContactName\": \"黄雅玲\", \"ContactTitle\": \"市场经理\", \"Address\": \"广发北路 10 号\", \"City\": \"大连\", \"Region\": \"东北\", \"PostalCode\": \"565479\", \"Country\": \"中国\", \"Phone\": \"(0671) 88601531\", \"Fax\": \"(0671) 88601532\"}, {\"CustomerID\": \"MEREP\", \"CompanyName\": \"华科\", \"ContactName\": \"吴小姐\", \"ContactTitle\": \"市场助理\", \"Address\": \"和光北路 952 号\", \"City\": \"大连\", \"Region\": \"东北\", \"PostalCode\": \"280235\", \"Country\": \"中国\", \"Phone\": \"(0514) 5558054\", \"Fax\": \"(0514) 5558055\"}] }";
        }
    }
}