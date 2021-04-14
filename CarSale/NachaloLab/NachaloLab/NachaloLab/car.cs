using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace NachaloLab
{
   [Table("Cars")]
    public class Car
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string BodyType { get; set; }
        public string Price { get; set; }
        public string Text { get; set; }
        public string EngineType { get; set; }
        public string Milage { get; set; }
        public string Transmision { get; set; }
        public string TypeOfDrive { get; set; }
        public string VIN { get; set; }
        public string Color { get; set; }
        public string InteriorMaterials { get; set; }
        public string InteriorColor { get; set; }
        public string Exchange { get; set; }
        public string Light { get; set; }
        public string PhotoPath1 { get; set; }
        public string PhotoPath2 { get; set; }
        public string PhotoPath3 { get; set; }

    }
}
