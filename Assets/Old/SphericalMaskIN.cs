using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphericalMaskIN : MonoBehaviour
{
    public float Radiusi = 0.5f;
    public float Softnessi = 0.5f;

    void Update()
    {
        Shader.SetGlobalVector("_GLOBALMaskPosition", transform.position);
        Shader.SetGlobalFloat("_GLOBALMaskRadius", Radiusi);
        Shader.SetGlobalFloat("_GLOBALMaskSoftness", Softnessi);
    }
}
