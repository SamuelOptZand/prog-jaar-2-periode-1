using UnityEngine;

public class Createballs : MonoBehaviour
{
    public GameObject prefab;
    private float elapsedTime = 0f;
    void Start() { }
    void Update()
    {
        Vector3 RanPos = new Vector3(Random.Range(-5f, 5f), Random.Range(0f, 5f), Random.Range(-5f, 5f));
        Color RanColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 0.2f)
        {
            GameObject newBall = CreateBall(RanColor, RanPos);
            DestroyBall(newBall);
            elapsedTime = 0f;
        }
    }
    public GameObject CreateBall(Color c, Vector3 position)
    {
        GameObject ball = Instantiate(prefab, position, Quaternion.identity);
        Material material = ball.GetComponent<MeshRenderer>().material;
        material.SetColor("_Color", c);
        return ball;
    }
    private void DestroyBall(GameObject Desball)
    {
        Destroy(Desball, 3f);
    }
}
