using System;

namespace Ex04.Menus.Delegates
{
    public class ActionItem : MenuItem
    {
        private MenuItem m_BackItem;
        public event Action ExecuteActionItem;

        public ActionItem(string i_Name) : base(i_Name) { }

        internal override void NotifySelectedMenuItem()
        {
            ExecuteLeafItem();
            m_BackItem?.NotifySelectedMenuItem();
        }

        protected virtual void ExecuteLeafItem()
        {
            ExecuteActionItem?.Invoke();
        }

        internal override void AddBackOption(MenuItem i_MenuItem)
        {
            this.m_BackItem = i_MenuItem;
        }
    }
}