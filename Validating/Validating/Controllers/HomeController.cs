using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validating.Models;

namespace Validating.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(MemberRepository.Members);
        }

        public ActionResult Create()
        {
            if (ModelState.IsValid)
            {
                Response.Write("Model Is Valid");
            }
            else
            {
                Response.Write("Model is NOT Valid");
            }
            return View(new Member());
        }

        [HttpPost]
        public ActionResult Create(Member member)
        {
            MemberRepository.Members.Add(member);
            return RedirectToAction("Index");
        }

        public ActionResult CheckName(Member member)
        {
            if (member.MemberName.Contains("a"))
            {
                return Json(string.Format("{0} is reserved, enter another name", member.MemberName), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult CheckNickname(Member member)
        {
            if (member.NickName.Contains("a"))
            {
                return Json(string.Format("{0} is reserved, enter another nickname", member.NickName), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult CheckSalary(Member member)
        {
            if (member.Salary < 10000)
            {
                return Json(string.Format("{0} Is really too little", member.Salary), JsonRequestBehavior.AllowGet);
            }
            if (member.Salary > 1000000)
            {
                return Json("You are exagerating. Nobody should learn more than 1 million", JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }


    }
}