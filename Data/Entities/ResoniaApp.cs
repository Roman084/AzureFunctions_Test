namespace FunctionApp.Data.Entities
{
    public class ResoniaApp
    {
        public string Title { get; set; }
        public string Tehtavanimi { get; set; }
        public string TyonantajanNimi { get; set; }
        public string Kunta { get; set; }
        public string Kuvaus { get; set; }
        public string Kuvausteksti { get; set; }
        public string KuvaustekstiHTML { get; set; }
        public string Yhteystiedot { get; set; }
        public string TyopaikanOsoite { get; set; }
        public string Palkkausteksti { get; set; }
        public string TyoAlkaaTeksti { get; set; }
        public string Tyoaika { get; set; }
        public string TyonKesto { get; set; }
        public string HakuPaattyy { get; set; }

        public string HakemusLahetetaanHTML { get; set; }
        public string HakemusLahetetaanKevytHTML { get; set; }
        public string Ilmoituspaivamaarateksti{ get; set; }
        public string Ilmoitusnumero { get; set; }
        public string LahettajanViite { get; set; }
    }
}