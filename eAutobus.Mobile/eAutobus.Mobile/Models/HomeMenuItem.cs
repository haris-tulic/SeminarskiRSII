using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobus.Mobile.Models
{
    public enum MenuItemsType
    {
        Pocetna,
        Cjenovnik,
        Ocjena,
        RedVoznje,
       HistorijaKarata,
        RezervacijaKarte,
        OdjaviSe
       
    }
    public class HomeMenuItem
    {
        public MenuItemsType Id { get; set; }
        public string Title { get; set; }
    }
}
