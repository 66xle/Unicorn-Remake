using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public enum CardType
{
    INSTANT,
    UPGRADE,
    DOWNGRADE,
    MAGIC,
    MAGICAL,
    BASIC,
    BABY,
}

public enum UnicornType
{
    Unicorn,
    Narwhal,
}


[CreateAssetMenu(menuName = "Card")]
public class Card : ScriptableObject
{
    public CardType cardType;
    public UnicornType unicornType;
    public string cardName;
    public Texture2D cardImage;
    public string description;
}
