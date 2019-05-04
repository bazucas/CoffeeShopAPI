﻿using System.Collections.Generic;

namespace CleanArchitecture.Core.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public ICollection<SubMenu> SubMenus { get; set; }
    }
}