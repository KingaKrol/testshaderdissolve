using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLights : MonoBehaviour
{
    public float scaleFloat;
    public GameObject Light;
    // Start is called before the first frame update
    void Start()
    {
        scaleFloat = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (scaleFloat <= 350f)
            {
                scaleFloat += Time.deltaTime * 80f;
                this.transform.localScale = new Vector3(scaleFloat, scaleFloat, scaleFloat);
            }

        }

       

        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (scaleFloat >= 0f)
            {
                scaleFloat -= Time.deltaTime * 80f;
                this.transform.localScale = new Vector3(scaleFloat, scaleFloat, scaleFloat);
            }

        }
    }


    private void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Licht") {
            other.gameObject.SetActive(false);
           Debug.Log("Licht soll ausgehen");
       }
    }

}