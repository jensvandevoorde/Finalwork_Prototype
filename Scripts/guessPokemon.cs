using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class guessPokemon : MonoBehaviour
{
    public GameObject shadowWall;

    public GameObject[] pokemons;
    GameObject currentPokemon;
    GameObject wrongPokemonOne;
    GameObject wrongPokemonTwo;
    public Text message;
    Text firstButton;
    Text secondButton;
    Text thirdButton;
    Text score;
    float points;
    public float countdown = 0;
    float choicesRandomized;
    float timer;
    bool canGetNextPoke = true;
    bool canRemoveShadow = false;
    bool canPlaceShadow = false;
    float xPos;
    float yPos;
    float zPos;
    Vector3 startPos;
    Vector3 destinationPos;
    float percentagePassed;
    int pokemonNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        xPos = 0;
        yPos = 1.83f;
        zPos = 0;



        countdown = 5;
        // startPos = new Vector3(-0.49f, 5.3167f, 3.56f);
        //  destinationPos = new Vector3(-0.49f, 13.3167f, 3.56f);

        firstButton = GameObject.Find("OptionOneText").GetComponent<Text>();
        secondButton = GameObject.Find("OptionTwoText").GetComponent<Text>();
        thirdButton = GameObject.Find("OptionThreeText").GetComponent<Text>();
        score = GameObject.Find("Points").GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {

        if (countdown > 0)
        {
            countdown -= Time.deltaTime;
        }
        /*   if (message.text == "Who's this Pokemon?")
           {
               Instantiate(shadowWall, new Vector3(xPos, yPos, zPos + 3f), Quaternion.identity);
           }
           if (message.text == "Congratzz" || message.text == "Too bad")
           {
               Destroy(GameObject.FindWithTag("Shadow"));
           } */

        if (message.text == "Congratzz" && countdown <= 0)
        {
            RandomPokemon();
            message.text = "Who's this Pokemon?";
        }

        NextPokemon();

    }

    void RandomPokemon()
    {
        canGetNextPoke = true;
        Destroy(GameObject.FindWithTag("Clone"));
    }
    public void FirstOption()
    {
        if (currentPokemon.name == firstButton.text)
        {
            points += 1;
            message.text = "Congratzz";
            score.text = "Score: " + points;
            countdown = 2;
            Destroy(GameObject.FindWithTag("Shadow"));
        }
        if (currentPokemon.name != firstButton.text)
        {
            Destroy(GameObject.FindWithTag("Shadow"));
            message.text = "Too bad";
        }


    }

    public void SecondOption()
    {
        if (currentPokemon.name == secondButton.text)
        {
            points += 1;
            message.text = "Congratzz";
            score.text = "Score: " + points;
            countdown = 2;
            Destroy(GameObject.FindWithTag("Shadow"));
        }
        if (currentPokemon.name != secondButton.text)
        {
            message.text = "Too bad";
            Destroy(GameObject.FindWithTag("Shadow"));
        }
    }
    public void ThirdOption()
    {
        if (currentPokemon.name == thirdButton.text)
        {
            points += 1;
            message.text = "Congratzz";
            score.text = "Score: " + points;
            countdown = 2;
            Destroy(GameObject.FindWithTag("Shadow"));
        }
        if (currentPokemon.name != thirdButton.text)
        {
            message.text = "Too bad";
            Destroy(GameObject.FindWithTag("Shadow"));
        }
    }

    void NextPokemon()
    {
        xPos = 0;
        yPos = 1.83f;
        zPos = 0;

        if (canGetNextPoke)
        {
            currentPokemon = pokemons[Random.Range(0, pokemons.Length)];
            wrongPokemonOne = pokemons[Random.Range(0, pokemons.Length)];
            wrongPokemonTwo = pokemons[Random.Range(0, pokemons.Length)];
            choicesRandomized = Random.Range(0, 2);

            Instantiate(currentPokemon, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            Instantiate(shadowWall, new Vector3(xPos, yPos, zPos + 3f), Quaternion.identity);

            if (choicesRandomized == 0)
            {
                firstButton.text = currentPokemon.name;
                secondButton.text = wrongPokemonOne.name;
                thirdButton.text = wrongPokemonTwo.name;
            }
            if (choicesRandomized == 1)
            {
                firstButton.text = wrongPokemonOne.name;
                secondButton.text = currentPokemon.name;
                thirdButton.text = wrongPokemonTwo.name;
            }
            if (choicesRandomized == 2)
            {
                firstButton.text = wrongPokemonOne.name;
                secondButton.text = wrongPokemonTwo.name;
                thirdButton.text = currentPokemon.name;
            }

            canGetNextPoke = false;
            canPlaceShadow = true;

            currentPokemon.tag = "Clone";

        }



    }
}
