using System;
using System.Collections.Generic;
using System.Text;

namespace Nishaan.Solutions.Core.Models.EntityBase
{
    public class EntityBase
    {
        public DateTime? Created { get; set; }

        public DateTime? Updated { get; set; }

        public bool Deleted { get; set; }

        public EntityBase()
        {
            Deleted = false;
        }

        public virtual int IdentityID()
        {
            return 0;
        }

        public virtual object[] IdentityID(bool dummy = true)
        {
            return new List<object>().ToArray();
        }
    }
}