using AutoMapper;
using OData_Grid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;

namespace OData_Grid
{
    public static class AutomapperConfig
    {
        public static void Register()
        {
            //Mapper.CreateMap<Product, ProductDTO>();
            Mapper.Initialize(cfg =>
                cfg.CreateMap<Product, ProductDTO>()
                .ForMember(m => m.Name, conf => conf.MapFrom(ol => ol.Name))
                .ForMember(m => m.Description, conf => conf.MapFrom(ol => ol.Description))
                .ForMember(m => m.OnStock, conf => conf.MapFrom(ol => ol.OnStock))
            );
        }
    }
}
