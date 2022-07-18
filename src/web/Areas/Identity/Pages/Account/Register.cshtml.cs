using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly string adminEmail;
        private readonly string chiefMobist;
        private readonly string officer;
        private readonly string conscription;
        private readonly string vehicle;
        private readonly string mainAdmin;
        private readonly string operatorAdmin;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            IConfiguration configuration,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
            adminEmail = configuration.GetValue<string>("Admin:Login");
            chiefMobist = "chiefMobist@outlook.com";
            officer = "officer@outlook.com";
            conscription = "conscription@outlook.com";
            vehicle = "vehicle@outlook.com";
            mainAdmin = "superAdmin@outlook.com";
            operatorAdmin = "operator@outlook.com";
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    var roleResult = await _roleManager.FindByNameAsync("Admin");
                    if (roleResult == null)
                    {
                        await _roleManager.CreateAsync(new IdentityRole("Admin"));
                    }

                    var superAdmin = await _roleManager.FindByNameAsync("SuperAdmin");
                    if (superAdmin == null)
                    {
                        await _roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
                    }

                    var roleChiefMobist = await _roleManager.FindByNameAsync("ChiefMobist");
                    if (roleChiefMobist == null)
                    {
                        await _roleManager.CreateAsync(new IdentityRole("ChiefMobist"));
                    }

                    var roleOfficer = await _roleManager.FindByNameAsync("Officer");
                    if (roleOfficer == null)
                    {
                        await _roleManager.CreateAsync(new IdentityRole("Officer"));
                    }

                    var roleConscription = await _roleManager.FindByNameAsync("Conscription");
                    if (roleConscription == null)
                    {
                        await _roleManager.CreateAsync(new IdentityRole("Conscription"));
                    }

                    var roleVehicle = await _roleManager.FindByNameAsync("Vehicle");
                    if (roleVehicle == null)
                    {
                        await _roleManager.CreateAsync(new IdentityRole("Vehicle"));
                    }

                    var roleOperator = await _roleManager.FindByNameAsync("Operator");
                    if (roleOperator == null)
                    {
                        await _roleManager.CreateAsync(new IdentityRole("Operator"));
                    }

                    var currentUser = await _userManager.FindByEmailAsync(Input.Email);
                    if (currentUser.Email == adminEmail)
                    {
                        var isInRole = await _userManager.IsInRoleAsync(currentUser, "Admin");
                        if (!isInRole)
                        {
                            await _userManager.AddToRoleAsync(currentUser, "Admin");
                            await _signInManager.RefreshSignInAsync(currentUser);
                        }
                    }

                    if (currentUser.Email == mainAdmin)
                    {
                        var isInRole = await _userManager.IsInRoleAsync(currentUser, "SuperAdmin");
                        if (!isInRole)
                        {
                            await _userManager.AddToRoleAsync(currentUser, "SuperAdmin");
                            await _signInManager.RefreshSignInAsync(currentUser);
                        }
                    }

                    if (currentUser.Email == chiefMobist)
                    {
                        var isInRole = await _userManager.IsInRoleAsync(currentUser, "ChiefMobist");
                        if (!isInRole)
                        {
                            await _userManager.AddToRoleAsync(currentUser, "ChiefMobist");
                            await _signInManager.RefreshSignInAsync(currentUser);
                        }
                    }

                    if (currentUser.Email == officer)
                    {
                        var isInRole = await _userManager.IsInRoleAsync(currentUser, "Officer");
                        if (!isInRole)
                        {
                            await _userManager.AddToRoleAsync(currentUser, "Officer");
                            await _signInManager.RefreshSignInAsync(currentUser);
                        }
                    }

                    if (currentUser.Email == conscription)
                    {
                        var isInRole = await _userManager.IsInRoleAsync(currentUser, "Conscription");
                        if (!isInRole)
                        {
                            await _userManager.AddToRoleAsync(currentUser, "Conscription");
                            await _signInManager.RefreshSignInAsync(currentUser);
                        }
                    }

                    if (currentUser.Email == vehicle)
                    {
                        var isInRole = await _userManager.IsInRoleAsync(currentUser, "Vehicle");
                        if (!isInRole)
                        {
                            await _userManager.AddToRoleAsync(currentUser, "Vehicle");
                            await _signInManager.RefreshSignInAsync(currentUser);
                        }
                    }
                                      
                    if (currentUser.Email == operatorAdmin)
                    {
                        var isInRole = await _userManager.IsInRoleAsync(currentUser, "Operator");
                        if (!isInRole)
                        {
                            await _userManager.AddToRoleAsync(currentUser, "Operator");
                            await _signInManager.RefreshSignInAsync(currentUser);
                        }
                    }

                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
