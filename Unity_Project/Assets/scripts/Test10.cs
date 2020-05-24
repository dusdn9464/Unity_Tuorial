using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test10 : MonoBehaviour
{

    [SerializeField] private Text txt_name;
    [SerializeField] private Image img_name;
    [SerializeField] private Sprite sprite;

    private bool isCoolTime = false;

    private float curretTime = 5f;
    private float delayTime = 5f;

    void Update()
    {

        if(isCoolTime)
        {
            curretTime -= Time.deltaTime;
            img_name.fillAmount = curretTime /  delayTime;

            if(curretTime <= 0)
            {
                isCoolTime = false;
                curretTime = 1f;
                img_name.fillAmount = curretTime;
            }
        }
    }
    public void Change()
    {
        txt_name.text = "변경됨";
        isCoolTime = true;
    }
}
