using System;
using System.Collections.Generic;

namespace DotNetCoreApp.Database
{
    public partial class TblGender
    {
        public TblGender()
        {
            TblUserRegsitrations = new HashSet<TblUserRegsitration>();
        }

        public int GenderId { get; set; }
        public string Gender { get; set; } = null!;

        public virtual ICollection<TblUserRegsitration> TblUserRegsitrations { get; set; }
    }
}
