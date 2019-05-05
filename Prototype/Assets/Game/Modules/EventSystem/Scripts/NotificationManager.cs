using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace snd
{
    public class NotificationManager : MonoBehaviour
    {
        public float lifeTime = 5f;

        public Sprite notificationIconInput;
        public string notificationHeaderInput;
        public string notificationDescriptionInput;
 
        public Image notificationIcon;
        public TMP_Text notificationHeader;
        public TMP_Text notificationDescription;

        private StateManager stateManager = new StateManager();
        public Animator animator;
        

        // Start is called before the first frame update
        void Awake()
        {
            animator = GetComponent<Animator>();
            this.stateManager.ChangeState(new UIPopulateNotificationState(stateManager, this));
        }

        // Update is called once per frame
        void Update()
        {
            this.stateManager.ExecuteStateUpdate();
        }

        public void PopulateNotification()
        {
            notificationIcon.sprite = notificationIconInput;
            notificationHeader.text = notificationHeaderInput;
            notificationDescription.text = notificationDescriptionInput;
            			
            this.stateManager.ChangeState(new UIShowNotificationState(stateManager, this.lifeTime, this));
        }

        public void ShowNotification()
        {
            animator.SetBool("ShowNotification", true);
        }

        public void HideNotification()
        {
            animator.SetBool("HideNotification", true);
            Destroy(this.gameObject, 3f);
        }
    }
}