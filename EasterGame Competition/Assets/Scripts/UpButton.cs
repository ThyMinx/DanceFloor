using UnityEngine;
using System.Collections;

public class UpButton : MonoBehaviour {

    public GameManager gM;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Arrow" && Input.GetKeyDown(KeyCode.UpArrow))
        {
            Destroy(col.gameObject);
            gM.score += 150;
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Arrow" && Input.GetKeyDown(KeyCode.UpArrow))
        {
            Destroy(col.gameObject);
            gM.score += 75;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Arrow" && Input.GetKeyDown(KeyCode.UpArrow))
        {
            Destroy(col.gameObject);
            gM.score += 25;
        }
    }

}
