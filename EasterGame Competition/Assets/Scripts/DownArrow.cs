using UnityEngine;
using System.Collections;

public class DownArrow : MonoBehaviour {

    public int speed = -5;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
