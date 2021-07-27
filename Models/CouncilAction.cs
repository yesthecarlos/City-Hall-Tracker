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

      [Display(Name="Action Id")]
      public int CouncilActionId { get; set; }

      [Display(Name="Action Title")]
      public string CouncilActionTitle { get; set; }

      public string CouncilActionTags { get; set; }
      public string CouncilActionYeas { get; set; }
      public string CouncilActionNays { get; set; }
      public string CouncilActionAbstain { get; set; }

      public virtual ICollection<CouncilActionCouncilMember> JoinEntities { get; set; }
    }
}