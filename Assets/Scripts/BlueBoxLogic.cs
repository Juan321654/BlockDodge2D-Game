using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBoxLogic : MonoBehaviour
{
    float _yBoundary = -6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < _yBoundary) {
            GlobalScoreManager.AddPointToGlobalScore();
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag(TagManager.Tags.Player.ToString() )) {
            UnityEngine.SceneManagement.SceneManager.LoadScene(TagManager.Scenes.GameOver.ToString());
        }
    }
}
