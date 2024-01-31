using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour
{

    Dictionary<string, int> BountyPirate = new Dictionary<string, int>()
    {
        { "Luffy", 300000000 },
        { "Chopper", 1000 }
    };

    Dictionary<string, string> CelestialDragon = new Dictionary<string, string>()
    {
        { "Saturn", "EggHead" },
        
    };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            updateBounty("Luffy", 6000000);
            Debug.Log("PiratesCount: " + BountyPirate.Count);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            addPirate("Kuma", 34000000);
            addPirate("Dofi", 64000000);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (CelestialDragon.ContainsKey("Saturn") && CelestialDragon.ContainsValue("EggHead"))
            {
                deletePirate("Kuma");
            }
        }
    }

    void updateBounty(string pirateName, int newBounty)
    {
        BountyPirate[pirateName] = newBounty;
    }

    void addPirate(string pirateName, int bounty)
    {
        BountyPirate.Add(pirateName, bounty);
    }

    void deletePirate(string pirateName)
    {
        BountyPirate.Remove(pirateName);
    }
}
