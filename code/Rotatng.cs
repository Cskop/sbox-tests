using Sandbox;
using System;

public sealed class Rotatng : Component
{
	protected override void OnUpdate()
	{
		WorldPosition = new Vector3( MathF.Sin( Time.Now )*200, MathF.Cos( Time.Now )*200, 200 );
	}
}
