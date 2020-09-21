using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswerSet2 : MonoBehaviour
{
    public GameObject letterOne, letterTwo, letterThree, letterFour, letterFive, letterSix, letterSeven, letterEight, BoxOne, BoxTwo, BoxThree, BoxFour;

    Vector3 letterOneIni, letterTwoIni, letterThreeIni, letterFourIni, letterFiveIni, letterSixIni, letterSevenIni, letterEightIni;

    string str = "";
    public string word;

    public GameObject questionToHide, questionToShow;

    bool oneCorrect, twoCorrect, threeCorrect, fourCorrect = false;

    Vector3 iniScaleLetterOne, iniScaleLetterTwo, iniScaleLetterThree, iniScaleLetterFour, iniScaleLetterFive, iniScaleLetterSix, iniScaleLetterSeven, iniScaleLetterEight;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;
    public AudioClip buttonDrop;
    public AudioClip reload;

    // Start is called before the first frame update
    void Start()
    {
        letterOneIni = letterOne.transform.position;
        letterTwoIni = letterTwo.transform.position;
        letterThreeIni = letterThree.transform.position;
        letterFourIni = letterFour.transform.position;
        letterFiveIni = letterFive.transform.position;
        letterSixIni = letterSix.transform.position;
        letterSevenIni = letterSeven.transform.position;
        letterEightIni = letterEight.transform.position;

        iniScaleLetterOne = letterOne.transform.localScale;
        iniScaleLetterTwo = letterTwo.transform.localScale;
        iniScaleLetterThree = letterThree.transform.localScale;
        iniScaleLetterFour = letterFour.transform.localScale;
        iniScaleLetterFive = letterFive.transform.localScale;
        iniScaleLetterSix = letterSix.transform.localScale;
        iniScaleLetterSeven = letterSeven.transform.localScale;
        iniScaleLetterEight = letterEight.transform.localScale;

    }

    public void DragLetterOne()
    {
        letterOne.transform.position = Input.mousePosition;
    }

    public void DragLetterTwo()
    {
        letterTwo.transform.position = Input.mousePosition;
    }

    public void DragLetterThree()
    {
        letterThree.transform.position = Input.mousePosition;
    }

    public void DragLetterFour()
    {
        letterFour.transform.position = Input.mousePosition;
    }

    public void DragLetterFive()
    {
        letterFive.transform.position = Input.mousePosition;
    }

    public void DragLetterSix()
    {
        letterSix.transform.position = Input.mousePosition;
    }

    public void DragLetterSeven()
    {
        letterSeven.transform.position = Input.mousePosition;
    }

    public void DragLetterEight()
    {
        letterEight.transform.position = Input.mousePosition;
    }

    public void DropLetterOne()
    {
        float Distance1 = Vector3.Distance(letterOne.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(letterOne.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterOne.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterOne.transform.position, BoxFour.transform.position);

        if (Distance1 < 50 && oneCorrect == false)
        {
            letterOne.transform.localScale = BoxOne.transform.localScale;
            letterOne.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            letterOne.transform.localScale = BoxTwo.transform.localScale;
            letterOne.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            letterOne.transform.localScale = BoxThree.transform.localScale;
            letterOne.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterOne.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && fourCorrect == false)
        {
            letterOne.transform.localScale = BoxFour.transform.localScale;
            letterOne.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = letterOne.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            letterOne.transform.position = letterOneIni;
            source.clip = reload;
            source.Play();
        }
    }

    public void DropLetterTwo()
    {
        float Distance1 = Vector3.Distance(letterTwo.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(letterTwo.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterTwo.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterTwo.transform.position, BoxFour.transform.position);

        if (Distance1 < 50 && oneCorrect == false)
        {
            letterTwo.transform.localScale = BoxOne.transform.localScale;
            letterTwo.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            letterTwo.transform.localScale = BoxTwo.transform.localScale;
            letterTwo.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            letterTwo.transform.localScale = BoxThree.transform.localScale;
            letterTwo.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && fourCorrect == false)
        {
            letterTwo.transform.localScale = BoxFour.transform.localScale;
            letterTwo.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = letterTwo.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            letterTwo.transform.position = letterTwoIni;
            source.clip = reload;
            source.Play();
        }
    }

    public void DropLetterThree()
    {
        float Distance1 = Vector3.Distance(letterThree.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(letterThree.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterThree.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterThree.transform.position, BoxFour.transform.position);

        if (Distance1 < 50 && oneCorrect == false)
        {
            letterThree.transform.localScale = BoxOne.transform.localScale;
            letterThree.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            letterThree.transform.localScale = BoxTwo.transform.localScale;
            letterThree.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            letterThree.transform.localScale = BoxThree.transform.localScale;
            letterThree.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterThree.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && fourCorrect == false)
        {
            letterThree.transform.localScale = BoxFour.transform.localScale;
            letterThree.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = letterThree.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            letterThree.transform.position = letterThreeIni;
            source.clip = reload;
            source.Play();
        }
    }

    public void DropLetterFour()
    {
        float Distance1 = Vector3.Distance(letterFour.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(letterFour.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterFour.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterFour.transform.position, BoxFour.transform.position);

        if (Distance1 < 50 && oneCorrect == false)
        {
            letterFour.transform.localScale = BoxOne.transform.localScale;
            letterFour.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterFour.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            letterFour.transform.localScale = BoxTwo.transform.localScale;
            letterFour.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterFour.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            letterFour.transform.localScale = BoxThree.transform.localScale;
            letterFour.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterFour.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && fourCorrect == false)
        {
            letterFour.transform.localScale = BoxFour.transform.localScale;
            letterFour.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = letterFour.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            letterFour.transform.position = letterFourIni;
            source.clip = reload;
            source.Play();
        }
    }

    public void DropLetterFive()
    {
        float Distance1 = Vector3.Distance(letterFive.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(letterFive.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterFive.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterFive.transform.position, BoxFour.transform.position);

        if (Distance1 < 50 && oneCorrect == false)
        {
            letterFive.transform.localScale = BoxOne.transform.localScale;
            letterFive.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            letterFive.transform.localScale = BoxTwo.transform.localScale;
            letterFive.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            letterFive.transform.localScale = BoxThree.transform.localScale;
            letterFive.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterFive.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && fourCorrect == false)
        {
            letterFive.transform.localScale = BoxFour.transform.localScale;
            letterFive.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = letterFive.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            letterFive.transform.position = letterFiveIni;
            source.clip = reload;
            source.Play();
        }
    }

    public void DropLetterSix()
    {
        float Distance1 = Vector3.Distance(letterSix.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(letterSix.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterSix.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterSix.transform.position, BoxFour.transform.position);

        if (Distance1 < 50 && oneCorrect == false)
        {
            letterSix.transform.localScale = BoxOne.transform.localScale;
            letterSix.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            letterSix.transform.localScale = BoxTwo.transform.localScale;
            letterSix.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            letterSix.transform.localScale = BoxThree.transform.localScale;
            letterSix.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterSix.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && fourCorrect == false)
        {
            letterSix.transform.localScale = BoxFour.transform.localScale;
            letterSix.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = letterSix.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            letterSix.transform.position = letterSixIni;
            source.clip = reload;
            source.Play();
        }
    }

    public void DropLetterSeven()
    {
        float Distance1 = Vector3.Distance(letterSeven.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(letterSeven.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterSeven.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterSeven.transform.position, BoxFour.transform.position);

        if (Distance1 < 50 && oneCorrect == false)
        {
            letterSeven.transform.localScale = BoxOne.transform.localScale;
            letterSeven.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            letterSeven.transform.localScale = BoxTwo.transform.localScale;
            letterSeven.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            letterSeven.transform.localScale = BoxThree.transform.localScale;
            letterSeven.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && fourCorrect == false)
        {
            letterSeven.transform.localScale = BoxFour.transform.localScale;
            letterSeven.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = letterSeven.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            letterSeven.transform.position = letterSevenIni;
            source.clip = reload;
            source.Play();
        }
    }

    public void DropLetterEight()
    {
        float Distance1 = Vector3.Distance(letterEight.transform.position, BoxOne.transform.position);
        float Distance2 = Vector3.Distance(letterEight.transform.position, BoxTwo.transform.position);
        float Distance3 = Vector3.Distance(letterEight.transform.position, BoxThree.transform.position);
        float Distance4 = Vector3.Distance(letterEight.transform.position, BoxFour.transform.position);

        if (Distance1 < 50 && oneCorrect == false)
        {
            letterEight.transform.localScale = BoxOne.transform.localScale;
            letterEight.transform.position = BoxOne.transform.position;
            oneCorrect = true;
            BoxOne.name = letterEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance2 < 50 && twoCorrect == false)
        {
            letterEight.transform.localScale = BoxTwo.transform.localScale;
            letterEight.transform.position = BoxTwo.transform.position;
            twoCorrect = true;
            BoxTwo.name = letterEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance3 < 50 && threeCorrect == false)
        {
            letterEight.transform.localScale = BoxThree.transform.localScale;
            letterEight.transform.position = BoxThree.transform.position;
            threeCorrect = true;
            BoxThree.name = letterEight.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distance4 < 50 && fourCorrect == false)
        {
            letterEight.transform.localScale = BoxFour.transform.localScale;
            letterEight.transform.position = BoxFour.transform.position;
            fourCorrect = true;
            BoxFour.name = letterEight.name;
            source.clip = buttonDrop;
            source.Play();
        }


        else
        {
            letterEight.transform.position = letterEightIni;
            source.clip = reload;
            source.Play();
        }
    }

    public void Check()
    {
        str = BoxFour.name + BoxThree.name + BoxTwo.name + BoxOne.name;

        if (word == str)
        {
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            ScoreScript.scoreValue += 5;
            StartCoroutine(LoadNextPanel());
        }
        else
        {
            source.clip = incorrect;
            source.Play();
            StartCoroutine(LoadNextPanel());
        }

    }

    public void Reload()
    {
        str = "";

        source.clip = reload;
        source.Play();

        oneCorrect = false;
        twoCorrect = false;
        threeCorrect = false;
        fourCorrect = false;

        BoxOne.name = "1";
        BoxTwo.name = "2";
        BoxThree.name = "3";
        BoxFour.name = "4";

        letterOne.transform.position = letterOneIni;
        letterTwo.transform.position = letterTwoIni;
        letterThree.transform.position = letterThreeIni;
        letterFour.transform.position = letterFourIni;
        letterFive.transform.position = letterFiveIni;
        letterSix.transform.position = letterSixIni;
        letterSeven.transform.position = letterSevenIni;
        letterEight.transform.position = letterEightIni;

        letterOne.transform.localScale = iniScaleLetterOne;
        letterTwo.transform.localScale = iniScaleLetterTwo;
        letterThree.transform.localScale = iniScaleLetterThree;
        letterFour.transform.localScale = iniScaleLetterFour;
        letterFive.transform.localScale = iniScaleLetterFive;
        letterSix.transform.localScale = iniScaleLetterSix;
        letterSeven.transform.localScale = iniScaleLetterSeven;
        letterEight.transform.localScale = iniScaleLetterEight;
    }

    IEnumerator LoadNextPanel()
    {
        yield return new WaitForSeconds(1f);
        questionToHide.SetActive(false);
        questionToShow.SetActive(true);
    }
}

