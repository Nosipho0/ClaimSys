using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ClaimSys.Models;
using System.Collections.Generic;

namespace ClaimSys.Controllers
{
    public class AccountController : Controller
    {
        // Demo in-memory user list
        private static List<User> users = new List<User>();

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            User user = users.Find(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                HttpContext.Session.SetString("Username", user.Username);
                HttpContext.Session.SetString("Role", user.Role ?? "Lecturer");
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Message = "Invalid username or password!";
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string username, string password, string role)
        {
            users.Add(new User
            {
                Username = username,
                Password = password,
                Role = role
            });

            ViewBag.Message = "Registration successful! Please login.";
            return RedirectToAction("Login");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
