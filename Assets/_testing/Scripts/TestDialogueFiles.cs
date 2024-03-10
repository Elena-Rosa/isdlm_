using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DIALOGUE;
using COMMANDS;

namespace TESTING
{

    public class TestDialogueFiles : MonoBehaviour
    {
        [SerializeField] private TextAsset fileToRead = null;

        void Start()
        {
            StartConversation();
        }

        void StartConversation()
        {
            List<string> lines = FileManager.ReadTextAsset(fileToRead);

            DialogueSystem.instance.Say(lines);
        }

    }
}
