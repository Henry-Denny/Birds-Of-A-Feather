using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;

namespace Birds_Of_A_Feather
{

    public enum SpawnableObjects
    {
        Boid,
        Predator,
        Obstacle,
    }

    public struct Vector
    {
        public double x, y;

        /// <param name="xCoordinate">The x position of the vector.</param>
        /// <param name="yCoordinate">The y position of the vector.</param>
        public Vector(double xCoordinate, double yCoordinate)
        {
            x = xCoordinate;
            y = yCoordinate;
        }

        /// <summary>
        /// Gets the magnitude of this vector.
        /// </summary>
        public double GetMagnitude()
        {
            double magnitude;
            magnitude = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return magnitude;
        }

        /// <summary>
        /// Gets the vector equivalent of this vector with a magnitude of 'magnitude'.
        /// </summary>
        public Vector GetMagnitude(double magnitude)
        {
            Vector vector;
            vector = this;
            vector.Normalise();
            vector.SetMagnitude(magnitude);
            return vector;
        }

        /// <summary>
        /// Sets the magnitude of the vector to 'magnitude'
        /// </summary>
        /// <param name="magnitude">The magnitude that the vector will be set to</param>
        public void SetMagnitude(double magnitude)
        {
            if (this.GetMagnitude() == 0f) { return; } // Handles cases where the magnitude of the vector is 0 <Edit: I don't think I need this now because I handled it in Vector.GetNormalised()>
            this.Normalise();
            this = Multiply(this, magnitude);
        }

        /// <summary>
        /// Multiplies a vector by a value
        /// </summary>
        /// <param name="vector">The vector to multiply</param>
        /// <param name="value">The value which the vector should be multiplied to</param>
        private Vector Multiply(Vector vector, double value)
        {
            Vector product;
            double xProduct, yProduct;
            xProduct = vector.x * value;
            yProduct = vector.y * value;
            product = new Vector(xProduct, yProduct);
            return product;
        }

        /// <summary>
        /// Gets the normalised version of this vector.
        /// </summary>
        public Vector GetNormalised()
        {
            double magnitude, xNormalised, yNormalised;
            Vector normalisedVector;
            magnitude = this.GetMagnitude();
            if (magnitude == 0f) { return this; } // Handles cases where the magnitude of the vector is 0
            xNormalised = this.x / magnitude;
            yNormalised = this.y / magnitude;
            normalisedVector = new Vector(xNormalised, yNormalised);
            return normalisedVector;
        }

        /// <summary>
        /// Normalises this vector.
        /// </summary>
        public void Normalise()
        {
            this = this.GetNormalised();
        }

        /// <summary>
        /// Gets the result of adding vectors 'A' and 'B' together.
        /// </summary>
        public static Vector Add(Vector A, Vector B)
        {
            Vector sum;
            double xSum, ySum;
            xSum = A.x + B.x;
            ySum = A.y + B.y;
            sum = new Vector(xSum, ySum);
            return sum;
        }

        /// <summary>
        /// Limits the magnitude of the vector.
        /// </summary>
        /// <param name="magnitude">The maximum magnitude of the vector.</param>
        public void Limit(double magnitude)
        {
            double currentMagnitude = this.GetMagnitude();
            if (currentMagnitude > magnitude)
            {
                this.SetMagnitude(magnitude);
            }
        }


        /// <summary>
        /// Gets the result of adding all of the vectors in the list together.
        /// </summary>
        public static Vector Add(Vector[] vectors)
        {
            Vector sum;
            double xSum = 0.0f;
            double ySum = 0.0f;
            foreach (Vector vector in vectors)
            {
                xSum += vector.x;
                ySum += vector.y;
            }
            sum = new Vector(xSum, ySum);
            return sum;
        }

        /// <summary>
        /// Gets the average position of the vectors in the array.
        /// </summary>
        public static Vector GetAverageVector(Vector[] vectors)
        {
            Vector averageVector;
            Vector sumOfVectors = Add(vectors);
            double xSum, ySum;
            xSum = sumOfVectors.x;
            ySum = sumOfVectors.y;
            averageVector = new Vector(xSum / vectors.Length, ySum / vectors.Length);
            return averageVector;
        }

