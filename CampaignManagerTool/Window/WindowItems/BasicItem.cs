namespace CampaignManagerTool.Pages.PageItems
{
    class BasicItem : IBaseItem
    {
        public string Header;

        string IBaseItem.ItemName => Header;
    }
}
