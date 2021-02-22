using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class avatar : MonoBehaviour
{
 public string playerID2;
 public CanvasGroup StatsScreen;
 public Text InformPlayer;
 public Slider _ColorChange;
 public Slider _ItemChange;
 public Image image;
 public Image itemChange;
 public Sprite one;
 public Sprite two;
 public Sprite three;

 Color32[] Colors;

 private void Awake()
 {
     Colors = new Color32[4];
     Colors[0] = new Color32(100,0,0,255);
     Colors[1] = new Color32(0,100,0,255);
     Colors[2] = new Color32(0,0,100,255);
     Colors[3] = new Color32(100,100,0,255);

     playerID2 = PlayerPrefs.GetString("ThisPlayer", "playerName");
     InformPlayer.text = "Good Day, " + playerID2;

 }

 public void changeImage()
 {
     float newImageValue = _ColorChange.value;
     image.color = Colors[(int)newImageValue];

 }


public void itemChanger()
{
    float newItemValue = _ItemChange.value; //slider values

    if(newItemValue == 0)
    {
        itemChange.sprite = one;
    }
    else if(newItemValue == 1)
    {
        itemChange.sprite = two;
    }
    else if(newItemValue == 2)
    {
        itemChange.sprite = three;
    }
}
public void closePanel()
{
    StatsScreen.alpha = 0f;
    StatsScreen.interactable = false;
    StatsScreen.blocksRaycasts = false;
}
}
