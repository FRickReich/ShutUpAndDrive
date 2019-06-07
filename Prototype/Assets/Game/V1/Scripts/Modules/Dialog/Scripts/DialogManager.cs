using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.V1.Dialog
{
    public class DialogManager : MonoBehaviour
    {
        private Queue<DialogLine> conversation;
        private Game.V1.Object.Dialog currentDialog;

        private string currentSpeaker;
        private string currentText;
        private Sprite currentPortrait;

        public bool dialogEnded;
        public bool dialogRunning;

        public float typingSpeed = 0.02f;

        private void Start()
        {
            conversation = new Queue<DialogLine>();
        }

        public void StartDialog(Game.V1.Object.Dialog dialog)
        {
            conversation.Clear();

            currentDialog = dialog;

            dialogRunning = true;

            foreach(DialogLine line in dialog.lines)
            {
                conversation.Enqueue(line);
            }

            DisplayNextSentence();
        }

        private void Update()
        {
            if(dialogRunning && conversation.Count == 0)
            {
                EndDialog();
                return;
            }
        }

		private void DisplayNextSentence()
		{
            DialogLine currentDialog = conversation.Dequeue();

            currentSpeaker = currentDialog.speaker.characterName;
            currentPortrait = currentDialog.speaker.portrait;

            StartCoroutine("Type", currentDialog.sentence);
		}

        void EndDialog()
		{
            dialogEnded = true;
            dialogRunning = false;
            currentDialog.Callback();
		}

        public struct MinMax  
        {  
            public string speaker;  
            public string sentence;
            public Sprite portrait;
        }

        public MinMax GetCurrent()  
        {
            MinMax values = new MinMax();
            values.speaker = currentSpeaker;
            values.sentence = null;
            values.sentence = currentText;
            values.portrait = currentPortrait;
            return values;
        }  

        IEnumerator Type(string text)
        {
            currentText = "";
            
            foreach(char letter in text.ToCharArray())
            {
                currentText += letter;
                yield return new WaitForSeconds(typingSpeed);
            }
        }
	}
}
