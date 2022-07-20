using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    GameObject mathImg,dortIslemYaziImg,toplamaBtn,cikarmaBtn,carpmaBtn,bolmeBtn,rastgeleBtn;

    [SerializeField]
    GameObject menuPanel,sesPanel,exitBtn;
    
   

    [SerializeField]
    GameObject ayarlarPanel;

    [SerializeField]
    AudioClip bubbleClip,butonClip;

    string hangiOyunSecildi;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }

    private void Start()
    {
        StartCoroutine(MenuSahneElemanlariniAcRoutine());
    }

    IEnumerator MenuSahneElemanlariniAcRoutine()
    {
        yield return null;

        mathImg.GetComponent<RectTransform>().DORotate(Vector3.zero, .5f).SetEase(Ease.OutBack);
        mathImg.GetComponent<CanvasGroup>().DOFade(1, 0.5f);

      

        yield return new WaitForSeconds(.3f);

        dortIslemYaziImg.GetComponent<RectTransform>().DORotate(Vector3.zero, 0.5f).SetEase(Ease.OutBack);
        dortIslemYaziImg.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        

        yield return new WaitForSeconds(.3f);

        toplamaBtn.GetComponent<RectTransform>().DORotate(Vector3.zero, 0.5f).SetEase(Ease.OutBack);
        toplamaBtn.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        AudioSource.PlayClipAtPoint(bubbleClip, Camera.main.transform.position);

        yield return new WaitForSeconds(.3f);

        cikarmaBtn.GetComponent<RectTransform>().DORotate(Vector3.zero, 0.5f).SetEase(Ease.OutBack);
        cikarmaBtn.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        AudioSource.PlayClipAtPoint(bubbleClip, Camera.main.transform.position);

        yield return new WaitForSeconds(.3f);

        carpmaBtn.GetComponent<RectTransform>().DORotate(Vector3.zero, 0.5f).SetEase(Ease.OutBack);
        carpmaBtn.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        AudioSource.PlayClipAtPoint(bubbleClip, Camera.main.transform.position);

        yield return new WaitForSeconds(.3f);

        bolmeBtn.GetComponent<RectTransform>().DORotate(Vector3.zero, 0.5f).SetEase(Ease.OutBack);
        bolmeBtn.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        AudioSource.PlayClipAtPoint(bubbleClip, Camera.main.transform.position);

        yield return new WaitForSeconds(.3f);

        rastgeleBtn.GetComponent<RectTransform>().DORotate(Vector3.zero, 0.5f).SetEase(Ease.OutBack);
        rastgeleBtn.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        AudioSource.PlayClipAtPoint(bubbleClip, Camera.main.transform.position);

        
        sesPanel.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        exitBtn.GetComponent<CanvasGroup>().DOFade(1, 0.5f);

    }

    public void MenuyuKapat()
    {
        menuPanel.GetComponent<CanvasGroup>().DOFade(0, .5f);
        menuPanel.GetComponent<RectTransform>().DOScale(0, .5f).SetEase(Ease.InBack).OnComplete(AyarlarPaneliniAc);

        AudioSource.PlayClipAtPoint(butonClip, Camera.main.transform.position);

        if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.name=="toplamaBtn")
        {
            gameManager.secilenIslem = "toplama";
        }

        if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.name == "cikarmaBtn")
        {
            gameManager.secilenIslem = "çýkarma";
        }
        if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.name == "carpmaBtn")
        {
            gameManager.secilenIslem = "çarpma";
        }


        if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.name == "bolmeBtn")
        {
            gameManager.secilenIslem = "bölme";
        }


        if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.name == "rastgeleBtn")
        {
            gameManager.secilenIslem = "rastgele";
        }
    }


    void AyarlarPaneliniAc()
    {
        ayarlarPanel.GetComponent<CanvasGroup>().DOFade(1, .5f);
        ayarlarPanel.GetComponent<RectTransform>().DOScale(1, .5f).SetEase(Ease.OutBack);
       
    }

    

   


}
