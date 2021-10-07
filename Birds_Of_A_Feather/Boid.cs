using System;
using System.Collections.Generic;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace Birds_Of_A_Feather
{
    class Boid : MobileObject
    {
        private const double forceStrengthMultiplier = 0.05f;
        //public override Vector[] vertices { get; set; } = new Vector[] { new Vector(0f, 0f), new Vector(0.012f, 0f), new Vector(0.006f, 0.018f) };
        public override Vector[] vertices { get; set; } = new Vector[] { new Vector(0f, 0f), new Vector(0.018f, 0f), new Vector(0.009f, 0.027f) };
        public static Color colour;

        public static double cohesionRadius;
        public static double alignmentRadius;
        public static double boidAvoidanceRadius;
        public static double predatorAvoidanceRadius;
        public static double obstacleAvoidaceRadius;

        public static double cohesionStrength;
        public static double alignmentStrength;
        public static double boidAvoidanceStrength;
        public static double predatorAvoidanceStrength;
        public static double obstacleAvoidanceStrength;

        public static double cohesionPeripheralAngle;
        public static double alignmentPeripheralAngle;
        public static double boidAvoidancePeripheralAngle;
        public static double predatorAvoidancePeripheralAngle;
        public static double obstacleAvoidancePeripheralAngle;

        public static bool connectionLinesActive;
        public static double connectionLinesMaxDistance;
        public static Color connectionLinesColour;

        public static new List<Boid> activeObjects = new List<Boid>();

        public Boid(Vector _position)
            : base(_position)
        {
            activeObjects.Add(this);
        }

        public void Move(List<Boid> flock, List<Predator> predators, List<Obstacle> obstacles, double deltaTime)
        {
            Vector cohesionVector = GetCohesionVector(flock);
            Vector alignmentVector = GetAlignmentVector(flock);
            Vector separationVector = GetSeparationVector(flock, boidAvoidanceRadius, boidAvoidanceStrength, boidAvoidancePeripheralAngle);
            Vector predatorAvoidanceVector = GetSeparationVector(predators, predatorAvoidanceRadius, predatorAvoidanceStrength, predatorAvoidancePeripheralAngle);
            Vector obstacleAvoidanceVector = GetSeparationVector(obstacles, obstacleAvoidaceRadius, obstacleAvoidanceStrength, obstacleAvoidancePeripheralAngle);

            // Acceleration is reset
            acceleration = new Vector(0, 0);

            // The acceleration is set to the sum of each steering vector
            acceleration = Vector.Add(acceleration, cohesionVector);
            acceleration = Vector.Add(acceleration, alignmentVector);
            acceleration = Vector.Add(acceleration, separationVector);
            acceleration = Vector.Add(acceleration, predatorAvoidanceVector);
            acceleration = Vector.Add(acceleration, obstacleAvoidanceVector);

            // Move is then called from MobileObject
            base.Move(deltaTime);
        }

        private Vector GetCohesionVector(List<Boid> flock)
        {
            Boid[] nearbyBoids = GetNearbyObjects(flock, cohesionRadius, cohesionPeripheralAngle);
            Vector[] boidPositions = new Vector[nearbyBoids.Length];
            Vector averagePosition;
            Vector desiredVelocity;
            Vector cohesionVector;

            if (nearbyBoids.Length == 0) { return new Vector(0.0f, 0.0f); }

            boidPositions = GetObjectPositions(nearbyBoids);
            averagePosition = Vector.GetAverageVector(boidPositions);

            desiredVelocity = Vector.Sub(averagePosition, position);
            desiredVelocity.SetMagnitude(maxSpeed);
            cohesionVector = Vector.Sub(desiredVelocity, velocity);
            cohesionVector.Limit(cohesionStrength * forceStrengthMultiplier);

            return cohesionVector;
        }

        private Vector GetAlignmentVector(List<Boid> flock)
        {
            Boid[] nearbyBoids = GetNearbyObjects(flock, alignmentRadius, alignmentPeripheralAngle);
            Vector[] boidVelocities = new Vector[nearbyBoids.Length];
            Vector averageVelocity;
            Vector alignmentVector;

            if (nearbyBoids.Length == 0) { return new Vector(0.0f, 0.0f); }

            for (int boidIndex = 0; boidIndex < nearbyBoids.Length; boidIndex++)
            {
                boidVelocities[boidIndex] = nearbyBoids[boidIndex].velocity;
            }
            averageVelocity = Vector.GetAverageVector(boidVelocities);

            alignmentVector = Vector.Sub(averageVelocity.GetMagnitude(maxSpeed), velocity);
            alignmentVector.Limit(alignmentStrength * forceStrengthMultiplier);

            return alignmentVector;
        }

        private Vector GetSeparationVector<T>(List<T> group, double radius, double strength, double angle) where T : SceneObject
        {
            T[] nearbyGroupMembers = GetNearbyObjects(group, radius, angle);
            Vector[] groupMemberPositions = new Vector[nearbyGroupMembers.Length];
            Vector separationVector = new Vector(0.0f, 0.0f);

            if (nearbyGroupMembers.Length == 0) { return separationVector; }

            groupMemberPositions = GetObjectPositions(nearbyGroupMembers);

            foreach (Vector groupMemberPosition in groupMemberPositions)
            {
                Vector force = Vector.Sub(position, groupMemberPosition);
                force.SetMagnitude(1 / force.GetMagnitude());
                separationVector = Vector.Add(separationVector, force);
            }

            separationVector.Limit(strength * forceStrengthMultiplier);
            return separationVector;
        }

        public void DrawConnectionLines()
        {
            Boid[] nearbyBoids = GetNearbyObjects(activeObjects, connectionLinesMaxDistance, (Math.PI * 2));
            Vector[] nearbyBoidPositions = GetObjectPositions(nearbyBoids);
            foreach (Vector nearbyBoidPosition in nearbyBoidPositions)
            {
                GL.Begin(PrimitiveType.Lines);
                GL.Color3(connectionLinesColour);
                GL.Vertex2(position.x, position.y);
                GL.Vertex2(nearbyBoidPosition.x, nearbyBoidPosition.y);
                GL.End();
            }
        }

        public override void RemoveObjectFromScene()
        {
            activeObjects.Remove(this);
            base.RemoveObjectFromScene();
        }
    }
}
