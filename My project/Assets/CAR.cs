using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAR : MonoBehaviour
{
    string heroname = "rtx3080ti";
    int heroage = 3080;
    int heroheight = 200;
    string heropower = "money";
    string villainname = "gtx1650";
    int villainage = 1650;
    int villainheight = 160;
    string villainpower = "slowtime";
    int agedifference =  0;

    // Start is called before the first frame update
    void Start()
    {
        print(heroname);
        print(heroage);
        print(heroheight);
        print(heropower);
        print(villainname);
        print(villainage);
        print(villainheight);
        print(villainpower);
        agedifference = heroage - villainage;
        print(agedifference);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
