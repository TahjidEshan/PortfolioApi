﻿using System.ComponentModel;

namespace PortFolio2017.Enums
{
    public class Enums
    {
    }
    public enum LifeEvent
    {
        [Description("Work Details")]
        WorkDetails = 1,
        Education,
        Publication
    }

    public enum DisplayType
    {
        Chart =1,
        ProgressBar
    }
    public enum SocialLinkType
    {
        Sidebar = 1,
        Footer 
    }
}
