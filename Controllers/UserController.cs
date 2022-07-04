using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Models;

namespace OnlineBookStore.Controllers
{
    public class UserController : Controller
    {
        private UserManager<ApplicationIdentiyUser> _userManager;
        private SignInManager<ApplicationIdentiyUser> _signInManager;

        public UserController(UserManager<ApplicationIdentiyUser> userManager, SignInManager<ApplicationIdentiyUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

      
        public IActionResult Register()
        {
            UserIdentityModel userIdentityModel = new UserIdentityModel() {};
            return View(userIdentityModel);
        }


        [HttpPost]
        public async Task<IActionResult> Register(UserIdentityModel userIdentityModel)
        {

            if (ModelState.IsValid) { 

            ApplicationIdentiyUser newUserIdentity = new ApplicationIdentiyUser()
            {
                firstName = userIdentityModel.firstName,
                lastName = userIdentityModel.lastName,
                UserName = userIdentityModel.email,
                Email = userIdentityModel.email,
               
            };

            var result = await _userManager.CreateAsync(newUserIdentity, userIdentityModel.password);

            if (result.Succeeded)
            {
                    await _userManager.AddToRoleAsync(newUserIdentity,"Customer");
                    await _signInManager.PasswordSignInAsync(userIdentityModel.email, userIdentityModel.password, true, true);
                    
                    return Redirect("~/");
            }
            else
            {
                    List<IdentityError> errorList = result.Errors.ToList();
                    ViewBag.errors = errorList;
                    return View("Register", userIdentityModel);
            }
            }
            else
            {
                return View("Register", userIdentityModel);
            }

        }


        public IActionResult Login(string returnUrl)
        {
            UserIdentityModel userIdentityModel = new UserIdentityModel() {
                    returnUrl=returnUrl};
            return View(userIdentityModel);
        }


        [HttpPost]
        public async Task<IActionResult> Login(UserIdentityModel userIdentityModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.
                    PasswordSignInAsync(userIdentityModel.email, userIdentityModel.password, true, true);


                if (string.IsNullOrEmpty(userIdentityModel.returnUrl))
                {
                    userIdentityModel.returnUrl = "~/";
                }

                if (result.Succeeded)
                {
                       return Redirect(userIdentityModel.returnUrl);
                }
                else
                {
                    return View("Login", userIdentityModel);
                }
            }
            else
            {
                return View("Login", userIdentityModel);
            }

        }

     
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }




    }
}
