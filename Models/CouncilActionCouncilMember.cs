using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityHallTracker.Models

{
  [Index(nameof(CouncilMemberId), nameof(CouncilActionId), IsUnique = true)]
  public class CouncilActionCouncilMember
    {       
      public int CouncilActionCouncilMemberId { get; set; }
      public int CouncilMemberId { get; set; }
      public int CouncilActionId { get; set; }
      public virtual CouncilMember CouncilMember { get; set; }
      public virtual CouncilAction CouncilAction { get; set; }
    }
}