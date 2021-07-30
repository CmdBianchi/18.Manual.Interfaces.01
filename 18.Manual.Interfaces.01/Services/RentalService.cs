using System;
using System.Collections.Generic;
using System.Text;
namespace Services {
    class RentalService {
        public DateTime PricePerHour { get; set; }
        public DateTime PricePerDay { get; set; }

        private ITaxService _taxService;
        public RentalService(DateTime pricePerHour, DateTime pricePerDay, ITaxService taxService) {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }


    }
}
