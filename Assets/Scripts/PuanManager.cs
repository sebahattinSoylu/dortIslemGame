using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class PuanManager : MonoBehaviour
{
    [SerializeField]
    TMP_Text puanTxt, dogruTxt, yanlisTxt;

    [SerializeField]
    GameObject bonusImg;

    public int toplamPuan,dogruAdet,yanlisAdet;

    int araPuan,bonusAdet;

    bool bonusKazandimi;

    void Start()
    {

        toplamPuan = 0;
        dogruAdet = 0;
        yanlisAdet = 0;
        araPuan = 0;

        puanTxt.text = "0";
        dogruTxt.text = "0";
        yanlisTxt.text = "0";
    }

    public void DogruArtir()
    {
        dogruAdet++;
        bonusAdet++;


        if(bonusAdet>=5 && bonusAdet<9)
        {
            bonusKazandimi = true;
            BonusCikar();
        }

        if(bonusAdet>=9)
        {
            bonusKazandimi = false;
            bonusAdet = 0;
            BonusKaybet();
        }


        PuaniArtir();

        dogruTxt.text = dogruAdet.ToString();
    }

    public void YanlisArtir()
    {
        yanlisAdet++;
        bonusAdet = 0;
        bonusKazandimi = false;

        BonusKaybet();

        yanlisTxt.text = yanlisAdet.ToString();
    }

    public void PuaniArtir()
    {
        if (bonusKazandimi)
        {
            araPuan = 25;
        }
        else
        {
            araPuan = 10;
        }

        toplamPuan += araPuan;

        puanTxt.text = toplamPuan.ToString();


    }

    void BonusCikar()
    {
        bonusImg.GetComponent<RectTransform>().DOScale(1, .5f).SetEase(Ease.OutBack);
        bonusImg.GetComponent<CanvasGroup>().DOFade(1, .5f);
    }

    void BonusKaybet()
    {
        bonusImg.GetComponent<RectTransform>().DOScale(0, .5f);
        bonusImg.GetComponent<CanvasGroup>().DOFade(0, .5f);
    }


}
