using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class collision : MonoBehaviour
{
    private Rigidbody rd;
    public int force = 5;
    private int score_num = 0;
    public GameObject score;
    public GameObject win;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
        win.SetActive(false);
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rd.AddForce(new Vector3(h, 0, v) * force);
    }
    //Åö×²¼ì²â
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "coin")
        {
            Debug.Log(score_num);
            score_num++;
            score.GetComponent<TMP_Text>().text = "score: " + score_num.ToString();
            if (score_num == 8)
            {
                win.SetActive(true);
            }
            Destroy(collision.collider.gameObject);
        }
    }
}
  