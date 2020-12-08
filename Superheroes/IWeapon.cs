using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    public interface IWeapon
    {
        string Name { get; set; }
        void Strike();
    }
}
