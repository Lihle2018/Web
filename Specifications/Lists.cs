using Web.Models;

namespace Web.Specifications
{
    public static class Lists
    {
        public static List<string> LicenceCode = new List<string>() { "Code 8", "Code 10" };
        public static List<string> Packages = new List<string>() { "Full course: 25 lessons + testing vehicle( 2 chances)", "Refresher course: 10 lessons + testing vehicle", "Test prep: 2 lessons + testing vehicle"};
        public static List<Package> packages = new List<Package>()
        {
            new Package()
            {
                Id=Guid.NewGuid(),
                Code="Code 8",
                Name="Full course",
                Description="25 lessons + testing vehicle( 2 chances)",
                price=3300m,
                duration=4,
                image="courses-1.jpg"
            },
            new Package()
            {
                Id=Guid.NewGuid(),
                Name="Refresher course",
                Description="10 lessons + testing vehicle",
                Code="Code 8",
                price=1600m,
                 duration=2,
                 image="courses-2.jpg"
            },
            new Package()
            {
                Id = Guid.NewGuid(),
                Name="Test preparation",
                Description="2 lessons + testing vehicle",
                Code="Code 8",
                price=950m,
                 duration=1,
                 image="courses-3.jpg"
            },
            new Package()
            {
                Id=Guid.NewGuid(),
                Code="Code 10",
                Name="Full course",
                Description="25 lessons + testing vehicle( 2 chances)",
                price=3800m,
                 image="courses-1.jpg",
                  duration=4

            },
            new Package()
            {
                Id=Guid.NewGuid(),
                Name="Refresher course",
                Description="10 lessons + testing vehicle",
                Code="Code 10",
                price=2600m,
                 image="courses-2.jpg",
                  duration=2
            },
            new Package()
            {
                Id = Guid.NewGuid(),
                Name="Test preparation",
                Description="2 lessons + testing vehicle",
                Code="Code 10",
                price=1500m,
                 image="courses-3.jpg",
                  duration=1
            }

        };
    }
}
