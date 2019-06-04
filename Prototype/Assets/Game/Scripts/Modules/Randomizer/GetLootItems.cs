using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BNWPrototype
{
    public class GetLootItems : MonoBehaviour
    {

        enum RarityType
        {
            COMMON, UNCOMMON, RARE, UNIQUE
        }

        public RectTransform itemList;
        public RectTransform commonItemPrefab;
        public RectTransform uncommonItemPrefab;
        public RectTransform rareItemPrefab;
        public RectTransform uniqueItemPrefab;

        public RectTransform temporaryItemList;

        private ItemRandomizer itemRandomizer;

        void Start()
        {
            itemRandomizer = GetComponent<ItemRandomizer>();
        }

        public void GetTestLoot(int amount)
        {
            if(GameObject.Find("Canvas/Itemlist") != null)
            {
                Debug.Log("Destroying old Itemlist");

                Destroy(GameObject.Find("Canvas/Itemlist"));
            }

            ManageItemList(amount);
        }

        void ManageItemList(int amount)
        {
            Debug.Log("Creating new Itemlist");

            Vector4 items = itemRandomizer.EvaluateChances(amount);
            RectTransform canvas = GameObject.Find("Canvas").GetComponent<RectTransform>();

            temporaryItemList = Instantiate(itemList);
            temporaryItemList.name = "Itemlist";
            temporaryItemList.transform.SetParent(canvas);
            temporaryItemList.anchoredPosition = itemList.anchoredPosition;
            temporaryItemList.sizeDelta = itemList.sizeDelta;
            temporaryItemList.eulerAngles = itemList.eulerAngles;

            CreateLoot(items.w, RarityType.UNIQUE);
            CreateLoot(items.z, RarityType.RARE);
            CreateLoot(items.y, RarityType.UNCOMMON);
            CreateLoot(items.x, RarityType.COMMON);
        }

        void CreateLoot(float amount, RarityType type)
        {
            RectTransform lootItem;

            for (int i = 0; i < amount; i++)
            {
                switch (type)
                {
                    default:
                    case RarityType.COMMON:
                        lootItem = Instantiate(commonItemPrefab);
                        break;
                    case RarityType.UNCOMMON:
                        lootItem = Instantiate(uncommonItemPrefab);
                        break;
                    case RarityType.RARE:
                        lootItem = Instantiate(rareItemPrefab);
                        break;
                    case RarityType.UNIQUE:
                        lootItem = Instantiate(uniqueItemPrefab);
                        break;
                }

                lootItem.SetParent(temporaryItemList);
            }
        }
    }
}