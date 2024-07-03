using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScoreManager : MonoBehaviour
{
    public static GlobalScoreManager Instance;

    [SerializeField] private int globalScore = 0;
    [SerializeField] private int globalHighScore = 0;
    
    public static int GlobalScore {
        get {
            return Instance.globalScore;
        }
        set {
            Instance.globalScore = value;
        }
    }

    public static int GlobalHighScore {
        get {
            return Instance.globalHighScore;
        }
        set {
            Instance.globalHighScore = value;
        }
    }

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public static void AddPointToGlobalScore() {
        Instance.globalScore++;
    }

    public static int GetGlobalScore() {
        return Instance.globalScore;
    }
    
}
