using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Ratatul.BL.ViewModels.Menu
{
    class MenuViewModel:BaseViewModel {

		public ICommand SampleCommand => MakeCommand(OnSampleCommand);

		async void OnSampleCommand() {
			NavigateTo("Camera");
		}
	}
}
