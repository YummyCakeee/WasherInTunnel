using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        PointF WorldCenter { get; set; }
        Tunnel Tunnel { get; set; }
        PointF TunnelPos { get; set; }
        Washer Washer { get; set; }
        PointF WasherPos { get; set; }
        float PixelsPerMeter { get; set; }
        static float ppmCoef = 10.0f;
        bool IsMouseDown { get; set; }
        PointF MouseDownPos { get; set; }
        PointF Camera { get; set; }
        PointF CameraD { get; set; }
        static float g = 9.8f;
        bool DrawChecks { get; set; }
        bool DrawPath { get; set; }

        DotsPair[] tunnelSides = null;
        private delegate void RunModel();
        public delegate void ModelingFinish();
        RunModel runModel;
        Bitmap btm;
        Graphics graphics;
        Graphics fG;
        Thread modelingThread;
        public Form1()
        {
            InitializeComponent();
        }  

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMouseDown = false;
            WorldCenter = new PointF(mainFieldPictureBox.Width / 2.0f, mainFieldPictureBox.Height / 2.0f);
            PixelsPerMeter = scaleScrollBar.Value / 100.0f * ppmCoef + ppmCoef;
            Camera = new PointF(0.0f, 0.0f);
            CameraD = new PointF(0.0f, 0.0f);
            DrawChecks = false;
            DrawPath = false;
            runModel = RunModelRealTime;
            mainFieldPictureBox.MouseWheel += MainFieldPictureBox_MouseWheel;
            UpdateValueFields();
            btm = new Bitmap(mainFieldPictureBox.Width, mainFieldPictureBox.Height);
            graphics = Graphics.FromImage(btm);
            fG = mainFieldPictureBox.CreateGraphics();
            modelingThread = new Thread(StartModeling);
            CreateTunnel();
            CreateWasher();
        }

        private void washerRadiusNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CreateWasher();
            DrawSafe();
        }

        private void washerMassNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CreateWasher();
        }

        private void startAngleScrollBar_ValueChanged(object sender, EventArgs e)
        {
            startAngleTextBox.Text = startAngleScrollBar.Value.ToString();
            CreateWasher();
            DrawSafe();
        }

        private void startXPosScrollBar_ValueChanged(object sender, EventArgs e)
        {
            startXPosTextBox.Text = (startXPosScrollBar.Value / 100.0f).ToString();
            CreateWasher();
            DrawSafe();
        }

        private void startYPosScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            startYPosTextBox.Text = (startYPosScrollBar.Value / 100.0f).ToString();
            CreateWasher();
            DrawSafe();
        }

        private void startSpeedScrollBar_ValueChanged(object sender, EventArgs e)
        {
            startSpeedTextBox.Text = startSpeedScrollBar.Value.ToString();
            CreateWasher();
            DrawSafe();
        }

        private void tunnelWidthScrollBar_ValueChanged(object sender, EventArgs e)
        {
            tunnelWidthTextBox.Text = tunnelWidthScrollBar.Value.ToString();
            CreateTunnel();
            DrawSafe();
        }

        private void firstSectionLengthScrollBar_ValueChanged(object sender, EventArgs e)
        {
            firstSectionLengthTextBox.Text = firstSectionLengthScrollBar.Value.ToString();
            CreateTunnel();
            DrawSafe();
        }

        private void secondSectionLengthScrollBar_ValueChanged(object sender, EventArgs e)
        {
            secondSectionLengthTextBox.Text = secondSectionLengthScrollBar.Value.ToString();
            CreateTunnel();
            DrawSafe();
        }

        private void tunnelAngleScrollBar_ValueChanged(object sender, EventArgs e)
        {
            tunnelAngleTextBox.Text = tunnelAngleScrollBar.Value.ToString();
            CreateTunnel();
            DrawSafe();
        }

        private void scaleScrollBar_ValueChanged(object sender, EventArgs e)
        {
            scaleTextBox.Text = (scaleScrollBar.Value / 100.0f).ToString();
            PixelsPerMeter = scaleScrollBar.Value / 100.0f * ppmCoef + ppmCoef;
            CreateTunnel();
            DrawSafe();
        }

        private void UpdateValueFields()
        {
            startAngleTextBox.Text = startAngleScrollBar.Value.ToString();
            startXPosTextBox.Text = startXPosScrollBar.Value.ToString();
            startYPosTextBox.Text = startYPosScrollBar.Value.ToString();
            startSpeedTextBox.Text = startSpeedScrollBar.Value.ToString();
            tunnelWidthTextBox.Text = tunnelWidthScrollBar.Value.ToString();
            firstSectionLengthTextBox.Text = firstSectionLengthScrollBar.Value.ToString();
            secondSectionLengthTextBox.Text = secondSectionLengthScrollBar.Value.ToString();
            tunnelAngleTextBox.Text = tunnelAngleScrollBar.Value.ToString();
            scaleTextBox.Text = (scaleScrollBar.Value / 100.0f).ToString();
            cameraPosXTextBox.Text = (-Camera.X).ToString();
            cameraPosYTextBox.Text = Camera.Y.ToString();
        }

        private void CreateTunnel()
        {
            Tunnel = new Tunnel(firstSectionLengthScrollBar.Value, secondSectionLengthScrollBar.Value,
                tunnelWidthScrollBar.Value, tunnelAngleScrollBar.Value);
            TunnelPos = new PointF(0.0f, 0.0f);
            tunnelSides = Tunnel.GetSides();
        }

        private void CreateWasher()
        {
            Washer = new Washer(0.0, 0.0, startSpeedScrollBar.Value, startAngleScrollBar.Value,
                (float)washerMassNumericUpDown.Value / 1000.0f, (float)washerRadiusNumericUpDown.Value / 100.0f);
            WasherPos = new PointF(startXPosScrollBar.Value / 100.0f, -5.0f - startYPosScrollBar.Value / 100.0f);
        }

        private void mainFieldPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            MouseDownPos = e.Location;
            CameraD = new PointF(0.0f, 0.0f);
            mainFieldPictureBox.Cursor = Cursors.Hand;
        }

        private void mainFieldPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            Camera = new PointF(Camera.X + CameraD.X, Camera.Y + CameraD.Y);
            CameraD = new PointF(0.0f, 0.0f);
            mainFieldPictureBox.Cursor = Cursors.Default;
        }

        private void mainFieldPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                CameraD = new PointF(e.X - MouseDownPos.X, e.Y - MouseDownPos.Y);
                PointF CameraConvert = new PointF(Camera.X + CameraD.X, Camera.Y + CameraD.Y);
                cameraPosXTextBox.Text = (-CameraConvert.X).ToString();
                cameraPosYTextBox.Text = CameraConvert.Y.ToString();
                DrawSafe();
            }
        }

        private void MainFieldPictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            scaleScrollBar.Value = Helper.LimitRange(scaleScrollBar.Value + e.Delta / 10, scaleScrollBar.Maximum, scaleScrollBar.Minimum);
        }

        private void startModButton_Click(object sender, EventArgs e)
        {
            if (modelingThread?.IsAlive == true) return;
            paramsGroupBox.Enabled = false;
            modelingThread = new Thread(StartModeling);
            modelingThread.Start();
        }

        private void StartModeling()
        {
            runModel();
            Form1.ActiveForm.BeginInvoke(new ModelingFinish(FinishTest));
            modelingThread.Abort();
        }

        public void ParamsGroupBoxReload()
        {
            
        }

        public void FinishTest()
        {
            MessageBox.Show("Пройденное расстояние: " + Math.Truncate(Washer.TotalDistance * 100.0) / 100.0 + "м.");
            paramsGroupBox.Enabled = true;
        }

        private void RunModelRealTime()
        {
            DateTime dTime;
            float frictionF = (float)frictionCoefNumericUpDown.Value * Washer.Mass * g;
            double dTimeMs = 1.0;
            do
            {
                dTime = DateTime.Now;
                Washer.Move(dTimeMs / 1000.0, frictionF);
                Washer.checkCollideSegments(tunnelSides, WasherPos, TunnelPos, WorldCenter);
                Draw();
                dTimeMs = (DateTime.Now - dTime).TotalMilliseconds;
            } while (!Washer.IsStopped);
        }

        private void RunModelFixStep()
        {
            float frictionF = (float)frictionCoefNumericUpDown.Value * Washer.Mass * g;
            double step = (float)stepNumericUpDown.Value;
            do
            {
                Washer.Move(step / 1000.0, frictionF);
                Washer.checkCollideSegments(tunnelSides, WasherPos, TunnelPos, WorldCenter);
                Draw();
            } while (!Washer.IsStopped);
        }
        private void Draw()
        {
            PointF WorldCamera = new PointF(WorldCenter.X + Camera.X + CameraD.X, WorldCenter.Y + Camera.Y + CameraD.Y);
            graphics.Clear(Color.White);
            Tunnel.Draw(graphics, TunnelPos, WorldCamera, PixelsPerMeter);
            Washer.Draw(graphics, WasherPos, WorldCamera, PixelsPerMeter, DrawPath, DrawChecks, TunnelPos);
            fG.DrawImage(btm, 0, 0);
        }
        private void DrawSafe()
        {
            if (modelingThread?.IsAlive == true) return;
            Draw();
        }
        private void drawChecksCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DrawChecks = drawChecksCheckBox.Checked;
            DrawSafe();
        }

        private void drawPathCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DrawPath = drawPathCheckBox.Checked;
        }

        private void useElTimeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (useElTimeRadioButton.Checked)
            {
                runModel -= RunModelFixStep;
                runModel += RunModelRealTime;
            }
        }

        private void useStepRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (useStepRadioButton.Checked)
            {
                runModel -= RunModelRealTime;
                runModel += RunModelFixStep;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (modelingThread?.IsAlive == true)
                modelingThread.Abort();
        }

        private void stopModButton_Click(object sender, EventArgs e)
        {
            modelingThread?.Abort();
            paramsGroupBox.Enabled = true;
            CreateWasher();
            DrawSafe();
        }

        private void CameraPosLabel_Click(object sender, EventArgs e)
        {
            Camera = new PointF(0.0f, 0.0f);
            DrawSafe();
        }
    }
}