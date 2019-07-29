using System.Threading;
using System.Threading.Tasks;
using Ratatul.DAL.DataObjects;

namespace Ratatul.DAL.DataServices.Mock {
	class MockMainDataService: BaseMockDataService, IMainDataService {
		public Task<RequestResult<SampleDataObject>> GetSampleDataObject(CancellationToken ctx) {
			return GetMockData<SampleDataObject>("Ratatul.DAL.Resources.Mock.Main.SampleDataObject.json");
		}
	}
}

