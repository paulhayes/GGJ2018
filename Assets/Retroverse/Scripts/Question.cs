﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Questions/Question")]
public class Question : ScriptableObject
{
    public string videoClipForward;
    public string videoClipReverse;
    public string answer;
    public int difficulty;

}