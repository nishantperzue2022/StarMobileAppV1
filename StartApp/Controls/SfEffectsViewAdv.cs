using Syncfusion.Maui.Toolkit.EffectsView;
using Syncfusion.Maui.Toolkit.Internals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointerEventArgs = Syncfusion.Maui.Toolkit.Internals.PointerEventArgs;

namespace StartApp.Controls
{
    internal partial class SfEffectsViewAdv : SfEffectsView, ITouchListener, IGestureListener
    {
        public SfEffectsViewAdv()
        {


        }
        public new void OnTouch(PointerEventArgs e)
        {
            if (e.Action == PointerActions.Entered)
            {
                ApplyEffects(SfEffects.Highlight, RippleStartPosition.Default, new System.Drawing.Point((int)e.TouchPoint.X, (int)e.TouchPoint.Y), false);
            }
            else if (e.Action == PointerActions.Released)
            {
                Reset();
            }
            else if (e.Action == PointerActions.Cancelled)
            {
                Reset();
            }
            else if (e.Action == PointerActions.Exited)
            {
                Reset();
            }
            else if (e.Action == PointerActions.Pressed)
            {
                ApplyEffects(SfEffects.Ripple, RippleStartPosition.Default, new System.Drawing.Point((int)e.TouchPoint.X, (int)e.TouchPoint.Y), false);
            }
        }

        internal void ForceRemoveEffects()
        {
            Reset();
        }
    }
}
