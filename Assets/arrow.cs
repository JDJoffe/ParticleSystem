using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
   public GameObject player;
    Rigidbody rb;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 arrowrot = new Vector3(0, rb.velocity.y, 0);
        transform.LookAt(player.transform.position +arrowrot);
    }
}
