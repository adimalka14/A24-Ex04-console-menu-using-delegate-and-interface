namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem
    {
        private readonly IExecuteLeafAction r_ExecuteLeafItem;
        private MenuItem m_BackItem;

        public ActionItem(string i_Name, IExecuteLeafAction i_ExecuteILeafItem) : base(i_Name)
        {
            this.r_ExecuteLeafItem = i_ExecuteILeafItem;
        }

        internal override void NotifySelectedMenuItem()
        {
            r_ExecuteLeafItem.ExecuteLeafAction();
            m_BackItem?.NotifySelectedMenuItem();
        }

        internal override void AddBackOption(MenuItem i_MenuItem)
        {
            this.m_BackItem = i_MenuItem;
        }
    }
}