
using System;
using Android.Graphics;
using TabbedPageProjeto;
using TabbedPageProjeto.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;
using Android.App;
using Android.Graphics.Drawables;
using System.Linq;

[assembly: ExportRenderer(typeof(CustomTabbedPage), typeof(CustomTabbedPageRenderer))]
namespace TabbedPageProjeto.Droid
{
    public class CustomTabbedPageRenderer : TabbedPageRenderer
    {
        protected override void DispatchDraw(Canvas canvas)
        {
            base.DispatchDraw(canvas);

            SetIcons();
        }

        private void SetIcons()
        {
            var activity = Context as Activity;
            if (activity != null && activity.ActionBar != null) {
                //for (int i = 0; i < activity.ActionBar.TabCount; i++)
                //{
                //    ActionBar.Tab aba = activity.ActionBar.GetTabAt(i);
                //    aba.SetIcon(ResourceIdFromString("icon"));
                //}

                int i = 0; ;
                foreach (var item in Element.Children)
                {
                    ActionBar.Tab aba = activity.ActionBar.GetTabAt(i++);
                    
                    aba.SetIcon(ResourceIdFromString(item.Icon.File));
                }
            }
        }

        private int ResourceIdFromString(string resourceName)
        {
            resourceName = System.IO.Path.GetFileNameWithoutExtension(resourceName).ToLower();
            Type tipo = typeof(Resource.Drawable);

            return (int)tipo.GetFields().FirstOrDefault(p=>p.Name.ToLower() == resourceName).GetValue(null);
        }
    }
}