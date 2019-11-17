using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEvents : Event
{
    public float duration;
    ParticleSystem temp;
    Event eventSystem;
    // Start is called before the first frame update
    void Start()
    {
        hostObject = gameObject;
        particleSystem = GetComponent<ParticleSystem>();
    }
    public override void EventFunc()
    {
        var main = particleSystem.main;
        main.duration = duration;
        base.EventFunc();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
