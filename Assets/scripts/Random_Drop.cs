using UnityEngine;

public class Random_Drop : MonoBehaviour
{
    public GameObject objectPrefab; // オブジェクトのプレハブを格納する変数
    public GameObject objectPrefab2; //２個目のオブジェクト
    public GameObject objectPrefab3;
    public float spawnRangeX; // X軸の出現範囲
    public float spawnRangeY; // Y軸の出現範囲

    void Start()
    {
        Camera mainCamera = Camera.main;
        float cameraHeight = 2f * mainCamera.orthographicSize;
        float cameraWidth = cameraHeight * mainCamera.aspect;

        spawnRangeX = cameraWidth;
        spawnRangeY = cameraHeight;
        
        InvokeRepeating("SpawnObject", 0f, 1.0f); // 1秒ごとに SpawnObject メソッドを呼び出す
    }

    void SpawnObject()
    {
        float spawnPositionX = Random.Range(-spawnRangeX / 2f, spawnRangeX / 2f); // X軸のランダムな座標を生成
        float spawnPositionY = Random.Range(-spawnRangeY / 2f, spawnRangeY / 2f); // Y軸のランダムな座標を生成
        Vector2 spawnPosition = new Vector2(spawnPositionX, spawnPositionY);

        int randomIndex = Random.Range(0, 3); //０または２のランダムな値を生成

        GameObject obj = null; // GameObject オブジェクトの宣言と初期化

        if (randomIndex == 0){
            obj = Instantiate(objectPrefab, spawnPosition, Quaternion.identity); // オブジェクトを生成
        }else if (randomIndex == 1){
            obj = Instantiate(objectPrefab2, spawnPosition, Quaternion.identity); // オブジェクト２を生成
        }else{
            obj = Instantiate(objectPrefab3, spawnPosition, Quaternion.identity); // オブジェクト３を生成
        }
        
        if (obj != null){
            obj.SetActive(true); //表示する
        }

    }
}