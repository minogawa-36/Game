using UnityEngine;
using UnityEngine.SceneManagement;

public class Home_Move : MonoBehaviour
{
    public string sceneToLoad = "Random_item";//移動先のシーン名を指定する変数

    private void OnMouseDown(){
        //クリックされたら指定されたシーンに移動する
        SceneManager.LoadScene(sceneToLoad);
    }
}