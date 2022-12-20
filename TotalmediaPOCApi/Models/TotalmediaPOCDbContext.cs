using Microsoft.EntityFrameworkCore;
using System;

namespace TotalmediaPOCApi.Models
{
    public class TotalmediaPOCDbContext : DbContext
    {
        public TotalmediaPOCDbContext(DbContextOptions<TotalmediaPOCDbContext> options) : base(options) { }

        #region DbSet's

        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryVATRate> CountryVATRates { get; set; }

        #endregion

        #region Model creating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // seed's
            SeedAll(modelBuilder);
        }

        #endregion

        #region Seed's

        /// <summary>
        /// Seed tables
        /// </summary>
        /// <param name="modelBuilder">ModelBuilder obj</param>
        private void SeedAll(ModelBuilder modelBuilder)
        {
            // seed tables
            SeedCountries(modelBuilder);
            SeedCountryVATRates(modelBuilder);
        }

        /// <summary>
        /// Seed countries
        /// </summary>
        /// <param name="modelBuilder">ModelBuilder obj</param>
        private void SeedCountries(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country()
                {
                    CountryId = new Guid("8FC99100-6C51-4B50-B640-ABB96593CB6A"),
                    CountryName = "Portugal"
                },
                new Country()
                {
                    CountryId = new Guid("0B1E9CE5-70A5-4D61-8A09-9E9DCFD80CEC"),
                    CountryName = "France"
                },
                new Country()
                {
                    CountryId = new Guid("445AE582-533C-4A95-94DE-60C4694DD220"),
                    CountryName = "United Kingdom"
                },
                new Country()
                {
                    CountryId = new Guid("8E7ED540-A4A4-4F0A-80BA-DDE9473B4F41"),
                    CountryName = "Spain"
                }
            );
        }

        /// <summary>
        /// Seed country VAT rates
        /// </summary>
        /// <param name="modelBuilder">ModelBuilder obj</param>
        private void SeedCountryVATRates(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryVATRate>().HasData(
                new CountryVATRate()
                {
                    CountryVATRateId = new Guid("5B86F9EF-1D81-4F75-A013-4EF19A23FA46"),
                    CountryVATRateValue = 5.5M,
                    CountryId = new Guid("0B1E9CE5-70A5-4D61-8A09-9E9DCFD80CEC")
                },
                new CountryVATRate()
                {
                    CountryVATRateId = new Guid("06FFF34F-0CC9-4A20-BAD9-0A9111A347F2"),
                    CountryVATRateValue = 20,
                    CountryId = new Guid("0B1E9CE5-70A5-4D61-8A09-9E9DCFD80CEC")
                },
                new CountryVATRate()
                {
                    CountryVATRateId = new Guid("D7DFFAB9-1E36-4377-A076-01AAECD38A09"),
                    CountryVATRateValue = 10,
                    CountryId = new Guid("0B1E9CE5-70A5-4D61-8A09-9E9DCFD80CEC")
                },
                new CountryVATRate()
                {
                    CountryVATRateId = new Guid("BFDD0A03-40A4-42C8-87D5-7D03B15F9AD9"),
                    CountryVATRateValue = 5,
                    CountryId = new Guid("445AE582-533C-4A95-94DE-60C4694DD220")
                },
                new CountryVATRate()
                {
                    CountryVATRateId = new Guid("7A238B83-5238-4CE0-828C-B38C4F577765"),
                    CountryVATRateValue = 20,
                    CountryId = new Guid("445AE582-533C-4A95-94DE-60C4694DD220")
                },
                new CountryVATRate()
                {
                    CountryVATRateId = new Guid("C79D35BA-E75E-46DC-B7BE-3DFED93B031A"),
                    CountryVATRateValue = 6,
                    CountryId = new Guid("8FC99100-6C51-4B50-B640-ABB96593CB6A")
                },
                new CountryVATRate()
                {
                    CountryVATRateId = new Guid("777CD10F-B105-4AE1-A2A6-2743D4C74331"),
                    CountryVATRateValue = 13,
                    CountryId = new Guid("8FC99100-6C51-4B50-B640-ABB96593CB6A")
                },
                new CountryVATRate()
                {
                    CountryVATRateId = new Guid("63C515D4-E4F9-40EC-A0A9-5D53221FBE7E"),
                    CountryVATRateValue = 23,
                    CountryId = new Guid("8FC99100-6C51-4B50-B640-ABB96593CB6A")
                },
                new CountryVATRate()
                {
                    CountryVATRateId = new Guid("31C2D3C0-8A16-490F-B242-C568F3F6928F"),
                    CountryVATRateValue = 21,
                    CountryId = new Guid("8E7ED540-A4A4-4F0A-80BA-DDE9473B4F41")
                },
                new CountryVATRate()
                {
                    CountryVATRateId = new Guid("F7484DE8-856E-45E7-86BF-40AD86ED470C"),
                    CountryVATRateValue = 10,
                    CountryId = new Guid("8E7ED540-A4A4-4F0A-80BA-DDE9473B4F41")
                }
            );
        }

        #endregion
    }

}
