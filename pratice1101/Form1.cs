namespace pratice1101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void toometh(int i);
        public delegate void datebirth(int i);
        public delegate int birthtime(int Nowyear, int age);

        private void button1_Click(object sender, EventArgs e)
        {
            toometh a = new toometh(meth01);
            a.Invoke(30);
            toometh b = meth02;
            b(40);
            toometh c = meth03;
            c(50);



        }

        public void meth01(int i)
        {
            MessageBox.Show(i.ToString());
        }
        public void meth02(int i)
        {
            i = i + 1;
            MessageBox.Show(i.ToString());
        }
        public void meth03(int i)
        {
            i = i + 2;
            MessageBox.Show(i.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            datebirth bt = delegate (int i)               //匿名方法
            {
                int birth = DateTime.Now.Year - i;
                MessageBox.Show($"今年{i}歲,出生於{birth}年");   
                

            };
            bt.Invoke(32);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            birthtime a;                      //委派a 
            a = (int year, int age) => { return year - age; };
            int lamba1 = a(DateTime.Now.Year, 12);                  //有回傳值得
            MessageBox.Show($"{lamba1}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
        }

        //一百個按鈕



        //測試用用看











    }
}