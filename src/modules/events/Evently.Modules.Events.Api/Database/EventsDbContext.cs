﻿using Evently.Modules.Events.Api.Events;
using Microsoft.EntityFrameworkCore;

namespace Evently.Modules.Events.Api.Database;
public sealed class EventsDbContext(DbContextOptions<EventsDbContext> options) : DbContext(options)
{
    public DbSet<Event> Events { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(Schemas.Events);
    }


}
