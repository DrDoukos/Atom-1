using UnityEngine;
using System.Collections;

public class Listas : MonoBehaviour
{
    public int electron;
    public int proton;
    public int neutron;

    public int Neutrones(int ing)
    {
        switch (ing)
        {
            case 1:
                neutron = 1;
            case 2:
                neutron =2;
            case 3:
                neutron =  4;
            case 4:
                neutron = 5;
            case 5:
                neutron = 6;
            case 6:
                neutron = 6;
            case 7:
                neutron = 7;
            case 8:
                neutron = 8;
            case 9:
                neutron = 10;
            case 10:
                neutron = 10;
            case 11:
                proton = 11;
                neutron = 12;
                electron = 11;
            case 12:
                neutron = 12;
            case 13:
                neutron = 14;
            case 14:
                neutron = 14;
            case 15:
                neutron = 16;
            case 16:
                neutron = 16;
            case 17:
                neutron = 18;
            case 18:
                neutron = 22;
            case 19:
                neutron = 20;
            case 20:
                neutron =20;
            case 21:
                neutron = 23;
            case 22:
                neutron = 26;
            case 23:
                neutron = 28;
            case 24:
                neutron = 28;
            case 25:
                neutron = 30;
            case 26:
                neutron = 30;
         

        }

        return neutron;
    }
}
