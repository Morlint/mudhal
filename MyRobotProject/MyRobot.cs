/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

using Robocode;

//namespace MyRobotProject
namespace SampleCs
{
    public class MyRobot : Robot
    {
        public override void Run()
        {
            // -- Initialization of the robot --
            // Here we turn the robot to point upwards, and move the gun 90 degrees
            
            while (true)
            {
                Ahead(100); // Move ahead 100
                TurnGunRight(360); // Spin gun around
                Back(100); // Move back 100
                TurnGunRight(180); // Spin gun around
                Ahead(500); 
                Back(200);
                TurnLeft(45);
                Ahead(250);
            }

            
        }
        
        public override void OnScannedRobot()
        {
            // Turn gun to point at the scanned robot
            TurnGunTo(ScannedAngle);

            // Fire!
            Fire(1);
        }

    }
}
