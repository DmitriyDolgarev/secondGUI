namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = Properties.Settings.Default.text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string message=TextLogic.ChangeText(text);
            textBox1.Text = message;

            Properties.Settings.Default.text = message;
            Properties.Settings.Default.Save();
        }
    }
    public class TextLogic
    {
        public static string ChangeText(string text)
        {
            string[] words = text.Split(" ");

            List<string> newText = new List<string>();
            string newWord;
            foreach (string word in words)
            {
                if (word.Length % 2 != 0)
                {
                    newWord = word.Replace('d', 't');
                    newText.Add(newWord);
                    newText.Add(newWord);
                }
            }
            string outText = "";
            foreach (string word in newText)
            {
                outText += word + " ";
            }
            return outText;
        }
    }
}
