using UnityEngine;

namespace Game.V1.Helper
{
	public class Bullet : MonoBehaviour
	{
		public float speed;
		public float range;
		public int damage;
		public float impactForce;

		private Vector3 startPos;

		private void Awake()
		{
			startPos = this.transform.position;
		}

		private void Update()
		{
			transform.Translate(Vector3.forward * speed * Time.deltaTime);

			if(Vector3.Distance(this.startPos, this.transform.position) >= this.range)
			{
				Destroy(this);
			}
		}
	}
}
