using System;

namespace BusinessLogic
{
    public struct Price
    {
        public decimal? Value { get; set; }
        public DateTimeOffset? Date { get; set; }
    }
}