using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UpArrow : MonoBehaviour {

    public int speed = -5;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
