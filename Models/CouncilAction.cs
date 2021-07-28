using System.Collections.Generic;
using System.Collections;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityHallTracker.Models
{
    public class CouncilAction
    {
      public CouncilAction()
      {
        this.JoinEntities = new HashSet<CouncilActionCouncilMember>();
      }

      public virtual ApplicationUser User { get; set; }

      [Required]
      public int CouncilActionId { get; set; }
      public string CouncilActionTitle { get; set; }
      public string CouncilActionDate { get; set; }
      public string CouncilActionTag { get; set; }
      public string CouncilActionContextLink { get; set; }

      public virtual ICollection<CouncilActionCouncilMember> JoinEntities { get; set; }
    }
}