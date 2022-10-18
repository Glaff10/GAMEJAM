using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TotemTrigger : MonoBehaviour
{
    [SerializeField] private ParticleSystem ps;
    public FireTrigger fire;

    public ParticleSystem Ps { get => ps; set => ps = value; }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player" && fire.has_fire == true){
            ps.Play();
            Debug.Log(fire.has_fire);
            StartCoroutine(Example());
        
        }

        Debug.Log(ps.time);

        
    }

    IEnumerator Example()
    {   

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("GameEnding");

    }
    

}
