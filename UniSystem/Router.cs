using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniSystem.Controls;

namespace UniSystem
{
    static class Router
    {
        private static Dictionary<string, UserControl> routes = new Dictionary<string, UserControl>
        {
            { "home", new StudentsControl() },
            { "add", new StudentsControl() },
            { "edit", new StudentsControl() },
            { "delete", new StudentsControl() }
        };

        public static void Navigate(this Panel panel, string route)
        {
            panel.Controls.Clear();
            panel.Controls.Add(routes[route]);
        }
    }
}
