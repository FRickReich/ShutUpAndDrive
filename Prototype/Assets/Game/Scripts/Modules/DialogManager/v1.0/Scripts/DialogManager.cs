using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules
{
    public class DialogManager : MonoBehaviour
    {
        private Queue<DialogLine> conversation;
        private Dialog currentDialog;

        private string currentSpeaker;
        private string currentText;

        public bool dialogEnded;
        public bool dialogRunning;

        public float typingSpeed = 0.02f;

        private void Start()
        {
            conversation = new Queue<DialogLine>();
        }

        public void StartDialog(Dialog dialog)
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

            currentSpeaker = currentDialog.speaker;

            StartCoroutine("Type", currentDialog.sentence);
		}

        void EndDialog()
		{
            dialogEnded = true;
            currentDialog.Callback();
		}

        public struct MinMax  
        {  
            public string speaker;  
            public string sentence;  
        }

        public MinMax GetCurrent()  
        {  
            MinMax values = new MinMax();
            values.speaker = currentSpeaker;
            values.sentence = currentText;
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

		// Start is called before the first frame update
		/*void Start()
        {
            sentences = new Queue<string>();
        }        

		public void StartDialog(Dialog dialog)
		{
            sentences.Clear();

            dialogRunning = true;

            currentSpeaker = dialog.speaker;

            foreach(string sentence in dialog.sentences)
            {
                sentences.Enqueue(sentence);
            }

            DisplayNextSentence();
		}

        private void Update()
        {
            if(dialogRunning && sentences.Count == 0)
            {
                EndDialog();
                return;
            }
        }

        public void DisplayNextSentence()
        {
            StartCoroutine("Type", sentences.Dequeue());
        }

		void EndDialog()
		{
			Debug.Log("End of conversation");
            dialogEnded = true;
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
        */
	}
}
