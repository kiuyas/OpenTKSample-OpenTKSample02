using System;
using System.Drawing;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace OpenTKSample02
{
    public partial class Form1 : Form
    {
        #region 定数フィールド

        /// <summary>Fovy以外の各パラメータに指定できる最大値</summary>
        private const float MAX = 65;

        /// <summary>Fovy以外の各パラメータの精度</summary>
        private const float TICK = 0.01F;

        /// <summary>Fovy以外の各パラメータのトラックバーの最大値</summary>
        private const float TRACKBAR_MAX = MAX * (1 / TICK);

        #endregion

        #region フィールド

        /// <summary>目の位置X座標</summary>
        private float eyeX = 0;

        /// <summary>目の位置Y座標</summary>
        private float eyeY = 0;

        /// <summary>目の位置X座標</summary>
        private float eyeZ = 0;

        /// <summary>注視点位置X座標</summary>
        private float targetX = 0;

        /// <summary>注視点位置Y座標</summary>
        private float targetY = 0;

        /// <summary>注視点位置Z座標</summary>
        private const float TARGET_Z = 0;

        /// <summary>目の向きX座標</summary>
        private const float UP_X = 0;

        /// <summary>目の向きY座標</summary>
        private const float UP_Y = 1;

        /// <summary>目の向きZ座標</summary>
        private const float UP_Z = 0;

        /// <summary>旋回角(Z軸周りの回転角)</summary>
        private int alpha = 0;

        /// <summary>仰俯角(X軸周りの回転角)</summary>
        private int beta = 0;

        /// <summary>トラックバーオブジェクト群</summary>
        private TrackBar[] trackbars;

        /// <summary>値表示ラベルオブジェクト群</summary>
        private Label[] labels;

        /// <summary>マウスドラッグ開始点X座標</summary>
        private int startX = -1;

        /// <summary>マウスドラッグ開始点Y座標</summary>
        private int startY = -1;

        /// <summary>マウスドラッグ開始時EyeX</summary>
        private float startEyeX = 0;

        /// <summary>マウスドラッグ開始時EyeY</summary>
        private float startEyeY = 0;

        /// <summary>マウスドラッグ開始時Alpha</summary>
        private float startAlpha = 0;

        /// <summary>マウスドラッグ開始時Beta</summary>
        private float startBeta = 0;

        #endregion

        #region 初期処理

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        /// <summary>
        /// 初期処理
        /// </summary>
        private void Initialize()
        {
            trackbars = new TrackBar[] { trbEyeX, trbEyeY, trbEyeZ,
                trbTargetX, trbTargetY, trbAlpha, trbBeta };
            labels = new Label[] { lblEyeX, lblEyeY, lblEyeZ,
                lblTargetX, lblTargetY, lblAlpha, lblBeta };

            for (int i = 0; i < trackbars.Length; i++)
            {
                trackbars[i].Minimum = -(int)TRACKBAR_MAX;
                trackbars[i].Maximum = (int)TRACKBAR_MAX;
            }

            glControl1.MouseWheel += new MouseEventHandler(glControl1_MouseWheel);
            MouseWheel += new MouseEventHandler(glControl1_MouseWheel);

            ResetParameters();
            SetTrackBars();
            ShowParameters();
        }

        /// <summary>
        /// パラメータの初期化
        /// </summary>
        private void ResetParameters()
        {
            eyeX = 0;
            eyeY = 0;
            eyeZ = 5;
            targetX = 0;
            targetY = 0;
            alpha = 0;
            beta = 0;
        }

        #endregion

        #region 描画処理

        /// <summary>
        /// 描画処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            GLControl canvas = sender as GLControl;

            // 初期化
            InitFor3D(canvas.Width, canvas.Height);

            // 平面を描く
            DrawSurface();

            // 描画結果を反映させる
            canvas.SwapBuffers();
        }

        /// <summary>
        /// 三次元描画用に初期化する
        /// </summary>
        /// <param name="width">描画領域幅</param>
        /// <param name="height">描画領域高さ</param>
        private void InitFor3D(float width, float height)
        {
            // クリア
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            // ビューポートの設定
            GL.Viewport(0, 0, (int)width, (int)height);

            // 視点の設定
            Matrix4 modelView = Matrix4.LookAt(eyeX, eyeY, eyeZ, targetX, targetY, TARGET_Z, UP_X, UP_Y, UP_Z);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelView);

            // 射影の設定
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, width / height, 1.0f, 64.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);

            // 物体の回転
            GL.Translate(-eyeX, -eyeY, -eyeZ);
            GL.Rotate(alpha, new Vector3d(0, 0, 1));
            GL.Rotate(beta, new Vector3d(1, 0, 0));
            GL.Translate(eyeX, eyeY, eyeZ);
        }

        /// <summary>
        /// 度数をラジアンに変換する
        /// </summary>
        /// <param name="degree">度数値</param>
        /// <returns>ラジアン値</returns>
        private float Deg2Rad(int degree)
        {
            return (float)(degree * Math.PI / 180);
        }

        /// <summary>
        /// 平面を描く
        /// </summary>
        private void DrawSurface()
        {
            GL.Color3(Color.Lime);
            GL.Begin(PrimitiveType.Lines);

            for (float i = -1; i <= 1.1; i += 0.1F)
            {
                GL.Vertex3(-1, i, 0);
                GL.Vertex3(1, i, 0);

                GL.Vertex3(i, -1, 0);
                GL.Vertex3(i, 1, 0);
            }

            GL.End();

            GL.Begin(PrimitiveType.TriangleFan);

            GL.Vertex3(0, 0.95, 0);
            GL.Vertex3(-0.05, 0.85, 0);
            GL.Vertex3(0.05, 0.85, 0);

            GL.End();
        }

        #endregion

        #region イベント処理

        /// <summary>
        /// トラックバースクロール時処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            eyeX = trbEyeX.Value * TICK;
            eyeY = trbEyeY.Value * TICK;
            eyeZ = trbEyeZ.Value * TICK;
            targetX = trbTargetX.Value * TICK;
            targetY = trbTargetY.Value * TICK;
            alpha = trbAlpha.Value;
            beta = trbBeta.Value;

            if (sender == trbEyeX || sender == trbEyeY)
            {
                targetX = eyeX;
                targetY = eyeY;
            }
            else if (sender == trbTargetX || sender == trbTargetY)
            {
                eyeX = targetX;
                eyeY = targetY;
            }

            ShowParameters();
            glControl1.Invalidate();
        }

        /// <summary>
        /// トラックバーに値を設定する
        /// </summary>
        private void SetTrackBars()
        {
            float[] values = { eyeX, eyeY, eyeZ, targetX, targetY, alpha, beta };
            for (int i = 0; i < trackbars.Length; i++)
            {
                trackbars[i].Scroll -= new EventHandler(trackBar_Scroll);
                if (i < trackbars.Length - 2)
                {
                    trackbars[i].Value = (int)(values[i] / TICK);
                }
                else
                {
                    trackbars[i].Value = (int)(values[i]);
                }
                trackbars[i].Scroll += new EventHandler(trackBar_Scroll);
            }
        }

        /// <summary>
        /// パラメータの値をラベルに表示する
        /// </summary>
        private void ShowParameters()
        {
            float[] values = { eyeX, eyeY, eyeZ, targetX, targetY, alpha, beta };

            for (int i = 0; i < labels.Length; i++)
            {
                if (i < trackbars.Length - 2)
                {
                    labels[i].Text = values[i].ToString("F2");
                }
                else
                {
                    labels[i].Text = values[i].ToString();
                }
            }
        }

        /// <summary>
        /// リセットボタン押下時処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetParameters();
            SetTrackBars();
            ShowParameters();
            glControl1.Invalidate();
        }

        #endregion

        #region イベント処理

        private void glControl1_SizeChanged(object sender, EventArgs e)
        {
            glControl1.Invalidate();
        }

        private void glControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            eyeZ += e.Delta * 0.01F;
            if (eyeZ < trbEyeZ.Minimum * TICK)
            {
                eyeZ = trbEyeZ.Minimum * TICK;
            }
            else if (eyeZ > trbEyeZ.Maximum * TICK)
            {
                eyeZ = trbEyeZ.Maximum * TICK;
            }
            SetTrackBars();
            ShowParameters();
            glControl1.Invalidate();
        }

        private void glControl1_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;

            if (e.Button == MouseButtons.Left)
            {
                startEyeX = eyeX;
                startEyeY = eyeY;
            }
            else if (e.Button == MouseButtons.Right)
            {
                startAlpha = alpha;
                startBeta = beta;
            }
        }

        private void glControl1_MouseMove(object sender, MouseEventArgs e)
        {
            int vx = e.X - startX;
            int vy = e.Y - startY;

            if (e.Button == MouseButtons.Left)
            {
                MoveEye(vx, vy);
            }
            else if (e.Button == MouseButtons.Right)
            {
                RotateObj(vx, vy);
            }
        }

        private void MoveEye(int vx, int vy)
        {
            eyeX = startEyeX - vx * 0.01F; ;
            eyeY = startEyeY + vy * 0.01F; ;
            targetX = eyeX;
            targetY = eyeY;

            SetTrackBars();
            ShowParameters();
            glControl1.Invalidate();
        }

        private void RotateObj(int vx, int vy)
        {
            if (Math.Abs(vx) < 16)
            {
                vx = 0;
            }
            if (Math.Abs(vy) < 16)
            {
                vy = 0;
            }

            alpha = (int)(startAlpha + vx);
            beta = (int)(startBeta + vy);

            SetTrackBars();
            ShowParameters();
            glControl1.Invalidate();
        }

        #endregion
    }
}
