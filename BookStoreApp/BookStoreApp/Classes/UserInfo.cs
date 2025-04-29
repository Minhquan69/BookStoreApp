using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCounterFinalProject.Classes
{
    internal class UserInfo
    {
        public string MaUser { get; set; }
        public string TenUser { get; set; }
        public UserInfo() { }
        public UserInfo(string ma, string ten) {
            MaUser = ma;
            TenUser = ten;
        }
        

    }
}
