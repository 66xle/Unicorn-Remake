using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public enum UnicornType
{
    INSTANT,
    UPGRADE,
    DOWNGRADE,
    MAGIC,
    MAGICAL,
    BASIC,
    BABY,
}


[CreateAssetMenu(menuName = "Card")]
public class Card : ScriptableObject
{
    public UnicornType unicornType;
    public string cardName;
    public Image cardImage;
    public string description;
}
