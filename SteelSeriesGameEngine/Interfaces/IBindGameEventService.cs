using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelSeriesGameEngine.Interfaces
{
    public interface IBindGameEventService
    {
        Task BindEventAsync();

        void BindEvent();
    }
}
