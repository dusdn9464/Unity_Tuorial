using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test6 : MonoBehaviour
{
    private Light theLight;

    private float targetIntesity;
    private float currentIntesity;

    // Start is called before the first frame update
    void Start()
    {
        theLight = GetComponent<Light>();
        currentIntesity = theLight.intensity;
        targetIntesity = Random.Range(0.4f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(targetIntesity - currentIntesity) >= 0.01)
        {
            if (targetIntesity - currentIntesity >= 0)
                currentIntesity += Time.deltaTime * 3f;
            else
                currentIntesity -= Time.deltaTime * 3f;

            theLight.intensity = currentIntesity;
            theLight.range = currentIntesity + 10;
        }
        else
        {
            targetIntesity = Random.Range(0.4f, 1f);
        }
    }
}
