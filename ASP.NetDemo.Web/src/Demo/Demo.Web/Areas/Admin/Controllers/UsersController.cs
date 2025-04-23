﻿using Demo.Infrastructure.Identity;
using Demo.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

//
using Demo.Infrastructure;
using Microsoft.AspNetCore.Authorization;

namespace Demo.Web.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles ="Admin")]
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly IUserEmailStore<ApplicationUser> _emailStore;
        public UsersController(UserManager<ApplicationUser> userManager,
            IUserStore<ApplicationUser> userStore)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
        }
        public IActionResult AddUser()
        {
            var model = new AddUserModel();
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUserAsync(AddUserModel model)
        {
            if (!ModelState.IsValid)
            {
                try
                {
                    var user = CreateUser();

                    await _userStore.SetUserNameAsync(user, model.Email, CancellationToken.None);
                    await _emailStore.SetEmailAsync(user, model.Email, CancellationToken.None);

                    user.RegistrationDate = DateTime.UtcNow;

                    var result = await _userManager.CreateAsync(user, model.Password);

                    //Creating Role.
                    await _userManager.AddToRoleAsync(user, model.Role);

                    //TempData.Put("ResponseMessage", new ResponseModel
                    //{
                    //    Message = "",
                    //    Type = ResponseType.Success
                    //});
                }
                catch (Exception ex)
                {
                    //var message = "User Create Failed";
                    //ModelState.AddModelError("UserCreateFailed", message);
                    //TempData.Put("ResponseMessage", new ResponseModel
                    //{
                    //    Message = message,
                    //    Type = ResponseType.Danger
                    //});
                }
            }

            return View(model);
        }

        private ApplicationUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<ApplicationUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(ApplicationUser)}'. " +
                    $"Ensure that '{nameof(ApplicationUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<ApplicationUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<ApplicationUser>)_userStore;
        }
    }
}
