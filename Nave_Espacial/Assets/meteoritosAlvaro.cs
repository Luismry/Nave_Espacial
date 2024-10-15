using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoritosAlvaro : MonoBehaviour
{
    public GameObject meteoritoPrefab;
    public float Delay = 3f;
    public int Tiempoinicio = 2;
    //public bool barrera;

    public BoxCollider2D zonaMeteoritos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomPosition", Tiempoinicio, Delay);
    }

    public void RandomPosition()
    {
        Bounds limites = zonaMeteoritos.bounds;
        float x = Random.Range(limites.min.x, limites.max.x);
        float y = Random.Range(limites.min.y, limites.max.y);
        Vector3 pos = new Vector3(x, y, 0);
        //transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0);
        Instantiate(meteoritoPrefab, pos, meteoritoPrefab.transform.rotation);
        
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("bola"))
        {
            Destroy(collision.gameObject);
        }

   
    }
    public void spawn(float delay)
    {
        InvokeRepeating("RandomPosition", Tiempoinicio, delay);
    }
    
}  




