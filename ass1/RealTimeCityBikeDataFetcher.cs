using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ass1 {
    public class RealTimeCityBikeDataFetcher : ICityBikeDataFetcher {
        public async Task<int> GetBikeCountInStation (string stationName) {

            try {
                foreach (var character in stationName.ToCharArray ()) {
                    if (char.IsDigit (character)) {
                        throw new ArgumentException ();
                    }
                }

                HttpClient client = new HttpClient ();
                string message = await client.GetStringAsync ("http://api.digitransit.fi/routing/v1/routers/hsl/bike_rental");
                BikeRentalStationList stationList = JsonConvert.DeserializeObject<BikeRentalStationList> (message);

                int bikes = 0;

                foreach (var station in stationList.stations) {
                    if (station.name == stationName) {
                        bikes = station.bikesAvailable;
                    }
                }
                return bikes;
            } catch (ArgumentException ex){
                Console.WriteLine("Invalid argument: " + ex.Message);
                return 0;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}