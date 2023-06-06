using UnityEngine;
using UnityEngine.SceneManagement;

public class Chenge_Scenne : MonoBehaviour
{
    void Update(){
        //クリックされたら実行するプログラムです
        if (Input.GetMouseButton(0)){
            SceneManager.LoadScene("Move_After");
        }
    }
}
