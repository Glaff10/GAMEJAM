using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrigger : MonoBehaviour
{
    [SerializeField] private ParticleSystem ps;
    public bool has_fire = false;

    public ParticleSystem Ps { get => ps; set => ps = value; }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
        ps.Play();
        Debug.Log(ps.name);
        has_fire = true;
        }
    }

}
