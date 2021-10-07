using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace Birds_Of_A_Feather
{
    abstract class MobileObject : SceneObject
    {
        public static double maxSpeed;
        public Vector velocity;
        public Vector acceleration;

        public static new List<MobileObject> activeObjects = new List<MobileObject>();

        public MobileObject(Vector _position)
            : base(_position)
        {
            Random random = new Random();
            Vector randomVelocity = new Vector(-1 + (2 * random.NextDouble()), -1 + (2 * random.NextDouble()));
            velocity = randomVelocity;
            velocity.SetMagnitude(maxSpeed);
            activeObjects.Add(this);
        }

        public MobileObject()
        {
            Random random = new Random();
            Vector randomVelocity = new Vector(-1 + (2 * random.NextDouble()), -1 + (2 * random.NextDouble()));
            velocity = randomVelocity;
            velocity.SetMagnitude(maxSpeed);
            activeObjects.Add(this);
        }

        public override T[] GetNearbyObjects<T>(List<T> group, double radius, double angle)
        {
            List<T> nearbyObjectsList = new List<T>();
            T[] nearbyObjects;
            foreach (T member in group)
            {
                if (WithinRange(member, radius) && (WithinPeripherals(member, angle) || this.velocity.GetMagnitude() == 0f) && member != this)
                {
                    nearbyObjectsList.Add(member);
                }
            }
            nearbyObjects = nearbyObjectsList.ToArray<T>();
            return nearbyObjects;
        }

        protected bool WithinPeripherals<T>(T member, double angle) where T : SceneObject
        {
            Vector vectorDistance = Vector.Sub(member.position, this.position);
            if (Vector.GetAngle(this.velocity, vectorDistance) < (angle / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Move(double deltaTime)
        {

            velocity = Vector.Add(velocity, acceleration);
            velocity.Limit(maxSpeed);

            position = Vector.Add(position, velocity.GetMagnitude(velocity.GetMagnitude() * deltaTime));

            CheckBoundaries();
        }

        public override void Draw(Color colour)
        {
            double angle = Vector.GetAngle(new Vector(0f, 1f), this.velocity);
            if (this.velocity.x < 0)
            {
                angle = (2 * Math.PI) - angle;
            }
            if (double.IsNaN(angle))
            {
                angle = 0f;
            }
            GL.Begin(PrimitiveType.Polygon);
            for (int vertexIndex = 0; vertexIndex < this.vertices.Length; vertexIndex++)
            {
                Vector rotatedVector = Vector.Add(this.position, this.relativeVertices[vertexIndex]).GetRotatedVector(angle, this.position);
                GL.Color3(colour);
                GL.Vertex2(rotatedVector.x, rotatedVector.y);
            }
            GL.End();
        }

        private void CheckBoundaries()
        {
            if (position.x > 1.0f)
            {
                position.x = position.x - 2.0f;
            }
            else if (position.x < -1.0f)
            {
                position.x = position.x + 2.0f;
            }
            if (position.y > 1.0f)
            {
                position.y = position.y - 2.0f;
            }
            else if (position.y < -1.0f)
            {
                position.y = position.y + 2.0f;
            }
        }

        public override void RemoveObjectFromScene()
        {
            activeObjects.Remove(this);
            base.RemoveObjectFromScene();
        }
    }
}