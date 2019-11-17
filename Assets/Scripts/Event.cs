using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Event : MonoBehaviour
{
  public  GameObject hostObject;
  public  ParticleSystem particleSystem;
    public virtual void EventFunc()
    {
        particleSystem.Play();
    }

}