        /// <summary>
        /// Returns vector 'A' minus vector 'B'.
        /// </summary>
        public static Vector Sub(Vector A, Vector B)
        {
            Vector result;
            double xDiff, yDiff;
            xDiff = A.x - B.x;
            yDiff = A.y - B.y;
            result = new Vector(xDiff, yDiff);
            return result;
        }

        /// <summary>
        /// Gets the magnitude of the distance between vectors 'A' and 'B'.
        /// </summary>
        public static double Distance(Vector A, Vector B)
        {
            double distance;
            Vector vectorDistance = Sub(A, B);
            distance = vectorDistance.GetMagnitude();
            return distance;
        }

        public static Vector GetClosestVector(Vector A, Vector[] vectors)
        {
            double shortestDistance = double.PositiveInfinity;
            Vector closestVector = vectors[0];
            foreach (Vector vector in vectors)
            {
                double currentDistance = Distance(A, vector);
                if (currentDistance < shortestDistance)
                {
                    shortestDistance = currentDistance;
                    closestVector = vector;
                }
            }
            return closestVector;
        }

        private static double Dot(Vector A, Vector B)
        {
            double dotProduct;
            dotProduct = (A.x * B.x) + (A.y * B.y);
            return dotProduct;
        }

        /// <summary>
        /// Gets the angle between vectors 'A' and 'B'.
        /// </summary>
        /// <returns>
        /// The angle between vectors 'A' and 'B' in radians.
        /// </returns>
        public static double GetAngle(Vector A, Vector B)
        {
            double productOfTheMagnitudes = A.GetMagnitude() * B.GetMagnitude();
            double dotProduct = Dot(A, B);
            double angle = Math.Acos(dotProduct / productOfTheMagnitudes);
            return angle;
        }

        /// <summary>
        /// Gets the vector equal to a certain vector rotated by a certain angle around a certain point
        /// </summary>
        /// <param name="angle">The angle which the vector should be rotated by</param>
        /// <param name="pointOfRotation">The point at which to rotate the vector</param>
        /// <returns></returns>
        public Vector GetRotatedVector(double angle, Vector pointOfRotation)
        {
            Vector relativeVector = Sub(this, pointOfRotation);
            Vector rotatedVector = new Vector();
            rotatedVector.x = (relativeVector.x * Math.Cos(-angle)) - (relativeVector.y * Math.Sin(-angle));
            rotatedVector.y = (relativeVector.x * Math.Sin(-angle)) + (relativeVector.y * Math.Cos(-angle));
            rotatedVector = Add(rotatedVector, pointOfRotation);
            return rotatedVector;
        }
    }

    public partial class Simulation : Form
    {
        public static Color backgroundColour;
        private DateTime previousTime = DateTime.Now;
        SpawnableObjects selectedObject = SpawnableObjects.Boid;

        public Simulation()
        {
            InitializeComponent();

            glControl.KeyDown += new KeyEventHandler(glControl_KeyDown);
            glControl.MouseDown += new MouseEventHandler(glControl_MouseDown);
            glControl.Resize += new EventHandler(glControl_Resize);

            Application.Idle += Application_Idle;
        }

        private void Simulation_Load(object sender, EventArgs e)
        {
            InitialiseSettings();
            glControl_Resize(glControl, EventArgs.Empty);
        }

