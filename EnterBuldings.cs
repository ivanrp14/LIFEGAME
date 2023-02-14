using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterBuldings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MeshCollider meshCollider = GetComponent<MeshCollider>();
    }

    // Update is called once per frame

    private void OnMouseDown()
    {
        Debug.Log("Edificio tocado = "+this.name);
    }
}
