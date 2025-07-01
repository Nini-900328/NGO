using System.ComponentModel.DataAnnotations;


namespace Caseshopping0625.Models
{
    public class ActivityItem
    {
        [Key]
        public int  ActivityId { get; set; }  //活動編號

        public string ?ActivityName { get; set; }  //活動名稱

        public string ?Description { get; set; }  //活動說明

        public string? Location { get; set; } //活動地點

        public int ?MaxParticipants { get; set; }  //最大人數

        public int ?CurrentParticipants { get; set; }  //已報名人數

        public DateTime ?StartDate { get; set; }  //活動開始日期

        public DateTime ?EndDate { get; set; }  //活動結束日期

        public string? ImageUrl { get; set; } // 活動圖片路徑或檔名

    }
}
