using UnityEngine;
 
public static class RendererExtensions
{
	public static bool IsVisibleFrom(this Renderer renderer, Camera camera)
	{

/*
using UnityEngine;
 
public class TestRendered : MonoBehaviour
{	
	void Update()
	{
		if (renderer.IsVisibleFrom(Camera.main)) Debug.Log("Visible");
		else Debug.Log("Not visible");
	}
}
*/

		Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
		return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
	}
}
