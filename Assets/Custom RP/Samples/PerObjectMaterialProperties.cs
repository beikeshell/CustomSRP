using System;
using UnityEngine;

[DisallowMultipleComponent]
public class PerObjectMaterialProperties : MonoBehaviour
{
    private static MaterialPropertyBlock block;
    
    private static int baseColorId = Shader.PropertyToID("_BaseColor");
    private static int cutoffId = Shader.PropertyToID("_Cutoff");
    
    [SerializeField]
    Color baseColor = Color.white;

    [SerializeField, Range(0f, 1f)]
    private float cutoff = 0.5f;
    

    private void Awake()
    {
        OnValidate();
    }

    private void OnValidate()
    {
        block ??= new MaterialPropertyBlock();
        block.SetColor(baseColorId, baseColor);
        block.SetFloat(cutoffId, cutoff);
        GetComponent<Renderer>().SetPropertyBlock(block);
    }
}
