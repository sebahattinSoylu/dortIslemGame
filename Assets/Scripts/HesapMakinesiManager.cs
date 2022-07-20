using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HesapMakinesiManager : MonoBehaviour
{
    [SerializeField]
    TMP_Text girisTxt;


    int basilanRakam;

    string girilecekYazi;


    GameManager gameManager;

    

    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();    
    }

   

   


    public void SifirButonunaBasildi()
    {
        if(girisTxt.text.Length>0)
        {
            if (girisTxt.text.Substring(0, 1) == "0")
                return;
        }
       


        basilanRakam = 0;
        if (girisTxt.text == "")
        {
            girisTxt.text = "";
            girilecekYazi = "";
        }

        if (girisTxt.text.Length < 3)
        {

          



            girilecekYazi += basilanRakam.ToString();

            girisTxt.text = girilecekYazi;
        }
        


    }
    public void BirButonunaBasildi()
    {
        if (girisTxt.text.Length > 0)
        {
            if (girisTxt.text.Substring(0, 1) == "0")
            {
                girisTxt.text = "";
                girilecekYazi = "";
            }
                
        }


        basilanRakam = 1;
        if (girisTxt.text == "")
        {
            girisTxt.text = "";
            girilecekYazi = "";
        }

        if(girisTxt.text.Length<3)
        {
            girilecekYazi += basilanRakam.ToString();

            girisTxt.text = girilecekYazi;
        }

       


    }

    public void IkiButonunaBasildi()
    {
        if (girisTxt.text.Length > 0)
        {
            if (girisTxt.text.Substring(0, 1) == "0")
            {
                girisTxt.text = "";
                girilecekYazi = "";
            }

        }

        basilanRakam = 2;
        if (girisTxt.text == "")
        {
            girisTxt.text = "";
            girilecekYazi = "";
        }

        if (girisTxt.text.Length < 3)
        {
            girilecekYazi += basilanRakam.ToString();

            girisTxt.text = girilecekYazi;
        }

        

    }

    public void UcButonunaBasildi()
    {
        if (girisTxt.text.Length > 0)
        {
            if (girisTxt.text.Substring(0, 1) == "0")
            {
                girisTxt.text = "";
                girilecekYazi = "";
            }

        }


        basilanRakam = 3;
        if (girisTxt.text == "" && girisTxt.text.Length < 3)
        {
            girisTxt.text = "";
            girilecekYazi = "";
        }
        if (girisTxt.text.Length < 3)
        {
            girilecekYazi += basilanRakam.ToString();

            girisTxt.text = girilecekYazi;
        }

    }

    public void DortButonunaBasildi()
    {
        if (girisTxt.text.Length > 0)
        {
            if (girisTxt.text.Substring(0, 1) == "0")
            {
                girisTxt.text = "";
                girilecekYazi = "";
            }

        }


        basilanRakam = 4;
        if (girisTxt.text == "" && girisTxt.text.Length < 3)
        {
            girisTxt.text = "";
            girilecekYazi = "";
        }
        if (girisTxt.text.Length < 3)
        {
            girilecekYazi += basilanRakam.ToString();

            girisTxt.text = girilecekYazi;
        }

    }

    public void BesButonunaBasildi()
    {
        if (girisTxt.text.Length > 0)
        {
            if (girisTxt.text.Substring(0, 1) == "0")
            {
                girisTxt.text = "";
                girilecekYazi = "";
            }

        }


        basilanRakam = 5;
        if (girisTxt.text == "" && girisTxt.text.Length < 3)
        {
            girisTxt.text = "";
            girilecekYazi = "";
        }
        if (girisTxt.text.Length < 3)
        {
            girilecekYazi += basilanRakam.ToString();

            girisTxt.text = girilecekYazi;
        }

    }

    public void AltiButonunaBasildi()
    {
        if (girisTxt.text.Length > 0)
        {
            if (girisTxt.text.Substring(0, 1) == "0")
            {
                girisTxt.text = "";
                girilecekYazi = "";
            }

        }

        basilanRakam = 6;
        if (girisTxt.text == "" && girisTxt.text.Length < 3)
        {
            girisTxt.text = "";
            girilecekYazi = "";
        }
        if (girisTxt.text.Length < 3)
        {
            girilecekYazi += basilanRakam.ToString();

            girisTxt.text = girilecekYazi;
        }

    }

    public void YediButonunaBasildi()
    {
        if (girisTxt.text.Length > 0)
        {
            if (girisTxt.text.Substring(0, 1) == "0")
            {
                girisTxt.text = "";
                girilecekYazi = "";
            }

        }

        basilanRakam = 7;
        if (girisTxt.text == "" && girisTxt.text.Length < 3)
        {
            girisTxt.text = "";
            girilecekYazi = "";
        }
        if (girisTxt.text.Length < 3)
        {
            girilecekYazi += basilanRakam.ToString();

            girisTxt.text = girilecekYazi;
        }

    }

    public void SekizButonunaBasildi()
    {

        if (girisTxt.text.Length > 0)
        {
            if (girisTxt.text.Substring(0, 1) == "0")
            {
                girisTxt.text = "";
                girilecekYazi = "";
            }

        }

        basilanRakam = 8;
        if (girisTxt.text == "" && girisTxt.text.Length < 3)
        {
            girisTxt.text = "";
            girilecekYazi = "";
        }
        if (girisTxt.text.Length < 3)
        {
            girilecekYazi += basilanRakam.ToString();

            girisTxt.text = girilecekYazi;
        }

    }

    public void DokuzButonunaBasildi()
    {
        if (girisTxt.text.Length > 0)
        {
            if (girisTxt.text.Substring(0, 1) == "0")
            {
                girisTxt.text = "";
                girilecekYazi = "";
            }

        }

        basilanRakam = 9;
        if (girisTxt.text == "" && girisTxt.text.Length < 3)
        {
            girisTxt.text = "";
            girilecekYazi = "";
        }
        if (girisTxt.text.Length < 3)
        {
            girilecekYazi += basilanRakam.ToString();

            girisTxt.text = girilecekYazi;
        }

    }
    public void SilButonunaBasildi()
    {
        
       
        girilecekYazi ="";

        girisTxt.text = girilecekYazi;
    }

    public void GeriButonunaBasildi()
    {
        
       
        if(girilecekYazi.Length>0)
            girilecekYazi = girilecekYazi.Remove(girilecekYazi.Length - 1);
        
        if(girilecekYazi.Length==0)
        {
            girilecekYazi = "";
            
        }

        girisTxt.text = girilecekYazi;
    }

    

    public void GirisEkraniniSifirla()
    {
        girilecekYazi = "";
        girisTxt.text = girilecekYazi;

    }


}
