using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLights : MonoBehaviour
{
    public float scaleFloat;
    public AudioSource[] newAudios;
    public AudioSource[] jungleAudios;

    void Start()
    {
        scaleFloat = 0f;
        transform.localScale = new Vector3(scaleFloat, scaleFloat, scaleFloat);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            foreach (AudioSource audioSource in newAudios)
            {
                if(audioSource.volume >= 0.01f)
                {
                    audioSource.volume = audioSource.volume / 1.04f;
                }              
            }

            foreach (AudioSource audioSource in jungleAudios)
            {
                if (audioSource.volume <= 1.0f)
                {
                    audioSource.volume = audioSource.volume * 1.04f;
                }
            }

            if (scaleFloat <= 500f)
            {
                scaleFloat += Time.deltaTime * 170f;
                transform.localScale = new Vector3(scaleFloat, scaleFloat, scaleFloat);         
            }

        }

        if (Input.GetKey(KeyCode.Mouse1))
        {
            foreach (AudioSource audioSource in newAudios)
            {
                if (audioSource.volume <= 1.0f)
                {
                    audioSource.volume = audioSource.volume * 1.04f;
                }
            }

            foreach (AudioSource audioSource in jungleAudios)
            {
                if (audioSource.volume >= 0.0001f)
                {
                    audioSource.volume = audioSource.volume / 1.04f;
                }
            }

            if (scaleFloat >= 0f)
            {
                scaleFloat -= Time.deltaTime * 170f;
                transform.localScale = new Vector3(scaleFloat, scaleFloat, scaleFloat);               
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
       Light lisrc = other.gameObject.GetComponent<Light>();
       ParticleSystem particles = other.gameObject.GetComponent<ParticleSystem>();
       MeshCollider col = other.gameObject.GetComponent<MeshCollider>();

       if (other.tag == "Licht")
       {
            lisrc.enabled = false;
            particles.Stop();

           Debug.Log("Licht soll ausgehen");
       }

       if (other.tag == "Destroyed")
       {
            if (col.enabled == false)
            {
                col.enabled = true;
            }
       }

       if (other.tag == "Calendar")
        {
            if (col.enabled == true)
            {
                col.enabled = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Light lisrc = other.gameObject.GetComponent<Light>();
        ParticleSystem particles = other.gameObject.GetComponent<ParticleSystem>();
        MeshCollider col = other.gameObject.GetComponent<MeshCollider>();

        if (other.tag == "Licht")
        {
            lisrc.enabled = true;
            particles.Play();

            Debug.Log("Licht soll angehen");
        }

        if (other.tag == "Destroyed")
        {
            if (col.enabled == true)
            {
                col.enabled = false;
            }
        }

        if (other.tag == "Calendar")
        {
            if (col.enabled == false)
            {
                col.enabled = true;
            }
        }
    }
}