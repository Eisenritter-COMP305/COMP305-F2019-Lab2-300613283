﻿// Modified By: George Zhou
// Student ID: 300613283

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SceneSettings",menuName = "Scene/Settings")]
[System.Serializable]
public class SceneSettings:ScriptableObject
{
    [Header("Scene Configuration")] 
    public Scene scene;
    public SoundClip activeSoundClip = SoundClip.NONE;

    [Header("Scoreboard Labels")]
    public bool scoreLabelEnabled;
    public bool livesLabelEnabled;
    public bool highScoreLabelEnabled;

    [Header("Scene Labels")]
    public bool startLabelActive;
    public bool endLabelActive;

    [Header(("Scene Buttons"))]
    public bool restartButtonActive;
    public bool startButtonActive;
}
