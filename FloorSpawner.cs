using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
   
    public GameObject zemin;

    private Transform tr;

    public int zeminsayýsý;

    public float zemingeniþ;

    public float miny, maxy;

    private void Start()
    {
        tr = zemin.GetComponent<Transform>();
        Vector3 spawnkonumu = new Vector3();
        Vector2 newscale = new Vector2();

        for(int i = 0; i < zeminsayýsý; i++)
        {
            newscale.x = Random.Range(1.45f, 1.1f);
            newscale.y = Random.Range(1.45f, 1.1f);
            tr.localScale = newscale;

            spawnkonumu.y += Random.Range(miny, maxy);
            spawnkonumu.x = Random.Range(-zemingeniþ, zemingeniþ);

            Instantiate(zemin, spawnkonumu, Quaternion.identity);   
        }
    }
}
