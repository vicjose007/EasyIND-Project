﻿using EasyIND.Application.Dtos;
using EasyIND.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyIND.Application.Common.Interfaces
{
    public interface ICareerService : IEntityCRUDService<Career, CareerDto>
    {

        List<Career> GetAllCareers();

        Career CreateCareer(Career career);

        Career DeleteCareer(Career career);

    }
}
