using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnitamaMoveCard : MonoBehaviour
{
    public GameObject controller;
    private bool[,] scheme = new bool[5,5];
    private string color;
    private string position;
    private int id;
    private bool inGame;

    public Sprite aalCard, affeCard, bearCard, dogCard, dracheCard, elefantCard, foxCard, froschCard, gansCard,
        giraffeCard, gottesCard, hahnCard, haseCard, iguanaCard, kirinCard, kobraCard, krabbeCard, kranichCard,
        mouseCard, ochseCard, otterCard, pandaCard, pferdCard, phoenixCard, ratCard, sableCard, seaCard, tanukiCard,
        tigerCard, turtleCard, viperCard, wildCard;

    public void Activate()
    {
        if (inGame) {
            controller = GameObject.FindGameObjectWithTag("GameController");
            SetCoords();

            switch (this.name)
            {
                case "aalCard": this.GetComponent<SpriteRenderer>().sprite = aalCard; break;
                case "affeCard": this.GetComponent<SpriteRenderer>().sprite = affeCard; break;
                case "bearCard": this.GetComponent<SpriteRenderer>().sprite = bearCard; break;
                case "dogCard": this.GetComponent<SpriteRenderer>().sprite = dogCard; break;
                case "dracheCard": this.GetComponent<SpriteRenderer>().sprite = dracheCard; break;
                case "elefantCard": this.GetComponent<SpriteRenderer>().sprite = elefantCard; break;
                case "foxCard": this.GetComponent<SpriteRenderer>().sprite = foxCard; break;
                case "froschCard": this.GetComponent<SpriteRenderer>().sprite = froschCard; break;
                case "gansCard": this.GetComponent<SpriteRenderer>().sprite = gansCard; break;
                case "giraffeCard": this.GetComponent<SpriteRenderer>().sprite = giraffeCard; break;
                case "gottesCard": this.GetComponent<SpriteRenderer>().sprite = gottesCard; break;
                case "hahnCard": this.GetComponent<SpriteRenderer>().sprite = hahnCard; break;
                case "haseCard": this.GetComponent<SpriteRenderer>().sprite = haseCard; break;
                case "iguanaCard": this.GetComponent<SpriteRenderer>().sprite = iguanaCard; break;
                case "kirinCard": this.GetComponent<SpriteRenderer>().sprite = kirinCard; break;
                case "kobraCard": this.GetComponent<SpriteRenderer>().sprite = kobraCard; break;
                case "krabbeCard": this.GetComponent<SpriteRenderer>().sprite = krabbeCard; break;
                case "kranichCard": this.GetComponent<SpriteRenderer>().sprite = kranichCard; break;
                case "mouseCard": this.GetComponent<SpriteRenderer>().sprite = mouseCard; break;
                case "ochseCard": this.GetComponent<SpriteRenderer>().sprite = ochseCard; break;
                case "otterCard": this.GetComponent<SpriteRenderer>().sprite = otterCard; break;
                case "pandaCard": this.GetComponent<SpriteRenderer>().sprite = pandaCard; break;
                case "pferdCard": this.GetComponent<SpriteRenderer>().sprite = pferdCard; break;
                case "phoenixCard": this.GetComponent<SpriteRenderer>().sprite = phoenixCard; break;
                case "ratCard": this.GetComponent<SpriteRenderer>().sprite = ratCard; break;
                case "sableCard": this.GetComponent<SpriteRenderer>().sprite = sableCard; break;
                case "seaCard": this.GetComponent<SpriteRenderer>().sprite = seaCard; break;
                case "tanukiCard": this.GetComponent<SpriteRenderer>().sprite = tanukiCard; break;
                case "tigerCard": this.GetComponent<SpriteRenderer>().sprite = tigerCard; break;
                case "turtleCard": this.GetComponent<SpriteRenderer>().sprite = turtleCard; break;
                case "viperCard": this.GetComponent<SpriteRenderer>().sprite = viperCard; break;
                case "wildCard": this.GetComponent<SpriteRenderer>().sprite = wildCard; break;
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

}
