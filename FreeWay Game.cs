using System;
public class Dinglemouse
{
    public static int FreewayGame(double distKmToExit, double mySpeedKph, (double, double)[] otherCars)
    {
        int Score = 0;
        double myTimeToExit = (distKmToExit / mySpeedKph) * 60;

        foreach ( (double Lead, double Speed) Car in otherCars)     
        {
            double theirTimeToExit = Car.Lead + (distKmToExit / Car.Speed) * 60;
            //If they are ahead of me, and theirTimeToExit bigger than me, I will Overtake them
            if ((Car.Lead < 0) && (theirTimeToExit > myTimeToExit)) Score++;
            //If they are behind me, and theirTimeToExit smaller than me, They will ovetake me
            if ((Car.Lead >= 0) && (theirTimeToExit < myTimeToExit)) Score--;            
        }
        return Score;
    }
}
