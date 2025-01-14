﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tema_Dame.Models;
using Tema_Dame.Utils;
using Tema_Dame.ViewModels;

namespace Tema_Dame.Commands
{
    class NewGameCommand : ICommand
    {
        private GameViewModel gameVM;
        public NewGameCommand(GameViewModel gameVM)
        {
            this.gameVM = gameVM;
        }

        public void NewGame()
        {
            ObservableCollection<ObservableCollection<Cell>> board = GameHelper.InitGameBoard();
            gameVM.GameInfo = new GameInfo(board, gameVM.GameInfo.MultipleAllowed, false, false, false, false, true);
            gameVM.GameBoard = gameVM.CellBoardToCellViewModelBoard(board);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            NewGame();
        }

        public event EventHandler CanExecuteChanged;
    }
}
