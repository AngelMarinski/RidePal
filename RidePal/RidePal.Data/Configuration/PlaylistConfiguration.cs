﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RidePal.Data.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace RidePal.Data.Configuration
{
    public class PlaylistConfiguration : IEntityTypeConfiguration<Playlist>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            builder
                 .HasOne(a => a.Trip).WithOne(b => b.Playlist)
                 .HasForeignKey<Trip>(e => e.PlaylistId)
                 .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
