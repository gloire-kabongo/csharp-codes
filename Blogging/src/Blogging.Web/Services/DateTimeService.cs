using System;
using Blogging.Web.Interfaces;

namespace Blogging.Web.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}