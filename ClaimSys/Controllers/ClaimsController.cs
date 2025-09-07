using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ClaimSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClaimSys.Controllers
{
    public class ClaimsController : Controller
    {
        internal static List<System.Security.Claims.Claim> Claims;
        private static List<Claim> claims = new List<Claim>();
        private static int nextId = 1;

        public IActionResult Create()
        {
            string username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Create(string title, string description, decimal amount)
        {
            string username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login", "Account");
            }

            Claim claim = new Claim
            {
                Id = nextId++,
                Username = username,
                Title = title,
                Description = description,
                Amount = amount,
                DateSubmitted = DateTime.Now
            };

            claims.Add(claim);

            return RedirectToAction("History");
        }

        public IActionResult History()
        {
            string username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login", "Account");
            }

            List<Claim> userClaims = claims.Where(c => c.Username == username).ToList();
            return View(userClaims);
        }
    }
}

