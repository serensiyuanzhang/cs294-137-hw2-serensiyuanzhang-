using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Vector3 mPrevPos = Vector3.zero;
    Vector3 mPosDelta = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        float ws = Input.GetAxis("Vertical");  //按‘W’'S'键返回一个[-1，1]的值
        float ad = Input.GetAxis("Horizontal");  //按‘A’'D'键返回一个[-1，1]的值
        this.transform.Translate(Vector3.forward * ws * Time.deltaTime * 7, Space.World);  //前后移动
        transform.Translate(Vector3.right * ad * Time.deltaTime * 7, Space.World);  //左右移动
    }
}
