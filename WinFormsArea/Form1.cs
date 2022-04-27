using CalcArea;
using System.Text.RegularExpressions;

namespace WinFormsArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            Load += new EventHandler(Form1_Load);

            triangleC.TextChanged += new EventHandler(TriangleCalc_Clear);
            triangleC.TextChanged += new EventHandler(TextDigital_Changed);
            triangleB.TextChanged += new EventHandler(TriangleCalc_Clear);
            triangleB.TextChanged += new EventHandler(TextDigital_Changed);
            triangleA.TextChanged += new EventHandler(TriangleCalc_Clear);
            triangleA.TextChanged += new EventHandler(TextDigital_Changed);
            triangleCalc.Click += new EventHandler(TriangleCalc_Click);

            circleR.TextChanged += new EventHandler(CircleCalc_Clear);
            circleR.TextChanged += new EventHandler(TextDigital_Changed);
            circleCalc.Click += new EventHandler(CircleCalc_Click);
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
        }

        private void TriangleCalc_Clear(object? sender, EventArgs e)
        {
            triangleInfo.Text = "";
            triangleArea.Text = "";
        }

        private void TextDigital_Changed(object? sender, EventArgs args)
        {
            var tb = sender as TextBox;
            if (tb == null)
                return;
            if (string.IsNullOrEmpty(tb.Text))
                return;
            var regexTemplate = $@"[^0-9\{Global.DecimalSeparator}E\+]";
            var clearedText = Regex.Replace(tb.Text, regexTemplate, string.Empty);
            var parts = clearedText.Split(Global.DecimalSeparator);
            if (parts.Length > 1)
                clearedText = parts[0] + Global.DecimalSeparator + string.Join("", parts.Skip(1));
            if (string.CompareOrdinal(tb.Text, clearedText) == 0)
                return;
            var sstart = tb.SelectionStart;
            tb.Text = clearedText;
            if (sstart > 0)
                tb.SelectionStart = Math.Min(sstart - 1, tb.Text.Length);
        }

        private void TriangleCalc_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(triangleA.Text, out var a))
                    throw new Exception("Укажите сторону a");
                if (!double.TryParse(triangleB.Text, out var b))
                    throw new Exception("Укажите сторону b");
                if (!double.TryParse(triangleC.Text, out var c))
                    throw new Exception("Укажите сторону c");
                var t = new Triangle(a, b, c);
                triangleArea.Text = t.Area().ToString();
                triangleA.Text = a.ToString();
                triangleB.Text = b.ToString();
                triangleC.Text = c.ToString();
                triangleInfo.Text = t.IsRectangular() ? "Треугольник прямоугольный" : "";
            }
            catch (Exception ex)
            {
                triangleInfo.Text = ex.Message;
            }
        }

        private void CircleCalc_Clear(object? sender, EventArgs e)
        {
            circleInfo.Text = "";
            circleArea.Text = "";
        }

        private void CircleCalc_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(circleR.Text, out var r))
                    throw new Exception("Укажите радиус. Ошибка определения радиуса.");
                var c = new Circle(r);
                circleArea.Text = c.Area().ToString();
                circleR.Text = r.ToString();
            }
            catch (Exception ex)
            {
                circleInfo.Text = ex.Message;
            }
        }
    }
}