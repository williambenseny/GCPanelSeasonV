
namespace GCPanelSeasonV.Model
{
	public class GoodsInfoList
	{
		public int GoodsID { get; set; }
		public string GoodsName { get; set; }
		public int Duration { get; set; }
		public int CharType { get; set; }

		public string ItemText
		{
			get => $"ID {GoodsID} | {GoodsName}";
		}
	}
}
