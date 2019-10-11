using LdapForNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var con = new LdapConnection())
            {
                con.Connect("docker.host.internal", 50000);
                con.Bind();
                Console.WriteLine("OK");
            }
        }
    }
}
