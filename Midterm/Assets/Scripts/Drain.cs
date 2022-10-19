using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drain : MonoBehaviour, IDataPersistence
{
    [SerializeField] public string id;

    [ContextMenu("Generate guid for id")]
    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString();
    }

    public GameObject waterPlane;
    public GameObject plug;
    public bool used = false;

    public void LoadData(GameData data)
    {
        data.drainsOpened.TryGetValue(id, out used);
        if (used)
        {
            plug.SetActive(false);
            this.gameObject.GetComponent<MeshCollider>().enabled = false;
        }
    }

    public void SaveData(ref GameData data)
    {
        if (data.drainsOpened.ContainsKey(id))
        {
            data.drainsOpened.Remove(id);
        }
        data.drainsOpened.Add(id, used);
    }

    private void OnMouseDown()
    {
        plug.SetActive(false);
        used = true;
        this.gameObject.GetComponent<MeshCollider>().enabled = false;
        waterPlane.GetComponent<WaterLevelManager>().AddTime();
    }
}
