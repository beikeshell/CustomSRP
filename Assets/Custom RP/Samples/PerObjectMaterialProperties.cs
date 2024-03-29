using System;
using UnityEngine;

[DisallowMultipleComponent]
public class PerObjectMaterialProperties : MonoBehaviour
{
    private static MaterialPropertyBlock block;
    
    private static int baseColorId = Shader.PropertyToID("_BaseColor");
    
    [SerializeField]
    Color baseColor = Color.white;

    private void Awake()
    {
        OnValidate();
    }

    private void OnValidate()
    {
        block ??= new MaterialPropertyBlock();
        block.SetColor(baseColorId, baseColor);
        GetComponent<Renderer>().SetPropertyBlock(block);
    }
}
