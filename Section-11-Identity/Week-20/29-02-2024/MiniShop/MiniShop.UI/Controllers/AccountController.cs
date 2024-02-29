using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels;
using MiniShop.Shared.ViewModels.IdentityModels;
using MiniShop.UI.EmailServices.Abstract;

namespace MiniShop.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IOrderService _orderManager;
        private readonly IEmailSender _emailSender;
        private readonly IShoppingCartService _shoppingCartManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IOrderService orderManager, IEmailSender emailSender, IShoppingCartService shoppingCartManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _orderManager = orderManager;
            _emailSender = emailSender;
            _shoppingCartManager = shoppingCartManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if(ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = registerViewModel.UserName,
                    Email = registerViewModel.Email,
                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName,
                    EmailConfirmed=true
                  
                   
                };

                var result = await _userManager.CreateAsync(user,registerViewModel.Password);
                if (result.Succeeded)
                {
                    //mail gönderme işlemi başlıyor.
                    //token oluşturma
                    //var tokenCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //var backUrl = Url.Action("ConfirmEmail", "Account", new
                    //{
                    //    userId = user.Id,
                    //    token = tokenCode
                    //});
                    ////mail gönderme
                    //await _emailSender.SendEmailAsync(
                    //    user.Email,
                    //    "MiniShopApp Üyelik Onayı",
                    //    $"<p>MiniShopApp uygulamasına üyeliğiniz onaylamak için aşağıdaki linke tıklayınız.</p><a href='https://localhost:59079{backUrl}'>ONAY LİNKİ</<>"
                    //    );
                    return Redirect("~/");
                }
            }
            return View(registerViewModel);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl=null)
        {
            if (returnUrl != null)
            {
                TempData["ReturnUrl"] = returnUrl;
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(loginViewModel);
            }
            User user = await _userManager.FindByNameAsync(loginViewModel.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Kullanıcı bulunamadı");
                return View(loginViewModel);
            }
            var emailConfirmed = await _userManager.IsEmailConfirmedAsync(user);
            if (!emailConfirmed)
            {
                ModelState.AddModelError("", "Lütfen mailinizi onaylamayı unutmayın");
                return View(loginViewModel);
            }
            var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
            if(!result.Succeeded)
            {
                ModelState.AddModelError("", "Şifre hatalı");
                return View(loginViewModel);
            }
            var returnUrl = TempData["ReturnUrl"]?.ToString();
            if(!String.IsNullOrEmpty(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
    
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData["ReturnUrl"] = null;
            return Redirect("~/");
        }
        
        public IActionResult AccessDenied()
        {
            return View();
        }
    
        public async Task<IActionResult> Profile()
        {
            var userId = _userManager.GetUserId(User);
            var orders = await _orderManager.GetOrdersAsync(userId);
            var user= await _userManager.FindByIdAsync(userId);
            UserProfileViewModel userProfileViewModel = new UserProfileViewModel
            {
                Orders = orders,
                User = new UserViewModel
                {
                    Id=userId,
                    FirstName=user.FirstName,
                    LastName=user.LastName,
                    Email=user.Email,
                    PhoneNumber=user.PhoneNumber,
                    Address=user.Address,
                    City=user.City,
                    UserName=user.UserName,
                    Gender=user.Gender,
                    DateOfBirth=user.DateOfBirth,
                }
            };
         
            return View(userProfileViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Profile(UserProfileViewModel userProfileViewModel)
        {

            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            if (ModelState.IsValid)
            {
                user.FirstName = userProfileViewModel.User.FirstName;
                user.LastName= userProfileViewModel.User.LastName;
                user.Email = userProfileViewModel.User.Email;
                user.City = userProfileViewModel.User.City;
                user.Address = userProfileViewModel.User.Address;
                user.PhoneNumber = userProfileViewModel.User.PhoneNumber;
                user.DateOfBirth= userProfileViewModel.User.DateOfBirth;
                user.Gender = userProfileViewModel.User.Gender;
                user.UserName = userProfileViewModel.User.UserName;
             
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);
                    await _signInManager.SignOutAsync();
                    await _signInManager.SignInAsync(user,isPersistent:false);
                  
                    return Redirect("~/");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);

                }
           
            }
            userProfileViewModel.Orders = await _orderManager.GetOrdersAsync(userId);
            return View(userProfileViewModel);
        }

        public async Task<IActionResult> ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);
                var user = await _userManager.FindByIdAsync(userId);
                //eski şifre doğru mu?
                var isVerified = await _userManager.CheckPasswordAsync(user, changePasswordViewModel.OldPassword);
                //eski şifre doğruysa;
                if(isVerified)
                {
                    var result= await _userManager.ChangePasswordAsync(user,changePasswordViewModel.OldPassword,changePasswordViewModel.NewPassword);
                    if (result.Succeeded)
                    {
                      await _userManager.UpdateSecurityStampAsync(user);
                        await _signInManager.SignOutAsync();
                        await _signInManager.PasswordSignInAsync(user, changePasswordViewModel.NewPassword, false, false);
                        return RedirectToAction("Profile");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(changePasswordViewModel);
                }
                //eski şifre yanlışsa;
                ModelState.AddModelError("", "Geçerli şifreniz hatalıdır");
               

            }
            return View(changePasswordViewModel);
        }

        public async Task<IActionResult> ConfirmEmail(string userId,string token)
        {
            if(userId == null || token == null)
            {
                ModelState.AddModelError("", "Bilgilerde sorun var, yönetici ile görüşünüz.");
                return View();
            }
            var user= await _userManager.FindByIdAsync(userId);
            if(user== null)
            {
                ModelState.AddModelError("", "Kullanıcı bilgilerinize ulaşılamadı");
                return View();
            }
            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                //bu kişi onaylı bir user olduğuna göre bir shoppingcart oluşturuyoruz.
                await _shoppingCartManager.InitializeShoppingCartAsync(userId);
                return View("ConfirmEmail","Hesabınız başarıyla onaylanmıştır. Hoş geldiniz");
            }

            return View();
        }

        public  IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
