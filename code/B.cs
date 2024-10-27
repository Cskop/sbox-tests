using Sandbox;

public sealed class B : Component
{
	ModelRenderer modelRenderer;
    protected override void OnAwake()
    {
        modelRenderer = Components.Get<ModelRenderer>();
    }
    protected override void OnUpdate()
	{
		modelRenderer.RenderType = ((Time.Now % 1f) < .5f) ? ModelRenderer.ShadowRenderType.Off : ModelRenderer.ShadowRenderType.ShadowsOnly;
	}
}
