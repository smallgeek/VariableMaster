using System;

using Xamarin.Forms;

namespace VariableMaster.Controls
{
    public class VariableMasterDetailPage : MasterDetailPage
    {
        #region MaximumFraction BindableProperty

        public static readonly BindableProperty MaximumFractionProperty =
            BindableProperty.Create(
                propertyName: nameof(MaximumFraction),
                returnType: typeof(double),
                declaringType: typeof(VariableMasterDetailPage),
                defaultValue: 40.0,
                propertyChanged: OnMaximumFractionChanged);

        public double MaximumFraction
        {
            get { return (double)GetValue(MaximumFractionProperty); }
            set { SetValue(MaximumFractionProperty, value); }
        }

        protected static void OnMaximumFractionChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var page = (VariableMasterDetailPage)bindable;

            var newMaximum = (double)newValue;
            if (newMaximum < page.MinimumFraction)
                throw new ArgumentOutOfRangeException();

            var oldMaximum = (double)oldValue;
            if (oldMaximum.Equals(newMaximum) == false)
            {
                page.MaximumFraction = newMaximum;
                page.OnPropertyChanged(nameof(page.MaximumFraction));
            }
        }

        #endregion

        #region MinimumFraction BindableProperty

        public static readonly BindableProperty MinimumFractionProperty =
            BindableProperty.Create(
                propertyName: nameof(MinimumFraction),
                returnType: typeof(double),
                declaringType: typeof(VariableMasterDetailPage),
                defaultValue: 0.0,
                propertyChanged: OnMinimumFractionChanged);

        public double MinimumFraction
        {
            get { return (double)GetValue(MinimumFractionProperty); }
            set { SetValue(MinimumFractionProperty, value); }
        }

        protected static void OnMinimumFractionChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var page = (VariableMasterDetailPage)bindable;

            var newMinimum = (double)newValue;
            if (page.MaximumFraction < newMinimum)
                throw new ArgumentOutOfRangeException();

            var oldMinimum = (double)oldValue;
            if (oldMinimum.Equals(newMinimum) == false)
            {
                page.MinimumFraction = newMinimum;
                page.OnPropertyChanged(nameof(page.MinimumFraction));
            }
        }

        #endregion

        #region MasterFraction BindableProperty

        public static readonly BindableProperty MasterFractionProperty =
            BindableProperty.Create(
                propertyName: nameof(MasterFraction),
                returnType: typeof(double),
                declaringType: typeof(VariableMasterDetailPage),
                defaultValue: 0.0,
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: OnMasterFractionChanged);
                                

        public double MasterFraction
        {
            get { return (double)GetValue(MasterFractionProperty); }
            set { SetValue(MasterFractionProperty, value); }
        }

        protected static void OnMasterFractionChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var page = (VariableMasterDetailPage)bindable;

            var newFraction = (double)newValue;
            if (newFraction < page.MinimumFraction || page.MaximumFraction < newFraction)
                throw new ArgumentOutOfRangeException();

            var oldFraction = (double)oldValue;
            if (oldFraction.Equals(newFraction) == false)
            {
                page.MasterFraction = newFraction;
                page.OnPropertyChanged(nameof(page.MasterFraction));
            }
        }

        #endregion
    }
}


