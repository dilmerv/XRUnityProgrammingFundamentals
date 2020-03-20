using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Core
{
    public class VRController
    { 
        public bool IsLeftController { get; set; }

        public bool IsRightController { get; set; }

        public string Platform { get; set; }

        public override string ToString()
        {
            return $"IsLeftController: {IsLeftController} Platform: {Platform}";
        }
    }
}
