using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
   
    public GameObject zemin;

    private Transform tr;

    public int zeminsay�s�;

    public float zemingeni�;

    public float miny, maxy;

    private void Start()
    {
        tr = zemin.GetComponent<Transform>();
        Vector3 spawnkonumu = new Vector3();
        Vector2 newscale = new Vector2();

        for(int i = 0; i < zeminsay�s�; i++)
        {
            newscale.x = Random.Range(1.45f, 1.1f);
            newscale.y = Random.Range(1.45f, 1.1f);
            tr.localScale = newscale;

            spawnkonumu.y += Random.Range(miny, maxy);
            spawnkonumu.x = Random.Range(-zemingeni�, zemingeni�);

            Instantiate(zemin, spawnkonumu, Quaternion.identity);   
        }
    }
}
