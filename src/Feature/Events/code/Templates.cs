using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecon.Feature.Events
{
  public static class Templates
  {
    public static class Speaker
    {
      public static class Fields
      {
        public static readonly ID SpeakerName = new ID("{34A4E2AF-45EB-4727-9617-8AB2E6B7F3C6}");
        public static readonly ID SpeakerTitle = new ID("{93A6A0F5-BBB0-48D6-B5EA-4A8C89939D4A}");
        public static readonly ID SpeakerImage = new ID("{0C3569EA-97CD-470E-AC6F-B4B419636DB2}");
        public static readonly ID SpeakerDescription = new ID("{4106E3C9-7841-401A-A942-CFD0C2E44048}");
        public static readonly ID SpeakerTwitterUrl = new ID("{F60B573E-0A45-418D-9B32-21131E001674}");
        public static readonly ID SpeakerLinkedInUrl = new ID("{680C5DE2-64C4-47D2-A92A-8F830F33DF7E}");
        public static readonly ID SpeakerWebsiteUrl = new ID("{3CD15B30-D115-42D7-AAF9-60CB213F235D}");
      }
    }

    public static class FeaturedSpeaker
    {
      public static class Fields
      {
        public static readonly ID FeaturedSpeakersTitle = new ID("{C7BCCDA6-00D1-4F8F-B807-DAAA575A6B20}");
        public static readonly ID FeaturedSpeakersText = new ID("{CEF04141-C63A-4BD6-B6D7-097D7752D978}");
        public static readonly ID FeaturedSpeaker = new ID("{92477C30-C29C-43B4-B72D-620F873C6D18}");
        public static readonly ID FeaturedSpeakersList = new ID("{58499065-29A1-47E0-A7B1-9AEE1558CAD5}");
      }
    }

    public static class Event
    {
      public static class Fields
      {
        public static readonly ID EventName = new ID("{02FF2A17-C67D-47D2-8529-1904421FF30A}");
        public static readonly ID EventDate = new ID("{CCF84195-4501-477B-AA17-3A3D5216551E}");
        public static readonly ID IsFeaturedEvent = new ID("{CA184CCB-ACD9-4206-9103-72829926AB4C}");
        public static readonly ID EventSpeakers = new ID("{103864C1-8977-47BF-B841-17DE7E63A962}");
      }
    }

    public static class EventSchedule
    {
      public static class Fields
      {
        public static readonly ID EventScheduleBackground = new ID("{9E696815-15C5-447E-B553-798026571682}");
        public static readonly ID EventScheduleTitle = new ID("{387E817C-7905-420C-A46A-1E6A72F9AD3E}");
        public static readonly ID EventScheduleDay1Title = new ID("{A337B110-5DF5-44AC-8908-89B0C4644529}");
        public static readonly ID EventScheduleDay1Date = new ID("{67D41E4F-3DB0-431C-8A54-A2C0E11AE6E6}");
        public static readonly ID EventScheduleDay1Location = new ID("{31BAAAB1-57E6-4AFE-986C-7404417F636E}");
        public static readonly ID EventScheduleDay1Events = new ID("{8C47FC40-FEC7-444C-AE72-5C5EFBBE7385}");
        public static readonly ID EventScheduleDay2Title = new ID("{4EE1A979-F7E4-4A70-ACC0-E8005C474B18}");
        public static readonly ID EventScheduleDay2Date = new ID("{9BA67514-E892-42C5-8B38-BB6F5ADEDC10}");
        public static readonly ID EventScheduleDay2Location = new ID("{3F3B4B37-E682-40CF-9CCF-2B6F566FD5FF}");
        public static readonly ID EventScheduleDay2Events = new ID("{7087C150-191B-45D2-A021-096298222365}");
      }
    }
  }
}