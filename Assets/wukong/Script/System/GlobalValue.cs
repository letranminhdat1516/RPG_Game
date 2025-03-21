using UnityEngine;
using System.Collections;

public class GlobalValue : MonoBehaviour
{
    public static int worldPlaying = 1;
    public static int levelPlaying = 1;

    public static string WorldReached = "WorldReached";
    public static string Coins = "Coins";
    public static string Lives = "Lives";
    public static string Points = "Points";
    public static string Bullets = "Bullets";
    public static string Character = "Character";
    public static string ChoosenCharacterID = "choosenCharacterID";
    public static string ChoosenCharacterInstanceID = "ChoosenCharacterInstanceID";
    public static GameObject CharacterPrefab;

    public static int SavedCoins
    {
        get
        {
            if (!PlayerPrefs.HasKey(Coins))
                PlayerPrefs.SetInt(Coins, 0);

            return PlayerPrefs.GetInt(Coins, 0);
        }
        set
        {
            PlayerPrefs.SetInt(Coins, value);
            PlayerPrefs.Save(); // Bắt buộc lưu ngay
        }
    }

    public static int SavedBullets
    {
        get
        {
            if (!PlayerPrefs.HasKey(Bullets))
                PlayerPrefs.SetInt(Bullets, 0);

            return PlayerPrefs.GetInt(Bullets, 0);
        }
        set
        {
            PlayerPrefs.SetInt(Bullets, value);
            PlayerPrefs.Save(); // Bắt buộc lưu ngay
        }
    }
}
