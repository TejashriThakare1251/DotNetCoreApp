﻿using System;
using System.Collections.Generic;

namespace DotNetCoreApp.Database
{
    public partial class TblUserRegsitration
    {
        public TblUserRegsitration()
        {
            TblSetEvents = new HashSet<TblSetEvent>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Gender { get; set; }
        public string Password { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual TblGender GenderNavigation { get; set; } = null!;
        public virtual ICollection<TblSetEvent> TblSetEvents { get; set; }
    }
}
