using UnityEngine;
using System.Collections;

public class RightArrow : MonoBehaviour {

    public int speed = -5;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (gameObject.transform.position.y >= 6.5f)
        {
            Destroy(gameObject);
        }
    }
}
