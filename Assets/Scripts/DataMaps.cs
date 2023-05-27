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

    private Dictionary<string, Sprite> nameToSprite = new Dictionary<string, Sprite>();

   public void CreateSprites()
    {
        nameToSprite.Add("aalCard", aalCard);
        nameToSprite.Add("affeCard", affeCard);
        nameToSprite.Add("bearCard", bearCard);
        nameToSprite.Add("dogCard", dogCard);
        nameToSprite.Add("dracheCard", dracheCard);
        nameToSprite.Add("elefantCard", elefantCard);
        nameToSprite.Add("foxCard", foxCard);
        nameToSprite.Add("froschCard", froschCard);
        nameToSprite.Add("gansCard", gansCard);
        nameToSprite.Add("giraffeCard", giraffeCard);
        nameToSprite.Add("gottesCard", gottesCard);
        nameToSprite.Add("hahnCard", hahnCard);
        nameToSprite.Add("haseCard", haseCard);
        nameToSprite.Add("iguanaCard", iguanaCard);
        nameToSprite.Add("kirinCard", kirinCard);
        nameToSprite.Add("kobraCard", kobraCard);
        nameToSprite.Add("krabbeCard", krabbeCard);
        nameToSprite.Add("kranichCard", kranichCard);
        nameToSprite.Add("mouseCard", mouseCard);
        nameToSprite.Add("ochseCard", ochseCard);
        nameToSprite.Add("otterCard", otterCard);
        nameToSprite.Add("pandaCard", pandaCard);
        nameToSprite.Add("pferdCard", pferdCard);
        nameToSprite.Add("phoenixCard", phoenixCard);
        nameToSprite.Add("ratCard", ratCard);
        nameToSprite.Add("sableCard", sableCard);
        nameToSprite.Add("seaCard", seaCard);
        nameToSprite.Add("tanukiCard", tanukiCard);
        nameToSprite.Add("tigerCard", tigerCard);
        nameToSprite.Add("turtleCard", turtleCard);
        nameToSprite.Add("viperCard", viperCard);
        nameToSprite.Add("wildCard", wildCard);
    } 

    public Sprite getSprite(string name)
    {
        //Debug.Log(name);
        //Debug.Log(nameToSprite[name].ToString());
        return nameToSprite[name];

    }
};
