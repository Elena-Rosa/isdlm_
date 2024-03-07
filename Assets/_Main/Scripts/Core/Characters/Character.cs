using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CHARACTERS
{
    public abstract class Character 
    {
        public string name = "";
        public RectTransform root = null;
        public enum CharacterType
        {
            Text,
            Sprite,
            SpriteShhet,
            Live2D,
            Model3D
        }
    
    }
}
