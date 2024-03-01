using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;

public class TestFiles : MonoBehaviour
{
    private string fileName = "testFile.txt";
    
    void Start()
    {
        StartCoroutine(Run());
    }

    IEnumerator Run()
    {
    List<string> lines = FileManager.ReadTextFile(fileName, true);

    foreach (string line in lines)
        Debug.Log(line);

    yield return null;
    }
}
