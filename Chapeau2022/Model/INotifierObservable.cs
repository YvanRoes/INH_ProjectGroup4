using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface INotifierObservable
    {
        public void AddObserver(INotifierObserver observer);
        public void RemoveObserver(INotifierObserver observer);

    }
}
