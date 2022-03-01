using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace CoursOpenCVcaracteres
{
    public partial class Form1 : Form
    {
        Image<Gray, Byte> gray;
        Image<Bgr, Byte> image;
        Image<Gray, byte> image1;
        Image<Gray, byte> image2;
        Emgu.CV.Util.VectorOfVectorOfPoint contours;
        Emgu.CV.OCR.Tesseract ocr;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"ia.jpg";
            image = new Image<Bgr, Byte>(path);
            pbImage.Image = image.ToBitmap();

            // On passe binarise l'imag
            gray = image.Convert<Gray, Byte>();
            image1 = gray.Convert<Gray, byte>();
            image1 = image1.ThresholdBinaryInv(new Gray(80), new Gray(255));
            pbTraitement1.Image = image1.ToBitmap();

            getStructuringElement();
        }

        private void getStructuringElement()
        {
            image2 = gray.Convert<Gray, byte>();

            Mat r = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(30, 30), new Point(0, 0));
            CvInvoke.Dilate(image1, image2, r, new Point(0, 0), 1, Emgu.CV.CvEnum.BorderType.Constant, CvInvoke.MorphologyDefaultBorderValue);
            pbTraitement2.Image = image2.ToBitmap();

            Mat hierarchy = new Mat();
             contours = new Emgu.CV.Util.VectorOfVectorOfPoint();

            CvInvoke.FindContours(image2, contours, hierarchy, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            MCvScalar redColor = new MCvScalar(0, 0, 255);
            CvInvoke.DrawContours(image, contours, -1, redColor, 4);
            pbImage.Image = image.ToBitmap();

            // instanciez un objet
            String path = Application.StartupPath + @"\tessdata"; // @ supprime caracter de control
            Console.WriteLine(path);
            ocr = new Emgu.CV.OCR.Tesseract(@path, "eng", Emgu.CV.OCR.OcrEngineMode.TesseractOnly);
            MCvScalar greenColor = new MCvScalar(0, 255, 0);

            /*
                        Rectangle rect = CvInvoke.BoundingRectangle(contours[0]);
                        MCvScalar greenColor = new MCvScalar(0, 255, 0);
                        CvInvoke.Rectangle(image, rect, greenColor, 5);
                        pbImage.Image = image.ToBitmap();

                        Image<Gray, Byte> imageCrop = image1;
                        imageCrop.ROI = rect;
                        pbTraitement3.Image = imageCrop.ToBitmap();

                        ocr.SetImage(imageCrop);
                        String ocrResult = ocr.GetUTF8Text();
                        txtResult.AppendText(ocrResult);
            */
            for (int i = 0; i < contours.Size; i++)
            {


                Rectangle rect = CvInvoke.BoundingRectangle(contours[contours.Size - i-1]);
                CvInvoke.Rectangle(image, rect, greenColor, 5);

                Image<Gray, Byte> imageCrop = image1;
                imageCrop.ROI = rect;
                ocr.SetImage(imageCrop);
                String ocrResult = ocr.GetUTF8Text();
                txtResult.AppendText(ocrResult.Replace("\n", " "));
                Emgu.CV.OCR.Tesseract.Character[] characters = ocr.GetCharacters();
                foreach (Emgu.CV.OCR.Tesseract.Character c in characters)
                {
                    txtResult2.AppendText(c.Text);
                }

            }

  
            

        }


    }
}
