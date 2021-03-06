﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Shell.Feeds.FeedTypes;

namespace events.tac.local.Models
{
    public class NavigationItem
    {
        public NavigationItem(string title, string url, bool active = false)
        {
            Title = title;
            URL = url;
            Active = active;
        }

        public string Title { get; set; }
        public string URL { get; set; }
        public bool Active { get; set; }
    }
}