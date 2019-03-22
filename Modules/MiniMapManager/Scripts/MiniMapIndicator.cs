using UnityEngine;

using Game.Modules;

namespace Game.Modules.MiniMapManager
{
	public class MiniMapIndicator : MonoBehaviour 
	{
		public Sprite IndicatorSprite;
		public SpriteRenderer indicatorPrefab;
		public float distance;

		private SpriteRenderer newIndicator;
		private float playerSizeOnMap = 7.5f;
		private float initialSize = 2.5f;
		private float maxSize = 5f;
		private float closeDistance = 100f;
		private Transform player; 

		private void Awake()
		{
			player = GameObject.FindGameObjectWithTag("Player").transform;
			CreateMiniMapIndicator();

			ChangeSprite(IndicatorSprite);
		}

		private void Update()
		{	
			distance = Vector3.Distance(player.position, transform.position);

			if(distance <= closeDistance)
			{
				ControlIndicatorSize(Mathf.Clamp((closeDistance / distance), initialSize, maxSize));
			}
			else
			{
				ControlIndicatorSize(initialSize);
			}
		}

        private void CreateMiniMapIndicator()
        {
            newIndicator = Instantiate(indicatorPrefab, gameObject.transform.position, Quaternion.LookRotation(Vector3.up), gameObject.transform);
        }

		public void ChangeSprite(Sprite newSprite)
		{
			newIndicator.sprite = newSprite;
			ControlIndicatorSize(initialSize);
		}

		public void ControlIndicatorSize(float size)
		{
			if(gameObject.tag == "Player")
			{
				newIndicator.transform.localScale = new Vector3(playerSizeOnMap, playerSizeOnMap, 1);
			}
			else
			{
				newIndicator.transform.localScale = new Vector3(size, size, 1);
			}
		}
	}
}