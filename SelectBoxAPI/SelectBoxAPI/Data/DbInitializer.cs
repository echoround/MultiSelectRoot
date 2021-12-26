using Microsoft.EntityFrameworkCore;
using SelectBoxDomain.Models;
using System.Linq;


namespace SelectBoxAPI.Data
{
        public static class DbInitializer
        {
            public static void Initialize(SelectBoxAPIContext context)
            {
                
                context.Database.Migrate();

                // Check if DB seeded.
                if (context.Sectors.Any())
                {
                    return;   // DB has been seeded.
                }


                var sectors = new Sector[]
                {

                    new Sector{SectorName="Manufacturing"},
                    new Sector{SectorName="Construction materials"},
                    new Sector{SectorName="Electronics and Optics"},
                    new Sector{SectorName="Food and Beverage"},
                    new Sector{SectorName="Bakery & confectionery products"},
                    new Sector{SectorName="Beverages"},
                    new Sector{SectorName="Fish & fish products"},
                    new Sector{SectorName="Meat & meat products"},
                    new Sector{SectorName="Milk & dairy products"},
                    new Sector{SectorName="Other"},
                    new Sector{SectorName="Sweets & snack food"},
                    new Sector{SectorName="Furniture"},
                    new Sector{SectorName="Bathroom/sauna"},
                    new Sector{SectorName="Bedroom"},
                    new Sector{SectorName="Children's room"},
                    new Sector{SectorName="Kitchen"},
                    new Sector{SectorName="Living room"},
                    new Sector{SectorName="Office"},
                    new Sector{SectorName="Other (Furniture)"},
                    new Sector{SectorName="Outdoor"},
                    new Sector{SectorName="Project furniture"},
                    new Sector{SectorName="Machinery"},
                    new Sector{SectorName="Machinery components"},
                    new Sector{SectorName="Machinery equipment/tools"},
                    new Sector{SectorName="Manufacture of machinery"},
                    new Sector{SectorName="Maritime"},
                    new Sector{SectorName="Aluminium and steel workboats"},
                    new Sector{SectorName="Boat/Yacht building"},
                    new Sector{SectorName="Ship repair and conversion"},
                    new Sector{SectorName="Metal structures"},
                    new Sector{SectorName="Other"},
                    new Sector{SectorName="Repair and maintenance service"},
                    new Sector{SectorName="Metalworking"},
                    new Sector{SectorName="Construction of metal structures"},
                    new Sector{SectorName="Houses and buildings"},
                    new Sector{SectorName="Metal products"},
                    new Sector{SectorName="Metal works"},
                    new Sector{SectorName="CNC-machining"},
                    new Sector{SectorName="Forgings, Fasteners"},
                    new Sector{SectorName="Gas, Plasma, Laser cutting"},
                    new Sector{SectorName="MIG, TIG, Aluminum welding"},
                    new Sector{SectorName="Plastic and Rubber"},
                    new Sector{SectorName="Packaging"},
                    new Sector{SectorName="Plastic goods"},
                    new Sector{SectorName="Plastic processing technology"},
                    new Sector{SectorName="Blowing"},
                    new Sector{SectorName="Moulding"},
                    new Sector{SectorName="Plastics welding and processing"},
                    new Sector{SectorName="Plastic profiles"},
                    new Sector{SectorName="Printing"},
                    new Sector{SectorName="Advertising"},
                    new Sector{SectorName="Book/Periodicals printing"},
                    new Sector{SectorName="Labelling and packaging printing"},
                    new Sector{SectorName="Textile and Clothing"},
                    new Sector{SectorName="Clothing"},
                    new Sector{SectorName="Textile"},
                    new Sector{SectorName="Wood"},
                    new Sector{SectorName="Other (Wood)"},
                    new Sector{SectorName="Wooden building materials"},
                    new Sector{SectorName="Wooden houses"},
                    new Sector{SectorName="Other"},
                    new Sector{SectorName="Creative industries"},
                    new Sector{SectorName="Energy technology"},
                    new Sector{SectorName="Environment"},
                    new Sector{SectorName="Service"},
                    new Sector{SectorName="Business services"},
                    new Sector{SectorName="Engineering"},
                    new Sector{SectorName="Information Technology and Telecommunications"},
                    new Sector{SectorName="Data processing, Web portals, E-marketing"},
                    new Sector{SectorName="Programming, Consultancy"},
                    new Sector{SectorName="Software, Hardware"},
                    new Sector{SectorName="Telecommunications"},
                    new Sector{SectorName="Tourism"},
                    new Sector{SectorName="Translation services"},
                    new Sector{SectorName="Transport and Logistics"},
                    new Sector{SectorName="Air"},
                    new Sector{SectorName="Rail"},
                    new Sector{SectorName="Road"},
                    new Sector{SectorName="Water"}

                };

                foreach (Sector s in sectors)
                {
                    context.Sectors.Add(s);
                }

                context.SaveChanges();

            }
        }
}
