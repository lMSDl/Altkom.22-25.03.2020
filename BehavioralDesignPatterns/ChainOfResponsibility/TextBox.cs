﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.ChainOfResponsibility
{
    public class TextBox : Container
    {
        public string InputText { get; set; }

        protected override void Click(bool handled)
        {
            if (!handled)
            {
                Console.WriteLine("TextBox has focus");
                base.Click(true);
            }
            else
                base.Click(false);
        }
    }
}
