using Microsoft.EntityFrameworkCore;


namespace Caseshopping0625.Models
{
    //目的：建立一個「橋樑」，負責連接你的資料庫與程式。
    //DbContext 是 EF Core 的核心，用來管理連線、查詢、寫入
    public class CaseShoppingContext : DbContext
    {
        public CaseShoppingContext(DbContextOptions<CaseShoppingContext> options)
            : base(options)
        {
        }

        //我要跟資料庫的「CaseShoppingItems」資料表溝通，並且用 CaseShoppingItem(Modal) 當作每筆資料的模型
        public DbSet<CaseShoppingItem> CaseShoppingItems { get; set; }
    }
}
