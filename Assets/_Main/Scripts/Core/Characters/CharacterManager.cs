using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CHARACTERS
{
    public class CharacterManager : MonoBehaviour
    {
        public static CharacterManager instance { get; private set; }
        private Dictionary<string, Character> characters = new Dictionary<string, Character>();

        private void Awake()
        {
            instance = this;
        }

        public Character CreateCharacter(string characterName)
        {
            if (characters.ContainsKey(characterName.ToLower()))
            {
                Debug.LogWarning($"A Chacter called ' {characterName}' already exists. Did not create the character.");
                return null;
            }

            CHARACTER_INFO info = GetCharacterInfo(characterName);

            return null;

        }
        private Character_Info GetCharacterInfo(string characterName)
        {
            CHARACTER_INFO result = new CHARACTER_INFO();
            result.name = characterName;
        }
        private class CHARACTER_INFO
        {
            public string name = "";
            public CharacterConfigData config = null;
        }
    }
}
