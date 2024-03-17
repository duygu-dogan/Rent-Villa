﻿using RentVilla.Application.Repositories.AttributeRepo;
using RentVilla.Domain.Entities.Concrete;
using RentVilla.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentVilla.Persistence.Repositories.AttributeCRepo
{
    public class AttributeReadRepository : ReadRepository<ProductAttribute>, IAttributeReadRepository
    {
        public AttributeReadRepository(RentVillaDbContext context) : base(context)
        {
        }
    }
}