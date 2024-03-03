using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIALOGUE
{
    public class ConversationManager
    {
        private Coroutine process = null;
        public bool isRunning = false;

        public void StartConversation(List<string> conversation)
        {

        }
        public void StopConversation()
        {
            if (!isRunning)
                return;


        }
        IEnumerator RunningConversation()


    }
}
