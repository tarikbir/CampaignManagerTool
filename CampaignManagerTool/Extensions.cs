using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace CampaignManagerTool
{
    internal static class Extensions
    {
        internal static void FillChildrenWith(this Grid grid, List<UIElement> elements)
        {
            foreach (var item in elements)
            {
                grid.Children.Add(item);
            }
        }
    }
}
