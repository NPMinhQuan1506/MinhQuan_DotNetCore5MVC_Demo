using System;
using System.Collections.Generic;

#nullable disable

namespace MinhQuan_DotNetCoreMVC5_Demo.Models.Entities
{
    public partial class DemoUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
