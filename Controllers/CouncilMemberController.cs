using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

using CityHallTracker.Models;

namespace CityHallTracker.Controllers
{
  [Authorize]
  public class CouncilMembersController : Controller
  {
    private readonly CityHallTrackerContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public CouncilMembersController(UserManager<ApplicationUser> userManager, CityHallTrackerContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId); 
      var userCouncilMembers = _db.CouncilMembers.Where(entry => entry.User.Id == currentUser.Id).ToList();
      return View (userCouncilMembers);
    }

    public ActionResult Create()
    {
      ViewBag.CouncilActionId = new SelectList(_db.CouncilActions, "CouncilActionId", "CouncilActionName");
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(CouncilMember CouncilMember, int CouncilActionId)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      CouncilMember.User = currentUser;
      _db.CouncilMembers.Add(CouncilMember);
      _db.SaveChanges();
      if (CouncilActionId != 0)
      {
        _db.CouncilActionCouncilMember.Add(new CouncilActionCouncilMember() { CouncilActionId = CouncilActionId, CouncilMemberId = CouncilMember.CouncilMemberId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisCouncilMember = _db.CouncilMembers
          .Include(CouncilMember => CouncilMember.JoinEntities)
          .ThenInclude(join => join.CouncilAction)
          .FirstOrDefault(CouncilMember => CouncilMember.CouncilMemberId == id);
      return View(thisCouncilMember);
  }

    public ActionResult Edit(int id)
    {
      var thisCouncilMember = _db.CouncilMembers.FirstOrDefault(CouncilMember => CouncilMember.CouncilMemberId == id);
      ViewBag.CouncilActionId = new SelectList(_db.CouncilActions, "CouncilActionId", "CouncilActionName");
      return View(thisCouncilMember);
    }

    [HttpPost]
    public ActionResult Edit(CouncilMember CouncilMember, int CouncilActionId)
    {
      if (CouncilActionId != 0)
      {
        _db.CouncilActionCouncilMember.Add(new CouncilActionCouncilMember() { CouncilActionId = CouncilActionId, CouncilMemberId = CouncilMember.CouncilMemberId });
      }
      _db.Entry(CouncilMember).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddCouncilAction(int id)
    {
      var thisCouncilMember = _db.CouncilMembers.FirstOrDefault(CouncilMember => CouncilMember.CouncilMemberId == id);
      ViewBag.CouncilActionId = new SelectList(_db.CouncilActions, "CouncilActionId", "CouncilActionName");
      return View(thisCouncilMember);
    }

    [HttpPost]
    public ActionResult AddCouncilAction(CouncilMember CouncilMember, int CouncilActionId)
    {
      if (CouncilActionId != 0)
      {
        _db.CouncilActionCouncilMember.Add(new CouncilActionCouncilMember() { CouncilActionId = CouncilActionId, CouncilMemberId = CouncilMember.CouncilMemberId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
      }

      public ActionResult Delete(int id)
      {
        var thisCouncilMember = _db.CouncilMembers.FirstOrDefault(CouncilMember => CouncilMember.CouncilMemberId == id);
        _db.CouncilMembers.Remove(thisCouncilMember);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }

      [HttpPost, ActionName("Delete")]
      public ActionResult DeleteConfirmed(int id)
      {
        var thisCouncilMember = _db.CouncilMembers.FirstOrDefault(CouncilMember => CouncilMember.CouncilMemberId == id);
        _db.CouncilMembers.Remove(thisCouncilMember);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }

      [HttpPost]
      public ActionResult DeleteCouncilAction(int joinId)
      {
        var joinEntry = _db.CouncilActionCouncilMember.FirstOrDefault(entry => entry.CouncilActionCouncilMemberId == joinId);
        _db.CouncilActionCouncilMember.Remove(joinEntry);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }
}