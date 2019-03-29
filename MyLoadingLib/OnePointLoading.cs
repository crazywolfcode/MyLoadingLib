using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MyLoadingLib
{
   public class OnePointLoading :UserControl
    {

        static OnePointLoading() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(OnePointLoading), new FrameworkPropertyMetadata(typeof(OnePointLoading)));
        }
    }
}
