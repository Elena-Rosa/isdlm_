using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;
using COMMANDS;

namespace TESTING
{
    public class TestFiles : MonoBehaviour
    {
        [SerializeField] private TextAsset fileName;

        void Start()
        {
            StartCoroutine(Run());
        }

        IEnumerator Run()
        {
            List<string> lines = FileManager.ReadTextAsset(fileName, false);

            foreach (string line in lines)
                Debug.Log(line);

            yield return null;
        }
    }
}
