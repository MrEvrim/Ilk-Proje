using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class IkinciHaftaProje : MonoBehaviour
{
    void Start()
    {
        yapilacakIslemler(16, 61);
    }

    void yapilacakIslemler(int birinciS, int ikinciS)
    {
        //try hata ayıklaması için koydum el alışkanlığı
        try
        {
            List<int> sayilar = new List<int>();
            
            // if - else if kullandım çünkü ilk veya ikinci sayı büyük olma ihtimalleri programı bozar.
            if (birinciS > ikinciS)
            {
                sayilar.Add(ikinciS);
                while (birinciS >= ikinciS)
                {
                    ikinciS++;
                    sayilar.Add(ikinciS);
                }
            }

            else if (birinciS < ikinciS)
            {
                sayilar.Add (birinciS);
                while (birinciS <= ikinciS)
                {
                    birinciS++;
                    sayilar.Add(birinciS);
                }


            }
            //ilk oluşturdugum liste içerisinden 2-3-4-5 e bölünebilenlerin ayrı bir listeye eklemek ve ekrana yazdırmak.
            List<int> ikiyeBölünebilenler = sayilar.FindAll(sayi => sayi % 2 == 0);

            Debug.Log($"2 ile bölünebilenler: {string.Join(" - ", ikiyeBölünebilenler)}");

            List<int> uceBölünebilenler = sayilar.FindAll(sayi => sayi % 3 == 0);
            Debug.Log($"3 ile bölünebilenler: {string.Join(" - ", uceBölünebilenler)}");

            List<int> dorteBolunenler = sayilar.FindAll(sayi => sayi % 4 == 0);
            Debug.Log($"4 ile bölünebilenler: {string.Join(" - ", dorteBolunenler)}");

            List<int> beseBolunenler = sayilar.FindAll(sayi => sayi % 5 == 0);
            Debug.Log($"5 ile bölünebilenler: {string.Join(" - ", beseBolunenler)}");

        }
        catch (System.Exception ex )
        {

            Debug.Log(ex);
        }
       
        
    }
}