using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test11 : MonoBehaviour
{
    [SerializeField] private Slider slider;

    private bool isClick;

    private float dotTime = 1f;
    private float curretDotTime = 0f;

    private void Start()
    {
        curretDotTime = dotTime;
    }

    private void Update()
    {
        if (isClick)
        {
            curretDotTime -= Time.deltaTime;

            if (curretDotTime <= 0)
            {
                slider.value -= Time.deltaTime;
                if(curretDotTime <= -1)
                {
                    curretDotTime = dotTime;
                }
            }
        }
    }
    // Start is called before the first frame update
    public void Button()
    {
        isClick = true;
    }
}
