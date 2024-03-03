using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//this will hold the name box on screen
namespace DIALOGUE
{
    [System.Serializable]

    public class NameContainer
    {
    [SerializeField] private GameObject root;
    [SerializeField] private TextMeshProUGUI nameText;

    public void Show(string nameToShow = "")
    {
        root.SetActive(true);

        if (nameToShow != string.Empty)
            nameText.text = nameToShow;
    }

    public void Hide()
    {
        root.SetActive(false);
    }

}
}
