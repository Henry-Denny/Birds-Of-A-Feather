using System.Collections.Generic;
using System.Drawing;

namespace Birds_Of_A_Feather
{
    class Predator : MobileObject
    {
        private const double seekStrength = 0.1f;

        public override Vector[] vertices { get; set; } = new Vector[] { new Vector(0f, 0f), new Vector(0.024f, 0f), new Vector(0.012f, 0.036f) };
        public static Color colour;

        public static new List<Predator> activeObjects = new List<Predator>();

        public Predator(Vector _position)
            : base(_position)
        {
            activeObjects.Add(this);
        }

        public void Move(List<Boid> flock, double deltaTime)
        {
            Vector seekVector = GetSeekVector(flock);

            acceleration = new Vector(0, 0);
            acceleration = Vector.Add(acceleration, seekVector);

            base.Move(deltaTime);
        }

        private Vector GetSeekVector(List<Boid> flock)
        {
            Vector seekVector;
            Vector desiredVelocity;
            if (flock.Count == 0) { return new Vector(0f, 0f); }
            Vector closestBoidPosition = GetClosestBoidPosition(flock);
            desiredVelocity = Vector.Sub(closestBoidPosition, position);
            desiredVelocity.SetMagnitude(maxSpeed);
            seekVector = Vector.Sub(desiredVelocity, velocity);
            seekVector.Limit(seekStrength);

            return seekVector;
        }

        public Vector GetClosestBoidPosition(List<Boid> flock)
        {
            double shortestDistance = double.PositiveInfinity;
            Vector closestBoidPosition = new Vector();
            foreach (Boid boid in flock)
            {
                Vector[] equivalentBoidPositions = boid.GetAllEquivalentPositions();
                foreach (Vector equivalentBoidPosition in equivalentBoidPositions)
                {
                    double currentDistance = Vector.Distance(this.position, equivalentBoidPosition);
                    if (currentDistance < shortestDistance)
                    {
                        shortestDistance = currentDistance;
                        closestBoidPosition = equivalentBoidPosition;
                    }
                }
            }
            return closestBoidPosition;
        }

        public override void RemoveObjectFromScene()
        {
            activeObjects.Remove(this);
            base.RemoveObjectFromScene();
        }
    }
}
