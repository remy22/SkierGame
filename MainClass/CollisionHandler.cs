using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainClass
{
    public class CollisionHandler
    {

        public static void HandleCollision(Skier skier, List<GameObject> obstacles)
        {
            // Taking body`s coordinates of the skier 
            List<FieldCoordinates> skierProfile = skier.GetCollisionProfile();
            
            // Checking for collision between skier and all other objects
            foreach (var obj in obstacles)
            {
                if (obj.CanCollideWith(skier.GetCollisionName()))
                {
                    // Taking obstacle`s coordinates
                    List<FieldCoordinates> objProfile = obj.GetCollisionProfile();
                    
                    if(HaveCollision(skierProfile, objProfile))
                    {
                        if (obj.GetCollisionName() == Bonus.CollisionName)
                        {
                            obj.RespondToCollision(new CollisionData(obj.GetCollisionName()));
                        }
                        else if (obj.GetCollisionName() == Tree.CollisionName)
                        {
                            skier.RespondToCollision(new CollisionData(obj.GetCollisionName()));
                        }
                    }
                }
            }                   
        }

        private static bool HaveCollision(List<FieldCoordinates> skierProfile, List<FieldCoordinates> objProfile)
        {
            // Compare every skier`s char with obstacle`s char 
            foreach (var skierCoord in skierProfile)
            {
                foreach (var objCoord in objProfile)
                {
                    if (skierCoord.Equals(objCoord))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
        
    
    
    
    
    }
}
