using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Ray t_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit t_hit;
            if(Physics.Raycast(t_ray, out t_hit, 100f))
            {
                t_hit.transform.GetComponent<Cube>().Explosion();
            }
        }
    }

}
