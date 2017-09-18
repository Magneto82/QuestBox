using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Microsoft.Practices.Unity;
using Xamarin.Forms;

namespace QuestBox
{
	public partial class App : Application
	{
	    public static UnityContainer Container { get; set; }
	    public static string BaseURI = "http://dev.brainwiz.ru";
        public App ()
		{
			InitializeComponent();
		    var uCfg = new UnityConfig();
		    Container = uCfg.Config();
            MainPage = new QuestBox.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
