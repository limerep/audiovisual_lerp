using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpTransform : MonoBehaviour {

    // Min/max distance to lerp object
    [SerializeField]
    private float minimum = -1f;
    [SerializeField]
    private float maximum = 1f;
    [SerializeField]
    private float speed = 0.1f;

    // Starting value
    static float t = 0.0f;

    private void Update()
    {
        
        transform.position = new Vector3(0,0, Mathf.Lerp(minimum, maximum, t));

        t += speed * Time.deltaTime;

        //if (t > 1.0f)
        //{
        //    float temp = maximum;
        //    maximum = minimum;
        //    minimum = temp;
        //    t = 0.0f;
        //}
    }

}