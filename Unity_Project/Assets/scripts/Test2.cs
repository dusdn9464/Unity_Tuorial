using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    private Rigidbody myRigid;
    //private Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
        //rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            myRigid.AddExplosionForce(10, this.transform.right, 10);
        }
    }
}
