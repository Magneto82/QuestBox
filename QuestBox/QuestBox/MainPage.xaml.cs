using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizbeClient;
using Xamarin.Forms;

namespace QuestBox
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private void LoginClicked(object sender, EventArgs e)
	    {
	        var login = loginEntry.Text;
	        var password = passwordEntry.Text;
	        //App.Container.Resolve<>();
	        var wizAuthSvc = new AuthService(App.BaseURI);
	        var loginData = wizAuthSvc.Login(login, password);
	    }

	    //private string Token()
	    //{
	    //    if (_authData == null)
	    //        throw new Exception("no auth data");
	    //    if (!_authData.ContainsKey("access_token"))
	    //        throw new Exception("no access_token in auth data");
	    //    return _authData["access_token"];
	    //}
    }
}
