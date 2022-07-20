using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class SonucManager : MonoBehaviour
{
    [SerializeField]
    TMP_Text dogruTxt, yanlisTxt, puanTxt;

    [SerializeField]
    AudioClip finishClip,butonClip;

    public void SonucuGoster(int dogruAdet,int yanlisAdet,int puan)
    {
        dogruTxt.text = dogruAdet + " Adet";
        yanlisTxt.text = yanlisAdet + " Adet";
        puanTxt.text = puan + " Puan";

        AudioSource.PlayClipAtPoint(finishClip, Camera.main.transform.position);
    }

    public void YenidenOyna()
    {
        AudioSource.PlayClipAtPoint(butonClip, Camera.main.transform.position);
        SceneManager.LoadScene("GamePlay");
    }




}
