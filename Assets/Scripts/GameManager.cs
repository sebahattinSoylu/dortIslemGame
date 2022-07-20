using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    TMP_Text soruTxt,sonucTxt;

    [SerializeField]
    GameObject patlamaEfect,dogruEfect,yanlisEfect;

    [SerializeField]
    Image fillImage;

    [SerializeField]
    GameObject trueIcon, falseIcon;

    [SerializeField]
    GameObject sonucPanel;

    [SerializeField]
    GameObject hesapMakinesiPanel, puanPanel, haklarPanel,sesPanel,exitBtn;

    [SerializeField]
    TMP_Text uyariTxt;

    [SerializeField]
    AudioClip trueClip, falseClip,startClip;


    int birinciSayi, ikinciSayi, sonucSayi;

    string yazilacakSayi;


    public int ustDeger;

    public string secilenIslem;

    int rastgeleDeger;

    

    int kacinciSeviye;

    

   public int toplamSure;

    bool sureBaslasinmi;


    HesapMakinesiManager hesapMakinesiManager;
    HaklarManager haklarManager;
    PuanManager puanManager;

    SonucManager sonucManager;

   


    private void Awake()
    {
        hesapMakinesiManager = Object.FindObjectOfType<HesapMakinesiManager>();
        haklarManager = Object.FindObjectOfType<HaklarManager>();
        puanManager = Object.FindObjectOfType<PuanManager>();
        sonucManager = Object.FindObjectOfType<SonucManager>();
       
    }

    private void Start()
    {
        
        kacinciSeviye = 0;
    }

    public void SecilenIslemiAyarla()
    {
        uyariTxt.GetComponent<CanvasGroup>().DOFade(0, .2f);


       

        if(kacinciSeviye==0)
        {
            AudioSource.PlayClipAtPoint(startClip, Camera.main.transform.position);
        }

        if (sonucTxt.text==string.Empty)
        {
            if (secilenIslem == "toplama")
            {
                ToplamaIslemiYap();
            }
            else if (secilenIslem == "çýkarma")
            {
                CikarmaIslemliYap();
            }
            else if (secilenIslem == "çarpma")
            {
                CarpmaIslemiYap();
            }
            else if (secilenIslem == "bölme")
            {
                BolmeIslemiYap();
            }
            else if (secilenIslem == "rastgele")
            {
                rastgeleDeger = Random.Range(0, 4);


                switch (rastgeleDeger)
                {
                    case 0:
                        ToplamaIslemiYap();
                        break;

                    case 1:
                        CikarmaIslemliYap();
                        break;

                    case 2:
                        CarpmaIslemiYap();
                        break;

                    case 3:
                        BolmeIslemiYap();
                        break;
                }

            }
            
            
            
        }
            


        
    }

    public void KontrolEt()
    {
        if (!sureBaslasinmi)
            return;

        if(sonucTxt.text=="")
        {
            SureyiCikar("Sonuç alanýný boþ býrakmayýnýz.");
            return;
        }

       

        if(sonucTxt.text!="")
        {
            if (int.Parse(sonucTxt.text) == sonucSayi)
            {
                SetActiveTrueIcon();
                dogruEfect.SetActive(true);
                puanManager.DogruArtir();
                AudioSource.PlayClipAtPoint(trueClip, Camera.main.transform.position);

            }
            else
            {
                AudioSource.PlayClipAtPoint(falseClip, Camera.main.transform.position);
                haklarManager.HakAzalt();
                puanManager.YanlisArtir();
                SetActiveFalseIcon();
                yanlisEfect.SetActive(true);
            }
        }
        

        if(haklarManager.kalanHak>0)
        {
            kacinciSeviye++;
            sonucTxt.text = "";
            Invoke("SecilenIslemiAyarla", 0.5f);
            
        } else
        {
            SonucuGoster();
            sureBaslasinmi = false;
        }
        

    }

   
    void SoruyuCikar(string gelenSoru)
    {
        hesapMakinesiManager.GirisEkraniniSifirla();

        patlamaEfect.SetActive(true);
        sureBaslasinmi = false;
        Invoke("FillAmountSifirla", 0.6f);

        fillImage.fillAmount = 1f;


        soruTxt.GetComponent<RectTransform>().localScale=Vector3.zero;
        soruTxt.GetComponent<CanvasGroup>().alpha = 0f;

        soruTxt.text = gelenSoru;

        soruTxt.GetComponent<RectTransform>().DOScale(1, .5f);
        soruTxt.GetComponent<CanvasGroup>().DOFade(1, .5f);
    }


   public void CarpmaIslemiYap()
    {
        birinciSayi = Random.Range(1, ustDeger);
        ikinciSayi = Random.Range(1, ustDeger);

        yazilacakSayi = birinciSayi.ToString() + "x" + ikinciSayi.ToString()+ " =?";
        sonucSayi = birinciSayi * ikinciSayi;


        SoruyuCikar(yazilacakSayi);

    }


    public void ToplamaIslemiYap()
    {
        

        birinciSayi = Random.Range(1, ustDeger);
        ikinciSayi = Random.Range(1, ustDeger);

        yazilacakSayi = birinciSayi.ToString() + "+" + ikinciSayi.ToString()+ " =?";
        sonucSayi = birinciSayi + ikinciSayi;

        SoruyuCikar(yazilacakSayi);
    }

    public void CikarmaIslemliYap()
    {
        birinciSayi = Random.Range(1, ustDeger);
        ikinciSayi = Random.Range(1, ustDeger);

        while (birinciSayi < ikinciSayi)
            CikarmaIslemliYap();

        yazilacakSayi = birinciSayi.ToString() + "-" + ikinciSayi.ToString() + " =?";
        sonucSayi = birinciSayi - ikinciSayi;

        SoruyuCikar(yazilacakSayi);
    }

    public void BolmeIslemiYap()
    {
        birinciSayi = Random.Range(2, ustDeger);
        ikinciSayi = Random.Range(1, ustDeger);

        int bolunenSayi = birinciSayi * ikinciSayi;

        yazilacakSayi = bolunenSayi.ToString() + ":" + birinciSayi.ToString() + " =?";
        sonucSayi = ikinciSayi;


        SoruyuCikar(yazilacakSayi);

    }

    public void UstDegeriAyarla(int secilenDeger)
    {
        ustDeger = secilenDeger;
    }



    

    void FillAmountSifirla()
    {
        sureBaslasinmi = true;
    }


    private void Update()
    {

        if(sureBaslasinmi)
        {
            
            fillImage.fillAmount -= (float) 1.0f / toplamSure * Time.deltaTime;


            if (fillImage.fillAmount <= 0)
            {
                sureBaslasinmi = false;
                haklarManager.HakAzalt();
                puanManager.YanlisArtir();
                SetActiveFalseIcon();
                yanlisEfect.SetActive(true);

                SureyiCikar("Süreyi zamanýnda kullanamadýn.");

                AudioSource.PlayClipAtPoint(falseClip, Camera.main.transform.position);

                if (haklarManager.kalanHak > 0)
                {
                    sonucTxt.text = "";
                    Invoke("SecilenIslemiAyarla", 1f);

                }
                else
                {
                    SonucuGoster();
                   
                }


            }

           



        }
    }



    void SureyiCikar(string uyari)
    {
        uyariTxt.text = uyari;

        uyariTxt.GetComponent<CanvasGroup>().DOFade(1, .4f);
    }

    void SetActiveTrueIcon()
    {


        trueIcon.GetComponent<RectTransform>().DOScale(1, .4f).SetEase(Ease.OutBack);
        trueIcon.GetComponent<CanvasGroup>().DOFade(1, .4f);

        Invoke("SetPasiveTrueIcon", .8f);
    }

    void SetPasiveTrueIcon()
    {
        trueIcon.GetComponent<RectTransform>().DOScale(0, .2f);
        trueIcon.GetComponent<CanvasGroup>().DOFade(0, .2f);


    }

    void SetActiveFalseIcon()
    {


        falseIcon.GetComponent<RectTransform>().DOScale(1, .4f).SetEase(Ease.OutBack);
        falseIcon.GetComponent<CanvasGroup>().DOFade(1, .4f);

        Invoke("SetPasiveFalseIcon", .8f);
    }

    void SetPasiveFalseIcon()
    {


        falseIcon.GetComponent<RectTransform>().DOScale(0, .2f);
        falseIcon.GetComponent<CanvasGroup>().DOFade(0, .2f);
    }


    void SonucuGoster()
    {
        sonucManager.SonucuGoster(puanManager.dogruAdet, puanManager.yanlisAdet, puanManager.toplamPuan);


        uyariTxt.GetComponent<CanvasGroup>().DOFade(0, .2f);

        hesapMakinesiPanel.GetComponent<RectTransform>().DOScale(0, .2f);
        hesapMakinesiPanel.GetComponent<CanvasGroup>().DOFade(0, .2f);


        haklarPanel.GetComponent<RectTransform>().DOScale(0, .2f);
        haklarPanel.GetComponent<CanvasGroup>().DOFade(0, .2f);


        puanPanel.GetComponent<RectTransform>().DOScale(0, .2f);
        puanPanel.GetComponent<CanvasGroup>().DOFade(0, .2f);

        sonucPanel.GetComponent<RectTransform>().DOScale(1, .5f).SetEase(Ease.OutBack);
        sonucPanel.GetComponent<CanvasGroup>().DOFade(1, .5f);

        sesPanel.GetComponent<CanvasGroup>().DOFade(0, .2f);
        exitBtn.GetComponent<CanvasGroup>().DOFade(0, .2f);

    }

    public void OyundanCik()
    {
        Application.Quit();
    }












}
