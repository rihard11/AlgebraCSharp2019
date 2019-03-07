namespace _8._1._1_proizvod_zadaca
{
    internal class Proizvod
    {
        public string naziv= "";
        public double cijena = 0;
        public double marza = 0;
        public double porez = 0;

        // Metoda
        public double MPC()
        {
            return cijena + marza + porez;
        }
    }
}