using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalButton : MonoBehaviour, IDataPersistence
{
    [SerializeField] public string id;

    [ContextMenu("Generate guid for id")]
    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString();
    }

    public bool pressed = false;
    public Material green;

    public void LoadData(GameData data)
    {
        data.buttonsPressed.TryGetValue(id, out pressed);
        if (pressed)
        {
            this.pressed = true;
            this.gameObject.GetComponent<MeshRenderer>().material = green;
            this.gameObject.GetComponent<CapsuleCollider>().enabled = false;
        }
    }
    public void SaveData(ref GameData data)
    {
        if (data.buttonsPressed.ContainsKey(id))
        {
            data.buttonsPressed.Remove(id);
        }
        data.buttonsPressed.Add(id, pressed);
    }

    public void OnMouseDown()
    {
        pressed = true;
        gameObject.GetComponent<MeshRenderer>().material = green;
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
    }

    public bool WasPressed()
    {
        return pressed;
    }
}
