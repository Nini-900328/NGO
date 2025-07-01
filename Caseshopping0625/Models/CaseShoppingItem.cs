namespace Caseshopping0625.Models
{
    //讓 C# 認識你的資料表結構，未來可以用 C# 操作資料。
    //Model 就像是資料庫中一筆資料的「類別樣板」跟資料表的欄位要「名稱完全一致」才能正確映射
    public class CaseShoppingItem
    {
        public int Id { get; set; }                 // 商品編號
        public string ?Name { get; set; }            // 商品名稱
        public string ?ImageUrl { get; set; }        // 商品圖片連結
        public string ? Description { get; set; }        // 商品圖片連結
        public string? Category { get; set; }  // 商品類別
    }
}
