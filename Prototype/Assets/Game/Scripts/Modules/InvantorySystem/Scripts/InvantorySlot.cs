using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

using Game.Managers;

namespace Game.Logics
{
	public class InvantorySlot : MonoBehaviour, IPointerEnterHandler
	{
		public Sprite baseSoltImage, activeSlotImage;
		public Image itemImage;
		public TMP_Text slotText;
		public int slotID;
		[HideInInspector] public Invantory owningInventory;

		// Use this for initialization
		void Start()
		{
			slotText = GetComponentInChildren<TMP_Text>();
			SetItem(null, 0);
		}

		public void ToggleSlot(bool active)
		{
			if (active)
				GetComponent<Image>().sprite = activeSlotImage;
			else
				GetComponent<Image>().sprite = baseSoltImage;
		}

		public void SetItem(Sprite image, int quantity)
		{
			if (image == null)
			{
				itemImage.enabled = false;
			}
			else if (itemImage.enabled == false)
			{
				itemImage.enabled = true;
			}
			
			itemImage.sprite = image;
			slotText.text = quantity == 0 ? "" : quantity.ToString();
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
			owningInventory.ToggleSlotAtID(slotID);
		}
	}
}