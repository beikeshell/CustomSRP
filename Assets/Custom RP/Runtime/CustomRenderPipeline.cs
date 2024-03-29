using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CustomRenderPipeline : RenderPipeline
{
    private CameraRenderer renderer = new CameraRenderer();

    public CustomRenderPipeline()
    {
        GraphicsSettings.useScriptableRenderPipelineBatching = true;
    }
    
    protected override void Render(ScriptableRenderContext context, Camera[] cameras)
    {
        
    }

    /// <summary>
    /// Each frame Unity invokes Render on the RP instance.
    /// It passes along a context struct that provides a connection to the native engine, which we can use for rendering.
    /// It also passes an array of cameras, as there can be multiple active cameras in the scene.
    /// It is the RP's responsibility to render all those cameras in the order that they are provided.
    /// </summary>
    /// <param name="context"></param>
    /// <param name="cameras"></param>
    protected override void Render(ScriptableRenderContext context, List<Camera> cameras)
    {
        for (var i = 0; i < cameras.Count; i++)
        {
            renderer.Render(context, cameras[i]);
        }
    }
}
