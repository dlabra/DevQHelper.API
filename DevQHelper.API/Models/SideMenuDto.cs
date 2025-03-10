namespace DevQHelper.API.Models
{
    public class SideMenuDto
    {
        public int Id { get; set; }
        public string DisplayName { get; set; } = string.Empty;
        public int IdRole { get; set; }
        public ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
    }

    public class MenuItem
    {
        public int Id { get; set; }
        public int IdSidebar { get; set; }
        public string DisplayName { get; set; } = string.Empty;
        public ICollection<MenuItemCategory> Category { get; set; } = new List<MenuItemCategory>();
    }

    public class MenuItemCategory
    {
        public int Id { get; set; }
        public int IdMenuItem { get; set; }
        public string DisplayName { get; set; } = string.Empty;
        public string IconName { get; set; } = string.Empty;
        public string Route { get; set; } = string.Empty;
        public int IdTechnology { get; set; }
        public int IdFramework { get; set; }
        public int IdDifficulty { get; set; }

    }
}
