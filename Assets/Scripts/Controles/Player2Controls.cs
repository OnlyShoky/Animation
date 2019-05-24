using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Player2Controls 
{
    private static KeyCode UP = KeyCode.UpArrow,
    DOWN = KeyCode.DownArrow,
    LEFT=KeyCode.LeftArrow,
    RIGHT=KeyCode.RightArrow,
    JUMP=KeyCode.UpArrow,
    ATTACK=KeyCode.Keypad4,
    POWER1=KeyCode.Keypad1,
    POWER2=KeyCode.Keypad2,
    POWER3=KeyCode.Keypad2,
    POWER4=KeyCode.Keypad3;

    public static KeyCode getUP{
       get{
           return UP ;
       }
       set{
           UP = value ;
       }
    }
    public static KeyCode getDOWN{
       get{
           return DOWN ;
       }
       set{
           DOWN = value ;
       }

    }
    public static KeyCode getLEFT{
       get{
           return LEFT ;
       }
       set{
           LEFT = value ;
       }

    }
    public static KeyCode getRIGHT{
       get{
           return RIGHT ;
       }
       set{
           RIGHT = value ;
       }

    }
    public static KeyCode getATTACK{
       get{
           return ATTACK ;
       }
       set{
           ATTACK = value ;
       }

    }
    public static KeyCode getJUMP{
       get{
           return JUMP ;
       }
       set{
           JUMP = value ;
       }

    }
    public static KeyCode getPOWER1{
       get{
           return POWER1 ;
       }
       set{
           POWER1 = value ;
       }

    }
    public static KeyCode getPOWER2{
       get{
           return POWER2 ;
       }
       set{
           POWER2 = value ;
       }

    }public static KeyCode getPOWER3{
       get{
           return POWER3 ;
       }
       set{
           POWER3 = value ;
       }

    }public static KeyCode getPOWER4{
       get{
           return POWER4 ;
       }
       set{
           POWER4 = value ;
       }

    }
}
