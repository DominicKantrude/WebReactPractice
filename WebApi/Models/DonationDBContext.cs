using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class DonationDBContext: DbContext
    {
public DonationDBContext(DbContextOptions<DonationDBContext> options):base(options)
{
    
}
public DbSet<DCandidate>  DCandidates { get; set; }
    }
}
