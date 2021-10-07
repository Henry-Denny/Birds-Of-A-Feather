using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Birds_Of_A_Feather
{
    abstract class SceneObject
    {
        //public Vector[] vertices = new Vector[] { new Vector(0.436, 0.347), new Vector(0.4712, 0.2899), new Vector(0.4773, 0.3023), new Vector(0.4874, 0.2953), new Vector(0.493, 0.301), new Vector(0.4813, 0.3084), new Vector(0.4946, 0.3171) };
        //public Vector[] vertices = new Vector[] { new Vector(0f, 0f), new Vector(0.016f, 0f), new Vector(0.008f, 0.024f) };
        public abstract Vector[] vertices { get; set; }

        public Vector[] relativeVertices;
        public Vector position;

        public static List<SceneObject> activeObjects = new List<SceneObject>();

        public SceneObject(Vector _position)
        {
            position = Vector.GetAverageVector(vertices);
            relativeVertices = new Vector[vertices.Length];
            GetRelativeVertices();
            position = _position;
            activeObjects.Add(this);
        }

        public SceneObject()
        {
            Random random = new Random();
            Vector randomPosition = new Vector(-1 + (2 * random.NextDouble()), -1 + (2 * random.NextDouble()));
            position = Vector.GetAverageVector(vertices);
            relativeVertices = new Vector[vertices.Length];
            GetRelativeVertices();
            position = randomPosition;
            activeObjects.Add(this);
        }

        public abstract void Draw(Color colour);
        public abstract T[] GetNearbyObjects<T>(List<T> group, double radius, double angle) where T : SceneObject;

        private void GetRelativeVertices()
        {
            for (int vertexIndex = 0; vertexIndex < vertices.Length; vertexIndex++)
            {
                relativeVertices[vertexIndex].x = vertices[vertexIndex].x - position.x;
                relativeVertices[vertexIndex].y = vertices[vertexIndex].y - position.y;
            }
        }

        protected bool WithinRange<T>(T member, double radius) where T : SceneObject
        {
            bool withinRange = false;
            Vector[] allPositions = member.GetAllEquivalentPositions();
            foreach (Vector possiblePosition in allPositions)
            {
                if (Vector.Distance(this.position, possiblePosition) < radius)
                {
                    withinRange = true;
                    break;
                }
            }
            return withinRange;
        }

        public Vector[] GetAllEquivalentPositions()
        {
            List<Vector> equivalentPositions = new List<Vector>();
            for (int i = -2; i <= 2; i += 2)
            {
                for (int j = -2; j <= 2; j += 2)
                {
                    equivalentPositions.Add(new Vector(position.x + j, position.y + i));
                }
            }
            return equivalentPositions.ToArray<Vector>();
        }

        public Vector[] GetObjectPositions(SceneObject[] nearbyObjects)
        {
            Vector[] objectPositions = new Vector[nearbyObjects.Length];
            for (int memberIndex = 0; memberIndex < nearbyObjects.Length; memberIndex++)
            {
                Vector[] nearbyPositionsOfMember = nearbyObjects[memberIndex].GetAllEquivalentPositions();
                Vector closestPosition = Vector.GetClosestVector(this.position, nearbyPositionsOfMember);
                objectPositions[memberIndex] = closestPosition;
            }
            return objectPositions;
        }

        public virtual void RemoveObjectFromScene()
        {
            activeObjects.Remove(this);
        }
    }
}