namespace SeminarskiWebAPI.Database
{
    public class Stanica
    {
        public int StanicaID { get; set; }
        public string NazivLokacijeStanice { get; set; }
        public int GradID { get; set; }
        public Grad Grad { get; set; }
    }
}