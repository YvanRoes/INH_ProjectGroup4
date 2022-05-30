using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IFoodItem
    {
        public CourseType Item_CourseType { get; set; }

        public MenuType Item_MenuType { get; set; }
    }
}
