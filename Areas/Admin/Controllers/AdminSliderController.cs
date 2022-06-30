using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Interfaces;
using OnlineBookStore.Models;

namespace OnlineBookStore.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminSliderController : Controller
    {

            private ISliderServices sliderServices { get; set; }

            public AdminSliderController(ISliderServices sliderServices)
            {
                this.sliderServices = sliderServices;

            }

            public IActionResult SlidersList()
            {

                List<Slider> slidersList = sliderServices.GetSlidersList().ToList();

                return View(slidersList);
            }

            public IActionResult AddSlider()
            {
                Slider slider = new Slider() { sliderId=0};
                return View(slider);
            }

            public IActionResult EditSlider(int id)
            {

                Slider slider = sliderServices.GetSliderById(id);

                return View("AddSlider",slider);

            }

            public IActionResult DeleteSLider(int id)
            {

                sliderServices.DeleteSlider(id);
                return RedirectToAction("SlidersList");

            }


            [HttpPost]
            public async Task<IActionResult> SaveSlider(Slider slider, List<IFormFile> Files)
            {

                if (ModelState.IsValid)
                {

                    //Image raising

                    foreach (var file in Files)
                    {
                        if (file.Length > 0)
                        {
                            string ImageName = Guid.NewGuid().ToString() + ".jpg";
                            var filepath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwRoot\UploadedFiles\Images\SlidersImages", ImageName);

                            using (var stream = System.IO.File.Create(filepath))
                            {
                                await file.CopyToAsync(stream);
                            }
                            slider.sliderImageName= ImageName;
                        }
                    }



                    //Saving adding or editing Data to the DB 
                    if (slider.sliderId != 0)
                        sliderServices.EditSliderData(slider);
                    else
                        sliderServices.AddSlider(slider);

                    return RedirectToAction("SLidersList");

                }

                else
                {
                    return View("AddSlider",slider);
                }


            }


        }
    }
