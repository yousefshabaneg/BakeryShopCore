using BakeryShop.Data;
using BakeryShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BakeryShop.Pages
{
    public class orderModel : PageModel
    {
        private readonly BakeryShopContext _db;
        public orderModel(BakeryShopContext db) => _db = db;
        public Product Product { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        [BindProperty, EmailAddress, Required(ErrorMessage = "Please Enter a valid email"), Display(Name = "Your Email Address")]
        public string OrderEmail { get; set; }

        [BindProperty, Required(ErrorMessage = "Please Enter your shipping address"), Display(Name = "Shipping Address")]
        public string OrderShipping { get; set; }

        [BindProperty, Display(Name = "Quantity")]
        public int OrderQuantity { get; set; }

        public async Task OnGetAsync()
        {
            Product = await _db.Products.FindAsync(Id);
        }
        public async Task<IActionResult> OnPostAsync()
        {
            Product = await _db.Products.FindAsync(Id);
            if (ModelState.IsValid)
            {
                var emailBody = $"<p>Thank you, We Recived your order for {OrderQuantity} of Piceces of {Product.Name}</p>" +
                    $"<p>Your Address is {OrderShipping}</p>" +
                    $"<p>Your Total Price is {OrderQuantity * Product.Price} $</p>" +
                    "<p><b>Your Order Will Delivered Within 60 Minutes</b></p>";
                using (var smtp = new SmtpClient())
                {
                    var googleCredential = new NetworkCredential
                    {
                        UserName = "mazenbdo999@gmail.com",
                        Password = "######"
                    };
                    smtp.Credentials = googleCredential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    var message = new MailMessage();
                    message.To.Add(OrderEmail);
                    message.Subject = "Bakery Shop - New Order";
                    message.Body = emailBody;
                    message.IsBodyHtml = true;
                    message.From = new MailAddress("ahmed@gmail.com");
                    await smtp.SendMailAsync(message);
                }
                return RedirectToPage("OrderSuccess");
            }
            return Page();
        }
    }
}
