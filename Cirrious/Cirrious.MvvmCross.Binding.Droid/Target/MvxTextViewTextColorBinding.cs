using System;
using Android.Graphics;
using Android.Widget;
using Cirrious.CrossCore.Platform;

namespace Cirrious.MvvmCross.Binding.Droid.Target
{
    public class MvxTextViewTextColorBinding : MvxAndroidTargetBinding
    {
        public MvxTextViewTextColorBinding(object target) : base(target)
        {
            if (target == null)
            {
                MvxBindingTrace.Trace(MvxTraceLevel.Error, "Error - TextView is null in MvxTextViewTextColorBinding");
            }
        }

        public override Type TargetType
        {
            get { return typeof(Color); }
        }

        public override MvxBindingMode DefaultMode
        {
            get { return MvxBindingMode.OneWay; }
        }

        protected override void SetValueImpl(object target, object value)
        {
            var textView = (TextView) target;
            textView.SetTextColor((Color) value);
        }
    }
}
