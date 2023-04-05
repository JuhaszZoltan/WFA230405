namespace WFA230405
{
    public partial class FrmMain : Form
    {
        public static Random rnd = new();
        public Button[,] GombMatrix { get; set; }

        public FrmMain()
        {
            InitializeComponent();
            btnGeneral.Click += OnBtnGeneralClick;
            numSorSzam.Value = 5;
            numOszlopSzam.Value = 10;
        }

        private void OnBtnGeneralClick(object? sender, EventArgs e)
        {
            pnlMain.Controls.Clear();

            int s = (int)numSorSzam.Value;
            int o = (int)numOszlopSzam.Value;
            GombMatrix = new Button[s, o];

            GombMatrixFeltoltese(100);
        }

        private void GombMatrixFeltoltese(int arany = 50)
        {


            for (int s = 0; s < GombMatrix.GetLength(0); s++)
            {
                for (int o = 0; o < GombMatrix.GetLength(1); o++)
                {
                    GombMatrix[s, o] = new()
                    {
                        BackColor = rnd.Next(2) == 0 ? Color.Blue : Color.Red,
                        Font = new(familyName: "Consolas", emSize: 12F),
                        ForeColor = Color.White,
                        Location = new(x: o * arany, y: s * arany),
                        Size = new(width: arany, height: arany),
                        //Text = $"[s:{s}; o:{o}]",
                    };

                    GombMatrix[s, o].Click += OnMatrixButtonClick;

                    pnlMain.Controls.Add(GombMatrix[s, o]);
                }
            }
        }

        private void OnMatrixButtonClick(object? sender, EventArgs e)
        {
            Button btn = (sender as Button)!;
            (int s, int o) = HolVan(btn);

            SzinValt(btn);
            if (s != 0) SzinValt(GombMatrix[s - 1, o]);
            if (o != 0) SzinValt(GombMatrix[s, o - 1]);
            if (s < GombMatrix.GetLength(0) - 1) SzinValt(GombMatrix[s + 1, o]);
            if (o < GombMatrix.GetLength(1) - 1) SzinValt(GombMatrix[s, o + 1]);

            if(WinCheck()) MessageBox.Show("nyerté'!");
        }

        private bool WinCheck()
        {
            Color nysz = GombMatrix[0, 0].BackColor;
            foreach (Button btn in GombMatrix)
            {
                if (btn.BackColor != nysz) return false;
            }
            return true;
        }

        private void SzinValt(Button button)
        {
            button.BackColor = button.BackColor == Color.Blue
                ? Color.Red
                : Color.Blue;
        }

        private (int s, int o) HolVan(Button button)
        {
            for (int s = 0; s < GombMatrix.GetLength(0); s++)
            {
                for (int o = 0; o < GombMatrix.GetLength(1); o++)
                {
                    if (GombMatrix[s, o] == button) return (s, o);
                }
            }
            throw new Exception("hiba, de ez ugyse fordulhat elõ :p");
        }
    }
}