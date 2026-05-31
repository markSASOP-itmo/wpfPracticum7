using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpfPracticum7
{
    internal class myComands
    {
        public static RoutedCommand Exit {  get; set; }
        static myComands()
        {
            Exit = new RoutedCommand();
        }
    }
}
