using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace EBSİmageYazıYazma
{
    public class EbsFacebookProfilİmageCreater
    {

        static OpenFileDialog op;
        static Brush[] brushes = new Brush[] {
        Brushes.Transparent,
        Brushes.Orchid      ,
        Brushes.OrangeRed ,
        Brushes.Orange      ,
        Brushes.OliveDrab   ,
        Brushes.Olive        ,
        Brushes.OldLace     ,
        Brushes.Navy        ,
        Brushes.NavajoWhite,
        Brushes.Moccasin    ,
        Brushes.MistyRose  ,
        Brushes.MintCream ,
        Brushes.MidnightBlue,
        Brushes.MediumVioletRed,
        Brushes.MediumTurquoise,
        Brushes.MediumSpringGreen,
        Brushes.MediumSlateBlue,
        Brushes.MediumSeaGreen,
        Brushes.LightSeaGreen   ,
        Brushes.LightSkyBlue,
        Brushes.LightSlateGray   ,
        Brushes.LightSteelBlue   ,
        Brushes.LightYellow ,
        Brushes.Lime         ,
        Brushes.PaleGoldenrod    ,
        Brushes.LimeGreen  ,
        Brushes.Magenta    ,
        Brushes.Maroon     ,
        Brushes.MediumAquamarine,
        Brushes.MediumBlue,
        Brushes.MediumOrchid    ,
        Brushes.MediumPurple    ,
        Brushes.Linen        ,
        Brushes.PaleGreen  ,
        Brushes.PaleTurquoise    ,
        Brushes.PaleVioletRed    ,
        Brushes.SlateBlue   ,
        Brushes.SlateGray  ,
        Brushes.Snow        ,
        Brushes.SpringGreen,
        Brushes.SteelBlue   ,
        Brushes.Tan          ,
        Brushes.SkyBlue     ,
        Brushes.Teal         ,
        Brushes.Tomato     ,
        Brushes.Turquoise   ,
        Brushes.Violet       ,
        Brushes.Wheat      ,
        Brushes.White       ,
        Brushes.WhiteSmoke,
        Brushes.Thistle      ,
        Brushes.LightSalmon,
        Brushes.Silver       ,
        Brushes.SeaShell    ,
        Brushes.PapayaWhip,
        Brushes.PeachPuff  ,
        Brushes.Peru         ,
        Brushes.Pink         ,
        Brushes.Plum         ,
        Brushes.PowderBlue ,
        Brushes.Sienna      ,
        Brushes.Purple       ,
        Brushes.RosyBrown  ,
        Brushes.RoyalBlue   ,
        Brushes.SaddleBrown,
        Brushes.Salmon      ,
        Brushes.SandyBrown,
        Brushes.SeaGreen   ,
        Brushes.Red          ,
        Brushes.Yellow       ,
        Brushes.LightPink    ,
        Brushes.LightGreen ,
        Brushes.DarkOrchid ,
        Brushes.DarkOrange,
        Brushes.DarkOliveGreen  ,
        Brushes.DarkMagenta    ,
        Brushes.DarkKhaki  ,
        Brushes.DarkGreen  ,
        Brushes.DarkGray   ,
        Brushes.DarkGoldenrod   ,
        Brushes.DarkCyan   ,
        Brushes.DarkBlue    ,
        Brushes.Cyan        ,
        Brushes.Crimson     ,
        Brushes.Cornsilk     ,
        Brushes.CornflowerBlue   ,
        Brushes.Coral        ,
        Brushes.Chocolate   ,
        Brushes.Chartreuse ,
        Brushes.AliceBlue   ,
        Brushes.AntiqueWhite    ,
        Brushes.Aqua        ,
        Brushes.Aquamarine ,
        Brushes.Azure       ,
        Brushes.Beige        ,
        Brushes.DarkRed    ,
        Brushes.Bisque       ,
        Brushes.BlanchedAlmond  ,
        Brushes.Blue         ,
        Brushes.BlueViolet  ,
        Brushes.Brown       ,
        Brushes.BurlyWood  ,
        Brushes.CadetBlue  ,
        Brushes.Black        ,
        Brushes.DarkSalmon,
        Brushes.DarkSeaGreen   ,
        Brushes.DarkSlateBlue   ,
        Brushes.Honeydew  ,
        Brushes.HotPink     ,
        Brushes.IndianRed  ,
        Brushes.Indigo       ,
        Brushes.Ivory        ,
        Brushes.Khaki        ,
        Brushes.GreenYellow,
        Brushes.Lavender    ,
        Brushes.LawnGreen  ,
        Brushes.LemonChiffon    ,
        Brushes.LightBlue   ,
        Brushes.LightCoral  ,
        Brushes.LightCyan   ,
        Brushes.LightGoldenrodYellow ,
        Brushes.LavenderBlush    ,
        Brushes.LightGray   ,
        Brushes.Green       ,
        Brushes.Goldenrod   ,
        Brushes.DarkSlateGray   ,
        Brushes.DarkTurquoise   ,
        Brushes.DarkViolet  ,
        Brushes.DeepPink    ,
        Brushes.DeepSkyBlue,
        Brushes.DimGray    ,
        Brushes.Gray        ,
        Brushes.DodgerBlue ,
        Brushes.FloralWhite,
        Brushes.ForestGreen,
        Brushes.Fuchsia     ,
        Brushes.Gainsboro   ,
        Brushes.GhostWhite,
        Brushes.Gold         ,
        Brushes.Firebrick    ,
        Brushes.YellowGreen,
        };
        private static int xcolorr;
        private static int xboyut;
        private static int xfonttt;
        private static int xkordinati;
        private static int ykordinati;
        private static string isim;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pc"></param>
        /// <param name="txtx"></param>
        /// <param name="txty"></param>
        /// <param name="txtad"></param>
        /// <param name="txtsoyad"></param>
        /// <param name="kaydedilecekyol"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void create(PictureBox pc, TextBox txtx, TextBox txty, TextBox txtad, TextBox txtsoyad, string kaydedilecekyol, int x, int y )
        {
            try
            {
                Bitmap bp = new Bitmap(pc.Image, new Size(x, y));
                for (int i = 0; i < 60; i++)
                {
                    Random rnd = new Random();
                    xcolorr = rnd.Next(0, brushes.Length);
                    xboyut = rnd.Next(10, 15);
                    xfonttt = rnd.Next(0, FontFamily.Families.Length);
                    xkordinati = rnd.Next(0, 110);
                    txtx.Text = xkordinati.ToString();
                    ykordinati = rnd.Next(0, 260);
                    txty.Text = ykordinati.ToString();
                    using (Graphics g = Graphics.FromImage(bp))
                    {
                        using (Font myFont = new Font(FontFamily.Families[xfonttt], xboyut))
                        {
                            g.DrawString(txtad.Text + " " + txtsoyad.Text, myFont, brushes[xcolorr], new Point(int.Parse(txtx.Text), int.Parse(txty.Text)));
                        }
                    }
                    Thread.Sleep(50);

                }
                if (kaydedilecekyol=="")
                {
                    kaydedilecekyol = Application.StartupPath + @"\EBS" + ".jpg";
                }
                bp.Save(kaydedilecekyol);
                pc.ImageLocation = kaydedilecekyol;
                MessageBox.Show("Resim Oluşturuldu","EBS Time");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ebs Time");

            }
        }
    }
}
