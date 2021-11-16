using System;
using System.Collections.Generic;
using ProjectForTests.Repository;

namespace ProjectForTests.Tests.Infrastructure.Helpers
{
    public class CategoryHelper
    {
        public static Category GetOne(string id = "7b2be83f-906d-4184-4c79-7d23aa6ad243",
            string organizationId = "60468b18-0634-a38b-43ea-95ff3aff36ca")
        {
            return new Category
            {
                Id = Guid.Parse(id),
                Name = "CATEGORY NAME",
                Description = "CATEGORY DESCRIPTION",
                BriefName = "CATEG",
                OrganizationId = Guid.Parse(organizationId)
            };
        }

        public static IEnumerable<Category> GetMany()
        {
            yield return GetOne();
        }
    }
}