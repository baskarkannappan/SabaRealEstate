using SabaRealEstate.Models;

namespace SabaRealEstate.Services
{
    public class GoogleSheetService
    {
        private readonly HttpClient _httpClient;
        private const string CsvUrl = "https://docs.google.com/spreadsheets/d/e/2PACX-1vSkV0R6VamFzi9woaH6vCtYwOcELa1iOQKox4Sk3IqX_hPngfmiGzNU9Iwvn-Z9en-rzxWAi1MdTUJy/pub?output=csv";

        public GoogleSheetService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ListingModel>> GetListingsAsync()
        {
            var csv = await _httpClient.GetStringAsync(CsvUrl);
            var lines = csv.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var listings = new List<ListingModel>();

            foreach (var line in lines.Skip(1)) // Skip header
            {
                var cells = line.Split(',');

                if (cells.Length >= 52) // Check for enough columns
                {
                    listings.Add(new ListingModel
                    {
                        Id = cells[0].Trim('\"'),
                        Title = cells[1].Trim('\"'),
                        Price = cells[2].Trim('\"'),
                        ImageUrl = cells[3].Trim('\"'),
                        Address = cells[4].Trim('\"'),
                        Location = cells[5].Trim('\"'),
                        City = cells[6].Trim('\"'),
                        MLSNumber = cells[7].Trim('\"'),
                        Bedrooms = TryParseInt(cells[8]),
                        Bathrooms = TryParseInt(cells[9]),
                        SquareFeet = TryParseInt(cells[10]),
                        PropertyType = cells[11].Trim('\"'),
                        BuildingType = cells[12].Trim('\"'),
                        Storeys = TryParseInt(cells[13]),
                        SquareFootage = TryParseInt(cells[14]),
                        CommunityName = cells[15].Trim('\"'),
                        NeighbourhoodName = cells[16].Trim('\"'),
                        LandSize = cells[17].Trim('\"'),
                        BuiltIn = cells[18].Trim('\"'),
                        AnnualPropertyTaxes = cells[19].Trim('\"'),
                        ParkingType = cells[20].Trim('\"'),
                        TimeOnRealtor = cells[21].Trim('\"'),
                        TotalBathrooms = TryParseInt(cells[22]),
                        PartialBathrooms = TryParseInt(cells[23]),
                        Flooring = cells[24].Trim('\"'),
                        BasementType = cells[25].Trim('\"'),
                        BuildingStyle = cells[26].Trim('\"'),
                        FireplaceType = cells[27].Trim('\"'),
                        HeatingType = cells[28].Trim('\"'),
                        UtilitySewer = cells[29].Trim('\"'),
                        Water = cells[30].Trim('\"'),
                        RoofStyle = cells[31].Trim('\"'),
                        ExteriorFinish = cells[32].Trim('\"'),
                        CommunityFeatures = cells[33].Trim('\"'),
                        MaintenanceFees = cells[34].Trim('\"'),
                        ParkingType2 = cells[35].Trim('\"'),
                        TotalParkingSpaces = TryParseInt(cells[36]),
                        SquareFootage2 = TryParseInt(cells[37]),
                        Image2 = cells[38].Trim('\"'),
                        Image3 = cells[39].Trim('\"'),
                        Image4 = cells[40].Trim('\"'),
                        Image5 = cells[41].Trim('\"'),
                        Image6 = cells[42].Trim('\"'),
                        Image7 = cells[43].Trim('\"'),
                        Image8 = cells[44].Trim('\"'),
                        Image9 = cells[45].Trim('\"'),
                        Image10 = cells[46].Trim('\"'),
                        Image11 = cells[47].Trim('\"'),
                        Image12 = cells[48].Trim('\"'),
                        Image13 = cells[49].Trim('\"'),
                        Image14 = cells[50].Trim('\"'),
                        Image15 = cells[51].Trim('\"')
                    });
                }
            }

            return listings;
        }


        // Helper method to safely parse integers
        private static int TryParseInt(string? value)
        {
            return int.TryParse(value?.Trim('\"'), out var result) ? result : 0;
        }

    }
}
