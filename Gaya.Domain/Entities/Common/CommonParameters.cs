using System;

namespace Gaya.Domain.Entities.Common
{
    public class CommonParameters
    {
        public int Key { get; set; }
        public DateTime InitialSystemDate { get; set; }
        public bool Ready { get; set; }
        public string Version { get; set; }
    }
}