using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SpeechLib;
using AIMLbot;
using System.Runtime.InteropServices;

namespace Missy_AutonomousComputerProgram
{
    [SerializableAttribute]
    [ComVisibleAttribute(true)]
    public sealed class TargetInvocationException : ApplicationException
    { }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AIMLbot.Bot bot;
        public AIMLbot.User user;
        public MainWindow()
        {
            bot = new Bot();
            user = new User("DefaultUser", bot);
            bot.loadSettings();
            AIMLbot.Utils.AIMLLoader loader = new AIMLbot.Utils.AIMLLoader(bot);
            bot.isAcceptingUserInput = false;
            loader.loadAIML(bot.PathToAIML);
            bot.isAcceptingUserInput = true;
            
            InitializeComponent();
        }
        
        
        public string getoutput(string Input)
        {

            SpeechLib.SpVoice synth = new SpeechLib.SpVoice();
            Request request = new Request(Input, user, bot);
            Result result = bot.Chat(request);
            synth.Speak(result.Output, (SpeechVoiceSpeakFlags.SVSFDefault));
            return(result.Output);
        }
        String Input = null;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            
                Input = textBox.Text;
                textBlock.Text = getoutput(Input);
                textBox.Text = "";
                
            
        }
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Input = textBox.Text;
                textBlock.Text = getoutput(Input);
                textBox.Text = "";

            }
        }
    }
}
