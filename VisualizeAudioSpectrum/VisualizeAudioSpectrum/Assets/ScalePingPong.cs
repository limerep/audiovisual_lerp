using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalePingPong : MonoBehaviour {

	void Update ()
	{
        transform.localScale = new Vector3(Mathf.PingPong(Time.time, 3), transform.localScale.y, transform.localScale.z);
	}
}