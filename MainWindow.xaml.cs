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

namespace NPCManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class NPC
    {
        /// <summary>
        /// Every NPC needs a name, some stats, a profession and a description.
        /// </summary>
        string name;
        int[] stats;
        string profession;
        string description;

        public NPC(string n)
        {
            name = n;
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NPCAdd(object sender, RoutedEventArgs e)
        {
            npcNames.Items.Add("Test Test");
        }

        private void NPCDelete(object sender, RoutedEventArgs e)
        {
            if (npcNames.SelectedItem != null)
            {
                npcNames.Items.RemoveAt(npcNames.Items.IndexOf(npcNames.SelectedItem));                
            }            
        }
    }
}
