using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper.Mappers;
using CungbanShop.Model.Models;
using CungbanShop.Web.Models;

namespace CungbanShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {

            //Mapper.CreateMap<Post, PostViewModel>();
            //Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            //Mapper.CreateMap<Tag, TagViewModel>();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();
            });
            
        }
    }
}