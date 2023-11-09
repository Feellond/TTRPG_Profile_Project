using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Additional
{
    [Table("Sources")]
    public class Source : EntityBase
    {
        public string Name { get; set; } = string.Empty;
    }
}
