using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Ratatul.BL.ViewModels.Camera
{
    class CameraViewModel:BaseViewModel {

		public ICommand SampleCommand => MakeCommand(OnSampleCommand);

		async void OnSampleCommand() {
			NavigateTo("Search");
		}

		public ICommand AloCommand => MakeCommand(OnAloCommand);

		async void OnAloCommand() {
			NavigateTo("Main");
		}

		public ICommand GodCommand => MakeCommand(OnGodCommand);

		async void OnGodCommand() {
			NavigateTo("Menu");
		}
	}
}
