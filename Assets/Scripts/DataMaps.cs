using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DataMaps : MonoBehaviour
{
    public Sprite aalCard, affeCard, bearCard, dogCard, dracheCard, elefantCard, foxCard, froschCard, gansCard,
        giraffeCard, gottesCard, hahnCard, haseCard, iguanaCard, kirinCard, kobraCard, krabbeCard, kranichCard,
        mouseCard, ochseCard, otterCard, pandaCard, pferdCard, phoenixCard, ratCard, sableCard, seaCard, tanukiCard,
        tigerCard, turtleCard, viperCard, wildCard;

    private Dictionary<string, Sprite> onitamaMoveCardNameToSprite = new Dictionary<string, Sprite>();
    private Dictionary<string, string> onitamaMoveCardNameToColor = new Dictionary<string, string>();
    private string[] allCardNames = new string[32] { "aalCard", "affeCard", "bearCard", "dogCard", "dracheCard", "elefantCard", "foxCard", "froschCard", "gansCard",
        "giraffeCard", "gottesCard", "hahnCard", "haseCard", "iguanaCard", "kirinCard", "kobraCard", "krabbeCard", "kranichCard",
        "mouseCard", "ochseCard", "otterCard", "pandaCard", "pferdCard", "phoenixCard", "ratCard", "sableCard", "seaCard", "tanukiCard",
        "tigerCard", "turtleCard", "viperCard", "wildCard" };
    private Dictionary<string, bool[,]> onitamaMoveCardNameToScheme = new Dictionary<string, bool[,]>();

    public void CreateCardSchemes ()
    {
        bool[,] scheme = new bool[5,5];


        onitamaMoveCardNameToScheme.Add("aalCard", scheme);
        onitamaMoveCardNameToScheme.Add("affeCard", scheme);
        onitamaMoveCardNameToScheme.Add("bearCard", scheme);
        onitamaMoveCardNameToScheme.Add("dogCard", scheme);
        onitamaMoveCardNameToScheme.Add("dracheCard", scheme);
        onitamaMoveCardNameToScheme.Add("elefantCard", scheme);
        onitamaMoveCardNameToScheme.Add("foxCard", scheme);
        onitamaMoveCardNameToScheme.Add("froschCard", scheme);
        onitamaMoveCardNameToScheme.Add("gansCard", scheme);
        onitamaMoveCardNameToScheme.Add("giraffeCard", scheme);
        onitamaMoveCardNameToScheme.Add("gottesCard", scheme);
        onitamaMoveCardNameToScheme.Add("hahnCard", scheme);
        onitamaMoveCardNameToScheme.Add("haseCard", scheme);
        onitamaMoveCardNameToScheme.Add("iguanaCard", scheme);
        onitamaMoveCardNameToScheme.Add("kirinCard", scheme);
        onitamaMoveCardNameToScheme.Add("kobraCard", scheme);
        onitamaMoveCardNameToScheme.Add("krabbeCard", scheme);
        onitamaMoveCardNameToScheme.Add("kranichCard", scheme);
        onitamaMoveCardNameToScheme.Add("mouseCard", scheme);
        onitamaMoveCardNameToScheme.Add("ochseCard", scheme);
        onitamaMoveCardNameToScheme.Add("otterCard", scheme);
        onitamaMoveCardNameToScheme.Add("pandaCard", scheme);
        onitamaMoveCardNameToScheme.Add("pferdCard", scheme);
        onitamaMoveCardNameToScheme.Add("phoenixCard", scheme);
        onitamaMoveCardNameToScheme.Add("ratCard", scheme);
        onitamaMoveCardNameToScheme.Add("sableCard", scheme);
        onitamaMoveCardNameToScheme.Add("seaCard", scheme);
        onitamaMoveCardNameToScheme.Add("tanukiCard", scheme);
        onitamaMoveCardNameToScheme.Add("tigerCard", scheme);
        onitamaMoveCardNameToScheme.Add("turtleCard", scheme);
        onitamaMoveCardNameToScheme.Add("viperCard", scheme);
        onitamaMoveCardNameToScheme.Add("wildCard", scheme);

        onitamaMoveCardNameToScheme["aalCard"][1, 1] = true;
        onitamaMoveCardNameToScheme["aalCard"][1, 3] = true;
        onitamaMoveCardNameToScheme["aalCard"][3, 2] = true;

        onitamaMoveCardNameToScheme["affeCard"][1, 1] = true;
        onitamaMoveCardNameToScheme["affeCard"][1, 3] = true;
        onitamaMoveCardNameToScheme["affeCard"][3, 1] = true;
        onitamaMoveCardNameToScheme["affeCard"][3, 3] = true;

        onitamaMoveCardNameToScheme["bearCard"][2, 3] = true;
        onitamaMoveCardNameToScheme["bearCard"][1, 3] = true;
        onitamaMoveCardNameToScheme["bearCard"][3, 1] = true;

        onitamaMoveCardNameToScheme["dogCard"][1, 2] = true;
        onitamaMoveCardNameToScheme["dogCard"][1, 3] = true;
        onitamaMoveCardNameToScheme["dogCard"][1, 1] = true;

        onitamaMoveCardNameToScheme["dracheCard"][1, 1] = true;
        onitamaMoveCardNameToScheme["dracheCard"][0, 3] = true;
        onitamaMoveCardNameToScheme["dracheCard"][3, 1] = true;
        onitamaMoveCardNameToScheme["dracheCard"][4, 3] = true;

        onitamaMoveCardNameToScheme["elefantCard"][1, 2] = true;
        onitamaMoveCardNameToScheme["elefantCard"][1, 3] = true;
        onitamaMoveCardNameToScheme["elefantCard"][3, 2] = true;
        onitamaMoveCardNameToScheme["elefantCard"][3, 3] = true;

        onitamaMoveCardNameToScheme["foxCard"][3, 3] = true;
        onitamaMoveCardNameToScheme["foxCard"][3, 2] = true;
        onitamaMoveCardNameToScheme["foxCard"][3, 1] = true;

        onitamaMoveCardNameToScheme["froschCard"][0, 2] = true;
        onitamaMoveCardNameToScheme["froschCard"][1, 3] = true;
        onitamaMoveCardNameToScheme["froschCard"][3, 1] = true;

        onitamaMoveCardNameToScheme["gansCard"][3, 2] = true;
        onitamaMoveCardNameToScheme["gansCard"][1, 3] = true;
        onitamaMoveCardNameToScheme["gansCard"][3, 1] = true;
        onitamaMoveCardNameToScheme["gansCard"][1, 2] = true;

        onitamaMoveCardNameToScheme["giraffeCard"][2, 1] = true;
        onitamaMoveCardNameToScheme["giraffeCard"][0, 3] = true;
        onitamaMoveCardNameToScheme["giraffeCard"][4, 3] = true;

        onitamaMoveCardNameToScheme["gottesCard"][2, 1] = true;
        onitamaMoveCardNameToScheme["gottesCard"][1, 3] = true;
        onitamaMoveCardNameToScheme["gottesCard"][3, 3] = true;

        onitamaMoveCardNameToScheme["hahnCard"][1, 1] = true;
        onitamaMoveCardNameToScheme["hahnCard"][1, 2] = true;
        onitamaMoveCardNameToScheme["hahnCard"][3, 2] = true;
        onitamaMoveCardNameToScheme["hahnCard"][3, 3] = true;

        onitamaMoveCardNameToScheme["haseCard"][1, 1] = true;
        onitamaMoveCardNameToScheme["haseCard"][4, 2] = true;
        onitamaMoveCardNameToScheme["haseCard"][3, 3] = true;

        onitamaMoveCardNameToScheme["iguanaCard"][0, 3] = true;
        onitamaMoveCardNameToScheme["iguanaCard"][2, 3] = true;
        onitamaMoveCardNameToScheme["iguanaCard"][3, 1] = true;

        onitamaMoveCardNameToScheme["kirinCard"][2, 0] = true;
        onitamaMoveCardNameToScheme["kirinCard"][1, 4] = true;
        onitamaMoveCardNameToScheme["kirinCard"][3, 4] = true;

        onitamaMoveCardNameToScheme["kobraCard"][1, 2] = true;
        onitamaMoveCardNameToScheme["kobraCard"][3, 1] = true;
        onitamaMoveCardNameToScheme["kobraCard"][3, 3] = true;

        onitamaMoveCardNameToScheme["krabbeCard"][0, 2] = true;
        onitamaMoveCardNameToScheme["krabbeCard"][4, 2] = true;
        onitamaMoveCardNameToScheme["krabbeCard"][2, 3] = true;

        onitamaMoveCardNameToScheme["kranichCard"][1, 1] = true;
        onitamaMoveCardNameToScheme["kranichCard"][2, 3] = true;
        onitamaMoveCardNameToScheme["kranichCard"][3, 1] = true;

        onitamaMoveCardNameToScheme["mouseCard"][1, 1] = true;
        onitamaMoveCardNameToScheme["mouseCard"][2, 3] = true;
        onitamaMoveCardNameToScheme["mouseCard"][3, 2] = true;

        onitamaMoveCardNameToScheme["ochseCard"][2, 1] = true;
        onitamaMoveCardNameToScheme["ochseCard"][2, 3] = true;
        onitamaMoveCardNameToScheme["ochseCard"][3, 2] = true;

        onitamaMoveCardNameToScheme["otterCard"][4, 2] = true;
        onitamaMoveCardNameToScheme["otterCard"][1, 3] = true;
        onitamaMoveCardNameToScheme["otterCard"][3, 1] = true;

        onitamaMoveCardNameToScheme["pandaCard"][1, 1] = true;
        onitamaMoveCardNameToScheme["pandaCard"][2, 3] = true;
        onitamaMoveCardNameToScheme["pandaCard"][3, 3] = true;

        onitamaMoveCardNameToScheme["pferdCard"][1, 2] = true;
        onitamaMoveCardNameToScheme["pferdCard"][2, 1] = true;
        onitamaMoveCardNameToScheme["pferdCard"][2, 3] = true;

        onitamaMoveCardNameToScheme["phoenixCard"][0, 2] = true;
        onitamaMoveCardNameToScheme["phoenixCard"][4, 2] = true;
        onitamaMoveCardNameToScheme["phoenixCard"][3, 1] = true;
        onitamaMoveCardNameToScheme["phoenixCard"][3, 3] = true;

        onitamaMoveCardNameToScheme["ratCard"][1, 2] = true;
        onitamaMoveCardNameToScheme["ratCard"][2, 3] = true;
        onitamaMoveCardNameToScheme["ratCard"][3, 1] = true;

        onitamaMoveCardNameToScheme["sableCard"][1, 2] = true;
        onitamaMoveCardNameToScheme["sableCard"][0, 2] = true;
        onitamaMoveCardNameToScheme["sableCard"][3, 1] = true;

        onitamaMoveCardNameToScheme["seaCard"][1, 1] = true;
        onitamaMoveCardNameToScheme["seaCard"][2, 3] = true;
        onitamaMoveCardNameToScheme["seaCard"][4, 2] = true;

        onitamaMoveCardNameToScheme["tanukiCard"][1, 1] = true;
        onitamaMoveCardNameToScheme["tanukiCard"][2, 3] = true;
        onitamaMoveCardNameToScheme["tanukiCard"][4, 3] = true;

        onitamaMoveCardNameToScheme["tigerCard"][2, 1] = true;
        onitamaMoveCardNameToScheme["tigerCard"][2, 4] = true;

        onitamaMoveCardNameToScheme["turtleCard"][1, 1] = true;
        onitamaMoveCardNameToScheme["turtleCard"][0, 2] = true;
        onitamaMoveCardNameToScheme["turtleCard"][4, 2] = true;
        onitamaMoveCardNameToScheme["turtleCard"][3, 3] = true;

        onitamaMoveCardNameToScheme["viperCard"][0, 2] = true;
        onitamaMoveCardNameToScheme["viperCard"][2, 3] = true;
        onitamaMoveCardNameToScheme["viperCard"][3, 1] = true;

        onitamaMoveCardNameToScheme["wildCard"][1, 2] = true;
        onitamaMoveCardNameToScheme["wildCard"][3, 2] = true;
        onitamaMoveCardNameToScheme["wildCard"][2, 3] = true;
     
    }

    public bool getSchemePositionByName(string name, int x, int y)
    {
        return onitamaMoveCardNameToScheme[name][x, y];
    }
        
    public string getCardNameById(int id)
    {
        return allCardNames[id];
    }

    public int getNumberOfCards()
    {
        return allCardNames.Length;
    }

    public void CreateColors()
    {
        onitamaMoveCardNameToColor.Add("aalCard", "blue");
        onitamaMoveCardNameToColor.Add("affeCard", "blue");
        onitamaMoveCardNameToColor.Add("bearCard", "blue");
        onitamaMoveCardNameToColor.Add("dogCard", "blue");
        onitamaMoveCardNameToColor.Add("dracheCard", "red");
        onitamaMoveCardNameToColor.Add("elefantCard", "red");
        onitamaMoveCardNameToColor.Add("foxCard", "red");
        onitamaMoveCardNameToColor.Add("froschCard", "red");
        onitamaMoveCardNameToColor.Add("gansCard", "blue");
        onitamaMoveCardNameToColor.Add("giraffeCard", "blue");
        onitamaMoveCardNameToColor.Add("gottesCard", "red");
        onitamaMoveCardNameToColor.Add("hahnCard", "red");
        onitamaMoveCardNameToColor.Add("haseCard", "blue");
        onitamaMoveCardNameToColor.Add("iguanaCard", "red");
        onitamaMoveCardNameToColor.Add("kirinCard", "red");
        onitamaMoveCardNameToColor.Add("kobraCard", "red");
        onitamaMoveCardNameToColor.Add("krabbeCard", "blue");
        onitamaMoveCardNameToColor.Add("kranichCard", "blue");
        onitamaMoveCardNameToColor.Add("mouseCard", "blue");
        onitamaMoveCardNameToColor.Add("ochseCard", "blue");
        onitamaMoveCardNameToColor.Add("otterCard", "red");
        onitamaMoveCardNameToColor.Add("pandaCard", "red");
        onitamaMoveCardNameToColor.Add("pferdCard", "red");
        onitamaMoveCardNameToColor.Add("phoenixCard", "blue");
        onitamaMoveCardNameToColor.Add("ratCard", "red");
        onitamaMoveCardNameToColor.Add("sableCard", "blue");
        onitamaMoveCardNameToColor.Add("seaCard", "blue");
        onitamaMoveCardNameToColor.Add("tanukiCard", "blue");
        onitamaMoveCardNameToColor.Add("tigerCard", "blue");
        onitamaMoveCardNameToColor.Add("turtleCard", "red");
        onitamaMoveCardNameToColor.Add("viperCard", "red");
        onitamaMoveCardNameToColor.Add("wildCard", "red");
    }

    public string getOnitamaMoveCardColor(string name)
    {
        //Debug.Log(name);
        //Debug.Log(onitamaMoveCardNameToSprite[name].ToString());
        return onitamaMoveCardNameToColor[name];

    }

    public void CreateSprites()
    {
        onitamaMoveCardNameToSprite.Add("aalCard", aalCard);
        onitamaMoveCardNameToSprite.Add("affeCard", affeCard);
        onitamaMoveCardNameToSprite.Add("bearCard", bearCard);
        onitamaMoveCardNameToSprite.Add("dogCard", dogCard);
        onitamaMoveCardNameToSprite.Add("dracheCard", dracheCard);
        onitamaMoveCardNameToSprite.Add("elefantCard", elefantCard);
        onitamaMoveCardNameToSprite.Add("foxCard", foxCard);
        onitamaMoveCardNameToSprite.Add("froschCard", froschCard);
        onitamaMoveCardNameToSprite.Add("gansCard", gansCard);
        onitamaMoveCardNameToSprite.Add("giraffeCard", giraffeCard);
        onitamaMoveCardNameToSprite.Add("gottesCard", gottesCard);
        onitamaMoveCardNameToSprite.Add("hahnCard", hahnCard);
        onitamaMoveCardNameToSprite.Add("haseCard", haseCard);
        onitamaMoveCardNameToSprite.Add("iguanaCard", iguanaCard);
        onitamaMoveCardNameToSprite.Add("kirinCard", kirinCard);
        onitamaMoveCardNameToSprite.Add("kobraCard", kobraCard);
        onitamaMoveCardNameToSprite.Add("krabbeCard", krabbeCard);
        onitamaMoveCardNameToSprite.Add("kranichCard", kranichCard);
        onitamaMoveCardNameToSprite.Add("mouseCard", mouseCard);
        onitamaMoveCardNameToSprite.Add("ochseCard", ochseCard);
        onitamaMoveCardNameToSprite.Add("otterCard", otterCard);
        onitamaMoveCardNameToSprite.Add("pandaCard", pandaCard);
        onitamaMoveCardNameToSprite.Add("pferdCard", pferdCard);
        onitamaMoveCardNameToSprite.Add("phoenixCard", phoenixCard);
        onitamaMoveCardNameToSprite.Add("ratCard", ratCard);
        onitamaMoveCardNameToSprite.Add("sableCard", sableCard);
        onitamaMoveCardNameToSprite.Add("seaCard", seaCard);
        onitamaMoveCardNameToSprite.Add("tanukiCard", tanukiCard);
        onitamaMoveCardNameToSprite.Add("tigerCard", tigerCard);
        onitamaMoveCardNameToSprite.Add("turtleCard", turtleCard);
        onitamaMoveCardNameToSprite.Add("viperCard", viperCard);
        onitamaMoveCardNameToSprite.Add("wildCard", wildCard);
    } 

    public Sprite getOnitamaMoveCardSprite(string name)
    {
        //Debug.Log(name);
        //Debug.Log(onitamaMoveCardNameToSprite[name].ToString());
        return onitamaMoveCardNameToSprite[name];

    }
};
