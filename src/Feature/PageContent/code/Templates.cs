using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecon.Feature.PageContent
{
  public static class Templates
  {

    public static class BodyCopy
    {

      public static class Fields
      {

        public static readonly ID BodyCopy = new ID("{47630014-446B-41C0-93E9-5E735B641BB2}");
      }
    }

    public static class TwoImage
    {

      public static class Fields
      {

        public static readonly ID Image1 = new ID("{B36C861E-06AF-44C7-B0E0-0536949DA198}");
        public static readonly ID Image2 = new ID("{64D049B7-6A1C-42FC-8392-2B4BA11139C9}");
      }
    }
    public static class TitleAndText
    {

      public static class Fields
      {

        public static readonly ID ComponentTitle = new ID("{432FFD44-AC0D-4824-8A9D-6EC988C8998E}");
        public static readonly ID ComponentText = new ID("{B36D1856-D7C8-4982-9F08-9412835D05B8}");
      }
    }
  }
  
}