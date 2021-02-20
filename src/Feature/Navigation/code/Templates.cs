using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecon.Feature.Navigation
{
  public static class Templates
  {
    public static class Header
    {
      public static class Fields
      {
        public static readonly ID Logo = new ID("{97C28A37-998E-4F61-B96D-89F81EBD1347}");
        public static readonly ID HomeLink = new ID("{5E54968B-18D0-43F2-ACC6-F9FD4DB88666}");
        public static readonly ID EventsRoot = new ID("{84922A7D-BA36-4F04-82BF-714A8530E041}");
        public static readonly ID ScheduleLink = new ID("{386F6CD4-B8E0-42FB-8D89-0F43B5709B76}");
      }
    }

    public static class Footer
    {
      public static class Fields
      {
        public static readonly ID FooterTextLeft = new ID("{3086D63C-82BB-4F4F-B13C-576B6C1F9093}");
        public static readonly ID FooterLinkLeft = new ID("{40DE43D1-3318-44EC-AB75-167D0EC3A852}");
        public static readonly ID FooterLinkTextLeft = new ID("{3D73C0D7-32C9-4EE7-9531-7E4E07B2629B}");
        public static readonly ID FooterTextRight = new ID("{3D74911C-1DAE-4D5D-A6F5-71101122288D}");
        public static readonly ID FooterLinkRight = new ID("{5D3950A4-0A99-4215-9BD7-19FB101C0FEE}");
        public static readonly ID FooterLinkTextRight = new ID("{089A2D9D-F54B-41D8-BE91-5E792E2BCB76}");
      }
    }
  }
}