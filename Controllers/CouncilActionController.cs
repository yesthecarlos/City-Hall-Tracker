using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using CityHallTracker.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace CityHallTracker.Controllers
{
  [AllowAnonymous]
  public class CouncilActionsController : Controller
  {
    private readonly CityHallTrackerContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public CouncilActionsController(UserManager<ApplicationUser> userManager, CityHallTrackerContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index()
    {
      // var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      // var currentUser = await _userManager.FindByIdAsync(userId);
      var userCouncilActions = _db.CouncilActions.ToList();
      return View(userCouncilActions);
    }

    public ActionResult Create()
    {
      ViewBag.CouncilMemberId = new SelectList(_db.CouncilMembers, "CouncilMemberId", "CouncilMemberName");
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(CouncilAction CouncilAction, int CouncilMemberId)
    {
      // var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      // var currentUser = await _userManager.FindByIdAsync(userId);
      // CouncilAction.User = currentUser;
      _db.CouncilActions.Add(CouncilAction);
      _db.SaveChanges();
      if (CouncilMemberId != 0)
      {
          _db.CouncilActionCouncilMember.Add(new CouncilActionCouncilMember() { CouncilMemberId = CouncilMemberId, CouncilActionId = CouncilAction.CouncilActionId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisCouncilAction = _db.CouncilActions
          .Include(CouncilAction => CouncilAction.JoinEntities)
          .ThenInclude(join => join.CouncilMember)
          .FirstOrDefault(CouncilAction => CouncilAction.CouncilActionId == id);
      return View(thisCouncilAction);
    }

    public ActionResult Edit(int id)
    {
      var thisCouncilAction = _db.CouncilActions.FirstOrDefault(CouncilAction => CouncilAction.CouncilActionId == id);
      ViewBag.CouncilMemberId = new SelectList(_db.CouncilMembers, "CouncilMemberId", "CouncilMemberName");
      return View(thisCouncilAction);
    }

    [HttpPost]
    public ActionResult Edit(CouncilAction CouncilAction, int CouncilMemberId)
    {
      if (CouncilMemberId != 0)
      {
        _db.CouncilActionCouncilMember.Add(new CouncilActionCouncilMember() { CouncilMemberId = CouncilMemberId, CouncilActionId = CouncilAction.CouncilActionId });
      }
      _db.Entry(CouncilAction).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddCouncilMember(int id)
    {
      var thisCouncilAction = _db.CouncilActions.FirstOrDefault(CouncilAction => CouncilAction.CouncilActionId == id);
      ViewBag.CouncilMemberId = new SelectList(_db.CouncilMembers, "CouncilMemberId", "CouncilMemberName");
      return View(thisCouncilAction);
    }

    [HttpPost]
    public ActionResult AddCouncilMember(CouncilAction CouncilAction, int CouncilMemberId)
    {
      if (CouncilMemberId != 0)
      {
      _db.CouncilActionCouncilMember.Add(new CouncilActionCouncilMember() { CouncilMemberId = CouncilMemberId, CouncilActionId = CouncilAction.CouncilActionId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisCouncilAction = _db.CouncilActions.FirstOrDefault(CouncilAction => CouncilAction.CouncilActionId == id);
      return View(thisCouncilAction);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCouncilAction = _db.CouncilActions.FirstOrDefault(CouncilAction => CouncilAction.CouncilActionId == id);
      _db.CouncilActions.Remove(thisCouncilAction);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteCouncilMember(int joinId)
    {
      var joinEntry = _db.CouncilActionCouncilMember.FirstOrDefault(entry => entry.CouncilActionCouncilMemberId == joinId);
      _db.CouncilActionCouncilMember.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}