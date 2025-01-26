using UnityEngine;

public class DDSim : MonoBehaviour
{
    //initalize variables
    [SerializeField] public string PlayerName;
    [SerializeField][Range(1, 5)] int PBonus;
    [SerializeField][Range(-5, 5)] int Strn;
    [SerializeField][Range(-5, 5)] int Dex;
    [SerializeField] bool finWeapon;
    int Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // get the die and roll it
        int DIE = Random.Range(1, 21);

        //determine player strength
        if (Dex > Strn && finWeapon == true)
        {

            Player = DIE + PBonus + Dex;
        }
        else
        {
            Player = DIE + PBonus + Strn;
        }

        //get the computer strength
        int Comp = Random.Range(10, 21);

        //determine if there was a hit and display results
        if (Player > Comp)
        {
            Debug.Log(PlayerName + " rolled a " + DIE + ".\n" + PlayerName + "'s strength was " + Player);
            Debug.Log("The Computer had " + Comp + " armor.");
            Debug.Log(PlayerName + " chopped off the Computer's hypothetical head.");

        }
        else
        {
            Debug.Log(PlayerName + " rolled a " + DIE + ".\n" + PlayerName + "'s strength was " + Player);
            Debug.Log("The Computer had " + Comp + " armor.");
            Debug.Log(PlayerName + " just wasn't strong enough.\n Try Again if you dare.");


        }
    }



    // Update is called once per frame
    void Update()
    {

    }
}

