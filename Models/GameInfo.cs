﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Dame.Models
{
    public class GameInfo : INotifyPropertyChanged
    {

        private ObservableCollection<ObservableCollection<Cell>> board;
        private bool playerTurn;
        private bool multipleAllowed;
        private bool blackWins;
        private bool redWins;
        private bool gameFinished;
        private bool startPhase;

        public GameInfo()
        {

        }

        public GameInfo(ObservableCollection<ObservableCollection<Cell>> board, bool multipleAllowed, bool playerTurn, bool whiteWins, bool redWins, bool gameFinished, bool startPhase)
        {
            Board = board;
            MultipleAllowed = multipleAllowed;
            PlayerTurn = playerTurn;
            BlackWins = whiteWins;
            RedWins = redWins;
            GameFinished = gameFinished;
            StartPhase = startPhase;
        }

        public ObservableCollection<ObservableCollection<Cell>> Board
        {
            get { return board; }
            set
            {
                board = value;
                OnPropertyChanged();
            }
        }

        public bool MultipleAllowed
        {
            get { return multipleAllowed; }
            set
            {
                multipleAllowed = value;
                OnPropertyChanged();
            }
        }

        public bool PlayerTurn
        {
            get { return playerTurn; }
            set
            {
                playerTurn = value;
                OnPropertyChanged();
            }
        }

        public bool BlackWins
        {
            get { return blackWins; }
            set
            {
                blackWins = value;
                OnPropertyChanged();
            }
        }

        public bool RedWins
        {
            get { return redWins; }
            set
            {
                redWins = value;
                OnPropertyChanged();
            }
        }

        public bool GameFinished
        {
            get { return gameFinished; }
            set
            {
                gameFinished = value;
                OnPropertyChanged();
            }
        }

        public bool StartPhase
        {
            get { return startPhase; }
            set
            {
                startPhase = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
