using System.Collections.Generic;
using System.Collections;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityHallTracker.Models
{
    public class CouncilMember
    {
      public CouncilMember()
      {
        this.JoinEntities = new HashSet<CouncilActionCouncilMember>();
      }

      public virtual ApplicationUser User { get; set; }

      public int CouncilMemberId { get; set; }

      [Display(Name="Councilmember")]
      [Required]
      public string CouncilMemberName { get; set; }

      [Display(Name="District")]
      public int CouncilMemberDistrict { get; set; }

      [Display(Name="Sworn In")]
      public string CouncilMemberStartDate { get; set; }

      [Display(Name="End of Term")]
      public string CouncilMemberEndDate { get; set; }
      
      public string CouncilMemberPhoto { get; set; }
      public virtual ICollection<CouncilActionCouncilMember> JoinEntities { get; set; }
    }
}