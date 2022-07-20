using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class AyarlarManager : MonoBehaviour
{
    [SerializeField]
    Transform secimButonlariTransform;

    int secilenDeger;

   

    [SerializeField]
    Transform ayarlarPanel,hesapMakinesiPanel,haklarPanel,puanPanel;

    [SerializeField]
    AudioClip  butonClip;

    int sayiAdet;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }

    void Start()
    {
        AllIconsSetActiveFalse();

        secilenDeger = 5;
        gameManager.toplamSure = 15;

        secimButonlariTransform.GetChild(0).GetChild(1).transform.gameObject.SetActive(true);
    }

   void AllIconsSetActiveFalse()
    {
        for (int i = 0; i < secimButonlariTransform.childCount; i++)
        {
            secimButonlariTransform.GetChild(i).GetChild(1).transform.gameObject.SetActive(false);
        }
    }

    public void SecimiYap()
    {
        AllIconsSetActiveFalse();
        UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.GetChild(1).gameObject.SetActive(true);
        AudioSource.PlayClipAtPoint(butonClip, Camera.main.transform.position);
        secilenDeger =int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text);

        

       if(secilenDeger<=10)
        {
            gameManager.toplamSure = 15;
        } 

       if(secilenDeger>10 && secilenDeger<=30)
        {
            gameManager.toplamSure = 20;
        }

        if (secilenDeger > 30)
            gameManager.toplamSure = 25;
        
    }



    public void OyunuBaslat()
    {

        ayarlarPanel.GetComponent<CanvasGroup>().DOFade(0, .5f);
        ayarlarPanel.GetComponent<RectTransform>().DOScale(0, .5f).SetEase(Ease.InBack);
        AudioSource.PlayClipAtPoint(butonClip, Camera.main.transform.position);

        puanPanel.GetComponent<CanvasGroup>().DOFade(1, .5f);
        

        haklarPanel.GetComponent<CanvasGroup>().DOFade(1, .5f);
       

        hesapMakinesiPanel.GetComponent<CanvasGroup>().DOFade(1, .5f);
        hesapMakinesiPanel.GetComponent<RectTransform>().DOScale(1, .5f).SetEase(Ease.OutBack);

        gameManager.UstDegeriAyarla(secilenDeger + 1);

        gameManager.SecilenIslemiAyarla();
    }

    
}
