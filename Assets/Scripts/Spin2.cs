using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin2 : MonoBehaviour
{
    public GameObject obj;
	public float speed;
    // Start is called before the first frame update
    void Awake()
    {
        obj = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
		    
    obj.transform.Rotate(0,speed * Time.deltaTime,0);

    }
}
