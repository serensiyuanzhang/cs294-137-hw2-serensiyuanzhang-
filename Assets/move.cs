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
        float ws = Input.GetAxis("Vertical");  //����W��'S'������һ��[-1��1]��ֵ
        float ad = Input.GetAxis("Horizontal");  //����A��'D'������һ��[-1��1]��ֵ
        this.transform.Translate(Vector3.forward * ws * Time.deltaTime * 7, Space.World);  //ǰ���ƶ�
        transform.Translate(Vector3.right * ad * Time.deltaTime * 7, Space.World);  //�����ƶ�
    }
}
