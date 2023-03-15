using System.Security.Cryptography.X509Certificates;
using static List;
namespace ЛР4
{
    public partial class Form1 : Form
    {
        MyList<Ccircle> list = new MyList<Ccircle>();
        public class Ccircle
        {
            public int r = 50;
            public int x;
            public int y;
            public Ccircle(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void paint_Ccircle(PaintEventArgs e)
            {
                e.Graphics.FillEllipse(Brushes.Red, x - r/2, y - r/2, r, r);
            }
        }
//        Ccircle c = new Ccircle(10, 50);
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_paint_Click(object sender, EventArgs e)
        {
            pict_box.Refresh();
        }

        private void pict_box_MouseClick(object sender, MouseEventArgs e)
        {
            Ccircle c = new Ccircle(e.X, e.Y);
            list.PushBack(c);
            pict_box.Refresh();
           
        }

        private void pict_box_Paint(object sender, PaintEventArgs e)
        {
            for (Node<Ccircle> i = list.first; i!= null; i = i.pos)
            {
                i.val.paint_Ccircle(e);
            }
        }
    }
}