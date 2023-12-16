namespace WinFormsApp11
{
    public partial class   Form1 : Form
    {
        private Button colorButton;

        public Form1()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            colorButton = new Button();
            colorButton.Text = "Выбрать цвет";
            colorButton.Size = new Size(150, 30);
            colorButton.Location = new Point((ClientSize.Width - colorButton.Width) / 2, (ClientSize.Height - colorButton.Height) / 2);
            colorButton.Click += ColorButton_Click;

            Controls.Add(colorButton);
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            // Создаем новый ColorDialog
            using (ColorDialog colorDialog = new ColorDialog())
            {
                // Открываем диалог выбора цвета
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Изменяем цвет фона формы на выбранный цвет
                    BackColor = colorDialog.Color;
                }
            }
        }
    }
}
