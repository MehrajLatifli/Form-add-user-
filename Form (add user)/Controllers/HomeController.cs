using Form__add_user_.Fake_Repo;
using Form__add_user_.Helpers;
using Form__add_user_.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Form__add_user_.Controllers
{
    public class HomeController : Controller
    {


        private readonly IWebHostEnvironment env;


        public HomeController(IWebHostEnvironment webHost)
        {
            env = webHost;

          

        }




        public IActionResult Index()
        {

            var model = new UserListViewModel
            {
                Users = UserRepo.Users
            };

    

            

            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel model)
        {
            var imagehelper = new FileHelper(env);

            model.User.ImageUrl = await imagehelper.SaveFile(model.FormFile);

            UserRepo.Users.Add(model.User);



            return RedirectToAction("Index", "Home");
        }

        public void Deleteimage()
        {
            string[] files = Directory.GetFiles(@"wwwroot\\images", "*.*", SearchOption.AllDirectories);

            List<string> imageFiles = new List<string>();

            foreach (string filename in files)
            {
                if (Regex.IsMatch(filename, @"\.jpg$|\.jpeg$|\.png$|\.gif$|\.tiff$|\.bmp$|\.svg$"))
                    imageFiles.Add(filename);
            }


            var generalresult = String.Concat(files);

            List<string> filesList = new List<string>();


            var result1 = Array.Find(files, e => e == @"wwwroot\\images\1.png");
            var result2 = Array.Find(files, e => e == @"wwwroot\\images\2.png");
            var result3 = Array.Find(files, e => e == @"wwwroot\\images\3.png");
            var result4 = Array.Find(files, e => e == @"wwwroot\\images\4.png");

            if (imageFiles.Contains(result1))
            {

                ViewData["a"] = imageFiles.ToArray();

                if (!string.IsNullOrEmpty(result3))
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", result3);

                    System.IO.DirectoryInfo di = new DirectoryInfo("wwwroot\\images");

                    foreach (FileInfo file in di.EnumerateFiles())
                    {


                        if (file.Name != "1.png" && file.Name != "2.png" && file.Name != "3.png" && file.Name != "4.png")
                        {

                            file.Delete();
                        }

                    }
                }
            };
        }
    }
}