        Bitmap TakeScreenshot()
        {
            Bitmap bmp = new Bitmap(glControl.ClientRectangle.Width, glControl.ClientRectangle.Height);
            System.Drawing.Imaging.BitmapData data = bmp.LockBits(glControl.ClientRectangle, System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            GL.ReadPixels(glControl.ClientRectangle.X, glControl.ClientRectangle.Y, glControl.ClientRectangle.Width, glControl.ClientRectangle.Height, PixelFormat.Bgr, PixelType.UnsignedByte, data.Scan0);
            bmp.UnlockBits(data);
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return bmp;
        }

        void glControl_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.F12:
                    try
                    {
                        TakeScreenshot().Save(DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString() + "." + DateTime.Now.Second.ToString() + ".png");
                        MessageBox.Show("Screenshot saved");
                    }
                    catch
                    {
                        MessageBox.Show("Failed to save screenshot", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        void glControl_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Vector mousePosition = GetMousePosition(e);
            if (e.Button == MouseButtons.Left)
            {
                switch (selectedObject)
                {
                    case SpawnableObjects.Boid:
                        new Boid(mousePosition);
                        break;
                    case SpawnableObjects.Predator:
                        new Predator(mousePosition);
                        break;
                    case SpawnableObjects.Obstacle:
                        new Obstacle(mousePosition);
                        break;
                    default:
                        // No object selected to Instantiate (should be impossible)
                        break;
                }
            }
        }

        private Vector GetMousePosition(System.Windows.Forms.MouseEventArgs e)
        {
            double xPosition = (e.X - (glControl.Width / 2f)) / (glControl.Width / 2f);
            double yPosition = -((e.Y - (glControl.Height / 2f)) / (glControl.Height / 2f));
            Vector mousePosition = new Vector(xPosition, yPosition);
            return mousePosition;
        }

        void glControl_Resize(object sender, EventArgs e)
        {
            OpenTK.GLControl c = sender as OpenTK.GLControl;

            if (c.ClientSize.Height == 0)
                c.ClientSize = new Size(c.ClientSize.Width, 1);

            GL.Viewport(0, 0, c.ClientSize.Width, c.ClientSize.Height);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            while (glControl.IsIdle)
            {
                double deltaTime = GetDeltaTime();
                OnUpdate(deltaTime);
                Render();
            }
        }

        double GetDeltaTime()
        {
            DateTime currentTime = DateTime.Now;
            double deltaTime = Convert.ToDouble(currentTime.Ticks - previousTime.Ticks) / 10000000f;
            previousTime = currentTime;
            return deltaTime;
        }

        void Render()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            if (Boid.connectionLinesActive)
            {
                foreach (Boid boid in Boid.activeObjects)
                {
                    boid.DrawConnectionLines();
                }
            }

            foreach (SceneObject sceneObject in SceneObject.activeObjects)
            {
                Color colour = new Color();

                if (sceneObject.GetType() == typeof(Boid))
                {
                    colour = Boid.colour;
                }
                else if (sceneObject.GetType() == typeof(Predator))
                {
                    colour = Predator.colour;
                }
                else if (sceneObject.GetType() == typeof(Obstacle))
                {
                    colour = Obstacle.colour;
                }
                sceneObject.Draw(colour);
            }

            glControl.SwapBuffers();
        }

        void OnUpdate(double deltaTime)
        {
            foreach (Boid boid in Boid.activeObjects)
            {
                boid.Move(Boid.activeObjects, Predator.activeObjects, Obstacle.activeObjects, deltaTime);
            }
            foreach (Predator predator in Predator.activeObjects)
            {
                predator.Move(Boid.activeObjects, deltaTime);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Idle -= Application_Idle;

            base.OnClosing(e);
        }

        #region Trackbars

        private void UpdateValue(CustomTrackbar trackBar, Label label, ref double valueToChange)
        {
            double newValue = trackBar.Value;
            valueToChange = newValue;
            label.Text = Convert.ToString(newValue);
        }

        private void SldAlignmentRadius_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldAlignmentRadius, LblAlignmentRadius, ref Boid.alignmentRadius);
        }

