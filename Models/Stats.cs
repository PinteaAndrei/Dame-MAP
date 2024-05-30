using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Dame.Models
{
    public class Stats : INotifyPropertyChanged
    {

        public string statPath = "C:\\Users\\Andrei\\Desktop\\Tema_Dame\\Resources\\stats.txt";
        private string redWinsString;
        private string whiteWinsString;
        private string buttonStats;

        private bool showStats;
        private int winsRed;
        private int winsWhite;

        public Stats()
        {
            TextReader statFile = File.OpenText(statPath);
            winsWhite = int.Parse(statFile.ReadLine());
            winsRed = int.Parse(statFile.ReadLine());
            redWinsString = winsRed.ToString();
            whiteWinsString = winsWhite.ToString();
            buttonStats = "Show Stats";
            statFile.Close();
        }

        public string RedWinsString
        {
            get { return redWinsString; }
            set 
            { 
                redWinsString = value;
                OnPropertyChanged();
            }
        }

        public string WhiteWinsString
        {
            get { return whiteWinsString; }
            set 
            {
                whiteWinsString = value; 
                OnPropertyChanged();
            }
        }

        public int WinsRed
        {
            get { return winsRed; }
            set
            {
                winsRed = value;
                OnPropertyChanged();
            }
        }

        public int WinsWhite
        {
            get { return winsWhite; }
            set
            {
                winsWhite = value;
                OnPropertyChanged();
            }
        }

        public string ButtonStats
        {
            get { return buttonStats; }
            set
            {
                buttonStats = value;
                OnPropertyChanged();
            }
        }

        public bool ShowStats
        {
            get { return showStats; }
            set
            {
                showStats = value;
                OnPropertyChanged();
            }
        }

        ~Stats()
        {
            using (StreamWriter write = new StreamWriter(statPath))
            {
                write.WriteLine(winsWhite);
                write.WriteLine(winsRed);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
