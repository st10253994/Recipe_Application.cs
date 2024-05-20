using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Application
{
    internal class Step
    {
        private string description = "";

        public string Description
        { 
            get => description;
            set => description = value;
        }
    }
}
