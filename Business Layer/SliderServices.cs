using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineBookStore.Interfaces;
using OnlineBookStore.Models;

namespace OnlineBookStore.Business_Layer
{
    public class SliderServices: ISliderServices
    {
        private OnlineBookStoreDbContext _context { get; set; }

        public SliderServices(OnlineBookStoreDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Slider> GetSlidersList()
        {

            return _context.Tb_Slider;

        }


        public bool AddSlider(Slider slider)
        {
            try
            {

                using (var transaction = _context.Database.BeginTransaction())
                {
                    _context.Tb_Slider.Add(slider);
                    _context.SaveChanges();

                    transaction.Commit();
                }

                return true;

            }
            catch
            {

                return false;
            }

        }

        public bool EditSliderData(Slider slider)
        {
            try
            {

                using (var transaction = _context.Database.BeginTransaction())
                {

                    _context.Entry(slider).State = EntityState.Modified;

                    _context.SaveChanges();

                    transaction.Commit();
                }

                return true;

            }
            catch
            {

                return false;
            }

        }

        public bool DeleteSlider(int id)
        {
            try
            {

                var delSlider = this.GetSliderById(id);
                _context.Tb_Slider.Remove(delSlider);
                _context.SaveChanges();


                return true;

            }
            catch
            {

                return false;
            }
        }

        public Slider GetSliderById(int id)
        {
            return _context.Tb_Slider.Where(i => i.sliderId == id).FirstOrDefault();
        }


    }
}
