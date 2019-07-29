using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ratatul.UI.Pages.Camera
{
	[XamlCompilation(XamlCompilationOptions.Compile)]

	public partial class CameraPage : BasePage
	{
		public CameraPage ()
		{
			Label header = new Label {
				Text = "История",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center
			};

			string[] recepts = new string[] { "Жаренная куриная грудка", "Каша с фруктами", "Фруктовый салат-Осенний", "Яичница", "Жаренная куриная грудка", "Каша с фруктами", "Фруктовый салат-Осенний", "Яичница", "Каша с фруктами", "Фруктовый салат-Осенний", "Яичница", "Жаренная куриная грудка", "Каша с фруктами", "Фруктовый салат-Осенний", "Яичница" };

			ListView listView = new ListView();
			// определяем источник данных
			listView.ItemsSource = recepts;
			this.Content = new StackLayout { Children = { header, listView } };
		}
	}
}