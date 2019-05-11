using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;

namespace snd
{
public class NoticationCenter : MonoBehaviour
{
    public NotificationManager notificationMessage;
    public GameObject parent;

    private UnityAction create;

    void Awake ()
    {
        
    }

    void OnEnable ()
    {
        //FindObjectOfType<InterfaceSection>().sendNotification += CreateNew;
    }

    void OnDisable ()
    {
        //FindObjectOfType<InterfaceSection>().sendNotification -= CreateNew;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateNew(string header, string description)
    {
        Debug.Log(header + "/" + description);

        NotificationManager nm = Instantiate(notificationMessage, parent.transform.position, parent.transform.rotation, parent.transform);
        nm.notificationHeaderInput = header;
        nm.notificationDescriptionInput = description;

    }
    }
}