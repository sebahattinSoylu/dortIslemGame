using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HaklarManager : MonoBehaviour
{
    [SerializeField]
    Image healtFillImg;


    public int kalanHak;


    private void Start()
    {
        kalanHak = 3;
        healtFillImg.fillAmount = 1f;
    }
    public void HakAzalt()
    {
        kalanHak--;

        if(kalanHak==3)
        {
            healtFillImg.GetComponent<Image>().DOFillAmount(1, .3f);
           
        } else if(kalanHak==2)
        {
            healtFillImg.GetComponent<Image>().DOFillAmount(.66f, .3f);
        }
        else if (kalanHak == 1)
        {
            healtFillImg.GetComponent<Image>().DOFillAmount(.33f, .3f);
        }
        else if (kalanHak == 0)
        {
            healtFillImg.GetComponent<Image>().DOFillAmount(0, .3f);
        }
    }



}
