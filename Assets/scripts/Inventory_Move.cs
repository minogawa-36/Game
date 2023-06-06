using UnityEngine;
using UnityEngine.SceneManagement;

public class Inventory_Move : MonoBehaviour
{
    public string sceneToLoad = "inventory";//移動先のシーン名を指定する変数

    private void OnMouseDown(){
        //クリックされたら指定されたシーンに移動する
        SceneManager.LoadScene(sceneToLoad);
    }
}