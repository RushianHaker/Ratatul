using System.Threading.Tasks;
using System.Windows.Input;
using Ratatul.DAL.DataObjects;
using Ratatul.DAL.DataServices;

namespace Ratatul.BL.ViewModels.Main {
	public class MainViewModel : BaseViewModel {
		public SampleDataObject SampleObject {
			get => Get<SampleDataObject>();
			private set => Set(value);
		}

		public ICommand SampleCommand => MakeCommand(OnSampleCommand);

		public override async Task OnPageAppearing() {
			State = PageState.Loading;
			var result = await DataServices.Main.GetSampleDataObject(CancellationToken);
			if (result.IsValid) {
				SampleObject = result.Data;
				State = PageState.Normal;
			}
			else
				State = PageState.Error;
		}

		async void OnSampleCommand() {
			NavigateTo("Camera");
		}

		public ICommand AloCommand => MakeCommand(OnAloCommand);

		async void OnAloCommand() {
			NavigateTo("Search");
		}
	}
}
