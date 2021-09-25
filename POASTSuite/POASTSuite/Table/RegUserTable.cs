using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.Table
{
    class RegUserTable
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Matricno { get; set; }
    }
}
