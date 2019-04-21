using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;
    public GameObject card5;

    List<GameObject> cardsInDeck = new List<GameObject>();
    int deckSize = 10;

    public GameManager gm;

    void Start()
    {
        cardsInDeck.Add(card1);
        cardsInDeck.Add(card1);
        cardsInDeck.Add(card2);
        cardsInDeck.Add(card2);
        cardsInDeck.Add(card3);
        cardsInDeck.Add(card3);
        cardsInDeck.Add(card4);
        cardsInDeck.Add(card4);
        cardsInDeck.Add(card5);
        cardsInDeck.Add(card5);
    }

    void Update()
    {
        if(deckSize == 0)
        {
            Destroy(this.gameObject);
        }
    }

    void DrawCard()
    {
        int drawnCardIndex = Random.Range(0, deckSize);
        Instantiate(cardsInDeck[drawnCardIndex], new Vector3(transform.position.x - 7f, transform.position.y, transform.position.z), Quaternion.identity);
        cardsInDeck.RemoveAt(drawnCardIndex);
        deckSize--;
        gm.numberOfActionsPerTurn--;
    }

    void OnMouseDown()
    {
        if (gm.hasActions && deckSize > 0)
        {
            DrawCard();
        }
        else if(!gm.hasActions)
        {
            print("you can't draw a card because you don't have enough actions");
        }
    }
}
