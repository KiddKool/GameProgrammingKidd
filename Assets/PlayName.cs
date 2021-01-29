using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayName : MonoBehaviour
{
    public InputField NamePlayer;
    public string myNamePlayer;
    public Text ShowName;

    public void DisplayName()
    {
        myNamePlayer = NamePlayer.text;
        ShowName.text = myNamePlayer;

    }

}
