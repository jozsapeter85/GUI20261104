namespace GUI20261104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbnumin.TextChanged += Tbnumin_TextChanged;
        }

        private void Tbnumin_TextChanged(object? sender, EventArgs e)
        {
            lbdivisor.Items.Clear();
            bool isValid = int.TryParse(tbnumin.Text, out int numin);
            if (!isValid)return;
            List<int> divisors = new List<int>();
            for (int x = 1; x <= numin/2; x++)
            {
                if (numin % x == 0)
                {
                    lbdivisor.Items.Add(x);
                }
            }
            if (numin != 0) lbdivisor.Items.Add(numin);
               

        }
    }
}
