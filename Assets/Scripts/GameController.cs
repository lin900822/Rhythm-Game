using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public SongData data;

    // Basic Setup
    #region BasicSetUP
    public string songName;

    public int songBPM;

    public float songLength;

    public int[,] songNotes;

    public int songDifficulty;

    public int totalCombo;

    public int totalScore;

    // Player data
    public int highCombo;

    public int highScore;

    public int playTimes;

    #endregion
    // 譜面設定
    public int[,] notes = new int[804, 4]
    {
        {0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,1},
{0,1,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,1,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,1,1,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{1,1,0,1},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,1,0},
{1,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{1,0,1,0},
{0,0,0,0},
{1,0,1,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,1,0},
{0,0,1,1},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,1,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,1,0},
{1,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,1,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,1,1,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,1,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,1,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{1,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{1,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,1,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,1,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,1,1,0},
{0,0,0,0},
{0,0,1,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0},
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,1,0,0},
{0,0,1,0},
{1,0,0,0},
{0,0,0,0},
{0,0,0,1},
{0,0,0,0},
{0,1,1,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0}
    };

    /// <summary>
    /// 遊戲基礎變數
    /// </summary>
    #region GameBasicVariables

    // GameController 單例
    public static GameController instance;

    // 音符Prefab
    public GameObject notePrefab;

    // 4個判定點
    public GameObject[] detectPoints;

    // 遊戲分數及combo數
    public int gameScore = 0;
    public int combo = 0;

    public int fullComboNumber = 0;

    // 遊戲UI
    public Text timingTxt;
    public Text scoreTxt;
    public Text comboTxt;

    #endregion

    /// <summary>
    /// 音樂相關變數
    /// </summary>
    #region MusicVariables

    // 音樂開始前等待時間
    public float timeBeforeStart;

    // 音樂BPM
    public float songBpm;

    // 總Beat數
    public int totalBeats;

    // 一秒幾個Beat
    public float secPerBeat;

    // 一個Beat幾秒
    public float beatPerSec;

    // Current song position, in seconds
    // 
    public float songPosition;

    // Current song position, in beats
    // 音樂撥放到第幾個BPM
    public float songPositionInBeats;

    public int beatNow;

    // How many seconds have passed since the song started
    public float dspSongTime;

    // an AudioSource attached to this GameObject that will play the music.
    public AudioSource musicSource;

    // 音樂長度
    public float musicLength;

    #endregion

    private void Start()
    {
        //data.songName = "Gurenge";
        //data.songBPM = 540;



        // 單例設定
        instance = this;

        // 初始化音樂設定
        MusicSetUP();

        // 
        BasicSetUP();
    }

    void Update()
    {
        // 音樂參數更新
        MusicUpdate();

        // 生成譜面
        SpawnNotes();

        // 更新UI
        UIUpdate();
    }

    /// <summary>
    /// 1. 取得AudioSource
    /// 2. 總共幾個Beats
    /// 3. 每秒幾個Beat、每Beat幾秒
    /// 4. 計算並倒數等待時間撥放音樂
    /// </summary>
    void MusicSetUP()
    {
        //Load the AudioSource attached to the Conductor GameObject
        musicSource = GetComponent<AudioSource>();

        musicLength = musicSource.clip.length;

        totalBeats = (Mathf.RoundToInt((songBpm * musicLength) / 60));

        //Calculate the number of seconds in each beat
        secPerBeat = 60f / songBpm;

        beatPerSec = songBpm / 60f;

        //Record the time when the music starts
        dspSongTime = (float)AudioSettings.dspTime;

        timeBeforeStart = (((10 / secPerBeat) + 1) * secPerBeat) / beatPerSec;

        StartCoroutine(WaitForStart(timeBeforeStart));
    }

    void BasicSetUP()
    {
        calculateFullCombo();
    }

    /// <summary>
    /// 1. 更新音樂撥放到第幾秒、Beat
    /// </summary>
    void MusicUpdate()
    {
        //determine how many seconds since the song started
        songPosition = (float)(AudioSettings.dspTime - dspSongTime);

        //determine how many beats since the song started
        songPositionInBeats = songPosition / secPerBeat;

        beatNow = (int)songPositionInBeats;
    }

    /// <summary>
    /// 1. 將陣列資料轉換成譜面生成在最上方
    /// </summary>
    void SpawnNotes()
    {
        for (int k = 0; k < totalBeats; k++)
        {
            if (beatNow == k)
            {
                for (int i = 0; i <= 3; i++)
                {
                    if (notes[k, i] == 1)
                    {
                        notes[k, i] = 0;
                        // ((10 / secPerBeat) + 1) * secPerBeat是遊戲畫面外的secPerBeat的最小倍數位置
                        Instantiate(notePrefab, detectPoints[i].transform.position + new Vector3(0, ((10 / secPerBeat) + 1) * secPerBeat, 0), detectPoints[i].transform.rotation);
                    }
                }
            }
        }
    }

    /// <summary>
    /// 1. 更新UI
    /// </summary>
    void UIUpdate()
    {
        scoreTxt.text = "Score : " + gameScore;
        comboTxt.text = "Combo : " + combo;
    }

    void calculateFullCombo()
    {
        for (int k = 0; k < totalBeats; k++)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (notes[k, i] == 1)
                {
                    fullComboNumber++;
                }
            }
        }
    }

    /// <summary>
    /// 1. 倒數timeToPlayMusic秒撥放音樂
    /// </summary>
    /// <param name="timeToPlayMusic"></param>
    /// <returns></returns>
    IEnumerator WaitForStart(float timeToPlayMusic)
    {
        yield return new WaitForSeconds(timeToPlayMusic);
        // Start the music
        musicSource.Play();
    }
}

