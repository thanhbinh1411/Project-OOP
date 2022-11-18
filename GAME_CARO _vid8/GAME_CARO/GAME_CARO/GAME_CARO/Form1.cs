using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAME_CARO;
namespace GAME_CARO
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        SocketManager socket;
        #endregion
        public Form1()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(ChessBoard_pnl, Player_txb, Mark_pic);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;


            Time_pcb.Step = Cons.COOL_DOWN_STEP;
            Time_pcb.Maximum = Cons.COOL_DOWN_TIME;
            Time_pcb.Value = 0;

            tmCoolDown.Interval = Cons.COOL_DOWN_INTERVAL;
            ChessBoard.DrawChessBoard();
            tmCoolDown.Start();

            socket= new SocketManager();

            NewGame();

        }
        #region Methods
        void EndGame()
        {
            tmCoolDown.Stop();
            ChessBoard_pnl.Enabled=false;
            undoToolStripMenuItem.Enabled=false;
            MessageBox.Show("   Game Over...");
            ChessBoard.DrawChessBoard();            
        }
        void NewGame()
        {
            Time_pcb.Value = 0;
            tmCoolDown.Stop();
            undoToolStripMenuItem.Enabled = true;
            ChessBoard.DrawChessBoard();            
        }
        void Quit()
        {
            Application.Exit();
        }
        void Undo()
        {
            ChessBoard.Undo();
        }
        void ChessBoard_PlayerMarked(object sender, Button_ClickEvent e)
        {
            tmCoolDown.Start();
            Time_pcb.Value = 0;
            ChessBoard_pnl.Enabled = false;
            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));

            Listen();
        }

        void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            Time_pcb.PerformStep();
            if(Time_pcb.Value >= Time_pcb.Maximum)
            {
                EndGame();
            }
                
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }


        private void LAN_btn_Click(object sender, EventArgs e)
        {
            socket.IP = LAN_txb.Text;
           

            if (!socket.ConnectSever())
            {
                socket.isServer = true;
                ChessBoard_pnl.Enabled = true;
                socket.CreateSever();
            }
            else
            {
                socket.isServer = false;
                ChessBoard_pnl.Enabled = false;
                Listen();
            }


        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            LAN_txb.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(LAN_txb.Text))
            {
                LAN_txb.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }
        void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();

                    ProcessData(data);
                }
                catch (Exception e)
                {
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        Time_pcb.Value = 0;
                        ChessBoard_pnl.Enabled = true;
                        tmCoolDown.Start();
                        ChessBoard.OtherPlayerMark(data.Point);
                    }));
                    break;
                case (int)SocketCommand.UNDO:
                    break;
                case (int)SocketCommand.END_GAME:
                    break;
                case (int)SocketCommand.QUIT:
                    break;
                default:
                    break;
            }

            Listen();
        }

        #endregion
    }
}