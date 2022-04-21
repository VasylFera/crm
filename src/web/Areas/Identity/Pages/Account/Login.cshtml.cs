using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly string adminEmail;
        private readonly string chiefMobist;
        private readonly string officer;
        private readonly string conscription;
        private readonly string vehicle;

        public LoginModel(SignInManager<IdentityUser> signInManager, 
            ILogger<LoginModel> logger,
            IConfiguration configuration,
            UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            adminEmail = configuration.GetValue<string>("Admin:Login");
            chiefMobist = "chiefMobist@outlook.com";
            officer = "officer@outlook.com";
            conscription = "conscription@outlook.com";
            vehicle = "vehicle@outlook.com";
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (Input.Email == adminEmail)
                {
                    var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };

                    var findUser = await _userManager.FindByEmailAsync(user.Email);
                    if (findUser != null)
                    {
                        await _signInManager.SignInAsync(findUser, isPersistent: false);
                        return LocalRedirect("~/admin-home");
                    }

                }

                if (Input.Email == chiefMobist)
                {
                    var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };

                    var findUser = await _userManager.FindByEmailAsync(user.Email);
                    if (findUser != null)
                    {
                        await _signInManager.SignInAsync(findUser, isPersistent: false);
                        return LocalRedirect("~/chiefMobist-home");
                    }

                }

                if (Input.Email == officer)
                {
                    var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };

                    var findUser = await _userManager.FindByEmailAsync(user.Email);
                    if (findUser != null)
                    {
                        await _signInManager.SignInAsync(findUser, isPersistent: false);
                        return LocalRedirect("~/officer-home");
                    }

                }

                if (Input.Email == conscription)
                {
                    var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };

                    var findUser = await _userManager.FindByEmailAsync(user.Email);
                    if (findUser != null)
                    {
                        await _signInManager.SignInAsync(findUser, isPersistent: false);
                        return LocalRedirect("~/conscription-home");
                    }

                }

                if (Input.Email == vehicle)
                {
                    var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };

                    var findUser = await _userManager.FindByEmailAsync(user.Email);
                    if (findUser != null)
                    {
                        await _signInManager.SignInAsync(findUser, isPersistent: false);
                        return LocalRedirect("~/vehicle-home");
                    }

                }
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
