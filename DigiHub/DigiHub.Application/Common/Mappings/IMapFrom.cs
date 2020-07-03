using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiHub.Application.Common.Mappings
{
    public interface IMapFrom<T>
    {
        void Mapping(T profile);
        
    }
}
