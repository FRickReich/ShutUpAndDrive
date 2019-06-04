using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupItem : MonoBehaviour
{
    public RectTransform UIImage;
    public RectTransform UIImagePrefab;


    // Start is called before the first frame update
    void Start()
    {
        UIImage = Instantiate(UIImagePrefab, this.transform.position, this.transform.rotation, GameObject.Find("GameUI/HUDPanel/Indicators").transform);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        UIImage.position = Game.Extensions.VectorExtensions.TransformToScreenPosition(new Vector3(
            this.transform.position.x,
            this.transform.position.y,
            this.transform.position.z + 1
        ));
    }
}
