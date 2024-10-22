using Flueris.Extensions;

namespace FluerisStarterKit
{
    public static class SidebarModels
    {
        public static List<SidebarItem> GetSidebarToggle()
        {
            List<SidebarItem> list = new()
        {
            new SidebarItem { Id = "1", Group = "0", Label = "Blazor sample pages", Image = "icon-192.png"  },
            new SidebarItem { Id = "2", Group = "0", Label = "Dialog boxes", Icon = "fa-solid fa-message"  },
            new SidebarItem { Id = "3", Group = "0", Label = "Menu controls", Icon = "fas  fa-bars"  },
            new SidebarItem { Id = "4", Group = "0", Label = "Text editing", Icon = "fas fa-text-width"  },
            new SidebarItem { Id = "5", Group = "0", Label = "Grouping controls", Icon = "fa-solid fa-object-group"  },

            new SidebarItem { Id = "1.1", Group = "1", Label = "Counter", URL = "counter" },
            new SidebarItem { Id = "1.2", Group = "1", Label = "Weather ", URL = "weather" },

            new SidebarItem { Id = "2.1", Group = "2", Label = "OpenFileDialog"  },
            new SidebarItem { Id = "2.2", Group = "2", Label = "PrintDialog "  },
            new SidebarItem { Id = "2.3", Group = "2", Label = "PrintPreviewDialog"  },
            new SidebarItem { Id = "2.4", Group = "2", Label = "SaveFileDialog"  },

            new SidebarItem { Id = "3.1", Group = "3", Label = "MenuStrip "  },
            new SidebarItem { Id = "3.2", Group = "3", Label = "Context MenuStrip"  },

            new SidebarItem { Id = "4.1", Group = "4", Label = "TextBox"  },
            new SidebarItem { Id = "4.2", Group = "4", Label = "Rich TextBox "  },
            new SidebarItem { Id = "4.3", Group = "4", Label = "Masked TextBox"  },

            new SidebarItem { Id = "5.1", Group = "5", Label = "Panel"  },
            new SidebarItem { Id = "5.2", Group = "5", Label = "Group Box "  },
            new SidebarItem { Id = "5.3", Group = "5", Label = "Tab Control"  },

        };

            return list;
        }
    }
}
