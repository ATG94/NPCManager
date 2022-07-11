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
        int[] stats = new int[6];
        string profession;
        string description;
        string race;

        public NPC(string n)
        {
            name = n;
            Random rnd = new Random();
            for (int i=0; i<6; i++)
            {
                this.stats[i]=rnd.Next(1, 6)+ rnd.Next(1, 6)+ rnd.Next(1, 6);
            }
        }
        public string GetName() => name;
        public int[] GetStats() => stats;
        public string GetProfession() => profession;
        public string GetDescription() => description;
        public string GetRace() => race;

    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int i = 1;

        private void NPCAdd(object sender, RoutedEventArgs e)
        {
            NPC npc = new NPC($"Deradalador {i}");
            i++;
            npcNames.Items.Add(npc.GetName());
            npcNames.SelectedItem = npcNames.Items.GetItemAt(0);
            
        }

        private void NPCDelete(object sender, RoutedEventArgs e)
        {
            if (npcNames.Items.Count > 0)
            {
                if (npcNames.SelectedItem == null)
                {
                    npcNames.SelectedItem = npcNames.Items.GetItemAt(0);
                }
                MessageBoxResult result = MessageBox.Show($"Deleting NPC {npcNames.SelectedItem} is irreversible. Do you wish to continue?", "Confirm NPC Removal", MessageBoxButton.OKCancel);
                switch (result)
                {
                    case MessageBoxResult.OK:
                        if (npcNames.SelectedItem != null)
                        {
                            npcNames.Items.RemoveAt(npcNames.Items.IndexOf(npcNames.SelectedItem));
                        }
                        else if (npcNames.Items.Count == 1)
                        {
                            npcNames.Items.Clear();
                        }
                        break;
                    case MessageBoxResult.Cancel:
                        break;
                }
            }            

            
        }

        private void NPCEdit(object sender, RoutedEventArgs e)
        {

        }
    }
}
