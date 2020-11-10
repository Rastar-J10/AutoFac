using Autofac.Features.AttributeFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace WebApplication2.Services
{
    public class TestService:ITestService
    {
        //单例注入
        private readonly SingleService _lbw;
        private readonly SingleService _xmz;
        //构造函数
        public TestService([KeyFilter("lbw")] SingleService lbw,[KeyFilter("xmz")] SingleService xmz)
        {
            _lbw = lbw;
            _xmz = xmz;
        }

        string ITestService.Dzh()
        {
            return "愿指引明路的苍蓝星为你闪耀";
        }

        string ITestService.GetName(string key)
        {
            if (key == "lbw")
            {
                return _lbw.GetName();
            }
            else if(key == "xmz")
            {
                return _xmz.GetName();
            }
            else
            {
                return "Not Know";
            }
        }
    }
}
