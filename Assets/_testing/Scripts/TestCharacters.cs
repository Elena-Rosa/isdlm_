using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CHARACTERS;
using DIALOGUE;
using TMPro;

namespace TESTING
{
    public class TestCharacters : MonoBehaviour
    {
        public TMP_FontAsset tempFont;


        void Start()
        {
            StartCoroutine(Test());
        }

        IEnumerator Test()
        {
            Character Blanca = CharacterManager.instance.CreateCharacter("Blanca");
            Character Will = CharacterManager.instance.CreateCharacter("Will");
            Character Elena = CharacterManager.instance.CreateCharacter("Elena");

            List<string> lines = new List<string>()
            {
                "Hi, there!",
                "I'm Blanca.",
                "I'm a character in the game.",
                "But this is real,right?"
            };
            yield return Blanca.Say(lines);

            Blanca.SetNameColor(Color.red);
            Blanca.SetDialogueColor(Color.green);
            Blanca.SetNameFont(tempFont);
            Blanca.SetDialogueFont(tempFont);

            yield return Blanca.Say(lines);

            Blanca.ResetConfigurationData();

            yield return Blanca.Say(lines);

            lines = new List<string>()
            {
                "Hi, Blanca!",
                "I'm Will.",
                "I'm a character in the game too.",
                "But this is real,right?"

            };
            yield return Will.Say(lines);

            yield return Elena.Say("Hi, I'm Elena.");

            Debug.Log("Finished");
        }



        // Update is called once per frame
        void Update()
        {

        }
    }
}

