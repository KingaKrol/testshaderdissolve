using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SphericalMask : MonoBehaviour
{
    public float radius = 0.5f;
    public float softness = 0.5f;

    public float Radiusi = 0.5f;
    public float Softnessi = 0.5f;

    public float scaleFactor = 1f;

    void Update()
    {
        Shader.SetGlobalVector("_GLOBALIMaskPosition", transform.position);
        Shader.SetGlobalFloat("_GLOBALIMaskRadius", radius);
        Shader.SetGlobalFloat("_GLOBALIMaskSoftness", softness);

        Shader.SetGlobalVector("_GLOBALMaskPosition", transform.position);
        Shader.SetGlobalFloat("_GLOBALMaskRadius", Radiusi);
        Shader.SetGlobalFloat("_GLOBALMaskSoftness", Softnessi);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            radius += scaleFactor * Time.deltaTime;
            Radiusi += scaleFactor * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            radius -= scaleFactor * Time.deltaTime;
            Radiusi -= scaleFactor * Time.deltaTime;
        }
    }
}
