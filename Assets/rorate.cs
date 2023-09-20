using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rorate : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
        this.transform.Rotate(Vector3.right, Space.Self);//втв╙
    }
}