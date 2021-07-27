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
      public int CouncilMemberDistrict { get; set; }
      public string CouncilMemberStartDate { get; set; }
      public string CouncilMemberEndDate { get; set; }
      public virtual ICollection<CouncilAction> CouncilActions { get; set; }
    }
}