using Lesson04.Models.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Lesson04.Controllers
{
    public class MemberController : Controller
    {
        private static readonly List<Member> members = new List<Member>()
        {
            new Member
            {
                MemberId = Guid.NewGuid().ToString(),
                UserName = "member1",
                Password = "1234",
                Email = "Member1@gmail.com"
            },
             new Member
            {
                MemberId = Guid.NewGuid().ToString(),
                UserName = "member2",
                Password = "1234",
                Email = "Member2@gmail.com"
            },
              new Member
            {
                MemberId = Guid.NewGuid().ToString(),
                UserName = "member3",
                Password = "1234",
                Email = "Member3@gmail.com"
            },
               new Member
            {
                MemberId = Guid.NewGuid().ToString(),
                UserName = "member4",
                Password = "1234",
                Email = "Member4@gmail.com"
            },
        };



        // GET: MemberController
        public ActionResult Index()
        {
            return View(members);
        }

        // GET: MemberController/Details/5
        public ActionResult Details(string GuidId)
        {
            var result = members.Find(x => x.MemberId == GuidId);
            return View(result);
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            try
            {
                member.MemberId = Guid.NewGuid().ToString();
                members.Add(member);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(string GuidId)
        {
            Console.WriteLine(GuidId);
            var ItemMember = members.FirstOrDefault(x => x.MemberId == GuidId);

            return View(ItemMember);
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Member member)
        {
            try
            {
                members.Remove(members.Find(x => x.MemberId == member.MemberId));
                members.Add(member);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MemberController/Delete/5
        public ActionResult Delete(string GuidId)
        {
            if (GuidId != null)
            {
                var ItemMember = members.FirstOrDefault(x => x.MemberId == GuidId);
                if (ItemMember != null)
                {
                    members.Remove(ItemMember);
                }
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
