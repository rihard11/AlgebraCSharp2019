namespace _8._2._2_static_instanca_zadaca
{
    internal class Static_Instanca
    {
        #region STAIC metoda

        public static bool Prost(int broj)
        {
            bool prost = true;

            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            return prost;
        }
        #endregion

        #region Metoda instance

        public bool Savrsen(int broj)
        {
            int zbrojDjelitelja = 0;

            for (int i = 1; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    zbrojDjelitelja = zbrojDjelitelja + i;
                }
            }

            if (broj == zbrojDjelitelja)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}