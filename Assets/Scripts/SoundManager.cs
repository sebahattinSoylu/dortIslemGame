using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    AudioSource backgroundSource;

    [SerializeField]
    Image sesImg;

    [SerializeField]
    Sprite sesAcikIcon, sesKapaliIcon;

    bool sesAcikmi;

    private void Start()
    {
        sesAcikmi = true;
    }


    public void SesiAcKapat()
    {
        if(sesAcikmi)
        {
            sesImg.sprite = sesKapaliIcon;
        } else
        {
            sesImg.sprite = sesAcikIcon;
        }

        sesAcikmi =!sesAcikmi;

        OyunArkaPlanSesiCikar(sesAcikmi);
    }

    public void OyunArkaPlanSesiCikar(bool sesCiksinmi)
    {
        if (sesCiksinmi)
        {
            if (!backgroundSource.isPlaying)
            {
                backgroundSource.Play();
            }
        }
        else
        {
            if (backgroundSource.isPlaying)
            {
                backgroundSource.Stop();
            }
        }
    }

    public void AnaMenuyeDon()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
