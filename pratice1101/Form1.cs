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
            datebirth bt = delegate (int i)               //�ΦW��k
            {
                int birth = DateTime.Now.Year - i;
                MessageBox.Show($"���~{i}��,�X�ͩ�{birth}�~");   
                

            };
            bt.Invoke(32);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            birthtime a;                      //�e��a 
            a = (int year, int age) => { return year - age; };
            int lamba1 = a(DateTime.Now.Year, 12);                  //���^�ǭȱo
            MessageBox.Show($"{lamba1}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
        }

        //�@�ʭӫ��s



        //���եΥά�











    }
}