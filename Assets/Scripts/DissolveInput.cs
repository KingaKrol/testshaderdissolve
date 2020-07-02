using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveInput : MonoBehaviour
{
    public float maxRadius = 0;
    Material[] materials;
    
    // Start is called before the first frame update
    void Start()
    {
        //Renderer rend = GetComponent<Renderer>();
        materials = GetComponent<Renderer>().materials;

        foreach(Material material in materials)
        {
            material.SetFloat("Vector1_80351654", maxRadius);
            material.SetFloat("Vector1_A9534723", maxRadius);
        }

        //rend.material.SetFloat("Vector1_80351654", maxRadius);
        //rend.material.SetFloat("Vector1_A9534723", maxRadius);
    }

    // Update is called once per frame
    void Update()
    {
        materials = GetComponent<Renderer>().materials;
        //Renderer rend = GetComponent<Renderer>();
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (maxRadius <= 350f)
            {
                maxRadius += Time.deltaTime * 80f;

                foreach (Material material in materials)
                {
                    material.SetFloat("Vector1_80351654", maxRadius);
                    material.SetFloat("Vector1_A9534723", maxRadius);
                }

                //rend.material.SetFloat("Vector1_80351654", maxRadius);
                //rend.material.SetFloat("Vector1_A9534723", maxRadius);
            }
            
        }

        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (maxRadius >= 0f)
            {
                maxRadius -= Time.deltaTime * 80f;

                foreach (Material material in materials)
                {
                    material.SetFloat("Vector1_80351654", maxRadius);
                    material.SetFloat("Vector1_A9534723", maxRadius);
                }

                //rend.material.SetFloat("Vector1_80351654", maxRadius);
                //rend.material.SetFloat("Vector1_A9534723", maxRadius);
            }

        }
    }
}
