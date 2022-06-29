using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.Models;

namespace OnlineBookStore.Interfaces
{
    public interface ISliderServices
    {
        public IEnumerable<Slider> GetSlidersList();

        public bool AddSlider(Slider slider);

        public bool EditSliderData(Slider slider);
        public bool DeleteSlider(int id);

        public Slider GetSliderById(int id);
    }
}
