using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }   
        public ComicBook ComicBook  { get; set; }

        public double Valor { get; set; }
        public DateTime FechaVenta{ get; set; }

    }
}