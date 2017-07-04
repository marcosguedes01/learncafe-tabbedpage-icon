using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabbedPageProjeto
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CustomTabbedPage
            {
                Children = {
                    new ContentPage {
                        Title ="Amarelo",
                        Content = new StackLayout{
                            BackgroundColor = Color.Yellow
                        },
                        Icon = "friends.png"
                    },
                    new ContentPage {
                        Title ="Vermelho",
                        Content = new StackLayout{
                            BackgroundColor = Color.Red
                        },
                        Icon = "groups.png"
                    },
                    new ContentPage {
                        Title ="Azul",
                        Content = new StackLayout{
                            BackgroundColor = Color.Blue
                        },
                        Icon = "home.png"
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
