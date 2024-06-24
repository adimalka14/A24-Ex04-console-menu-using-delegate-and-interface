namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        protected readonly string r_Name;

        protected MenuItem(string i_Name)
        {
            this.r_Name = i_Name;
        }

        internal string Name
        {
            get { return this.r_Name; }
        }

        internal abstract void NotifySelectedMenuItem();

        internal abstract void AddBackOption(MenuItem i_MenuItem);
    }
}