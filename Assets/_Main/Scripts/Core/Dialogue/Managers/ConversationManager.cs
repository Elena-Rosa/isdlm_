using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIALOGUE
{
    public class ConversationManager
    {
        private DialogueSystem dialogueSystem => DialogueSystem.instance;
        private Coroutine process = null;
        public bool isRunning => process != null;

        public void StartConversation(List<string> conversation)
        {
            StopConversation();

            process = dialogueSystem.StartCoroutine(RunningConversation(conversation));
        }
        public void StopConversation()
        {
            if (!isRunning)
                return;
            dialogueSystem.StopCoroutine(process);
            process = null;

        }
        IEnumerator RunningConversation(List<string> conversation)
        {
            for (int i = 0; i < conversation.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(conversation[i]))
                    continue;

                DIALOGUE_LINE line = DialogueParser.Parse(conversation[i]);

                //show dialogue
                if (line.hasDialogue)
                    yield return Line_RunDialogue(line);

                //run commands
                if (line.hasCommands)
                    yield return Line_RunCommands(line);

            }
            IEnumerator Line_RunDialogue(DIALOGUE_LINE line)
            {
                yield return null;
            }
            IEnumerator Line_RunCommands(DIALOGUE_LINE line)
            {
                yield return null;
            }

        }
    }
}
