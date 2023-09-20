using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    private Rigidbody rd;
    public int force = 5;
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rd.AddForce(new Vector3(h, 0, v) * force);
    }
    //´¥·¢¼ì²â
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "coin")
        {
            Destroy(collider.gameObject);
        }
    }
}