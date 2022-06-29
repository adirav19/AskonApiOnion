using dbfirstTest.Domain.Entities.Common;
using System;
using System.Collections.Generic;

namespace dbfirstTest.Domain.Entities
{
    public  class Vardiya:BaseEntity
    {
        public int Id { get; set; }
        public string? Vardiya1 { get; set; }
        public TimeSpan? Baslangic { get; set; }
        public TimeSpan? Bitis { get; set; }
        public bool? Gundegisimi { get; set; }
        public byte? Grup { get; set; }
        public bool? Gunduz { get; set; }
        public bool? GundegisimiA { get; set; }
    }
}
