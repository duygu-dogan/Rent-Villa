﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentVilla.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentVilla.Data.Concrete.Configs
{
    public class AttributeTypeConfig : IEntityTypeConfiguration<AttributeType>
    {
        public void Configure(EntityTypeBuilder<AttributeType> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).HasMaxLength(100).IsRequired();
        }
    }
}
