namespace SabaRealEstate.Models
{
    public class ListingModel
    {
        public string Id { get; set; } = string.Empty;                        // 0
        public string Title { get; set; } = string.Empty;                     // 1
        public string Price { get; set; } = string.Empty;                     // 2
        public string ImageUrl { get; set; } = string.Empty;                    // 3
        public string Address { get; set; } = string.Empty;                   // 4
        public string Location { get; set; } = string.Empty;                  // 5
        public string City { get; set; } = string.Empty;                    // newly added
        public string MLSNumber { get; set; } = string.Empty;                 // 6
        public int Bedrooms { get; set; }                                     // 7
        public int Bathrooms { get; set; }                                    // 8
        public int SquareFeet { get; set; }                                   // 9
        public string PropertyType { get; set; } = string.Empty;              // 10
        public string BuildingType { get; set; } = string.Empty;              // 11
        public int Storeys { get; set; }                                      // 12
        public int SquareFootage { get; set; }                                // 13
        public string CommunityName { get; set; } = string.Empty;             // 14
        public string NeighbourhoodName { get; set; } = string.Empty;         // 15
                                                                              // Duplicate TITLE at index 16, usually skip or document if needed
        public string LandSize { get; set; } = string.Empty;                  // 17
        public string BuiltIn { get; set; } = string.Empty;                   // 18
        public string AnnualPropertyTaxes { get; set; } = string.Empty;       // 19
        public string ParkingType { get; set; } = string.Empty;               // 20
        public string TimeOnRealtor { get; set; } = string.Empty;             // 21
        public int TotalBathrooms { get; set; }                               // 22
        public int PartialBathrooms { get; set; }                             // 23
        public string Flooring { get; set; } = string.Empty;                  // 24
        public string BasementType { get; set; } = string.Empty;              // 25
        public string BuildingStyle { get; set; } = string.Empty;             // 26
        public string FireplaceType { get; set; } = string.Empty;             // 27
        public string HeatingType { get; set; } = string.Empty;               // 28
        public string UtilitySewer { get; set; } = string.Empty;              // 29
        public string Water { get; set; } = string.Empty;                     // 30
        public string RoofStyle { get; set; } = string.Empty;                 // 31
        public string ExteriorFinish { get; set; } = string.Empty;            // 32
        public string CommunityFeatures { get; set; } = string.Empty;         // 33
        public string MaintenanceFees { get; set; } = string.Empty;           // 34
        public string ParkingType2 { get; set; } = string.Empty;              // 35
        public int TotalParkingSpaces { get; set; }                           // 36
        public int SquareFootage2 { get; set; }                               // 37
        public string Image2 { get; set; } = string.Empty;                    // 38
        public string Image3 { get; set; } = string.Empty;                    // 39
        public string Image4 { get; set; } = string.Empty;                    // 40
        public string Image5 { get; set; } = string.Empty;                    // 41
        public string Image6 { get; set; } = string.Empty;                    // 42
        public string Image7 { get; set; } = string.Empty;                    // 43
        public string Image8 { get; set; } = string.Empty;                    // 44
        public string Image9 { get; set; } = string.Empty;                    // 45
        public string Image10 { get; set; } = string.Empty;                   // 46
        public string Image11 { get; set; } = string.Empty;                   // 47
        public string Image12 { get; set; } = string.Empty;                   // 48
        public string Image13 { get; set; } = string.Empty;                   // 49
        public string Image14 { get; set; } = string.Empty;                   // 50
        public string Image15 { get; set; } = string.Empty;                   // 51
    }


}
