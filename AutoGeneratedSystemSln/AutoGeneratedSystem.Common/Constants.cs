﻿namespace AutoGeneratedSystem.Common
{
    public static class Constants
    {
        public static class PageRoutes
        {
            public static class CompanyRoutes
            {
                public const string Create = "/Company/Create";
            }
            public static class ApplicationRoleRoutes
            {
                public const string Create = "/ApplicationRole/Create";
                public const string List = "/ApplicationRole/List";
            }
            public static class ApplicationUserRoutes
            {
                public const string List = "/ApplicationUser/List";
                public const string Create = "/ApplicationUser/Create";
            }
        }
        public static class EntityNames
        {
            public const string ApplicationUser = nameof(ApplicationUser);
            public const string ApplicationRole = nameof(ApplicationRole);
            public const string Store = nameof(Store);
            public const string Company = nameof(Company);
        }
    }
}