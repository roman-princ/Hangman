using HangMan.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.ViewModels
{
    internal class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ParametrizedRelayCommand<string> Command { get; set; }
        public List<string> Words = new List<string>();

        public ObservableCollection<string> CorrectChars = new ObservableCollection<string>();

        public List<string> GuessedChars = new List<string>();

        public MainVM()
        {
            Words.Add("HOUBA");
            Words.Add("STROM");
            Words.Add("SLUNCE");
            Words.Add("OKO");

            Words.Add("MASO");
            Words.Add("OPICE");

            Words.Add("HANGMAN");


            int rnd = _rnd.Next(0, Words.Count);
            SelectedWord = Words[rnd];
            char[] selectedwords = new char[SelectedWord.Length];
            for (int i = 0; i < SelectedWord.Length; i++)
            {
                selectedwords[i] = SelectedWord[i];
            }


            Command = new ParametrizedRelayCommand<string>(
            (znak) =>
            {
                GuessedChars.Add(znak);
                Command.RaiseCanExecureChanged();
                if (SelectedWord.Contains(znak))
                {
                    CorrectChars.Append(znak);
                }

            },
            (znak) =>
            {
                return !GuessedChars.Contains(znak);
            });

            for (int i = 0; i < SelectedWord.Length; i++)
            {

            }
        }
        private Random _rnd = new Random();
        public string SelectedWord { get; set;}
            
        
    }
}
