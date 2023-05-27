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
    private OnitamaMoveCardDataMaps dataMaps;

    public void Activate(OnitamaMoveCardDataMaps dM)
    {
        if (inGame) {
            dM.CreateSprites();
            controller = GameObject.FindGameObjectWithTag("GameController");
            SetCoords();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    scheme[i, j] = false;

            switch (this.name)
            {
                case "aalCard": 
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "blue";
                        scheme[1, 1] = true;
                        scheme[1, 3] = true;
                        scheme[3, 2] = true;
                    } 
                    break;
                case "affeCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "blue";
                        scheme[1, 1] = true;
                        scheme[1, 3] = true;
                        scheme[3, 1] = true;
                        scheme[3, 3] = true;
                    }
                    break;
                case "bearCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "blue";
                        scheme[2, 3] = true;
                        scheme[1, 3] = true;
                        scheme[3, 1] = true;
                    }
                    break;
                case "dogCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "blue";
                        scheme[1, 2] = true;
                        scheme[1, 3] = true;
                        scheme[1, 1] = true;
                    }
                    break;
                case "dracheCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "red";
                        scheme[1, 1] = true;
                        scheme[0, 3] = true;
                        scheme[3, 1] = true;
                        scheme[4, 3] = true;
                    }
                    break;
                case "elefantCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "red";
                        scheme[1, 2] = true;
                        scheme[1, 3] = true;
                        scheme[3, 2] = true;
                        scheme[3, 3] = true;
                    }
                    break;
                case "foxCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "red";
                        scheme[3, 3] = true;
                        scheme[3, 2] = true;
                        scheme[3, 1] = true;
                    }
                    break;
                case "froschCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "red";
                        scheme[0, 2] = true;
                        scheme[1, 3] = true;
                        scheme[3, 1] = true;

                    } 
                    break;
                case "gansCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "blue";
                        scheme[3, 2] = true;
                        scheme[1, 3] = true;
                        scheme[3, 1] = true;
                        scheme[1, 2] = true;
                    }
                    break;
                case "giraffeCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "blue";
                        scheme[2, 1] = true;
                        scheme[0, 3] = true;
                        scheme[4, 3] = true;
                    }
                    break;
                case "gottesCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "red";
                        scheme[2, 1] = true;
                        scheme[1, 3] = true;
                        scheme[3, 3] = true;
                    }
                    break;
                case "hahnCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "red";
                        scheme[1, 1] = true;
                        scheme[1, 2] = true;
                        scheme[3, 2] = true;
                        scheme[3, 3] = true;
                    }
                    break;
                case "haseCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "blue";
                        scheme[1, 1] = true;
                        scheme[4, 2] = true;
                        scheme[3, 3] = true;
                    }
                    break;
                case "iguanaCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "red";
                        scheme[0, 3] = true;
                        scheme[2, 3] = true;
                        scheme[3, 1] = true;
                    }
                    break;
                case "kirinCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "red";
                        scheme[2, 0] = true;
                        scheme[1, 4] = true;
                        scheme[3, 4] = true;
                    }
                    break;
                case "kobraCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "red";
                        scheme[1, 2] = true;
                        scheme[3, 1] = true;
                        scheme[3, 3] = true;
                    }
                    break;
                case "krabbeCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "blue";
                        scheme[0, 2] = true;
                        scheme[4, 2] = true;
                        scheme[2, 3] = true;
                    }
                    break;
                case "kranichCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "blue";
                        scheme[1, 1] = true;
                        scheme[2, 3] = true;
                        scheme[3, 1] = true;
                    }
                    break;
                case "mouseCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "blue";
                        scheme[1, 1] = true;
                        scheme[2, 3] = true;
                        scheme[3, 2] = true;
                    }
                    break;
                case "ochseCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "blue";
                        scheme[2, 1] = true;
                        scheme[2, 3] = true;
                        scheme[3, 2] = true;
                    }
                    break;
                case "otterCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "red";
                        scheme[4, 2] = true;
                        scheme[1, 3] = true;
                        scheme[3, 1] = true;
                    }
                    break;
                case "pandaCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "red";
                        scheme[1, 1] = true;
                        scheme[2, 3] = true;
                        scheme[3, 3] = true;
                    }
                    break;
                case "pferdCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "red";
                        scheme[1, 2] = true;
                        scheme[2, 1] = true;
                        scheme[2, 3] = true;
                    }
                    break;
                case "phoenixCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "blue";
                        scheme[0, 2] = true;
                        scheme[4, 2] = true;
                        scheme[3, 1] = true;
                        scheme[3, 3] = true;
                    }
                    break;
                case "ratCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "red";
                        scheme[1, 2] = true;
                        scheme[2, 3] = true;
                        scheme[3, 1] = true;
                    }
                    break;
                case "sableCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "blue";
                        scheme[1, 1] = true;
                        scheme[0, 2] = true;
                        scheme[3, 1] = true;

                    }
                    break;
                case "seaCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "blue";
                        scheme[1, 1] = true;
                        scheme[2, 3] = true;
                        scheme[4, 2] = true;
                    }
                    break;
                case "tanukiCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "blue";
                        scheme[1, 1] = true;
                        scheme[2, 3] = true;
                        scheme[4, 3] = true;
                    }
                    break;
                case "tigerCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "blue";
                        scheme[2, 1] = true;
                        scheme[2, 4] = true;
                    }
                    break;
                case "turtleCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "red";
                        scheme[1, 1] = true;
                        scheme[0, 2] = true;
                        scheme[4, 2] = true;
                        scheme[3, 3] = true;
                    }
                    break;
                case "viperCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "red";
                        scheme[0, 2] = true;
                        scheme[2, 3] = true;
                        scheme[3, 1] = true;
                    }
                    break;
                case "wildCard":
                    {
                        this.GetComponent<SpriteRenderer>().sprite = dM.getSprite(this.name);
                        color = "red";
                        scheme[1, 2] = true;
                        scheme[3, 2] = true;
                        scheme[2, 3] = true;
                    }
                    break;
            }

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
