using UnityEngine;

public class Random_Drop : MonoBehaviour
{
    public GameObject objectPrefab; // オブジェクトのプレハブを格納する変数
    public float spawnRangeX = 10f; // X軸の出現範囲
    public float spawnRangeY = 12f; // Y軸の出現範囲

    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, 1.0f); // 1秒ごとに SpawnObject メソッドを呼び出す
    }

    void SpawnObject()
    {
        float spawnPositionX = Random.Range(-spawnRangeX / 2f, spawnRangeX / 2f); // X軸のランダムな座標を生成
        float spawnPositionY = Random.Range(-spawnRangeY / 2f, spawnRangeY / 2f); // Y軸のランダムな座標を生成
        Vector2 spawnPosition = new Vector2(spawnPositionX, spawnPositionY);

        Instantiate(objectPrefab, spawnPosition, Quaternion.identity); // オブジェクトを生成
    }
}

