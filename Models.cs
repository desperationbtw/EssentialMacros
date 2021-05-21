using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EssentialMacros
{
    public class SettingsElement
    {
        public string name { get; set; }
        public object value { get; set; }
    }

    public class WeaponElement
    {
        public string name { get; set; }
        public BindControl element { get; set; }
        public string[] offsets { get; set; }
        public Key bind { get; set; }
    }
}
