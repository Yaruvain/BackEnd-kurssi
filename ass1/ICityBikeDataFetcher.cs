using System.Threading.Tasks;

namespace ass1 {
    public interface ICityBikeDataFetcher {
        Task<int> GetBikeCountInStation (string stationName);
    }
}