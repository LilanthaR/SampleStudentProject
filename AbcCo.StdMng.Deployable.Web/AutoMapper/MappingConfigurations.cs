using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AutoMapper;

namespace AbcCo.StdMng.Deployable.Web.AutoMapper
{
    public class MappingConfigurations
    {

        public static void Configure()
        {
            Mapper.CreateMap<Studnt, StudentViewModel>();
        }
    }
}