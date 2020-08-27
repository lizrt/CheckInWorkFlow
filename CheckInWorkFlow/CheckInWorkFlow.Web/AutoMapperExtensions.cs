using System.Collections.Generic;
using AutoMapper;
using CheckInWorkFlow.Data.Models;
using CheckInWorkFlow.Web.ViewModels;

namespace CheckInWorkFlow.Web
{
    public static class AutoMapperExtensions
{
    public static IEnumerable<TDestination> MapList<TSource, TDestination>(this IMapper mapper, IEnumerable<TSource> source)
    {
        return mapper.Map<IEnumerable<TDestination>>(source);
    }
}
}