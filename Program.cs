using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
public class MainForm : Form
{
    private TextBox textBox;
    private Button submitButton;
    private Label outputLabel;

    public MainForm()
    {
        this.Text = "Input Nama Praktikan";
        this.Size = new System.Drawing.Size(300, 200);

        textBox = new TextBox { Width = 200, Top = 20, Left = 50 };
        submitButton = new Button { Text = "Submit/Kirim", Width = 100, Top = 20, Left = 270 };
        outputLabel = new Label { Text = "", Top = 55, Left = 50, Width = 200 };

        submitButton.Click += OnSubmit;

        this.Controls.Add(textBox);
        this.Controls.Add(submitButton);
        this.Controls.Add(outputLabel);
    }

    private void OnSubmit(object sender, EventArgs e)
    {
        string name = textBox.Text;
        if (!string.IsNullOrEmpty(name))
        {
            outputLabel.Text = $"Halo {name} -!";
        }
        else
        {
            outputLabel.Text = "Silakan masukkan nama";
        }
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new MainForm());
    }
}
