using AutoMapper;
using Mango.Servicec.CouponAPI.Models;
using Mango.Servicec.CouponAPI.Models.Dto;

namespace Mango.Servicec.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
