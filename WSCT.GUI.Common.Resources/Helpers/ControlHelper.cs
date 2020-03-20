using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WSCT.GUI.Common.Resources.Helpers
{
    public static class ControlHelper
    {
        private static readonly Dictionary<Control, Color> DefaultControlBackColors = new Dictionary<Control, Color>();

        /// <summary>
        /// Resets BackColor property of <param name="control" /> to its original value.
        /// If no original color is found then current color is defined as such.
        /// </summary>
        /// <param name="control"></param>
        public static T ResetControlBackColor<T>(this T control)
            where T : Control
        {
            if (DefaultControlBackColors.TryGetValue(control, out var defaultBackColor))
            {
                control.BackColor = defaultBackColor;
            }
            else
            {
                DefaultControlBackColors.Add(control, control.BackColor);
            }

            return control;
        }

        /// <summary>
        /// Sets BackColor property of <param name="control" /> to given <param name="backColor" /> value.
        /// Backs up the original color if not previously done.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="backColor"></param>
        /// <seealso cref="ResetControlBackColor{T}"/>
        public static T SetControlBackColor<T>(this T control, Color backColor)
            where T : Control
        {
            if (!DefaultControlBackColors.ContainsKey(control))
            {
                DefaultControlBackColors.Add(control, control.BackColor);
            }

            control.BackColor = backColor;

            return control;
        }

    }
}
