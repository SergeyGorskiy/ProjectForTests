using System;

namespace ProjectForTests.Repository
{
    public class Category
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string BriefName { get; set; }

        public Guid OrganizationId { get; set; }


    }
}