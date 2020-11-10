using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Services
{
    public class SingleService
    {
        public SingleService(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string GetName()
        {
            return $"你的名字是：{Name}";
        }
    }
}
