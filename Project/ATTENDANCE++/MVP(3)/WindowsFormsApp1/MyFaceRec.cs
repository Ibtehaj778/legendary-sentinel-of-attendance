using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public class MyFaceRec: Form
	{
		private double distance = 1E+19;

		private CascadeClassifier CascadeClassifier = new CascadeClassifier(string.Concat(Environment.get_CurrentDirectory(), "E:\\ATTENDANCE++ (2)\\WindowsFormsApp1\\bin\\Debug\\Haarcascade"));

		private Image<Bgr, byte> Frame = null;

		private Capture camera;

		private Mat mat = new Mat();

		private List<Image<Gray, byte>> trainedFaces = new List<Image<Gray, byte>>();

		private List<int> PersonLabs = new List<int>();

		private bool isEnable_SaveImage = false;

		private string ImageName;

		private PictureBox PictureBox_Frame;

		private PictureBox PictureBox_smallFrame;

		private string setPersonName;

		public bool isTrained = false;

		private List<string> Names = new List<string>();

		private EigenFaceRecognizer eigenFaceRecognizer;

		private IContainer components = null;

		public MyFaceRec()
		{
			this.InitializeComponent();
			if (!Directory.Exists(string.Concat(Environment.get_CurrentDirectory(), "\\Image")))
			{
				Directory.CreateDirectory(string.Concat(Environment.get_CurrentDirectory(), "\\Image"));
			}
		}

		private void Camera_ImageGrabbed(object sender, EventArgs e)
		{
			this.camera.Retrieve(this.mat, 0);
			this.Frame = this.mat.ToImage<Bgr, byte>(false).Resize(this.PictureBox_Frame.get_Width(), this.PictureBox_Frame.get_Height(), Inter.Cubic);
			this.detectFace();
			this.PictureBox_Frame.set_Image(this.Frame.Bitmap);
		}

		private void checkName(Image<Bgr, byte> resultImage, Rectangle face)
		{
			Bgr bgr;
			try
			{
				if (this.isTrained)
				{
					Image<Gray, byte> image = resultImage.Convert<Gray, byte>().Resize(100, 100, Inter.Cubic);
					CvInvoke.EqualizeHist(image, image);
					FaceRecognizer.PredictionResult predictionResult = this.eigenFaceRecognizer.Predict(image);
					if ((predictionResult.Label == -1 ? true : predictionResult.Distance >= this.distance))
					{
						Image<Bgr, byte> frame = this.Frame;
						Point point = new Point(face.get_X() - 2, face.get_Y() - 2);
						bgr = new Bgr(Color.get_OrangeRed());
						CvInvoke.PutText(frame, "Unknown", point, FontFace.HersheyPlain, 1, bgr.MCvScalar, 1, LineType.EightConnected, false);
					}
					else
					{
						this.PictureBox_smallFrame.set_Image(this.trainedFaces.get_Item(predictionResult.Label).Bitmap);
						this.setPersonName = this.Names.get_Item(predictionResult.Label).Replace(string.Concat(Environment.get_CurrentDirectory(), "\\Image\\"), "").Replace(".jpg", "");
						Image<Bgr, byte> frame1 = this.Frame;
						string str = this.setPersonName;
						Point point1 = new Point(face.get_X() - 2, face.get_Y() - 2);
						bgr = new Bgr(Color.get_LimeGreen());
						CvInvoke.PutText(frame1, str, point1, FontFace.HersheyPlain, 1, bgr.MCvScalar, 1, LineType.EightConnected, false);
					}
				}
			}
			catch
			{
			}
		}

		private void detectFace()
		{
			Image<Bgr, byte> image = this.Frame.Convert<Bgr, byte>();
			Mat mat = new Mat();
			CvInvoke.CvtColor(this.Frame, mat, ColorConversion.Bgr2Gray, 0);
			CvInvoke.EqualizeHist(mat, mat);
			CascadeClassifier cascadeClassifier = this.CascadeClassifier;
			Size size = new Size();
			Size size1 = size;
			size = new Size();
			Rectangle[] rectangleArray = cascadeClassifier.DetectMultiScale(mat, 1.1, 4, size1, size);
			if (rectangleArray.Length == 0)
			{
				this.setPersonName = "";
			}
			else
			{
				Rectangle[] rectangleArray1 = rectangleArray;
				for (int i = 0; i < (int)rectangleArray1.Length; i++)
				{
					Rectangle rectangle = rectangleArray1[i];
					Image<Bgr, byte> frame = this.Frame;
					Bgr bgr = new Bgr(Color.get_LimeGreen());
					CvInvoke.Rectangle(frame, rectangle, bgr.MCvScalar, 2, LineType.EightConnected, 0);
					this.SaveImage(rectangle);
					image.ROI = rectangle;
					this.trainedIamge();
					this.checkName(image, rectangle);
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : (object)this.components != (object)null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		public void getPersonName(Control control)
		{
			FaceRec.u003cu003ec__DisplayClass14_0 variable = null;
			Timer timer = new Timer();
			timer.add_Tick(new EventHandler(variable, (object sender, EventArgs e) => this.control.set_Text(this.u003cu003e4__this.setPersonName)));
			timer.set_Interval(100);
			timer.Start();
		}

		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.set_AutoScaleDimensions(new SizeF(8f, 16f));
			base.set_AutoScaleMode(1);
			base.set_ClientSize(new Size(0x320, 0x1c2));
			base.set_Name("FaceRec");
			this.set_Text("FaceRec");
			base.ResumeLayout(false);
		}

		public void openCamera(PictureBox pictureBox_Camera, PictureBox pictureBox_Trained)
		{
			this.PictureBox_Frame = pictureBox_Camera;
			this.PictureBox_smallFrame = pictureBox_Trained;
			this.camera = new Capture();
			this.camera.ImageGrabbed += new EventHandler(this, FaceRec.Camera_ImageGrabbed);
			this.camera.Start();
		}

		public void Save_IMAGE(string imageName)
		{
			this.ImageName = imageName;
			this.isEnable_SaveImage = true;
		}

		private void SaveImage(Rectangle face)
		{
			if (this.isEnable_SaveImage)
			{
				Image<Bgr, byte> image = this.Frame.Convert<Bgr, byte>();
				image.ROI = face;
				image.Resize(100, 100, Inter.Cubic).Save(string.Concat(Environment.get_CurrentDirectory(), "\\Image\\", this.ImageName, ".jpg"));
				this.isEnable_SaveImage = false;
				this.trainedIamge();
			}
		}

		private void trainedIamge()
		{
			try
			{
				int num = 0;
				this.trainedFaces.Clear();
				this.PersonLabs.Clear();
				this.Names.Clear();
				string[] files = Directory.GetFiles(string.Concat(Directory.GetCurrentDirectory(), "\\Image"), "*.jpg", 1);
				string[] strArray = files;
				for (int i = 0; i < (int)strArray.Length; i++)
				{
					string str = strArray[i];
					Image<Gray, byte> image = new Image<Gray, byte>(str);
					this.trainedFaces.Add(image);
					this.PersonLabs.Add(num);
					this.Names.Add(str);
					num++;
				}
				this.eigenFaceRecognizer = new EigenFaceRecognizer(num, this.distance);
				this.eigenFaceRecognizer.Train<Gray, byte>(this.trainedFaces.ToArray(), this.PersonLabs.ToArray());
			}
			catch
			{
			}
		}
	}
}

