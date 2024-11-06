using UnityEngine;

public class towers : MonoBehaviour
{
    [SerializeField] private GameObject towersPrefab;

    void Start() { }
    
    void Update() { }
    private void OnMouseUp()
    {
        var newScale = new Vector3(Random.Range(0.5f, 3f), 1f, Random.Range(0.5f, 3f));
        var position = new Vector3(Random.Range(-5.0f, 5.0f), 1f, Random.Range(-5.0f, 5.0f));
        GameObject Insttower = Instantiate(towersPrefab, position, Quaternion.identity);
        Insttower.transform.localScale = newScale;
    }
}
