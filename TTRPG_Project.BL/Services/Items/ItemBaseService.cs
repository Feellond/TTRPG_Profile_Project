using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.Services.Items
{
    public class ItemBaseService : BaseService<ItemBase, int>
    {
        public ItemBaseService(ApplicationDbContext dbContext) : base(dbContext)
        {
        
        }
    }
}
