using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMove : MonoBehaviour
{
    public float Speedz;
    public float Speedy;
    public float Speedx;
    public float StartTime;
    public float EndTime;




    public float RSpeedz;
    public float RSpeedy;
    public float RSpeedx;
    public float RStartTime;
    public float REndTime;
    float t = 0;
    float Rt = 0;
    Vector3 ABC = new Vector3(1, 1, 1);
    void Start()
    {
        this.ABC = new Vector3(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (t < StartTime)
        {
            t = t + Time.deltaTime;
        }
        else if (t < EndTime)
        {
            //行动
            //this.GetComponent<Rigidbody>().velocity = new Vector3(Speedx, Speedy, Speedz);
            this.transform.Translate(Vector3.right * Time.deltaTime * Speedx);
            this.transform.Translate(Vector3.up * Time.deltaTime * Speedy);
            this.transform.Translate(Vector3.forward * Time.deltaTime * Speedz);
            t = t + Time.deltaTime;
        }
        if (Rt < RStartTime)
        {
            Rt = Rt + Time.deltaTime;
        }
        else if (Rt < REndTime)
        {
            //行动
            ABC.x += RSpeedx;
            ABC.y += RSpeedy;
            ABC.z += RSpeedz;
            this.transform.rotation = Quaternion.Euler(ABC);
            Rt = Rt + Time.deltaTime;
        }


    }
}