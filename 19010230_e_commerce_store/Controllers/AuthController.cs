using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using _19010230_e_commerce_store.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _19010230_e_commerce_store.Controllers
{
    public class AuthController : Controller
    {
        prog7311Task2Context db; // Instance prog7311Task2Context class which extends the DbContext class.

        #region Login Methods
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            // The following code has been adapted from the Microsoft Docs.
            // Author: Microsoft
            // Available at: https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha512?view=netcore-3.1

            byte[] data = Encoding.UTF8.GetBytes(password); // Getting the byte array of the entered password.
            SHA512 shaM = new SHA512Managed(); // Creating a new instance of the SHA512Managed class, used for hashing.
            byte[] result = shaM.ComputeHash(data); // Creating a hash of the password
            password = Convert.ToBase64String(result); // Converting the hash to a string so that it can be stored in the database.

            try
            {
                UserInfo checkIfExists = new UserInfo();
                checkIfExists = await db.UserInfos.Where(x => x.UserEmail.Equals(email) && x.UserPassword.Equals(password)).SingleOrDefaultAsync();
                if (checkIfExists is null)
                {
                    ViewBag.alreadyExists = "Invalid login credentials!";
                    return View("Login");

                }
                else
                {
                    HttpContext.Session.SetString("currentUser", email); // Settings the Session variable currentUser to the successfully loggged in user's email.
                                                                         // This will allow for the retrieval of user specific data throughout the application.

                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception)
            {
                ViewBag.error = "Error! Unable to access the database.";
                return RedirectToAction("Login", "Auth");
            }

        }
        #endregion


        #region Signup Methods
        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(string email, string password)
        {
            // The following code has been adapted from the Microsoft Docs.
            // Author: Microsoft
            // Available at: https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha512?view=netcore-3.1

            byte[] data = Encoding.UTF8.GetBytes(password); // Getting the byte array of the entered password.
            SHA512 shaM = new SHA512Managed(); // Creating a new instance of the SHA512Managed class, used for hashing.
            byte[] result = shaM.ComputeHash(data); // Creating a hash of the password
            password = Convert.ToBase64String(result); // Converting the hash to a string so that it can be stored in the database.


            try
            {
                // Checking if the username already exists.
                UserInfo checkIfExists = new UserInfo();
                checkIfExists = await db.UserInfos.Where(x => x.UserEmail.Equals(email)).SingleOrDefaultAsync();

                if (checkIfExists is null)
                {
                    UserInfo u = new UserInfo();
                    u.UserEmail = email;
                    u.UserPassword = password;
                    await db.UserInfos.AddAsync(u);
                    await db.SaveChangesAsync();

                    HttpContext.Session.SetString("currentUser", email); // Settings the Session variable currentUser to the successfully loggged in user's email.
                                                                         // This will allow for the retrieval of user specific data throughout the application.

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.alreadyExists = "An account with this email already exists!";
                    return View("Signup");
                }
            }
            catch (Exception)
            {
                ViewBag.error = "Error! Unable to access the database.";
                return View("Signup");
            }

        }
        #endregion

    }
}
