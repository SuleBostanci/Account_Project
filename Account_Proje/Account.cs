namespace Account_Proje;
public class Account
{
    public string Ibannumarası { get; set; }
    public string KişiAdı { get; set; }
    public double GelenPara { get; set; }
    public double GidenPara { get; set; }
    public double ToplamPara { get; set; }


    public void setIbannumarası(string Ibannumaras)
    {
        Ibannumarası = Ibannumaras;
    }
    public void setKişiadı(string KişiAdı)
    {
        KişiAdı = KişiAdı;
    }
    public void setGelenPara(string GelenPara)
    {
        GelenPara = GelenPara;
    }
    public void setGidenPara(double GidenPara)
    {
        GidenPara = GidenPara;
        {

            if (GidenPara >= 1000 && GidenPara < 2000)
            {
                GidenPara += 4;

            }
            else if (GidenPara >= 2000 && GidenPara < 10000)
            {
                GidenPara += 8;

            }
            else if (GidenPara >= 10000 && GidenPara < 20000)
            {
                GidenPara += 15;

            }
            else if ((GidenPara >= 20000))
            {
                GidenPara *= 1.08;

            }
        }
    }
    public void setToplamPara(double ToplamPara)
    {
        ToplamPara = ToplamPara;
    }




    public override string ToString()
    {
        return $"İban numarası{Ibannumarası},Kişi adı{KişiAdı},Gelen para{GelenPara},Giden para {GidenPara},Toplam para {ToplamPara}";
    }
}


