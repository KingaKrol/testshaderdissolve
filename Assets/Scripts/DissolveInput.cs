using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveInput : MonoBehaviour
{
    public float maxRadius = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.SetFloat("Vector1_80351654", maxRadius);
        Debug.Log(rend.material.GetFloat("Vector1_80351654"));

        rend.material.SetFloat("Vector1_A9534723", maxRadius);
        Debug.Log(rend.material.GetFloat("Vector1_A9534723"));
    }

    // Update is called once per frame
    void Update()
    {
        Renderer rend = GetComponent<Renderer>();
        if (Input.GetKey(KeyCode.A))
        {
            if (maxRadius <= 40f)
            {
                maxRadius += Time.deltaTime * 5f;
                rend.material.SetFloat("Vector1_80351654", maxRadius);
                Debug.Log(rend.material.GetFloat("Vector1_80351654"));

                rend.material.SetFloat("Vector1_A9534723", maxRadius);
                Debug.Log(rend.material.GetFloat("Vector1_A9534723"));
            }
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (maxRadius >= 0f)
            {
                maxRadius -= Time.deltaTime * 5f;
                rend.material.SetFloat("Vector1_80351654", maxRadius);
                Debug.Log(rend.material.GetFloat("Vector1_80351654"));

                rend.material.SetFloat("Vector1_A9534723", maxRadius);
                Debug.Log(rend.material.GetFloat("Vector1_A9534723"));
            }

        }
    }
}
