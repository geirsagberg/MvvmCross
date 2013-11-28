using System;
using Android.Graphics;
using Android.Views;
using Cirrious.CrossCore.Platform;

namespace Cirrious.MvvmCross.Binding.Droid.Target
{
    public class MvxViewBackgroundColorBinding : MvxAndroidTargetBinding
    {
        public MvxViewBackgroundColorBinding(object target)
            : base(target)
        {
            if (target == null)
            {
                MvxBindingTrace.Trace(MvxTraceLevel.Error, "Error - View is null in MvxViewBackgroundColorBinding");
            }
        }


        public override Type TargetType
        {
            get { return typeof (Color); }
        }

        public override MvxBindingMode DefaultMode
        {
            get { return MvxBindingMode.OneWay; }
        }

        protected override void SetValueImpl(object target, object value)
        {
            var view = (View) target;
            view.SetBackgroundColor((Color) value);
        }
    }
}