using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAllPlayerPrefsPro : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        PlayerPrefsPro.DeleteAll();
    }
}
