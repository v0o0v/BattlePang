﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    private Dictionary<string, GameObject> m_TileDictionary = new Dictionary<string, GameObject>();
    private GameObject m_tilePrefab;
    public int m_width = 16;
    public int m_heught = 16;

    // Start is called before the first frame update
    void Start()
    {
        m_tilePrefab = Resources.Load("Prefabs/CandyPurple") as GameObject;
        this.CreateTiles();
    }

    private void CreateTiles()
    {
        for (int y = 0; y < m_heught; y++)
        {
            for (int x = 0; x < m_width; x++)
            {
                string key = x.ToString() + "," + y.ToString();
                GameObject newTileGo = Instantiate(m_tilePrefab, this.transform, true);
                newTileGo.transform.position = new Vector2(x,y);
                m_TileDictionary[key] = newTileGo;

            }
        }

        
    }

    // Update is called once per frame
    void Update()
    {
    }
}