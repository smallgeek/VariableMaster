using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using VariableMaster;
using VariableMaster.Controls;
using VariableMaster.iOS;

[assembly: ExportRenderer(typeof(VariableMasterDetailPage), typeof(VarriableMasterDetailPageRenderer))]

namespace VariableMaster.iOS
{
    public class VarriableMasterDetailPageRenderer : TabletMasterDetailRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            var page = e.NewElement as VariableMasterDetailPage;
            if (page != null)
            {
                page.PropertyChanged += (sender, args) =>
                {
                    if (args.PropertyName == "MasterFraction")
                    {
                        MaximumPrimaryColumnWidth = (nfloat)(page.Width * page.MasterFraction / 100);
                        PreferredPrimaryColumnWidthFraction = (nfloat)page.MasterFraction / 100;
                    }
                };
            }

            base.OnElementChanged(e);
        }
    }
}

