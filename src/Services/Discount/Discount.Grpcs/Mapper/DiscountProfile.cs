using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Discount.Grpcs.Enitities;
using Discount.Grpcs.Protos;

namespace Discount.Grpcs.Mapper
{
    public class DiscountProfile: Profile
    {
        public DiscountProfile()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}