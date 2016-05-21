using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleLI
{
    static class BaseballStat
    {
        // A static class with a static method for calculating a Leverage Index value given a game state argument
        // Based on Tom Tango's calculations: http://www.insidethebook.com/li.shtml
        // TODO: refactor this into a series of compound arrays, rather than the (admittedly quite gross) series of nested conditionals it is right now


        static public double LeverageIndex(Tuple<bool, int, int> inning, Tuple<bool, bool, bool> baseState, int runDeltaHome)
        {
            double leverageIndex = 0.0;

            switch (inning.Item2)
            {
                case 1:
                    // Top 1st
                    if (inning.Item1)
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 0:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        default:
                                            break;
                                    }                                    
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 0.8;
                                            break;
                                        case -1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 0:
                                            leverageIndex = 1.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.5;
                                            break;
                                        case -1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 0:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.9;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.9;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.1;
                                            break;
                                        case -3:
                                            leverageIndex = 1.5;
                                            break;
                                        case -2:
                                            leverageIndex = 1.8;
                                            break;
                                        case -1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 0:
                                            leverageIndex = 2.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.3;
                                            break;
                                        case -1:
                                            leverageIndex = 0.4;
                                            break;
                                        case 0:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.6;
                                            break;
                                        case -1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 0:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.9;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 1.8;
                                            break;
                                        case -2:
                                            leverageIndex = 2.1;
                                            break;
                                        case -1:
                                            leverageIndex = 2.5;
                                            break;
                                        case 0:
                                            leverageIndex = 2.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    /// Bottom 1st
                    else
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 0:
                                            leverageIndex = 0.9;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.2;
                                            break;
                                        case -3:
                                            leverageIndex = 1.4;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.1;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.1;
                                            break;
                                        case 1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.0;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.9;
                                            break;
                                        case -2:
                                            leverageIndex = 2.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.6;
                                            break;
                                        case -3:
                                            leverageIndex = 1.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 1.5;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.2;
                                            break;
                                        case -3:
                                            leverageIndex = 2.3;
                                            break;
                                        case -2:
                                            leverageIndex = 2.3;
                                            break;
                                        case -1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 0.6;
                                            break;
                                        case -1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 0:
                                            leverageIndex = 0.6;
                                            break;
                                        case 1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.2;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.1;
                                            break;
                                        case 1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.2;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.9;
                                            break;
                                        case -2:
                                            leverageIndex = 2.0;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.5;
                                            break;
                                        case -3:
                                            leverageIndex = 1.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 1.5;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.4;
                                            break;
                                        case -3:
                                            leverageIndex = 2.6;
                                            break;
                                        case -2:
                                            leverageIndex = 2.6;
                                            break;
                                        case -1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.3;
                                            break;
                                        case 1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 2:
                                            leverageIndex = 1.6;
                                            break;
                                        case 3:
                                            leverageIndex = 1.3;
                                            break;
                                        case 4:
                                            leverageIndex = 1.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.4;
                                            break;
                                        case -1:
                                            leverageIndex = 0.4;
                                            break;
                                        case 0:
                                            leverageIndex = 0.4;
                                            break;
                                        case 1:
                                            leverageIndex = 0.4;
                                            break;
                                        case 2:
                                            leverageIndex = 0.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 0.8;
                                            break;
                                        case -1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 0:
                                            leverageIndex = 0.8;
                                            break;
                                        case 1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.1;
                                            break;
                                        case 1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.3;
                                            break;
                                        case -3:
                                            leverageIndex = 1.5;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 1.6;
                                            break;
                                        case -2:
                                            leverageIndex = 1.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.6;
                                            break;
                                        case -3:
                                            leverageIndex = 1.8;
                                            break;
                                        case -2:
                                            leverageIndex = 2.0;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.4;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.4;
                                            break;
                                        case -3:
                                            leverageIndex = 2.7;
                                            break;
                                        case -2:
                                            leverageIndex = 2.9;
                                            break;
                                        case -1:
                                            leverageIndex = 2.9;
                                            break;
                                        case 0:
                                            leverageIndex = 2.7;
                                            break;
                                        case 1:
                                            leverageIndex = 2.4;
                                            break;
                                        case 2:
                                            leverageIndex = 2.0;
                                            break;
                                        case 3:
                                            leverageIndex = 1.5;
                                            break;
                                        case 4:
                                            leverageIndex = 1.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 2:
                    // Top 2nd
                    if (inning.Item1)
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 0:
                                            leverageIndex = 0.9;
                                            break;
                                        case 1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.5;
                                            break;
                                        case 3:
                                            leverageIndex = 1.4;
                                            break;
                                        case 4:
                                            leverageIndex = 1.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.2;
                                            break;
                                        case 4:
                                            leverageIndex = 1.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 0.8;
                                            break;
                                        case -1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 0:
                                            leverageIndex = 1.1;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 2:
                                            leverageIndex = 2.0;
                                            break;
                                        case 3:
                                            leverageIndex = 1.9;
                                            break;
                                        case 4:
                                            leverageIndex = 1.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.8;
                                            break;
                                        case 3:
                                            leverageIndex = 1.7;
                                            break;
                                        case 4:
                                            leverageIndex = 1.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.6;
                                            break;
                                        case 3:
                                            leverageIndex = 1.5;
                                            break;
                                        case 4:
                                            leverageIndex = 1.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 2.3;
                                            break;
                                        case 2:
                                            leverageIndex = 2.4;
                                            break;
                                        case 3:
                                            leverageIndex = 2.3;
                                            break;
                                        case 4:
                                            leverageIndex = 2.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.5;
                                            break;
                                        case -1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 0:
                                            leverageIndex = 0.7;
                                            break;
                                        case 1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.9;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 2:
                                            leverageIndex = 2.0;
                                            break;
                                        case 3:
                                            leverageIndex = 1.8;
                                            break;
                                        case 4:
                                            leverageIndex = 1.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.9;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 2:
                                            leverageIndex = 1.8;
                                            break;
                                        case 3:
                                            leverageIndex = 1.6;
                                            break;
                                        case 4:
                                            leverageIndex = 1.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.6;
                                            break;
                                        case 3:
                                            leverageIndex = 1.5;
                                            break;
                                        case 4:
                                            leverageIndex = 1.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.1;
                                            break;
                                        case -3:
                                            leverageIndex = 1.5;
                                            break;
                                        case -2:
                                            leverageIndex = 1.8;
                                            break;
                                        case -1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 0:
                                            leverageIndex = 2.5;
                                            break;
                                        case 1:
                                            leverageIndex = 2.7;
                                            break;
                                        case 2:
                                            leverageIndex = 2.7;
                                            break;
                                        case 3:
                                            leverageIndex = 2.6;
                                            break;
                                        case 4:
                                            leverageIndex = 2.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.3;
                                            break;
                                        case -1:
                                            leverageIndex = 0.4;
                                            break;
                                        case 0:
                                            leverageIndex = 0.4;
                                            break;
                                        case 1:
                                            leverageIndex = 0.4;
                                            break;
                                        case 2:
                                            leverageIndex = 0.4;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 0:
                                            leverageIndex = 0.8;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 1.1;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.6;
                                            break;
                                        case 3:
                                            leverageIndex = 1.4;
                                            break;
                                        case 4:
                                            leverageIndex = 1.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.9;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 2:
                                            leverageIndex = 1.7;
                                            break;
                                        case 3:
                                            leverageIndex = 1.5;
                                            break;
                                        case 4:
                                            leverageIndex = 1.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 2:
                                            leverageIndex = 2.0;
                                            break;
                                        case 3:
                                            leverageIndex = 1.7;
                                            break;
                                        case 4:
                                            leverageIndex = 1.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.3;
                                            break;
                                        case -3:
                                            leverageIndex = 1.7;
                                            break;
                                        case -2:
                                            leverageIndex = 2.2;
                                            break;
                                        case -1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.9;
                                            break;
                                        case 1:
                                            leverageIndex = 3.0;
                                            break;
                                        case 2:
                                            leverageIndex = 2.9;
                                            break;
                                        case 3:
                                            leverageIndex = 2.6;
                                            break;
                                        case 4:
                                            leverageIndex = 2.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    /// Bottom 2nd
                    else
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 0.9;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.3;
                                            break;
                                        case -3:
                                            leverageIndex = 1.5;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.1;
                                            break;
                                        case -3:
                                            leverageIndex = 1.3;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.2;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.0;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.8;
                                            break;
                                        case -3:
                                            leverageIndex = 2.0;
                                            break;
                                        case -2:
                                            leverageIndex = 2.1;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.6;
                                            break;
                                        case -3:
                                            leverageIndex = 1.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.5;
                                            break;
                                        case -3:
                                            leverageIndex = 1.6;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.3;
                                            break;
                                        case -3:
                                            leverageIndex = 2.4;
                                            break;
                                        case -2:
                                            leverageIndex = 2.4;
                                            break;
                                        case -1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 0:
                                            leverageIndex = 0.7;
                                            break;
                                        case 1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.7;
                                            break;
                                        case -3:
                                            leverageIndex = 2.0;
                                            break;
                                        case -2:
                                            leverageIndex = 2.1;
                                            break;
                                        case -1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.5;
                                            break;
                                        case -3:
                                            leverageIndex = 1.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 1.6;
                                            break;
                                        case -2:
                                            leverageIndex = 1.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.5;
                                            break;
                                        case -3:
                                            leverageIndex = 2.7;
                                            break;
                                        case -2:
                                            leverageIndex = 2.8;
                                            break;
                                        case -1:
                                            leverageIndex = 2.7;
                                            break;
                                        case 0:
                                            leverageIndex = 2.4;
                                            break;
                                        case 1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 2:
                                            leverageIndex = 1.7;
                                            break;
                                        case 3:
                                            leverageIndex = 1.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.4;
                                            break;
                                        case -1:
                                            leverageIndex = 0.5;
                                            break;
                                        case 0:
                                            leverageIndex = 0.4;
                                            break;
                                        case 1:
                                            leverageIndex = 0.4;
                                            break;
                                        case 2:
                                            leverageIndex = 0.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 0:
                                            leverageIndex = 0.8;
                                            break;
                                        case 1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.2;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.3;
                                            break;
                                        case -3:
                                            leverageIndex = 1.6;
                                            break;
                                        case -2:
                                            leverageIndex = 1.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 1.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.6;
                                            break;
                                        case -3:
                                            leverageIndex = 1.9;
                                            break;
                                        case -2:
                                            leverageIndex = 2.1;
                                            break;
                                        case -1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.4;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.5;
                                            break;
                                        case -3:
                                            leverageIndex = 2.8;
                                            break;
                                        case -2:
                                            leverageIndex = 3.1;
                                            break;
                                        case -1:
                                            leverageIndex = 3.1;
                                            break;
                                        case 0:
                                            leverageIndex = 2.9;
                                            break;
                                        case 1:
                                            leverageIndex = 2.5;
                                            break;
                                        case 2:
                                            leverageIndex = 2.0;
                                            break;
                                        case 3:
                                            leverageIndex = 1.5;
                                            break;
                                        case 4:
                                            leverageIndex = 1.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 3:
                    // top 3rd
                    if (inning.Item1)
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 0:
                                            leverageIndex = 1.0;
                                            break;
                                        case 1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.6;
                                            break;
                                        case 3:
                                            leverageIndex = 1.4;
                                            break;
                                        case 4:
                                            leverageIndex = 1.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 1.4;
                                            break;
                                        case 3:
                                            leverageIndex = 1.2;
                                            break;
                                        case 4:
                                            leverageIndex = 1.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 0.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.1;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 1.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 2:
                                            leverageIndex = 2.1;
                                            break;
                                        case 3:
                                            leverageIndex = 2.0;
                                            break;
                                        case 4:
                                            leverageIndex = 1.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 2:
                                            leverageIndex = 1.9;
                                            break;
                                        case 3:
                                            leverageIndex = 1.8;
                                            break;
                                        case 4:
                                            leverageIndex = 1.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.7;
                                            break;
                                        case 3:
                                            leverageIndex = 1.6;
                                            break;
                                        case 4:
                                            leverageIndex = 1.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 2.4;
                                            break;
                                        case 2:
                                            leverageIndex = 2.6;
                                            break;
                                        case 3:
                                            leverageIndex = 2.5;
                                            break;
                                        case 4:
                                            leverageIndex = 2.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.5;
                                            break;
                                        case -1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 0:
                                            leverageIndex = 0.7;
                                            break;
                                        case 1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 2:
                                            leverageIndex = 0.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.9;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 2:
                                            leverageIndex = 2.1;
                                            break;
                                        case 3:
                                            leverageIndex = 1.9;
                                            break;
                                        case 4:
                                            leverageIndex = 1.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 2:
                                            leverageIndex = 1.9;
                                            break;
                                        case 3:
                                            leverageIndex = 1.7;
                                            break;
                                        case 4:
                                            leverageIndex = 1.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.2;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.7;
                                            break;
                                        case 3:
                                            leverageIndex = 1.6;
                                            break;
                                        case 4:
                                            leverageIndex = 1.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.1;
                                            break;
                                        case -3:
                                            leverageIndex = 1.4;
                                            break;
                                        case -2:
                                            leverageIndex = 1.9;
                                            break;
                                        case -1:
                                            leverageIndex = 2.3;
                                            break;
                                        case 0:
                                            leverageIndex = 2.7;
                                            break;
                                        case 1:
                                            leverageIndex = 2.9;
                                            break;
                                        case 2:
                                            leverageIndex = 2.9;
                                            break;
                                        case 3:
                                            leverageIndex = 2.7;
                                            break;
                                        case 4:
                                            leverageIndex = 2.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.4;
                                            break;
                                        case -1:
                                            leverageIndex = 0.4;
                                            break;
                                        case 0:
                                            leverageIndex = 0.5;
                                            break;
                                        case 1:
                                            leverageIndex = 0.5;
                                            break;
                                        case 2:
                                            leverageIndex = 0.4;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 0:
                                            leverageIndex = 0.9;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.1;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 2:
                                            leverageIndex = 1.8;
                                            break;
                                        case 3:
                                            leverageIndex = 1.5;
                                            break;
                                        case 4:
                                            leverageIndex = 1.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 2:
                                            leverageIndex = 1.9;
                                            break;
                                        case 3:
                                            leverageIndex = 1.6;
                                            break;
                                        case 4:
                                            leverageIndex = 1.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.9;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 0:
                                            leverageIndex = 2.2;
                                            break;
                                        case 1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 2:
                                            leverageIndex = 2.1;
                                            break;
                                        case 3:
                                            leverageIndex = 1.8;
                                            break;
                                        case 4:
                                            leverageIndex = 1.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.3;
                                            break;
                                        case -3:
                                            leverageIndex = 1.7;
                                            break;
                                        case -2:
                                            leverageIndex = 2.2;
                                            break;
                                        case -1:
                                            leverageIndex = 2.7;
                                            break;
                                        case 0:
                                            leverageIndex = 3.1;
                                            break;
                                        case 1:
                                            leverageIndex = 3.3;
                                            break;
                                        case 2:
                                            leverageIndex = 3.1;
                                            break;
                                        case 3:
                                            leverageIndex = 2.7;
                                            break;
                                        case 4:
                                            leverageIndex = 2.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    /// Bottom 3rd
                    else
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.0;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.3;
                                            break;
                                        case -3:
                                            leverageIndex = 1.6;
                                            break;
                                        case -2:
                                            leverageIndex = 1.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.2;
                                            break;
                                        case -3:
                                            leverageIndex = 1.3;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.1;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.1;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.9;
                                            break;
                                        case -3:
                                            leverageIndex = 2.1;
                                            break;
                                        case -2:
                                            leverageIndex = 2.3;
                                            break;
                                        case -1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.9;
                                            break;
                                        case -2:
                                            leverageIndex = 2.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.6;
                                            break;
                                        case -3:
                                            leverageIndex = 1.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.4;
                                            break;
                                        case -3:
                                            leverageIndex = 2.6;
                                            break;
                                        case -2:
                                            leverageIndex = 2.6;
                                            break;
                                        case -1:
                                            leverageIndex = 2.4;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 0:
                                            leverageIndex = 0.7;
                                            break;
                                        case 1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.3;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.3;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.8;
                                            break;
                                        case -3:
                                            leverageIndex = 2.1;
                                            break;
                                        case -2:
                                            leverageIndex = 2.3;
                                            break;
                                        case -1:
                                            leverageIndex = 2.3;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.6;
                                            break;
                                        case -3:
                                            leverageIndex = 1.9;
                                            break;
                                        case -2:
                                            leverageIndex = 2.0;
                                            break;
                                        case -1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.5;
                                            break;
                                        case -3:
                                            leverageIndex = 1.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.6;
                                            break;
                                        case -3:
                                            leverageIndex = 2.9;
                                            break;
                                        case -2:
                                            leverageIndex = 3.1;
                                            break;
                                        case -1:
                                            leverageIndex = 2.9;
                                            break;
                                        case 0:
                                            leverageIndex = 2.6;
                                            break;
                                        case 1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 2:
                                            leverageIndex = 1.6;
                                            break;
                                        case 3:
                                            leverageIndex = 1.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.5;
                                            break;
                                        case -1:
                                            leverageIndex = 0.5;
                                            break;
                                        case 0:
                                            leverageIndex = 0.5;
                                            break;
                                        case 1:
                                            leverageIndex = 0.4;
                                            break;
                                        case 2:
                                            leverageIndex = 0.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 0.9;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.9;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 1.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.9;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 1.8;
                                            break;
                                        case -2:
                                            leverageIndex = 2.0;
                                            break;
                                        case -1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.6;
                                            break;
                                        case -3:
                                            leverageIndex = 2.0;
                                            break;
                                        case -2:
                                            leverageIndex = 2.3;
                                            break;
                                        case -1:
                                            leverageIndex = 2.3;
                                            break;
                                        case 0:
                                            leverageIndex = 2.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 2:
                                            leverageIndex = 1.4;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.5;
                                            break;
                                        case -3:
                                            leverageIndex = 3.0;
                                            break;
                                        case -2:
                                            leverageIndex = 3.3;
                                            break;
                                        case -1:
                                            leverageIndex = 3.4;
                                            break;
                                        case 0:
                                            leverageIndex = 3.1;
                                            break;
                                        case 1:
                                            leverageIndex = 2.5;
                                            break;
                                        case 2:
                                            leverageIndex = 2.0;
                                            break;
                                        case 3:
                                            leverageIndex = 1.5;
                                            break;
                                        case 4:
                                            leverageIndex = 1.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 4:
                    // top fourth
                    if (inning.Item1)
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 0:
                                            leverageIndex = 1.1;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 1.1;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 2:
                                            leverageIndex = 1.7;
                                            break;
                                        case 3:
                                            leverageIndex = 1.5;
                                            break;
                                        case 4:
                                            leverageIndex = 1.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.5;
                                            break;
                                        case 3:
                                            leverageIndex = 1.3;
                                            break;
                                        case 4:
                                            leverageIndex = 1.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 0.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.2;
                                            break;
                                        case 4:
                                            leverageIndex = 1.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 2.3;
                                            break;
                                        case 2:
                                            leverageIndex = 2.3;
                                            break;
                                        case 3:
                                            leverageIndex = 2.1;
                                            break;
                                        case 4:
                                            leverageIndex = 1.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 2:
                                            leverageIndex = 2.1;
                                            break;
                                        case 3:
                                            leverageIndex = 1.9;
                                            break;
                                        case 4:
                                            leverageIndex = 1.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 2:
                                            leverageIndex = 1.8;
                                            break;
                                        case 3:
                                            leverageIndex = 1.7;
                                            break;
                                        case 4:
                                            leverageIndex = 1.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.2;
                                            break;
                                        case 1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 2:
                                            leverageIndex = 2.8;
                                            break;
                                        case 3:
                                            leverageIndex = 2.7;
                                            break;
                                        case 4:
                                            leverageIndex = 2.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.5;
                                            break;
                                        case -1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 0:
                                            leverageIndex = 0.8;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.4;
                                            break;
                                        case 3:
                                            leverageIndex = 1.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.4;
                                            break;
                                        case 3:
                                            leverageIndex = 1.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.4;
                                            break;
                                        case 3:
                                            leverageIndex = 1.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 0:
                                            leverageIndex = 2.3;
                                            break;
                                        case 1:
                                            leverageIndex = 2.4;
                                            break;
                                        case 2:
                                            leverageIndex = 2.3;
                                            break;
                                        case 3:
                                            leverageIndex = 2.0;
                                            break;
                                        case 4:
                                            leverageIndex = 1.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 2:
                                            leverageIndex = 2.1;
                                            break;
                                        case 3:
                                            leverageIndex = 1.8;
                                            break;
                                        case 4:
                                            leverageIndex = 1.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.2;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 2:
                                            leverageIndex = 1.9;
                                            break;
                                        case 3:
                                            leverageIndex = 1.7;
                                            break;
                                        case 4:
                                            leverageIndex = 1.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.4;
                                            break;
                                        case -2:
                                            leverageIndex = 1.9;
                                            break;
                                        case -1:
                                            leverageIndex = 2.4;
                                            break;
                                        case 0:
                                            leverageIndex = 2.9;
                                            break;
                                        case 1:
                                            leverageIndex = 3.1;
                                            break;
                                        case 2:
                                            leverageIndex = 3.2;
                                            break;
                                        case 3:
                                            leverageIndex = 2.9;
                                            break;
                                        case 4:
                                            leverageIndex = 2.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.4;
                                            break;
                                        case -1:
                                            leverageIndex = 0.5;
                                            break;
                                        case 0:
                                            leverageIndex = 0.5;
                                            break;
                                        case 1:
                                            leverageIndex = 0.5;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 0:
                                            leverageIndex = 1.0;
                                            break;
                                        case 1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.2;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.4;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 2:
                                            leverageIndex = 1.9;
                                            break;
                                        case 3:
                                            leverageIndex = 1.6;
                                            break;
                                        case 4:
                                            leverageIndex = 1.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 2:
                                            leverageIndex = 2.0;
                                            break;
                                        case 3:
                                            leverageIndex = 1.7;
                                            break;
                                        case 4:
                                            leverageIndex = 1.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.9;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 2.4;
                                            break;
                                        case 1:
                                            leverageIndex = 2.5;
                                            break;
                                        case 2:
                                            leverageIndex = 2.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.9;
                                            break;
                                        case 4:
                                            leverageIndex = 1.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.2;
                                            break;
                                        case -3:
                                            leverageIndex = 1.7;
                                            break;
                                        case -2:
                                            leverageIndex = 2.3;
                                            break;
                                        case -1:
                                            leverageIndex = 2.9;
                                            break;
                                        case 0:
                                            leverageIndex = 3.4;
                                            break;
                                        case 1:
                                            leverageIndex = 3.6;
                                            break;
                                        case 2:
                                            leverageIndex = 3.4;
                                            break;
                                        case 3:
                                            leverageIndex = 2.9;
                                            break;
                                        case 4:
                                            leverageIndex = 2.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    /// Bottom fourth
                    else
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.1;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 1.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.2;
                                            break;
                                        case -3:
                                            leverageIndex = 1.4;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.1;
                                            break;
                                        case -3:
                                            leverageIndex = 1.3;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.1;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.0;
                                            break;
                                        case -3:
                                            leverageIndex = 2.3;
                                            break;
                                        case -2:
                                            leverageIndex = 2.5;
                                            break;
                                        case -1:
                                            leverageIndex = 2.4;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.1;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.8;
                                            break;
                                        case -3:
                                            leverageIndex = 2.1;
                                            break;
                                        case -2:
                                            leverageIndex = 2.1;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.6;
                                            break;
                                        case -3:
                                            leverageIndex = 2.8;
                                            break;
                                        case -2:
                                            leverageIndex = 2.8;
                                            break;
                                        case -1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.1;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 0.8;
                                            break;
                                        case -1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 0:
                                            leverageIndex = 0.8;
                                            break;
                                        case 1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.3;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.1;
                                            break;
                                        case -3:
                                            leverageIndex = 1.3;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.3;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.8;
                                            break;
                                        case -3:
                                            leverageIndex = 2.2;
                                            break;
                                        case -2:
                                            leverageIndex = 2.5;
                                            break;
                                        case -1:
                                            leverageIndex = 2.5;
                                            break;
                                        case 0:
                                            leverageIndex = 2.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.7;
                                            break;
                                        case -3:
                                            leverageIndex = 2.0;
                                            break;
                                        case -2:
                                            leverageIndex = 2.2;
                                            break;
                                        case -1:
                                            leverageIndex = 2.3;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.6;
                                            break;
                                        case -3:
                                            leverageIndex = 1.8;
                                            break;
                                        case -2:
                                            leverageIndex = 2.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.7;
                                            break;
                                        case -3:
                                            leverageIndex = 3.2;
                                            break;
                                        case -2:
                                            leverageIndex = 3.3;
                                            break;
                                        case -1:
                                            leverageIndex = 3.2;
                                            break;
                                        case 0:
                                            leverageIndex = 2.8;
                                            break;
                                        case 1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 2:
                                            leverageIndex = 1.6;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.5;
                                            break;
                                        case -1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 0:
                                            leverageIndex = 0.5;
                                            break;
                                        case 1:
                                            leverageIndex = 0.4;
                                            break;
                                        case 2:
                                            leverageIndex = 0.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.0;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.9;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.3;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 1.8;
                                            break;
                                        case -2:
                                            leverageIndex = 2.1;
                                            break;
                                        case -1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.5;
                                            break;
                                        case -3:
                                            leverageIndex = 1.9;
                                            break;
                                        case -2:
                                            leverageIndex = 2.2;
                                            break;
                                        case -1:
                                            leverageIndex = 2.3;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.7;
                                            break;
                                        case -3:
                                            leverageIndex = 2.1;
                                            break;
                                        case -2:
                                            leverageIndex = 2.5;
                                            break;
                                        case -1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 2:
                                            leverageIndex = 1.4;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.6;
                                            break;
                                        case -3:
                                            leverageIndex = 3.2;
                                            break;
                                        case -2:
                                            leverageIndex = 3.6;
                                            break;
                                        case -1:
                                            leverageIndex = 3.7;
                                            break;
                                        case 0:
                                            leverageIndex = 3.3;
                                            break;
                                        case 1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.9;
                                            break;
                                        case 3:
                                            leverageIndex = 1.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 5:
                    // top fifth
                    if (inning.Item1)
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.1;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 2:
                                            leverageIndex = 1.9;
                                            break;
                                        case 3:
                                            leverageIndex = 1.6;
                                            break;
                                        case 4:
                                            leverageIndex = 1.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.6;
                                            break;
                                        case 3:
                                            leverageIndex = 1.4;
                                            break;
                                        case 4:
                                            leverageIndex = 1.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.5;
                                            break;
                                        case 3:
                                            leverageIndex = 1.3;
                                            break;
                                        case 4:
                                            leverageIndex = 1.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.3;
                                            break;
                                        case 1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 2:
                                            leverageIndex = 2.5;
                                            break;
                                        case 3:
                                            leverageIndex = 2.3;
                                            break;
                                        case 4:
                                            leverageIndex = 1.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 2:
                                            leverageIndex = 2.3;
                                            break;
                                        case 3:
                                            leverageIndex = 2.1;
                                            break;
                                        case 4:
                                            leverageIndex = 1.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 2:
                                            leverageIndex = 2.0;
                                            break;
                                        case 3:
                                            leverageIndex = 1.9;
                                            break;
                                        case 4:
                                            leverageIndex = 1.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.4;
                                            break;
                                        case 1:
                                            leverageIndex = 2.8;
                                            break;
                                        case 2:
                                            leverageIndex = 3.0;
                                            break;
                                        case 3:
                                            leverageIndex = 2.9;
                                            break;
                                        case 4:
                                            leverageIndex = 2.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.6;
                                            break;
                                        case -1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 0:
                                            leverageIndex = 0.9;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.5;
                                            break;
                                        case 3:
                                            leverageIndex = 1.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.5;
                                            break;
                                        case 3:
                                            leverageIndex = 1.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 2:
                                            leverageIndex = 1.5;
                                            break;
                                        case 3:
                                            leverageIndex = 1.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 2.5;
                                            break;
                                        case 1:
                                            leverageIndex = 2.7;
                                            break;
                                        case 2:
                                            leverageIndex = 2.5;
                                            break;
                                        case 3:
                                            leverageIndex = 2.1;
                                            break;
                                        case 4:
                                            leverageIndex = 1.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 0:
                                            leverageIndex = 2.3;
                                            break;
                                        case 1:
                                            leverageIndex = 2.4;
                                            break;
                                        case 2:
                                            leverageIndex = 2.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.9;
                                            break;
                                        case 4:
                                            leverageIndex = 1.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.2;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 2:
                                            leverageIndex = 2.1;
                                            break;
                                        case 3:
                                            leverageIndex = 1.8;
                                            break;
                                        case 4:
                                            leverageIndex = 1.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.9;
                                            break;
                                        case -3:
                                            leverageIndex = 1.3;
                                            break;
                                        case -2:
                                            leverageIndex = 1.9;
                                            break;
                                        case -1:
                                            leverageIndex = 2.5;
                                            break;
                                        case 0:
                                            leverageIndex = 3.1;
                                            break;
                                        case 1:
                                            leverageIndex = 3.5;
                                            break;
                                        case 2:
                                            leverageIndex = 3.5;
                                            break;
                                        case 3:
                                            leverageIndex = 3.1;
                                            break;
                                        case 4:
                                            leverageIndex = 2.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.4;
                                            break;
                                        case -1:
                                            leverageIndex = 0.5;
                                            break;
                                        case 0:
                                            leverageIndex = 0.6;
                                            break;
                                        case 1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 0:
                                            leverageIndex = 1.1;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.2;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 2:
                                            leverageIndex = 1.5;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.2;
                                            break;
                                        case 1:
                                            leverageIndex = 2.3;
                                            break;
                                        case 2:
                                            leverageIndex = 2.1;
                                            break;
                                        case 3:
                                            leverageIndex = 1.6;
                                            break;
                                        case 4:
                                            leverageIndex = 1.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 0:
                                            leverageIndex = 2.4;
                                            break;
                                        case 1:
                                            leverageIndex = 2.5;
                                            break;
                                        case 2:
                                            leverageIndex = 2.2;
                                            break;
                                        case 3:
                                            leverageIndex = 1.7;
                                            break;
                                        case 4:
                                            leverageIndex = 1.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 0:
                                            leverageIndex = 2.6;
                                            break;
                                        case 1:
                                            leverageIndex = 2.8;
                                            break;
                                        case 2:
                                            leverageIndex = 2.5;
                                            break;
                                        case 3:
                                            leverageIndex = 2.0;
                                            break;
                                        case 4:
                                            leverageIndex = 1.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.1;
                                            break;
                                        case -3:
                                            leverageIndex = 1.6;
                                            break;
                                        case -2:
                                            leverageIndex = 2.2;
                                            break;
                                        case -1:
                                            leverageIndex = 3.0;
                                            break;
                                        case 0:
                                            leverageIndex = 3.7;
                                            break;
                                        case 1:
                                            leverageIndex = 4.0;
                                            break;
                                        case 2:
                                            leverageIndex = 3.7;
                                            break;
                                        case 3:
                                            leverageIndex = 3.0;
                                            break;
                                        case 4:
                                            leverageIndex = 2.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    /// Bottom fifth
                    else
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 1.8;
                                            break;
                                        case -2:
                                            leverageIndex = 2.1;
                                            break;
                                        case -1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.2;
                                            break;
                                        case -3:
                                            leverageIndex = 1.6;
                                            break;
                                        case -2:
                                            leverageIndex = 1.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.2;
                                            break;
                                        case -3:
                                            leverageIndex = 1.5;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.1;
                                            break;
                                        case -3:
                                            leverageIndex = 2.5;
                                            break;
                                        case -2:
                                            leverageIndex = 2.7;
                                            break;
                                        case -1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.1;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.9;
                                            break;
                                        case -3:
                                            leverageIndex = 2.3;
                                            break;
                                        case -2:
                                            leverageIndex = 2.4;
                                            break;
                                        case -1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.8;
                                            break;
                                        case -3:
                                            leverageIndex = 2.1;
                                            break;
                                        case -2:
                                            leverageIndex = 2.1;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.8;
                                            break;
                                        case -3:
                                            leverageIndex = 3.1;
                                            break;
                                        case -2:
                                            leverageIndex = 3.1;
                                            break;
                                        case -1:
                                            leverageIndex = 2.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 0.9;
                                            break;
                                        case 1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.1;
                                            break;
                                        case -3:
                                            leverageIndex = 1.4;
                                            break;
                                        case -2:
                                            leverageIndex = 1.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.1;
                                            break;
                                        case -3:
                                            leverageIndex = 1.4;
                                            break;
                                        case -2:
                                            leverageIndex = 1.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.4;
                                            break;
                                        case -2:
                                            leverageIndex = 1.7;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.9;
                                            break;
                                        case -3:
                                            leverageIndex = 2.4;
                                            break;
                                        case -2:
                                            leverageIndex = 2.8;
                                            break;
                                        case -1:
                                            leverageIndex = 2.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.7;
                                            break;
                                        case -3:
                                            leverageIndex = 2.2;
                                            break;
                                        case -2:
                                            leverageIndex = 2.5;
                                            break;
                                        case -1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.6;
                                            break;
                                        case -3:
                                            leverageIndex = 2.0;
                                            break;
                                        case -2:
                                            leverageIndex = 2.2;
                                            break;
                                        case -1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.9;
                                            break;
                                        case -3:
                                            leverageIndex = 3.4;
                                            break;
                                        case -2:
                                            leverageIndex = 3.7;
                                            break;
                                        case -1:
                                            leverageIndex = 3.5;
                                            break;
                                        case 0:
                                            leverageIndex = 3.0;
                                            break;
                                        case 1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 2:
                                            leverageIndex = 1.5;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.6;
                                            break;
                                        case -1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 0:
                                            leverageIndex = 0.6;
                                            break;
                                        case 1:
                                            leverageIndex = 0.4;
                                            break;
                                        case 2:
                                            leverageIndex = 0.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.1;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.9;
                                            break;
                                        case -3:
                                            leverageIndex = 1.3;
                                            break;
                                        case -2:
                                            leverageIndex = 1.7;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 1.9;
                                            break;
                                        case -2:
                                            leverageIndex = 2.3;
                                            break;
                                        case -1:
                                            leverageIndex = 2.5;
                                            break;
                                        case 0:
                                            leverageIndex = 2.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.1;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.5;
                                            break;
                                        case -3:
                                            leverageIndex = 2.0;
                                            break;
                                        case -2:
                                            leverageIndex = 2.4;
                                            break;
                                        case -1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.7;
                                            break;
                                        case -3:
                                            leverageIndex = 2.3;
                                            break;
                                        case -2:
                                            leverageIndex = 2.8;
                                            break;
                                        case -1:
                                            leverageIndex = 3.0;
                                            break;
                                        case 0:
                                            leverageIndex = 2.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.7;
                                            break;
                                        case -3:
                                            leverageIndex = 3.4;
                                            break;
                                        case -2:
                                            leverageIndex = 4.0;
                                            break;
                                        case -1:
                                            leverageIndex = 4.2;
                                            break;
                                        case 0:
                                            leverageIndex = 3.6;
                                            break;
                                        case 1:
                                            leverageIndex = 2.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.8;
                                            break;
                                        case 3:
                                            leverageIndex = 1.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 6:
                    // top sixth
                    if (inning.Item1)
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 2.3;
                                            break;
                                        case 2:
                                            leverageIndex = 2.1;
                                            break;
                                        case 3:
                                            leverageIndex = 1.7;
                                            break;
                                        case 4:
                                            leverageIndex = 1.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 2:
                                            leverageIndex = 1.8;
                                            break;
                                        case 3:
                                            leverageIndex = 1.5;
                                            break;
                                        case 4:
                                            leverageIndex = 1.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.7;
                                            break;
                                        case 3:
                                            leverageIndex = 1.4;
                                            break;
                                        case 4:
                                            leverageIndex = 1.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.5;
                                            break;
                                        case 1:
                                            leverageIndex = 2.9;
                                            break;
                                        case 2:
                                            leverageIndex = 2.8;
                                            break;
                                        case 3:
                                            leverageIndex = 2.4;
                                            break;
                                        case 4:
                                            leverageIndex = 1.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 2.4;
                                            break;
                                        case 2:
                                            leverageIndex = 2.6;
                                            break;
                                        case 3:
                                            leverageIndex = 2.3;
                                            break;
                                        case 4:
                                            leverageIndex = 1.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 2:
                                            leverageIndex = 2.3;
                                            break;
                                        case 3:
                                            leverageIndex = 2.1;
                                            break;
                                        case 4:
                                            leverageIndex = 1.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.2;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.5;
                                            break;
                                        case 1:
                                            leverageIndex = 3.1;
                                            break;
                                        case 2:
                                            leverageIndex = 3.4;
                                            break;
                                        case 3:
                                            leverageIndex = 3.2;
                                            break;
                                        case 4:
                                            leverageIndex = 2.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.5;
                                            break;
                                        case -1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 0:
                                            leverageIndex = 1.0;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 2:
                                            leverageIndex = 1.7;
                                            break;
                                        case 3:
                                            leverageIndex = 1.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 2:
                                            leverageIndex = 1.7;
                                            break;
                                        case 3:
                                            leverageIndex = 1.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 2:
                                            leverageIndex = 1.6;
                                            break;
                                        case 3:
                                            leverageIndex = 1.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 0:
                                            leverageIndex = 2.8;
                                            break;
                                        case 1:
                                            leverageIndex = 3.1;
                                            break;
                                        case 2:
                                            leverageIndex = 2.8;
                                            break;
                                        case 3:
                                            leverageIndex = 2.2;
                                            break;
                                        case 4:
                                            leverageIndex = 1.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 2.6;
                                            break;
                                        case 1:
                                            leverageIndex = 2.8;
                                            break;
                                        case 2:
                                            leverageIndex = 2.5;
                                            break;
                                        case 3:
                                            leverageIndex = 2.1;
                                            break;
                                        case 4:
                                            leverageIndex = 1.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 2.3;
                                            break;
                                        case 2:
                                            leverageIndex = 2.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.9;
                                            break;
                                        case 4:
                                            leverageIndex = 1.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.8;
                                            break;
                                        case -1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 0:
                                            leverageIndex = 3.4;
                                            break;
                                        case 1:
                                            leverageIndex = 3.9;
                                            break;
                                        case 2:
                                            leverageIndex = 3.9;
                                            break;
                                        case 3:
                                            leverageIndex = 3.3;
                                            break;
                                        case 4:
                                            leverageIndex = 2.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.4;
                                            break;
                                        case -1:
                                            leverageIndex = 0.5;
                                            break;
                                        case 0:
                                            leverageIndex = 0.7;
                                            break;
                                        case 1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.1;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 2:
                                            leverageIndex = 1.4;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.2;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 2:
                                            leverageIndex = 1.6;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 0:
                                            leverageIndex = 2.5;
                                            break;
                                        case 1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 2:
                                            leverageIndex = 2.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.7;
                                            break;
                                        case 4:
                                            leverageIndex = 1.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 2.7;
                                            break;
                                        case 1:
                                            leverageIndex = 2.8;
                                            break;
                                        case 2:
                                            leverageIndex = 2.4;
                                            break;
                                        case 3:
                                            leverageIndex = 1.8;
                                            break;
                                        case 4:
                                            leverageIndex = 1.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 0:
                                            leverageIndex = 2.9;
                                            break;
                                        case 1:
                                            leverageIndex = 3.2;
                                            break;
                                        case 2:
                                            leverageIndex = 2.7;
                                            break;
                                        case 3:
                                            leverageIndex = 2.0;
                                            break;
                                        case 4:
                                            leverageIndex = 1.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.9;
                                            break;
                                        case -3:
                                            leverageIndex = 1.4;
                                            break;
                                        case -2:
                                            leverageIndex = 2.2;
                                            break;
                                        case -1:
                                            leverageIndex = 3.1;
                                            break;
                                        case 0:
                                            leverageIndex = 4.1;
                                            break;
                                        case 1:
                                            leverageIndex = 4.5;
                                            break;
                                        case 2:
                                            leverageIndex = 4.1;
                                            break;
                                        case 3:
                                            leverageIndex = 3.2;
                                            break;
                                        case 4:
                                            leverageIndex = 2.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    /// Bottom six
                    else
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 1.9;
                                            break;
                                        case -2:
                                            leverageIndex = 2.3;
                                            break;
                                        case -1:
                                            leverageIndex = 2.4;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.3;
                                            break;
                                        case -3:
                                            leverageIndex = 1.7;
                                            break;
                                        case -2:
                                            leverageIndex = 2.0;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.2;
                                            break;
                                        case -3:
                                            leverageIndex = 1.6;
                                            break;
                                        case -2:
                                            leverageIndex = 1.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.2;
                                            break;
                                        case -3:
                                            leverageIndex = 2.7;
                                            break;
                                        case -2:
                                            leverageIndex = 3.1;
                                            break;
                                        case -1:
                                            leverageIndex = 3.0;
                                            break;
                                        case 0:
                                            leverageIndex = 2.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.0;
                                            break;
                                        case -3:
                                            leverageIndex = 2.5;
                                            break;
                                        case -2:
                                            leverageIndex = 2.7;
                                            break;
                                        case -1:
                                            leverageIndex = 2.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.9;
                                            break;
                                        case -3:
                                            leverageIndex = 2.3;
                                            break;
                                        case -2:
                                            leverageIndex = 2.4;
                                            break;
                                        case -1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 3.0;
                                            break;
                                        case -3:
                                            leverageIndex = 3.5;
                                            break;
                                        case -2:
                                            leverageIndex = 3.6;
                                            break;
                                        case -1:
                                            leverageIndex = 3.1;
                                            break;
                                        case 0:
                                            leverageIndex = 2.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.0;
                                            break;
                                        case 1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 2:
                                            leverageIndex = 0.4;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.5;
                                            break;
                                        case -2:
                                            leverageIndex = 1.9;
                                            break;
                                        case -1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.1;
                                            break;
                                        case -3:
                                            leverageIndex = 1.5;
                                            break;
                                        case -2:
                                            leverageIndex = 1.9;
                                            break;
                                        case -1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.4;
                                            break;
                                        case -2:
                                            leverageIndex = 1.9;
                                            break;
                                        case -1:
                                            leverageIndex = 2.3;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.9;
                                            break;
                                        case -3:
                                            leverageIndex = 2.6;
                                            break;
                                        case -2:
                                            leverageIndex = 3.1;
                                            break;
                                        case -1:
                                            leverageIndex = 3.3;
                                            break;
                                        case 0:
                                            leverageIndex = 2.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 2:
                                            leverageIndex = 1.1;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.8;
                                            break;
                                        case -3:
                                            leverageIndex = 2.4;
                                            break;
                                        case -2:
                                            leverageIndex = 2.8;
                                            break;
                                        case -1:
                                            leverageIndex = 3.0;
                                            break;
                                        case 0:
                                            leverageIndex = 2.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.1;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.7;
                                            break;
                                        case -3:
                                            leverageIndex = 2.2;
                                            break;
                                        case -2:
                                            leverageIndex = 2.5;
                                            break;
                                        case -1:
                                            leverageIndex = 2.5;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 3.0;
                                            break;
                                        case -3:
                                            leverageIndex = 3.8;
                                            break;
                                        case -2:
                                            leverageIndex = 4.2;
                                            break;
                                        case -1:
                                            leverageIndex = 4.0;
                                            break;
                                        case 0:
                                            leverageIndex = 3.3;
                                            break;
                                        case 1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 2:
                                            leverageIndex = 1.4;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.6;
                                            break;
                                        case -1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 0:
                                            leverageIndex = 0.7;
                                            break;
                                        case 1:
                                            leverageIndex = 0.5;
                                            break;
                                        case 2:
                                            leverageIndex = 0.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.2;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.3;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.9;
                                            break;
                                        case -3:
                                            leverageIndex = 1.3;
                                            break;
                                        case -2:
                                            leverageIndex = 1.9;
                                            break;
                                        case -1:
                                            leverageIndex = 2.4;
                                            break;
                                        case 0:
                                            leverageIndex = 2.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 2.0;
                                            break;
                                        case -2:
                                            leverageIndex = 2.6;
                                            break;
                                        case -1:
                                            leverageIndex = 2.9;
                                            break;
                                        case 0:
                                            leverageIndex = 2.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 2.1;
                                            break;
                                        case -2:
                                            leverageIndex = 2.7;
                                            break;
                                        case -1:
                                            leverageIndex = 3.1;
                                            break;
                                        case 0:
                                            leverageIndex = 2.7;
                                            break;
                                        case 1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 2:
                                            leverageIndex = 1.1;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.6;
                                            break;
                                        case -3:
                                            leverageIndex = 2.4;
                                            break;
                                        case -2:
                                            leverageIndex = 3.1;
                                            break;
                                        case -1:
                                            leverageIndex = 3.5;
                                            break;
                                        case 0:
                                            leverageIndex = 2.9;
                                            break;
                                        case 1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.7;
                                            break;
                                        case -3:
                                            leverageIndex = 3.7;
                                            break;
                                        case -2:
                                            leverageIndex = 4.5;
                                            break;
                                        case -1:
                                            leverageIndex = 4.9;
                                            break;
                                        case 0:
                                            leverageIndex = 4.0;
                                            break;
                                        case 1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.7;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 7:
                    // top seven
                    if (inning.Item1)
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.4;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.4;
                                            break;
                                        case 1:
                                            leverageIndex = 2.7;
                                            break;
                                        case 2:
                                            leverageIndex = 2.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.7;
                                            break;
                                        case 4:
                                            leverageIndex = 1.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 2.3;
                                            break;
                                        case 2:
                                            leverageIndex = 2.0;
                                            break;
                                        case 3:
                                            leverageIndex = 1.5;
                                            break;
                                        case 4:
                                            leverageIndex = 1.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 2:
                                            leverageIndex = 1.9;
                                            break;
                                        case 3:
                                            leverageIndex = 1.5;
                                            break;
                                        case 4:
                                            leverageIndex = 1.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.7;
                                            break;
                                        case 1:
                                            leverageIndex = 3.4;
                                            break;
                                        case 2:
                                            leverageIndex = 3.2;
                                            break;
                                        case 3:
                                            leverageIndex = 2.6;
                                            break;
                                        case 4:
                                            leverageIndex = 1.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 2.8;
                                            break;
                                        case 2:
                                            leverageIndex = 3.0;
                                            break;
                                        case 3:
                                            leverageIndex = 2.5;
                                            break;
                                        case 4:
                                            leverageIndex = 1.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 2.5;
                                            break;
                                        case 2:
                                            leverageIndex = 2.6;
                                            break;
                                        case 3:
                                            leverageIndex = 2.3;
                                            break;
                                        case 4:
                                            leverageIndex = 1.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 2.6;
                                            break;
                                        case 1:
                                            leverageIndex = 3.5;
                                            break;
                                        case 2:
                                            leverageIndex = 3.9;
                                            break;
                                        case 3:
                                            leverageIndex = 3.6;
                                            break;
                                        case 4:
                                            leverageIndex = 2.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.5;
                                            break;
                                        case -1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 2.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.8;
                                            break;
                                        case 3:
                                            leverageIndex = 1.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 2.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.8;
                                            break;
                                        case 3:
                                            leverageIndex = 1.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.4;
                                            break;
                                        case 1:
                                            leverageIndex = 2.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.8;
                                            break;
                                        case 3:
                                            leverageIndex = 1.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 0:
                                            leverageIndex = 3.2;
                                            break;
                                        case 1:
                                            leverageIndex = 3.6;
                                            break;
                                        case 2:
                                            leverageIndex = 3.1;
                                            break;
                                        case 3:
                                            leverageIndex = 2.3;
                                            break;
                                        case 4:
                                            leverageIndex = 1.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 3.1;
                                            break;
                                        case 1:
                                            leverageIndex = 3.3;
                                            break;
                                        case 2:
                                            leverageIndex = 2.9;
                                            break;
                                        case 3:
                                            leverageIndex = 2.2;
                                            break;
                                        case 4:
                                            leverageIndex = 1.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.5;
                                            break;
                                        case 1:
                                            leverageIndex = 2.8;
                                            break;
                                        case 2:
                                            leverageIndex = 2.7;
                                            break;
                                        case 3:
                                            leverageIndex = 2.1;
                                            break;
                                        case 4:
                                            leverageIndex = 1.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 0:
                                            leverageIndex = 3.9;
                                            break;
                                        case 1:
                                            leverageIndex = 4.5;
                                            break;
                                        case 2:
                                            leverageIndex = 4.4;
                                            break;
                                        case 3:
                                            leverageIndex = 3.6;
                                            break;
                                        case 4:
                                            leverageIndex = 2.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.2;
                                            break;
                                        case -2:
                                            leverageIndex = 0.4;
                                            break;
                                        case -1:
                                            leverageIndex = 0.5;
                                            break;
                                        case 0:
                                            leverageIndex = 0.8;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 2:
                                            leverageIndex = 1.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 0:
                                            leverageIndex = 2.5;
                                            break;
                                        case 1:
                                            leverageIndex = 2.5;
                                            break;
                                        case 2:
                                            leverageIndex = 1.7;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.2;
                                            break;
                                        case -1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 0:
                                            leverageIndex = 2.9;
                                            break;
                                        case 1:
                                            leverageIndex = 3.2;
                                            break;
                                        case 2:
                                            leverageIndex = 2.5;
                                            break;
                                        case 3:
                                            leverageIndex = 1.7;
                                            break;
                                        case 4:
                                            leverageIndex = 1.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 0:
                                            leverageIndex = 3.1;
                                            break;
                                        case 1:
                                            leverageIndex = 3.4;
                                            break;
                                        case 2:
                                            leverageIndex = 2.6;
                                            break;
                                        case 3:
                                            leverageIndex = 1.7;
                                            break;
                                        case 4:
                                            leverageIndex = 1.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.5;
                                            break;
                                        case -1:
                                            leverageIndex = 2.3;
                                            break;
                                        case 0:
                                            leverageIndex = 3.4;
                                            break;
                                        case 1:
                                            leverageIndex = 3.9;
                                            break;
                                        case 2:
                                            leverageIndex = 3.1;
                                            break;
                                        case 3:
                                            leverageIndex = 2.0;
                                            break;
                                        case 4:
                                            leverageIndex = 1.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 2.0;
                                            break;
                                        case -1:
                                            leverageIndex = 3.1;
                                            break;
                                        case 0:
                                            leverageIndex = 4.7;
                                            break;
                                        case 1:
                                            leverageIndex = 5.4;
                                            break;
                                        case 2:
                                            leverageIndex = 4.5;
                                            break;
                                        case 3:
                                            leverageIndex = 3.3;
                                            break;
                                        case 4:
                                            leverageIndex = 2.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    /// Bottom seven
                    else
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.2;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.4;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 2.0;
                                            break;
                                        case -2:
                                            leverageIndex = 2.6;
                                            break;
                                        case -1:
                                            leverageIndex = 3.0;
                                            break;
                                        case 0:
                                            leverageIndex = 2.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 0.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.3;
                                            break;
                                        case -3:
                                            leverageIndex = 1.8;
                                            break;
                                        case -2:
                                            leverageIndex = 2.3;
                                            break;
                                        case -1:
                                            leverageIndex = 2.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.3;
                                            break;
                                        case -3:
                                            leverageIndex = 1.8;
                                            break;
                                        case -2:
                                            leverageIndex = 2.2;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.4;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.2;
                                            break;
                                        case -3:
                                            leverageIndex = 3.0;
                                            break;
                                        case -2:
                                            leverageIndex = 3.6;
                                            break;
                                        case -1:
                                            leverageIndex = 3.5;
                                            break;
                                        case 0:
                                            leverageIndex = 2.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.1;
                                            break;
                                        case -3:
                                            leverageIndex = 2.8;
                                            break;
                                        case -2:
                                            leverageIndex = 3.3;
                                            break;
                                        case -1:
                                            leverageIndex = 2.8;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.0;
                                            break;
                                        case -3:
                                            leverageIndex = 2.6;
                                            break;
                                        case -2:
                                            leverageIndex = 2.9;
                                            break;
                                        case -1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 3.3;
                                            break;
                                        case -3:
                                            leverageIndex = 4.0;
                                            break;
                                        case -2:
                                            leverageIndex = 4.1;
                                            break;
                                        case -1:
                                            leverageIndex = 3.5;
                                            break;
                                        case 0:
                                            leverageIndex = 2.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 0.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.2;
                                            break;
                                        case 1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 2:
                                            leverageIndex = 0.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.5;
                                            break;
                                        case -2:
                                            leverageIndex = 2.1;
                                            break;
                                        case -1:
                                            leverageIndex = 2.5;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.5;
                                            break;
                                        case -2:
                                            leverageIndex = 2.1;
                                            break;
                                        case -1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.5;
                                            break;
                                        case -2:
                                            leverageIndex = 2.1;
                                            break;
                                        case -1:
                                            leverageIndex = 2.9;
                                            break;
                                        case 0:
                                            leverageIndex = 2.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 0.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.9;
                                            break;
                                        case -3:
                                            leverageIndex = 2.7;
                                            break;
                                        case -2:
                                            leverageIndex = 3.6;
                                            break;
                                        case -1:
                                            leverageIndex = 4.0;
                                            break;
                                        case 0:
                                            leverageIndex = 3.0;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.8;
                                            break;
                                        case -3:
                                            leverageIndex = 2.6;
                                            break;
                                        case -2:
                                            leverageIndex = 3.2;
                                            break;
                                        case -1:
                                            leverageIndex = 3.7;
                                            break;
                                        case 0:
                                            leverageIndex = 3.1;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.7;
                                            break;
                                        case -3:
                                            leverageIndex = 2.4;
                                            break;
                                        case -2:
                                            leverageIndex = 3.0;
                                            break;
                                        case -1:
                                            leverageIndex = 3.0;
                                            break;
                                        case 0:
                                            leverageIndex = 2.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 0.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 3.1;
                                            break;
                                        case -3:
                                            leverageIndex = 4.2;
                                            break;
                                        case -2:
                                            leverageIndex = 4.9;
                                            break;
                                        case -1:
                                            leverageIndex = 4.8;
                                            break;
                                        case 0:
                                            leverageIndex = 3.7;
                                            break;
                                        case 1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 2:
                                            leverageIndex = 1.1;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 0.8;
                                            break;
                                        case 1:
                                            leverageIndex = 0.4;
                                            break;
                                        case 2:
                                            leverageIndex = 0.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.4;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.8;
                                            break;
                                        case -1:
                                            leverageIndex = 2.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.3;
                                            break;
                                        case -2:
                                            leverageIndex = 2.0;
                                            break;
                                        case -1:
                                            leverageIndex = 3.0;
                                            break;
                                        case 0:
                                            leverageIndex = 2.6;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.2;
                                            break;
                                        case -3:
                                            leverageIndex = 2.0;
                                            break;
                                        case -2:
                                            leverageIndex = 2.9;
                                            break;
                                        case -1:
                                            leverageIndex = 3.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.9;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.3;
                                            break;
                                        case -3:
                                            leverageIndex = 2.1;
                                            break;
                                        case -2:
                                            leverageIndex = 3.0;
                                            break;
                                        case -1:
                                            leverageIndex = 3.8;
                                            break;
                                        case 0:
                                            leverageIndex = 3.1;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 0.9;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.5;
                                            break;
                                        case -3:
                                            leverageIndex = 2.4;
                                            break;
                                        case -2:
                                            leverageIndex = 3.6;
                                            break;
                                        case -1:
                                            leverageIndex = 4.3;
                                            break;
                                        case 0:
                                            leverageIndex = 3.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.6;
                                            break;
                                        case -3:
                                            leverageIndex = 3.9;
                                            break;
                                        case -2:
                                            leverageIndex = 5.2;
                                            break;
                                        case -1:
                                            leverageIndex = 5.9;
                                            break;
                                        case 0:
                                            leverageIndex = 4.5;
                                            break;
                                        case 1:
                                            leverageIndex = 2.4;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 8:
                    // top eight
                    if (inning.Item1)
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 2:
                                            leverageIndex = 1.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 2.8;
                                            break;
                                        case 1:
                                            leverageIndex = 3.4;
                                            break;
                                        case 2:
                                            leverageIndex = 2.6;
                                            break;
                                        case 3:
                                            leverageIndex = 1.7;
                                            break;
                                        case 4:
                                            leverageIndex = 1.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 0:
                                            leverageIndex = 2.2;
                                            break;
                                        case 1:
                                            leverageIndex = 2.8;
                                            break;
                                        case 2:
                                            leverageIndex = 2.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.6;
                                            break;
                                        case 4:
                                            leverageIndex = 1.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.5;
                                            break;
                                        case -1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 2.4;
                                            break;
                                        case 2:
                                            leverageIndex = 2.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.6;
                                            break;
                                        case 4:
                                            leverageIndex = 1.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 3.1;
                                            break;
                                        case 1:
                                            leverageIndex = 4.1;
                                            break;
                                        case 2:
                                            leverageIndex = 3.7;
                                            break;
                                        case 3:
                                            leverageIndex = 2.8;
                                            break;
                                        case 4:
                                            leverageIndex = 1.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 3.3;
                                            break;
                                        case 2:
                                            leverageIndex = 3.6;
                                            break;
                                        case 3:
                                            leverageIndex = 2.8;
                                            break;
                                        case 4:
                                            leverageIndex = 1.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        case 1:
                                            leverageIndex = 3.1;
                                            break;
                                        case 2:
                                            leverageIndex = 3.2;
                                            break;
                                        case 3:
                                            leverageIndex = 2.6;
                                            break;
                                        case 4:
                                            leverageIndex = 1.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 2.8;
                                            break;
                                        case 1:
                                            leverageIndex = 4.1;
                                            break;
                                        case 2:
                                            leverageIndex = 4.6;
                                            break;
                                        case 3:
                                            leverageIndex = 4.0;
                                            break;
                                        case 4:
                                            leverageIndex = 3.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.2;
                                            break;
                                        case -2:
                                            leverageIndex = 0.4;
                                            break;
                                        case -1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 2.4;
                                            break;
                                        case 1:
                                            leverageIndex = 2.9;
                                            break;
                                        case 2:
                                            leverageIndex = 2.0;
                                            break;
                                        case 3:
                                            leverageIndex = 1.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 2.5;
                                            break;
                                        case 1:
                                            leverageIndex = 2.9;
                                            break;
                                        case 2:
                                            leverageIndex = 2.0;
                                            break;
                                        case 3:
                                            leverageIndex = 1.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 3.1;
                                            break;
                                        case 1:
                                            leverageIndex = 3.2;
                                            break;
                                        case 2:
                                            leverageIndex = 2.0;
                                            break;
                                        case 3:
                                            leverageIndex = 1.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 3.7;
                                            break;
                                        case 1:
                                            leverageIndex = 4.5;
                                            break;
                                        case 2:
                                            leverageIndex = 3.5;
                                            break;
                                        case 3:
                                            leverageIndex = 2.4;
                                            break;
                                        case 4:
                                            leverageIndex = 1.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 3.8;
                                            break;
                                        case 1:
                                            leverageIndex = 4.2;
                                            break;
                                        case 2:
                                            leverageIndex = 3.3;
                                            break;
                                        case 3:
                                            leverageIndex = 2.3;
                                            break;
                                        case 4:
                                            leverageIndex = 1.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 3.0;
                                            break;
                                        case 1:
                                            leverageIndex = 3.4;
                                            break;
                                        case 2:
                                            leverageIndex = 3.2;
                                            break;
                                        case 3:
                                            leverageIndex = 2.2;
                                            break;
                                        case 4:
                                            leverageIndex = 1.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.4;
                                            break;
                                        case -1:
                                            leverageIndex = 2.4;
                                            break;
                                        case 0:
                                            leverageIndex = 4.6;
                                            break;
                                        case 1:
                                            leverageIndex = 5.6;
                                            break;
                                        case 2:
                                            leverageIndex = 5.2;
                                            break;
                                        case 3:
                                            leverageIndex = 3.9;
                                            break;
                                        case 4:
                                            leverageIndex = 2.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.2;
                                            break;
                                        case -2:
                                            leverageIndex = 0.3;
                                            break;
                                        case -1:
                                            leverageIndex = 0.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.0;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.7;
                                            break;
                                        case 4:
                                            leverageIndex = 0.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 2.7;
                                            break;
                                        case 1:
                                            leverageIndex = 2.8;
                                            break;
                                        case 2:
                                            leverageIndex = 1.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 0.9;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 3.2;
                                            break;
                                        case 1:
                                            leverageIndex = 3.3;
                                            break;
                                        case 2:
                                            leverageIndex = 1.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.9;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 3.5;
                                            break;
                                        case 1:
                                            leverageIndex = 4.0;
                                            break;
                                        case 2:
                                            leverageIndex = 2.7;
                                            break;
                                        case 3:
                                            leverageIndex = 1.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 1.1;
                                            break;
                                        case -1:
                                            leverageIndex = 2.0;
                                            break;
                                        case 0:
                                            leverageIndex = 3.8;
                                            break;
                                        case 1:
                                            leverageIndex = 4.3;
                                            break;
                                        case 2:
                                            leverageIndex = 2.8;
                                            break;
                                        case 3:
                                            leverageIndex = 1.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.3;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.2;
                                            break;
                                        case -1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 0:
                                            leverageIndex = 4.0;
                                            break;
                                        case 1:
                                            leverageIndex = 4.9;
                                            break;
                                        case 2:
                                            leverageIndex = 3.5;
                                            break;
                                        case 3:
                                            leverageIndex = 1.9;
                                            break;
                                        case 4:
                                            leverageIndex = 1.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 0.9;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 2.9;
                                            break;
                                        case 0:
                                            leverageIndex = 5.6;
                                            break;
                                        case 1:
                                            leverageIndex = 6.8;
                                            break;
                                        case 2:
                                            leverageIndex = 5.1;
                                            break;
                                        case 3:
                                            leverageIndex = 3.3;
                                            break;
                                        case 4:
                                            leverageIndex = 1.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    /// Bottom eight
                    else
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 1.8;
                                            break;
                                        case -1:
                                            leverageIndex = 2.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 2:
                                            leverageIndex = 0.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.3;
                                            break;
                                        case -3:
                                            leverageIndex = 2.1;
                                            break;
                                        case -2:
                                            leverageIndex = 3.1;
                                            break;
                                        case -1:
                                            leverageIndex = 3.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.6;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.4;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.2;
                                            break;
                                        case -3:
                                            leverageIndex = 1.9;
                                            break;
                                        case -2:
                                            leverageIndex = 2.7;
                                            break;
                                        case -1:
                                            leverageIndex = 3.1;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        case 1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 2:
                                            leverageIndex = 0.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.2;
                                            break;
                                        case -3:
                                            leverageIndex = 1.9;
                                            break;
                                        case -2:
                                            leverageIndex = 2.7;
                                            break;
                                        case -1:
                                            leverageIndex = 2.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.7;
                                            break;
                                        case 1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 2:
                                            leverageIndex = 0.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.2;
                                            break;
                                        case -3:
                                            leverageIndex = 3.3;
                                            break;
                                        case -2:
                                            leverageIndex = 4.2;
                                            break;
                                        case -1:
                                            leverageIndex = 4.4;
                                            break;
                                        case 0:
                                            leverageIndex = 2.8;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.4;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.2;
                                            break;
                                        case -3:
                                            leverageIndex = 3.2;
                                            break;
                                        case -2:
                                            leverageIndex = 4.1;
                                            break;
                                        case -1:
                                            leverageIndex = 3.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 2:
                                            leverageIndex = 0.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.1;
                                            break;
                                        case -3:
                                            leverageIndex = 3.0;
                                            break;
                                        case -2:
                                            leverageIndex = 3.6;
                                            break;
                                        case -1:
                                            leverageIndex = 3.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 2:
                                            leverageIndex = 0.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 3.5;
                                            break;
                                        case -3:
                                            leverageIndex = 4.6;
                                            break;
                                        case -2:
                                            leverageIndex = 5.0;
                                            break;
                                        case -1:
                                            leverageIndex = 4.2;
                                            break;
                                        case 0:
                                            leverageIndex = 2.2;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.4;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.2;
                                            break;
                                        case -1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 0.5;
                                            break;
                                        case 2:
                                            leverageIndex = 0.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.5;
                                            break;
                                        case -2:
                                            leverageIndex = 2.4;
                                            break;
                                        case -1:
                                            leverageIndex = 3.4;
                                            break;
                                        case 0:
                                            leverageIndex = 2.4;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.4;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.8;
                                            break;
                                        case -3:
                                            leverageIndex = 1.5;
                                            break;
                                        case -2:
                                            leverageIndex = 2.4;
                                            break;
                                        case -1:
                                            leverageIndex = 3.4;
                                            break;
                                        case 0:
                                            leverageIndex = 2.5;
                                            break;
                                        case 1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 2:
                                            leverageIndex = 0.4;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.9;
                                            break;
                                        case -3:
                                            leverageIndex = 1.5;
                                            break;
                                        case -2:
                                            leverageIndex = 2.4;
                                            break;
                                        case -1:
                                            leverageIndex = 3.9;
                                            break;
                                        case 0:
                                            leverageIndex = 3.2;
                                            break;
                                        case 1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.7;
                                            break;
                                        case -3:
                                            leverageIndex = 2.9;
                                            break;
                                        case -2:
                                            leverageIndex = 4.1;
                                            break;
                                        case -1:
                                            leverageIndex = 5.1;
                                            break;
                                        case 0:
                                            leverageIndex = 3.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.7;
                                            break;
                                        case -3:
                                            leverageIndex = 2.7;
                                            break;
                                        case -2:
                                            leverageIndex = 3.9;
                                            break;
                                        case -1:
                                            leverageIndex = 4.9;
                                            break;
                                        case 0:
                                            leverageIndex = 3.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.6;
                                            break;
                                        case -3:
                                            leverageIndex = 2.6;
                                            break;
                                        case -2:
                                            leverageIndex = 3.7;
                                            break;
                                        case -1:
                                            leverageIndex = 4.0;
                                            break;
                                        case 0:
                                            leverageIndex = 3.0;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.4;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 3.1;
                                            break;
                                        case -3:
                                            leverageIndex = 4.6;
                                            break;
                                        case -2:
                                            leverageIndex = 5.9;
                                            break;
                                        case -1:
                                            leverageIndex = 6.2;
                                            break;
                                        case 0:
                                            leverageIndex = 4.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 2:
                                            leverageIndex = 0.7;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 1.1;
                                            break;
                                        case 1:
                                            leverageIndex = 0.3;
                                            break;
                                        case 2:
                                            leverageIndex = 0.2;
                                            break;
                                        case 3:
                                            leverageIndex = 0.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.4;
                                            break;
                                        case -3:
                                            leverageIndex = 0.8;
                                            break;
                                        case -2:
                                            leverageIndex = 1.6;
                                            break;
                                        case -1:
                                            leverageIndex = 2.5;
                                            break;
                                        case 0:
                                            leverageIndex = 1.8;
                                            break;
                                        case 1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 2:
                                            leverageIndex = 0.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 1.9;
                                            break;
                                        case -1:
                                            leverageIndex = 3.5;
                                            break;
                                        case 0:
                                            leverageIndex = 2.8;
                                            break;
                                        case 1:
                                            leverageIndex = 0.9;
                                            break;
                                        case 2:
                                            leverageIndex = 0.4;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 1.1;
                                            break;
                                        case -2:
                                            leverageIndex = 2.1;
                                            break;
                                        case -1:
                                            leverageIndex = 4.1;
                                            break;
                                        case 0:
                                            leverageIndex = 3.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 2.0;
                                            break;
                                        case -2:
                                            leverageIndex = 3.3;
                                            break;
                                        case -1:
                                            leverageIndex = 4.7;
                                            break;
                                        case 0:
                                            leverageIndex = 3.5;
                                            break;
                                        case 1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 2.0;
                                            break;
                                        case -2:
                                            leverageIndex = 3.4;
                                            break;
                                        case -1:
                                            leverageIndex = 5.1;
                                            break;
                                        case 0:
                                            leverageIndex = 3.8;
                                            break;
                                        case 1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.2;
                                            break;
                                        case -3:
                                            leverageIndex = 2.3;
                                            break;
                                        case -2:
                                            leverageIndex = 4.2;
                                            break;
                                        case -1:
                                            leverageIndex = 5.8;
                                            break;
                                        case 0:
                                            leverageIndex = 3.9;
                                            break;
                                        case 1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 2:
                                            leverageIndex = 0.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.3;
                                            break;
                                        case -3:
                                            leverageIndex = 4.0;
                                            break;
                                        case -2:
                                            leverageIndex = 6.1;
                                            break;
                                        case -1:
                                            leverageIndex = 7.7;
                                            break;
                                        case 0:
                                            leverageIndex = 5.3;
                                            break;
                                        case 1:
                                            leverageIndex = 1.7;
                                            break;
                                        case 2:
                                            leverageIndex = 0.8;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    // top nine and later
                    if (inning.Item1)
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.2;
                                            break;
                                        case -2:
                                            leverageIndex = 0.3;
                                            break;
                                        case -1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 0:
                                            leverageIndex = 2.4;
                                            break;
                                        case 1:
                                            leverageIndex = 2.9;
                                            break;
                                        case 2:
                                            leverageIndex = 1.6;
                                            break;
                                        case 3:
                                            leverageIndex = 0.8;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.2;
                                            break;
                                        case -2:
                                            leverageIndex = 0.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 0:
                                            leverageIndex = 3.4;
                                            break;
                                        case 1:
                                            leverageIndex = 4.6;
                                            break;
                                        case 2:
                                            leverageIndex = 2.9;
                                            break;
                                        case 3:
                                            leverageIndex = 1.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.2;
                                            break;
                                        case -2:
                                            leverageIndex = 0.4;
                                            break;
                                        case -1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.6;
                                            break;
                                        case 1:
                                            leverageIndex = 3.7;
                                            break;
                                        case 2:
                                            leverageIndex = 2.7;
                                            break;
                                        case 3:
                                            leverageIndex = 1.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.2;
                                            break;
                                        case -2:
                                            leverageIndex = 0.3;
                                            break;
                                        case -1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 0:
                                            leverageIndex = 2.3;
                                            break;
                                        case 1:
                                            leverageIndex = 3.1;
                                            break;
                                        case 2:
                                            leverageIndex = 2.9;
                                            break;
                                        case 3:
                                            leverageIndex = 1.6;
                                            break;
                                        case 4:
                                            leverageIndex = 0.8;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 3.6;
                                            break;
                                        case 1:
                                            leverageIndex = 5.3;
                                            break;
                                        case 2:
                                            leverageIndex = 4.4;
                                            break;
                                        case 3:
                                            leverageIndex = 2.9;
                                            break;
                                        case 4:
                                            leverageIndex = 1.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.2;
                                            break;
                                        case -2:
                                            leverageIndex = 0.4;
                                            break;
                                        case -1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.3;
                                            break;
                                        case 1:
                                            leverageIndex = 4.2;
                                            break;
                                        case 2:
                                            leverageIndex = 4.6;
                                            break;
                                        case 3:
                                            leverageIndex = 3.0;
                                            break;
                                        case 4:
                                            leverageIndex = 1.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.2;
                                            break;
                                        case -2:
                                            leverageIndex = 0.4;
                                            break;
                                        case -1:
                                            leverageIndex = 0.8;
                                            break;
                                        case 0:
                                            leverageIndex = 2.4;
                                            break;
                                        case 1:
                                            leverageIndex = 4.0;
                                            break;
                                        case 2:
                                            leverageIndex = 4.0;
                                            break;
                                        case 3:
                                            leverageIndex = 2.9;
                                            break;
                                        case 4:
                                            leverageIndex = 1.6;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.2;
                                            break;
                                        case -2:
                                            leverageIndex = 0.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 2.9;
                                            break;
                                        case 1:
                                            leverageIndex = 5.2;
                                            break;
                                        case 2:
                                            leverageIndex = 5.7;
                                            break;
                                        case 3:
                                            leverageIndex = 4.6;
                                            break;
                                        case 4:
                                            leverageIndex = 3.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.1;
                                            break;
                                        case -2:
                                            leverageIndex = 0.3;
                                            break;
                                        case -1:
                                            leverageIndex = 0.6;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        case 1:
                                            leverageIndex = 2.2;
                                            break;
                                        case 2:
                                            leverageIndex = 1.0;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.2;
                                            break;
                                        case -2:
                                            leverageIndex = 0.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 3.1;
                                            break;
                                        case 1:
                                            leverageIndex = 3.9;
                                            break;
                                        case 2:
                                            leverageIndex = 2.2;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.2;
                                            break;
                                        case -2:
                                            leverageIndex = 0.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.0;
                                            break;
                                        case 0:
                                            leverageIndex = 3.3;
                                            break;
                                        case 1:
                                            leverageIndex = 4.0;
                                            break;
                                        case 2:
                                            leverageIndex = 2.2;
                                            break;
                                        case 3:
                                            leverageIndex = 1.0;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 4.3;
                                            break;
                                        case 1:
                                            leverageIndex = 4.4;
                                            break;
                                        case 2:
                                            leverageIndex = 2.3;
                                            break;
                                        case 3:
                                            leverageIndex = 1.1;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 4.6;
                                            break;
                                        case 1:
                                            leverageIndex = 6.1;
                                            break;
                                        case 2:
                                            leverageIndex = 4.0;
                                            break;
                                        case 3:
                                            leverageIndex = 2.3;
                                            break;
                                        case 4:
                                            leverageIndex = 1.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 5.0;
                                            break;
                                        case 1:
                                            leverageIndex = 5.7;
                                            break;
                                        case 2:
                                            leverageIndex = 4.0;
                                            break;
                                        case 3:
                                            leverageIndex = 2.3;
                                            break;
                                        case 4:
                                            leverageIndex = 1.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.2;
                                            break;
                                        case 0:
                                            leverageIndex = 3.9;
                                            break;
                                        case 1:
                                            leverageIndex = 4.6;
                                            break;
                                        case 2:
                                            leverageIndex = 3.9;
                                            break;
                                        case 3:
                                            leverageIndex = 2.3;
                                            break;
                                        case 4:
                                            leverageIndex = 1.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.4;
                                            break;
                                        case -2:
                                            leverageIndex = 0.8;
                                            break;
                                        case -1:
                                            leverageIndex = 1.8;
                                            break;
                                        case 0:
                                            leverageIndex = 5.7;
                                            break;
                                        case 1:
                                            leverageIndex = 7.3;
                                            break;
                                        case 2:
                                            leverageIndex = 6.2;
                                            break;
                                        case 3:
                                            leverageIndex = 4.2;
                                            break;
                                        case 4:
                                            leverageIndex = 2.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.0;
                                            break;
                                        case -3:
                                            leverageIndex = 0.1;
                                            break;
                                        case -2:
                                            leverageIndex = 0.2;
                                            break;
                                        case -1:
                                            leverageIndex = 0.4;
                                            break;
                                        case 0:
                                            leverageIndex = 1.4;
                                            break;
                                        case 1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 2:
                                            leverageIndex = 0.5;
                                            break;
                                        case 3:
                                            leverageIndex = 0.2;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.2;
                                            break;
                                        case -2:
                                            leverageIndex = 0.3;
                                            break;
                                        case -1:
                                            leverageIndex = 0.7;
                                            break;
                                        case 0:
                                            leverageIndex = 2.4;
                                            break;
                                        case 1:
                                            leverageIndex = 2.9;
                                            break;
                                        case 2:
                                            leverageIndex = 1.3;
                                            break;
                                        case 3:
                                            leverageIndex = 0.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.2;
                                            break;
                                        case -2:
                                            leverageIndex = 0.5;
                                            break;
                                        case -1:
                                            leverageIndex = 1.1;
                                            break;
                                        case 0:
                                            leverageIndex = 3.7;
                                            break;
                                        case 1:
                                            leverageIndex = 4.0;
                                            break;
                                        case 2:
                                            leverageIndex = 1.4;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.3;
                                            break;
                                        case 0:
                                            leverageIndex = 4.4;
                                            break;
                                        case 1:
                                            leverageIndex = 4.6;
                                            break;
                                        case 2:
                                            leverageIndex = 1.4;
                                            break;
                                        case 3:
                                            leverageIndex = 0.5;
                                            break;
                                        case 4:
                                            leverageIndex = 0.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.4;
                                            break;
                                        case 0:
                                            leverageIndex = 4.5;
                                            break;
                                        case 1:
                                            leverageIndex = 5.5;
                                            break;
                                        case 2:
                                            leverageIndex = 2.9;
                                            break;
                                        case 3:
                                            leverageIndex = 1.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.5;
                                            break;
                                        case 0:
                                            leverageIndex = 5.0;
                                            break;
                                        case 1:
                                            leverageIndex = 5.9;
                                            break;
                                        case 2:
                                            leverageIndex = 2.9;
                                            break;
                                        case 3:
                                            leverageIndex = 1.3;
                                            break;
                                        case 4:
                                            leverageIndex = 0.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.3;
                                            break;
                                        case -2:
                                            leverageIndex = 0.7;
                                            break;
                                        case -1:
                                            leverageIndex = 1.6;
                                            break;
                                        case 0:
                                            leverageIndex = 5.1;
                                            break;
                                        case 1:
                                            leverageIndex = 6.9;
                                            break;
                                        case 2:
                                            leverageIndex = 3.9;
                                            break;
                                        case 3:
                                            leverageIndex = 1.4;
                                            break;
                                        case 4:
                                            leverageIndex = 0.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 1.0;
                                            break;
                                        case -1:
                                            leverageIndex = 2.1;
                                            break;
                                        case 0:
                                            leverageIndex = 6.9;
                                            break;
                                        case 1:
                                            leverageIndex = 9.1;
                                            break;
                                        case 2:
                                            leverageIndex = 5.7;
                                            break;
                                        case 3:
                                            leverageIndex = 3.1;
                                            break;
                                        case 4:
                                            leverageIndex = 1.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    /// Bottom nine
                    else
                    {
                        switch (inning.Item3)
                        {
                            case 0:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.5;
                                            break;
                                        case -3:
                                            leverageIndex = 1.0;
                                            break;
                                        case -2:
                                            leverageIndex = 2.0;
                                            break;
                                        case -1:
                                            leverageIndex = 3.6;
                                            break;
                                        case 0:
                                            leverageIndex = 2.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 2.0;
                                            break;
                                        case -2:
                                            leverageIndex = 3.6;
                                            break;
                                        case -1:
                                            leverageIndex = 5.4;
                                            break;
                                        case 0:
                                            leverageIndex = 3.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.0;
                                            break;
                                        case -3:
                                            leverageIndex = 1.9;
                                            break;
                                        case -2:
                                            leverageIndex = 3.3;
                                            break;
                                        case -1:
                                            leverageIndex = 4.3;
                                            break;
                                        case 0:
                                            leverageIndex = 2.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.1;
                                            break;
                                        case -3:
                                            leverageIndex = 2.0;
                                            break;
                                        case -2:
                                            leverageIndex = 3.6;
                                            break;
                                        case -1:
                                            leverageIndex = 3.5;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.0;
                                            break;
                                        case -3:
                                            leverageIndex = 3.6;
                                            break;
                                        case -2:
                                            leverageIndex = 5.2;
                                            break;
                                        case -1:
                                            leverageIndex = 6.0;
                                            break;
                                        case 0:
                                            leverageIndex = 3.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.1;
                                            break;
                                        case -3:
                                            leverageIndex = 3.7;
                                            break;
                                        case -2:
                                            leverageIndex = 5.5;
                                            break;
                                        case -1:
                                            leverageIndex = 4.3;
                                            break;
                                        case 0:
                                            leverageIndex = 2.1;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 2.0;
                                            break;
                                        case -3:
                                            leverageIndex = 3.5;
                                            break;
                                        case -2:
                                            leverageIndex = 4.7;
                                            break;
                                        case -1:
                                            leverageIndex = 4.3;
                                            break;
                                        case 0:
                                            leverageIndex = 2.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 3.7;
                                            break;
                                        case -3:
                                            leverageIndex = 5.4;
                                            break;
                                        case -2:
                                            leverageIndex = 6.4;
                                            break;
                                        case -1:
                                            leverageIndex = 5.3;
                                            break;
                                        case 0:
                                            leverageIndex = 2.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 1.3;
                                            break;
                                        case -1:
                                            leverageIndex = 2.8;
                                            break;
                                        case 0:
                                            leverageIndex = 1.9;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 1.3;
                                            break;
                                        case -2:
                                            leverageIndex = 2.8;
                                            break;
                                        case -1:
                                            leverageIndex = 4.8;
                                            break;
                                        case 0:
                                            leverageIndex = 3.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 1.3;
                                            break;
                                        case -2:
                                            leverageIndex = 2.7;
                                            break;
                                        case -1:
                                            leverageIndex = 5.0;
                                            break;
                                        case 0:
                                            leverageIndex = 3.2;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 1.4;
                                            break;
                                        case -2:
                                            leverageIndex = 2.9;
                                            break;
                                        case -1:
                                            leverageIndex = 5.8;
                                            break;
                                        case 0:
                                            leverageIndex = 4.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.3;
                                            break;
                                        case -3:
                                            leverageIndex = 2.9;
                                            break;
                                        case -2:
                                            leverageIndex = 4.8;
                                            break;
                                        case -1:
                                            leverageIndex = 7.2;
                                            break;
                                        case 0:
                                            leverageIndex = 4.3;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 2.9;
                                            break;
                                        case -2:
                                            leverageIndex = 4.9;
                                            break;
                                        case -1:
                                            leverageIndex = 7.1;
                                            break;
                                        case 0:
                                            leverageIndex = 5.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.4;
                                            break;
                                        case -3:
                                            leverageIndex = 2.8;
                                            break;
                                        case -2:
                                            leverageIndex = 4.8;
                                            break;
                                        case -1:
                                            leverageIndex = 5.7;
                                            break;
                                        case 0:
                                            leverageIndex = 4.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 3.0;
                                            break;
                                        case -3:
                                            leverageIndex = 5.1;
                                            break;
                                        case -2:
                                            leverageIndex = 7.3;
                                            break;
                                        case -1:
                                            leverageIndex = 8.6;
                                            break;
                                        case 0:
                                            leverageIndex = 5.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.1;
                                            break;
                                        case -3:
                                            leverageIndex = 0.2;
                                            break;
                                        case -2:
                                            leverageIndex = 0.6;
                                            break;
                                        case -1:
                                            leverageIndex = 1.9;
                                            break;
                                        case 0:
                                            leverageIndex = 1.5;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.5;
                                            break;
                                        case -2:
                                            leverageIndex = 1.7;
                                            break;
                                        case -1:
                                            leverageIndex = 3.7;
                                            break;
                                        case 0:
                                            leverageIndex = 2.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.6;
                                            break;
                                        case -2:
                                            leverageIndex = 1.8;
                                            break;
                                        case -1:
                                            leverageIndex = 6.1;
                                            break;
                                        case 0:
                                            leverageIndex = 4.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.2;
                                            break;
                                        case -3:
                                            leverageIndex = 0.7;
                                            break;
                                        case -2:
                                            leverageIndex = 1.8;
                                            break;
                                        case -1:
                                            leverageIndex = 6.1;
                                            break;
                                        case 0:
                                            leverageIndex = 4.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == false)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 1.7;
                                            break;
                                        case -2:
                                            leverageIndex = 3.7;
                                            break;
                                        case -1:
                                            leverageIndex = 6.8;
                                            break;
                                        case 0:
                                            leverageIndex = 4.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == false && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.6;
                                            break;
                                        case -3:
                                            leverageIndex = 1.7;
                                            break;
                                        case -2:
                                            leverageIndex = 3.7;
                                            break;
                                        case -1:
                                            leverageIndex = 7.4;
                                            break;
                                        case 0:
                                            leverageIndex = 5.0;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == false && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 0.7;
                                            break;
                                        case -3:
                                            leverageIndex = 1.8;
                                            break;
                                        case -2:
                                            leverageIndex = 5.1;
                                            break;
                                        case -1:
                                            leverageIndex = 8.4;
                                            break;
                                        case 0:
                                            leverageIndex = 4.7;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (baseState.Item1 == true && baseState.Item2 == true && baseState.Item3 == true)
                                {
                                    switch (runDeltaHome)
                                    {
                                        case -4:
                                            leverageIndex = 1.8;
                                            break;
                                        case -3:
                                            leverageIndex = 3.9;
                                            break;
                                        case -2:
                                            leverageIndex = 7.0;
                                            break;
                                        case -1:
                                            leverageIndex = 10.9;
                                            break;
                                        case 0:
                                            leverageIndex = 6.4;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
            }

            return leverageIndex;
        }
    }
}