        private void SldAlignmentStrength_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldAlignmentStrength, LblAlignmentStrength, ref Boid.alignmentStrength);
        }

        private void SldAlignmentPeripherals_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldAlignmentPeripherals, LblAlignmentPeripherals, ref Boid.alignmentPeripheralAngle);
        }

        private void SldCohesionRadius_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldCohesionRadius, LblCohesionRadius, ref Boid.cohesionRadius);
        }

        private void SldCohesionStrength_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldCohesionStrength, LblCohesionStrength, ref Boid.cohesionStrength);
        }

        private void SldCohesionPeripherals_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldCohesionPeripherals, LblCohesionPeripherals, ref Boid.cohesionPeripheralAngle);
        }

        private void SldBoidAvoidanceRadius_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldBoidAvoidanceRadius, LblBoidAvoidanceRadius, ref Boid.boidAvoidanceRadius);
        }

        private void SldBoidAvoidanceStrength_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldBoidAvoidanceStrength, LblBoidAvoidanceStrength, ref Boid.boidAvoidanceStrength);
        }

        private void SldBoidAvoidancePeripherals_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldBoidAvoidancePeripherals, LblBoidAvoidancePeripherals, ref Boid.boidAvoidancePeripheralAngle);
        }

        private void SldPredatorAvoidanceRadius_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldPredatorAvoidanceRadius, LblPredatorAvoidanceRadius, ref Boid.predatorAvoidanceRadius);
        }

        private void SldPredatorAvoidanceStrength_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldPredatorAvoidanceStrength, LblPredatorAvoidanceStrength, ref Boid.predatorAvoidanceStrength);
        }

        private void SldPredatorAvoidancePeripherals_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldPredatorAvoidancePeripherals, LblPredatorAvoidancePeripherals, ref Boid.predatorAvoidancePeripheralAngle);
        }

        private void SldObstacleAvoidanceRadius_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldObstacleAvoidanceRadius, LblObstacleAvoidanceRadius, ref Boid.obstacleAvoidaceRadius);
        }

        private void SldObstacleAvoidanceStrength_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldObstacleAvoidanceStrength, LblObstacleAvoidanceStrength, ref Boid.obstacleAvoidanceStrength);
        }

        private void SldObstacleAvoidancePeripherals_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldObstacleAvoidancePeripherals, LblObstacleAvoidancePeripherals, ref Boid.obstacleAvoidancePeripheralAngle);
        }

        private void SldMaxSpeed_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldMaxSpeed, LblMaxSpeed, ref MobileObject.maxSpeed);
        }

        private void SldMaxLineLength_Scroll(object sender, EventArgs e)
        {
            UpdateValue(SldMaxLineLength, LblMaxLineLength, ref Boid.connectionLinesMaxDistance);
        }

        #endregion

        #region RadioCheckboxes

        private void RadBoid_CheckedChanged(object sender, EventArgs e)
        {
            selectedObject = SpawnableObjects.Boid;
        }

        private void RadPredator_CheckedChanged(object sender, EventArgs e)
        {
            selectedObject = SpawnableObjects.Predator;
        }

        private void RadObstacle_CheckedChanged(object sender, EventArgs e)
        {
            selectedObject = SpawnableObjects.Obstacle;
        }

        #endregion

        #region PictureBoxes

        private void UpdateColour(PictureBox pictureBox, ref Color colourToChange)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color newColour = colorDialog.Color;
                colourToChange = newColour;
                pictureBox.BackColor = newColour;

            }
        }

        private void PbxBoidColour_Click(object sender, EventArgs e)
        {
            UpdateColour(PbxBoidColour, ref Boid.colour);
        }

        private void PbxPredatorColour_Click(object sender, EventArgs e)
        {
            UpdateColour(PbxPredatorColour, ref Predator.colour);
        }

        private void PbxObstacleColour_Click(object sender, EventArgs e)
        {
            UpdateColour(PbxObstacleColour, ref Obstacle.colour);
        }

        private void PbxBackgroundColour_Click(object sender, EventArgs e)
        {
            UpdateColour(PbxBackgroundColour, ref backgroundColour);
            GL.ClearColor(backgroundColour);
        }

        private void PbxConnectionLineColour_Click(object sender, EventArgs e)
        {
            UpdateColour(PbxConnectionLineColour, ref Boid.connectionLinesColour);
        }

        #endregion

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Boid.activeObjects = new List<Boid>();
            Predator.activeObjects = new List<Predator>();
            Obstacle.activeObjects = new List<Obstacle>();
            MobileObject.activeObjects = new List<MobileObject>();
            StationaryObject.activeObjects = new List<StationaryObject>();
            SceneObject.activeObjects = new List<SceneObject>();
        }

        private void ChbxConnectionLines_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbxConnectionLines.Checked == true)
            {
                Boid.connectionLinesActive = true;
                SldMaxLineLength.Enabled = true;
            }
            else
            {
                Boid.connectionLinesActive = false;
                SldMaxLineLength.Enabled = false;
            }
        }

        private void InitialiseSettings()
        {
            // Trackbars
            UpdateValue(SldAlignmentRadius, LblAlignmentRadius, ref Boid.alignmentRadius);
            UpdateValue(SldAlignmentStrength, LblAlignmentStrength, ref Boid.alignmentStrength);
            UpdateValue(SldAlignmentPeripherals, LblAlignmentPeripherals, ref Boid.alignmentPeripheralAngle);

            UpdateValue(SldCohesionRadius, LblCohesionRadius, ref Boid.cohesionRadius);
            UpdateValue(SldCohesionStrength, LblCohesionStrength, ref Boid.cohesionStrength);
            UpdateValue(SldCohesionPeripherals, LblCohesionPeripherals, ref Boid.cohesionPeripheralAngle);

            UpdateValue(SldBoidAvoidanceRadius, LblBoidAvoidanceRadius, ref Boid.boidAvoidanceRadius);
            UpdateValue(SldBoidAvoidanceStrength, LblBoidAvoidanceStrength, ref Boid.boidAvoidanceStrength);
            UpdateValue(SldBoidAvoidancePeripherals, LblBoidAvoidancePeripherals, ref Boid.boidAvoidancePeripheralAngle);

            UpdateValue(SldPredatorAvoidanceRadius, LblPredatorAvoidanceRadius, ref Boid.predatorAvoidanceRadius);
            UpdateValue(SldPredatorAvoidanceStrength, LblPredatorAvoidanceStrength, ref Boid.predatorAvoidanceStrength);
            UpdateValue(SldPredatorAvoidancePeripherals, LblPredatorAvoidancePeripherals, ref Boid.predatorAvoidancePeripheralAngle);

            UpdateValue(SldObstacleAvoidanceRadius, LblObstacleAvoidanceRadius, ref Boid.obstacleAvoidaceRadius);
            UpdateValue(SldObstacleAvoidanceStrength, LblObstacleAvoidanceStrength, ref Boid.obstacleAvoidanceStrength);
            UpdateValue(SldObstacleAvoidancePeripherals, LblObstacleAvoidancePeripherals, ref Boid.obstacleAvoidancePeripheralAngle);

            UpdateValue(SldMaxSpeed, LblMaxSpeed, ref MobileObject.maxSpeed);

            UpdateValue(SldMaxLineLength, LblMaxLineLength, ref Boid.connectionLinesMaxDistance);


            // Radio checkboxes
            if (RadBoid.Checked == true)
            {
                selectedObject = SpawnableObjects.Boid;
            }
            else if (RadObstacle.Checked == true)
            {
                selectedObject = SpawnableObjects.Predator;
            }
            else if (RadPredator.Checked == true)
            {
                selectedObject = SpawnableObjects.Obstacle;
            }

            if (ChbxConnectionLines.Checked == true)
            {
                Boid.connectionLinesActive = true;
                SldMaxLineLength.Enabled = true;
            }
            else
            {
                Boid.connectionLinesActive = false;
                SldMaxLineLength.Enabled = false;
            }


            // Colours
            backgroundColour = PbxBackgroundColour.BackColor;
            GL.ClearColor(backgroundColour);
            Boid.colour = PbxBoidColour.BackColor;
            Predator.colour = PbxPredatorColour.BackColor;
            Obstacle.colour = PbxObstacleColour.BackColor;
            Boid.connectionLinesColour = PbxConnectionLineColour.BackColor;
            

        }
    }
}
