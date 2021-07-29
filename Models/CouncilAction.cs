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

      [Display(Name="Council Action")]
      public string CouncilActionTitle { get; set; }

      [Display(Name="Date")]
      public string CouncilActionDate { get; set; }

      [Display(Name="Category")]
      public string CouncilActionTag { get; set; }

      [Display(Name="Related News Article")]
      public string CouncilActionContextLink { get; set; }

      public virtual ICollection<CouncilActionCouncilMember> JoinEntities { get; set; }
    }
}