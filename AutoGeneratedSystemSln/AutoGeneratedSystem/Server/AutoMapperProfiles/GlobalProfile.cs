﻿using AutoGeneratedSystem.DataAccess.Models;
using AutoGeneratedSystem.Models.ApplicationRole;
using AutoGeneratedSystem.Models.ApplicationUser;
using AutoGeneratedSystem.Models.Company;
using AutoGeneratedSystem.Models.Store;
using AutoGeneratedSystem.Models.ApplicationUserApplicationRole;
using AutoGeneratedSystem.Models.Product;
using AutoMapper;

namespace AutoGeneratedSystem.Server.AutoMapperProfiles
{
    public class GlobalProfile : Profile
    {
        public GlobalProfile()
        {
            CreateMap<CreateApplicationUserModel, ApplicationUser>();
            CreateMap<ApplicationUserModel, ApplicationUser>();
            CreateMap<ApplicationUser, ApplicationUserModel>();

            CreateMap<CreateApplicationRoleModel, ApplicationRole>();
            CreateMap<ApplicationRoleModel, ApplicationRole>();
            CreateMap<ApplicationRole, ApplicationRoleModel>();

            CreateMap<CreateStoreModel, Store>();
            CreateMap<StoreModel, Store>();
            CreateMap<Store, StoreModel>();

            CreateMap<CreateCompanyModel, Company>();
            CreateMap<CompanyModel, Company>();
            CreateMap<Company, CompanyModel>();

            CreateMap<CreateApplicationUserApplicationRoleModel, ApplicationUserApplicationRole>();
            CreateMap<ApplicationUserApplicationRoleModel, ApplicationUserApplicationRole>();
            CreateMap<ApplicationUserApplicationRole, ApplicationUserApplicationRoleModel>();

            CreateMap<CreateProductModel, Product>();
            CreateMap<ProductModel, Product>();
            CreateMap<Product, ProductModel>();
        }
    }
}
