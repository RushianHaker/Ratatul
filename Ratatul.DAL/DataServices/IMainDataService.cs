using System.Threading;
using System.Threading.Tasks;
using Ratatul.DAL.DataObjects;

namespace Ratatul.DAL.DataServices {
	public interface IMainDataService {
		Task<RequestResult<SampleDataObject>> GetSampleDataObject(CancellationToken ctx);
	}
}

