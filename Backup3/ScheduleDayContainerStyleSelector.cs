using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Data;

namespace Schedule
{
    public class ScheduleDayContainerStyleSelector : StyleSelector
    {
        public override Style SelectStyle(object item, DependencyObject container)
        {
            CollectionViewGroup viewGroup = (CollectionViewGroup)item;
            Window window = Application.Current.MainWindow;
            GroupItem groupItem = (GroupItem)container;
            Style returnStyle = null;

            if ((string)viewGroup.Name == "Larger or equal")
            {
                returnStyle = (Style)window.FindResource(Schedule.FlatStyleKey);
            }
            else if ((string)viewGroup.Name == "Smaller")
            {
                returnStyle = (Style)window.FindResource(Schedule.ChronicalStyleKey);
            }
            else
            {
                returnStyle = base.SelectStyle(item, container);
            }
            return returnStyle;
        }
    }
}
