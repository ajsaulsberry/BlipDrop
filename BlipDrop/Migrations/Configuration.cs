namespace BlipDrop.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BlipDrop.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.BlipDropContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.BlipDropContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            var countries = new List<Country>
            {
                new Country {
                    Iso3 = "USA",
                    CountryNameEnglish = "United States of America"
                },
                new Country
                {
                    Iso3 = "CAN",
                    CountryNameEnglish = "Canada"
                },
                new Country
                {
                    Iso3 = "FRA",
                    CountryNameEnglish = "France"
                }
            };
            countries.ForEach(s => context.Countries.AddOrUpdate(p => p.Iso3, s));
            context.SaveChanges();

            var regions = new List<Region>
            {
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "AL",
                    RegionName = "Alabama"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "AK",
                    RegionName = "Alaska"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "AZ",
                    RegionName = "Arizona"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "AR",
                    RegionName = "Arkansas"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "CA",
                    RegionName = "California"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "CO",
                    RegionName = "Colorado"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "CT",
                    RegionName = "Connecticut"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "DE",
                    RegionName = "Delaware"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "NY",
                    RegionName = "ork"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "NC",
                    RegionName = "North Carolina"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "ND",
                    RegionName = "North Dakota"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "OH",
                    RegionName = "Ohio"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "OK",
                    RegionName = "Oklahoma"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "OR",
                    RegionName = "Oregon"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "PA",
                    RegionName = "Pennsylvania"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "RI",
                    RegionName = "Rhode Island"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "SC",
                    RegionName = "South Carolina"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "SD",
                    RegionName = "South Dakota"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "TN",
                    RegionName = "Tennessee"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "TX",
                    RegionName = "Texas"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "UT",
                    RegionName = "Utah"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "VT",
                    RegionName = "Vermont"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "VA",
                    RegionName = "Virginia"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "WA",
                    RegionName = "Washington"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "WV",
                    RegionName = "West Virginia"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "WI",
                    RegionName = "Wisconsin"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "WY",
                    RegionName = "Wyoming"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "AS",
                    RegionName = "American Samoa"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "FM",
                    RegionName = "Federated States of Micronesia"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "GU",
                    RegionName = "Guam"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "MH",
                    RegionName = "Marshall Islands"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "MP",
                    RegionName = "Northern Mariana Islands"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "PR",
                    RegionName = "Puerto Rico"
                },
                new Region
                {
                    Iso3 = "USA",
                    PostalCode = "VI",
                    RegionName = "US Virgin Islands"
                },
                new Region
                {
                    Iso3 = "CAN",
                    PostalCode = "AB",
                    RegionName = "Alberta"
                },
                new Region
                {
                    Iso3 = "CAN",
                    PostalCode = "BC",
                    RegionName = "British Columbia"
                },
                new Region
                {
                    Iso3 = "CAN",
                    PostalCode = "MB",
                    RegionName = "Manitoba"
                },
                new Region
                {
                    Iso3 = "CAN",
                    PostalCode = "NB",
                    RegionName = "New Brunswick"
                },
                new Region
                {
                    Iso3 = "CAN",
                    PostalCode = "NF",
                    RegionName = "Newfoundland"
                },
                new Region
                {
                    Iso3 = "CAN",
                    PostalCode = "NT",
                    RegionName = "Northwest Territories"
                },
                new Region
                {
                    Iso3 = "CAN",
                    PostalCode = "NS",
                    RegionName = "Nova Scotia"
                },
                new Region
                {
                    Iso3 = "CAN",
                    PostalCode = "NU",
                    RegionName = "Nunavut"
                },
                new Region
                {
                    Iso3 = "CAN",
                    PostalCode = "ON",
                    RegionName = "Ontario"
                },
                new Region
                {
                    Iso3 = "CAN",
                    PostalCode = "PE",
                    RegionName = "Prince Edward Island"
                },
                new Region
                {
                    Iso3 = "CAN",
                    PostalCode = "QC",
                    RegionName = "Québec"
                },
                new Region
                {
                    Iso3 = "CAN",
                    PostalCode = "SK",
                    RegionName = "Saskatchewan"
                },
                new Region
                {
                    Iso3 = "CAN",
                    PostalCode = "YT",
                    RegionName = "Yukon"
                }
            };
            regions.ForEach(s => context.Regions.AddOrUpdate(p => p.PostalCode, s));
            context.SaveChanges();
        }
    }
}
