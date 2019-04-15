using UnityEngine;
using UnityEngine.UI;

public class Scor : MonoBehaviour {
    public Text Score;
	void Update () {
        Score.text = GameManager.score.ToString();
    }
}
