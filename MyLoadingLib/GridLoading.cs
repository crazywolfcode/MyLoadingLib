using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
namespace MyLoadingLib
{
    public class GridLoading : UserControl
    {
        static GridLoading() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GridLoading), new FrameworkPropertyMetadata(typeof(GridLoading)));
        }
    }
}
