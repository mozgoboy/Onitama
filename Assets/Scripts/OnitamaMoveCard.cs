using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class OnitamaMoveCard : MonoBehaviour
{
    public GameObject controller;
    private bool[,] scheme = new bool[5,5];
    private string color;
    private string position;
    private int id;
    private string player;
    private bool inGame;
    private DataMaps dataMaps;

    public void Activate(DataMaps dM)
    {
        if (inGame) {
            controller = GameObject.FindGameObjectWithTag("GameController");
            SetCoords();
            this.GetComponent<SpriteRenderer>().sprite = dM.getOnitamaMoveCardSprite(this.name);
            color = dM.getOnitamaMoveCardColor(name);
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    scheme[i, j] = dM.getSchemePositionByName(name, i, j);                  
        }
    }

    public void SetCoords()
    {
        switch (this.position)
        {
            case "blueLeft" : { 
                    this.transform.position = new Vector3(-1.5f, -3.75f, -1);
                    this.transform.rotation = Quaternion.identity;
                } break;
            case "blueRight": { 
                    this.transform.position = new Vector3(1.5f, -3.75f, -1);
                    this.transform.rotation = Quaternion.identity;
                } break;
            case "redLeft": { 
                    this.transform.position = new Vector3(-1.5f, 3.75f, -1);
                    this.transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 0, 1));
                } break;
            case "redRight": {
                    this.transform.position = new Vector3(1.5f, 3.75f, -1);
                    this.transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 0, 1));
                } break;
            case "blueNext": {
                    this.transform.position = new Vector3(-4.5f, 0, -1);
                    this.transform.rotation = Quaternion.identity;
                } break;
            case "redNext": {
                    this.transform.position = new Vector3(4.5f, 0, -1);
                    this.transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 0, 1));
                } break;
        }
    }

    public void SetPosition(string pos)
    {
        position = pos;
    }

    public void SetId(int i)
    {
        id = i;
    }

    public string GetColor()
    {
        return color;
    }

    public void GameOn()
    {
        inGame = true;
    }

    public void SetPlayer(string pl)
    {
        player = pl;
    }

    public string GetPlayer()
    {
        return player;
    }

}
