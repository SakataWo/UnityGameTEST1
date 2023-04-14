using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class Collectable
{
    public string nameCollectable;
    public int score;
    public int restoreHP;

    public enum CollectableType
    {
        GreenBubble,
        BlueBubble,
    }

    CollectableType healItem = CollectableType.GreenBubble;

    public Collectable(string name, int scorevalue, int restoreHPvalue)
    {
        this.nameCollectable = name;
        this.score = scorevalue;
        this.restoreHP = restoreHPvalue;
    }
}
