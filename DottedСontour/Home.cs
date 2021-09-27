using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DottedСontour
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            g = CreateGraphics();
            g.Clear(Color.Azure);
            polygon = new List<Point>();
        }
        Graphics g;
        List<Point> polygon;
        Point point;

        public void DrawingPolygon()
        {
            g.Clear(Color.Azure);
            foreach (var item in polygon)
            {
                int v = polygon.IndexOf(item) + 1;
                if (polygon.Count == v) { g.DrawLine(Pens.Green, polygon[v - 1], polygon[0]); }
                else g.DrawLine(Pens.Black, item, polygon[v]);
            }
            if(point != new Point()) g.DrawEllipse(Pens.Red, point.X, point.Y, 5, 5);
            else labelInfoPoint.Text = "Точка не указана";
        }
        public void ReadingFileXML(string fileName)
        {
            polygon = new List<Point>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fileName);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                Point point = new Point();
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "positionX")
                    {
                        point.X = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "positionY")
                    {
                        point.Y = Convert.ToInt32(childnode.InnerText);
                    }
                }
                polygon.Add(point);
            }
            point = new Point();
            labelInfoPoint.Text = "Точка не указана";
            DrawingPolygon();
        }
        public void WriteFileXML(string fileName)
        {
            XDocument xdoc = new XDocument();
            XElement points = new XElement("points");

            foreach (var item in polygon)
            {
                XElement point = new XElement("point");
                XElement positionX = new XElement("positionX", item.X.ToString());
                XElement positionY = new XElement("positionY", item.Y.ToString());
                point.Add(positionX);
                point.Add(positionY);
                points.Add(point);
            }

            xdoc.Add(points);
            xdoc.Save(fileName);

        }
        private void Home_MouseClick(object sender, MouseEventArgs e)
        {
            Point click = e.Location;
            if (radioButtonPolygon.Checked)
            {
                polygon.Add(new Point(click.X, click.Y));
                DrawingPolygon();
                if (point != new Point())
                {
                    bool res = IsPointInPolygon(polygon.ToArray(), new Point(point.X, point.Y));
                    if (res) labelInfoPoint.Text = "Точка внутри";
                    else labelInfoPoint.Text = "Точка снаружи";
                }
            }
            else
            {
                point = click;
                DrawingPolygon();
                bool res = IsPointInPolygon(polygon.ToArray(), new Point(point.X, point.Y));
                if (res) labelInfoPoint.Text = "Точка внутри";
                else labelInfoPoint.Text = "Точка снаружи";
            }
            
        }

        public static bool IsPointInPolygon(Point[] poly, Point p)
        {
            Point p1, p2;
            bool inside = false;

            if (poly.Length < 3)
            {
                return inside;
            }

            var oldPoint = new Point(
                poly[poly.Length - 1].X, poly[poly.Length - 1].Y);

            for (int i = 0; i < poly.Length; i++)
            {
                var newPoint = new Point(poly[i].X, poly[i].Y);

                if (newPoint.X > oldPoint.X)
                {
                    p1 = oldPoint;
                    p2 = newPoint;
                }
                else
                {
                    p1 = newPoint;
                    p2 = oldPoint;
                }

                if ((newPoint.X < p.X) == (p.X <= oldPoint.X)
                    && (p.Y - (long)p1.Y) * (p2.X - p1.X)
                    < (p2.Y - (long)p1.Y) * (p.X - p1.X))
                {
                    inside = !inside;
                }

                oldPoint = newPoint;
            }

            return inside;
        }
        private void buttonDownloadXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "xml files|*.xml";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                ReadingFileXML(OPF.FileName);
            }
        }

        private void buttonSaveXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xml files (*.xml)|*.xml";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            WriteFileXML(filename);
        }

        private void buttonСancel_Click(object sender, EventArgs e)
        {
            polygon.RemoveAt(polygon.Count - 1);
            DrawingPolygon();
        }

        private void buttonCleaning_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Azure);
            polygon = new List<Point>();
            point = new Point();
            labelInfoPoint.Text = "Точка не указана";
        }

        private void radioButtonPoint_CheckedChanged(object sender, EventArgs e)
        {
            buttonСancel.Visible = false;
            buttonCleaning.Visible = false;
        }

        private void radioButtonPolygon_CheckedChanged(object sender, EventArgs e)
        {
            buttonСancel.Visible = true;
            buttonCleaning.Visible = true;
        }

        private void Home_ResizeEnd(object sender, EventArgs e)
        {
            DrawingPolygon();
        }

        private void Home_ResizeBegin(object sender, EventArgs e)
        {
            DrawingPolygon();
        }

        private void Home_SizeChanged(object sender, EventArgs e)
        {
            if(g != null) DrawingPolygon();
        }
    }
}
