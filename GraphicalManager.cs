﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MSB_SERVER
{
    public class GraphicalManager
    {
		private static GraphicalManager INSTANCE;

		private readonly App serverApplication;

		private MainWindow mainWindow;
		private Border mainServerBlock;
		private TextBlock mainServerStatus;
		private Button mainServerButton;
		private TextBox mainEditorIP, mainEditorPort;
		private Border mainStatusSoloQueueTitleBlock, mainStatusTeamQueueTitleBlock, mainStatusDatabaseTitleBlock, mainStatusCommandTitleBlock, mainStatusUserTitleBlock, mainStatusRoomTitleBlock, mainStatusPingTitleBlock, mainStatusUptimeTitleBlock, mainStatusCpuTitleBlock, mainStatusRamTitleBlock;
		private TextBlock mainStatusSoloQueueTitle, mainStatusTeamQueueTitle, mainStatusDatabaseTitle, mainStatusCommandTitle, mainStatusUserTitle, mainStatusRoomTitle, mainStatusPingTitle, mainStatusUptimeTitle, mainStatusCpuTitle, mainStatusRamTitle;
		private Border mainStatusSoloQueueBlock, mainStatusTeamQueueBlock, mainStatusDatabaseBlock, mainStatusCommandBlock, mainStatusUserBlock, mainStatusRoomBlock, mainStatusPingBlock, mainStatusUptimeBlock, mainStatusCpuBlock, mainStatusRamBlock;
		private TextBlock mainStatusSoloQueue, mainStatusTeamQueue, mainStatusDatabase, mainStatusCommand, mainStatusUser, mainStatusRoom, mainStatusPing, mainStatusUptime, mainStatusCpu, mainStatusRam;
		private TextBox mainSystemLogBox, mainNetworkLogBox, mainSystemErrorLogBox, mainNetworkErrorLogBox, mainUserLogBox, mainRoomLogBox;
		
		private GraphicalManager()
		{
			serverApplication = (App) Application.Current;
		}

		public static GraphicalManager GetInstance()
		{
			if (INSTANCE == null) INSTANCE = new GraphicalManager();
			return INSTANCE;
		}

		public void ShowGraphicalUserInterface()
		{
			if (mainWindow == null) {
				mainWindow = new MainWindow();
				mainWindow.Show();
			}
			InitializeGraphicalUserInterface(mainWindow);
		}

		public void InitializeGraphicalUserInterface(Window window)
		{
			if (!(window is MainWindow))
			{
				return;
			}
			mainWindow = (MainWindow) window;
			mainServerBlock = (Border) mainWindow.FindName("mainServerBlock");
			mainServerStatus = (TextBlock) mainWindow.FindName("mainServerStatus");
			mainEditorIP = (TextBox) mainWindow.FindName("mainEditorIP");
			mainEditorPort = (TextBox) mainWindow.FindName("mainEditorPort");
			mainServerButton = (Button) mainWindow.FindName("mainServerButton");
			mainStatusSoloQueueTitleBlock = (Border) mainWindow.FindName("mainStatusSoloQueueTitleBlock");
			mainStatusTeamQueueTitleBlock = (Border) mainWindow.FindName("mainStatusTeamQueueTitleBlock");
			mainStatusDatabaseTitleBlock = (Border) mainWindow.FindName("mainStatusDatabaseTitleBlock");
			mainStatusCommandTitleBlock = (Border) mainWindow.FindName("mainStatusCommandTitleBlock");
			mainStatusUserTitleBlock = (Border) mainWindow.FindName("mainStatusUserTitleBlock");
			mainStatusRoomTitleBlock = (Border) mainWindow.FindName("mainStatusRoomTitleBlock");
			mainStatusPingTitleBlock = (Border) mainWindow.FindName("mainStatusPingTitleBlock");
			mainStatusUptimeTitleBlock = (Border) mainWindow.FindName("mainStatusUptimeTitleBlock");
			mainStatusCpuTitleBlock = (Border) mainWindow.FindName("mainStatusCpuTitleBlock");
			mainStatusRamTitleBlock = (Border) mainWindow.FindName("mainStatusRamTitleBlock");
			mainStatusSoloQueueTitle = (TextBlock) mainWindow.FindName("mainStatusSoloQueueTitle");
			mainStatusTeamQueueTitle = (TextBlock) mainWindow.FindName("mainStatusTeamQueueTitle");
			mainStatusDatabaseTitle = (TextBlock) mainWindow.FindName("mainStatusDatabaseTitle");
			mainStatusCommandTitle = (TextBlock) mainWindow.FindName("mainStatusCommandTitle");
			mainStatusUserTitle = (TextBlock) mainWindow.FindName("mainStatusUserTitle");
			mainStatusRoomTitle = (TextBlock) mainWindow.FindName("mainStatusRoomTitle");
			mainStatusPingTitle = (TextBlock) mainWindow.FindName("mainStatusPingTitle");
			mainStatusUptimeTitle = (TextBlock) mainWindow.FindName("mainStatusUptimetitle");
			mainStatusCpuTitle = (TextBlock) mainWindow.FindName("mainStatusCpuTitle");
			mainStatusRamTitle = (TextBlock) mainWindow.FindName("mainStatusRamTitle");
			mainStatusSoloQueueBlock = (Border) mainWindow.FindName("mainStatusSoloQueueBlock");
			mainStatusTeamQueueBlock = (Border) mainWindow.FindName("mainStatusTeamQueueBlock");
			mainStatusDatabaseBlock = (Border) mainWindow.FindName("mainStatusDatabaseBlock");
			mainStatusCommandBlock = (Border) mainWindow.FindName("mainStatusCommandBlock");
			mainStatusUserBlock = (Border) mainWindow.FindName("mainStatusUserBlock");
			mainStatusRoomBlock = (Border) mainWindow.FindName("mainStatusRoomBlock");
			mainStatusPingBlock = (Border) mainWindow.FindName("mainStatusPingBlock");
			mainStatusUptimeBlock = (Border) mainWindow.FindName("mainStatusUptimeBlock");
			mainStatusCpuBlock = (Border) mainWindow.FindName("mainStatusCpuBlock");
			mainStatusRamBlock = (Border) mainWindow.FindName("mainStatusRamBlock");
			mainStatusSoloQueue = (TextBlock) mainWindow.FindName("mainStatusSoloQueue");
			mainStatusTeamQueue = (TextBlock) mainWindow.FindName("mainStatusTeamQueue");
			mainStatusDatabase = (TextBlock) mainWindow.FindName("mainStatusDatabase");
			mainStatusCommand = (TextBlock) mainWindow.FindName("mainStatusCommand");
			mainStatusUser = (TextBlock) mainWindow.FindName("mainStatusUser");
			mainStatusRoom = (TextBlock) mainWindow.FindName("mainStatusRoom");
			mainStatusPing = (TextBlock) mainWindow.FindName("mainStatusPing");
			mainStatusUptime = (TextBlock) mainWindow.FindName("mainStatusUptime");
			mainStatusCpu = (TextBlock) mainWindow.FindName("mainStatusCpu");
			mainStatusRam = (TextBlock) mainWindow.FindName("mainStatusRam");
			mainSystemLogBox = (TextBox) mainWindow.FindName("mainSystemLog");
			mainSystemErrorLogBox = (TextBox) mainWindow.FindName("mainSystemErrorLog");
			mainNetworkLogBox = (TextBox) mainWindow.FindName("mainNetworkLog");
			mainNetworkErrorLogBox = (TextBox) mainWindow.FindName("mainNetworkErrorLog");
			mainUserLogBox = (TextBox) mainWindow.FindName("mainUserLog");
			mainRoomLogBox = (TextBox) mainWindow.FindName("mainRoomLog");

			serverApplication.logManager.SetSystemLogger(mainSystemLogBox, mainSystemErrorLogBox);
			serverApplication.logManager.SetNetworkLogger(mainNetworkLogBox, mainNetworkErrorLogBox);
			serverApplication.logManager.SetUserLogger(mainUserLogBox);
			serverApplication.logManager.SetRoomLogger(mainRoomLogBox);
		}

		public void OnUserServerButton(string inputIP, int inputPort)
		{
			serverApplication.Dispatcher?.Invoke(() =>
			{
				if (!NetworkManager.IsServerRunning())
				{
					// SERVER MAKE RUN
					serverApplication.networkManager.ServerRun(inputIP, inputPort);
				}
				else
				{
					// SERVER MAKE STOP
					serverApplication.networkManager.ServerStop();
				}
			});
		}

		public void OnServerStatusChanged(bool serverPower, bool isRunning)
		{
            serverApplication.Dispatcher?.Invoke(() => {
	            if (!serverPower)
	            {
		            mainEditorIP.IsEnabled = true;
		            mainEditorPort.IsEnabled = true;
		            mainServerButton.Content = Properties.Resources.ResourceManager.GetString("BUTTON_START");
		            mainServerBlock.Background = new SolidColorBrush(Colors.LightGray);
		            mainServerStatus.Foreground = new SolidColorBrush(Colors.Black);
		            mainServerStatus.Text = Properties.Resources.ResourceManager.GetString("STATUS_STOPPED");
		            return;
	            }
	            if (isRunning)
	            {
		            mainEditorIP.IsEnabled = false;
		            mainEditorPort.IsEnabled = false;
		            mainServerButton.Content = Properties.Resources.ResourceManager.GetString("BUTTON_STOP");
		            mainServerBlock.Background = new SolidColorBrush(Colors.LawnGreen);
		            mainServerStatus.Foreground = new SolidColorBrush(Colors.White);
		            mainServerStatus.Text = Properties.Resources.ResourceManager.GetString("STATUS_RUNNING");
	            } else
	            {
		            mainEditorIP.IsEnabled = true;
		            mainEditorPort.IsEnabled = true;
		            mainServerButton.Content = Properties.Resources.ResourceManager.GetString("BUTTON_START");
		            mainServerBlock.Background = new SolidColorBrush(Colors.OrangeRed);
		            mainServerStatus.Foreground = new SolidColorBrush(Colors.White);
		            mainServerStatus.Text = Properties.Resources.ResourceManager.GetString("STATUS_SUSPENDED");
	            }
            });
		}

		public void OnSoloModuleStatusChanged(bool serverPower, bool isRunning, int inQueue)
		{
            serverApplication.Dispatcher?.Invoke(() => {
	            if (!serverPower)
	            {
		            mainStatusSoloQueue.Text = Properties.Resources.ResourceManager.GetString("STATUS_DEFAULT");
		            mainStatusSoloQueue.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusSoloQueueBlock.Background = new SolidColorBrush(Colors.White);
		            mainStatusSoloQueueTitle.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusSoloQueueTitleBlock.Background = new SolidColorBrush(Colors.White);
		            return;
	            }
	            if (isRunning)
	            {
		            mainStatusSoloQueue.Text = inQueue + " IN QUEUE";
		            mainStatusSoloQueue.Foreground = new SolidColorBrush(Colors.ForestGreen);
		            mainStatusSoloQueueBlock.Background = new SolidColorBrush(Colors.White);
		            mainStatusSoloQueueTitle.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusSoloQueueTitleBlock.Background = new SolidColorBrush(Colors.White);
	            } else
	            {
		            mainStatusSoloQueue.Text = Properties.Resources.ResourceManager.GetString("STATUS_OFF");
		            mainStatusSoloQueue.Foreground = new SolidColorBrush(Colors.White);
		            mainStatusSoloQueueBlock.Background = new SolidColorBrush(Colors.OrangeRed);
		            mainStatusSoloQueueTitle.Foreground = new SolidColorBrush(Colors.White);
		            mainStatusSoloQueueTitleBlock.Background = new SolidColorBrush(Colors.OrangeRed);
	            }
            });
		}

		public void OnTeamModuleStatusChanged(bool serverPower, bool isRunning, int inQueue)
		{
            serverApplication.Dispatcher?.Invoke(() => {
	            if (!serverPower)
	            {
		            mainStatusTeamQueue.Text = Properties.Resources.ResourceManager.GetString("STATUS_DEFAULT");
		            mainStatusTeamQueue.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusTeamQueueBlock.Background = new SolidColorBrush(Colors.White);
		            mainStatusTeamQueueTitle.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusTeamQueueTitleBlock.Background = new SolidColorBrush(Colors.White);
		            return;
	            }
	            if (isRunning)
	            {
		            mainStatusTeamQueue.Text = inQueue + " IN QUEUE";
		            mainStatusTeamQueue.Foreground = new SolidColorBrush(Colors.ForestGreen);
		            mainStatusTeamQueueBlock.Background = new SolidColorBrush(Colors.White);
		            mainStatusTeamQueueTitle.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusTeamQueueTitleBlock.Background = new SolidColorBrush(Colors.White);
	            }
	            else
	            {
		            mainStatusTeamQueue.Text = Properties.Resources.ResourceManager.GetString("STATUS_OFF");
		            mainStatusTeamQueue.Foreground = new SolidColorBrush(Colors.White);
		            mainStatusTeamQueueBlock.Background = new SolidColorBrush(Colors.OrangeRed);
		            mainStatusTeamQueueTitle.Foreground = new SolidColorBrush(Colors.White);
		            mainStatusTeamQueueTitleBlock.Background = new SolidColorBrush(Colors.OrangeRed);
	            }
            });
		}

		public void OnDatabaseModuleStatusChanged(bool serverPower, bool isRunning)
		{
            serverApplication.Dispatcher?.Invoke(() => {
	            if (!serverPower)
	            {
		            mainStatusDatabase.Text = Properties.Resources.ResourceManager.GetString("STATUS_DEFAULT");
		            mainStatusDatabase.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusDatabaseBlock.Background = new SolidColorBrush(Colors.White);
		            mainStatusDatabaseTitle.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusDatabaseTitleBlock.Background = new SolidColorBrush(Colors.White);
		            return;
	            }
	            if (isRunning)
	            {
		            mainStatusDatabase.Text = Properties.Resources.ResourceManager.GetString("STATUS_ON");
		            mainStatusDatabase.Foreground = new SolidColorBrush(Colors.ForestGreen);
		            mainStatusDatabaseBlock.Background = new SolidColorBrush(Colors.White);
		            mainStatusDatabaseTitle.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusDatabaseTitleBlock.Background = new SolidColorBrush(Colors.White);
	            }
	            else
	            {
		            mainStatusDatabase.Text = Properties.Resources.ResourceManager.GetString("STATUS_OFF");
		            mainStatusDatabase.Foreground = new SolidColorBrush(Colors.White);
		            mainStatusDatabaseBlock.Background = new SolidColorBrush(Colors.OrangeRed);
		            mainStatusDatabaseTitle.Foreground = new SolidColorBrush(Colors.White);
		            mainStatusDatabaseTitleBlock.Background = new SolidColorBrush(Colors.OrangeRed);
	            }
            });
		}

		public void OnLogModuleStatusChanged(bool serverPower, bool isRunning)
		{
			/*
            serverApplication.Dispatcher?.Invoke(() => {
	            if (!serverPower)
	            {
		            mainStatusCommand.Text = Properties.Resources.ResourceManager.GetString("STATUS_DEFAULT");
		            mainStatusCommand.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusCommandBlock.Background = new SolidColorBrush(Colors.White);
		            mainStatusCommandTitle.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusCommandTitleBlock.Background = new SolidColorBrush(Colors.White);
		            return;
	            }
	            if (isRunning)
	            {
		            mainStatusCommand.Text = Properties.Resources.ResourceManager.GetString("STATUS_ON");
		            mainStatusCommand.Foreground = new SolidColorBrush(Colors.ForestGreen);
		            mainStatusCommandBlock.Background = new SolidColorBrush(Colors.White);
		            mainStatusCommandTitle.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusCommandTitleBlock.Background = new SolidColorBrush(Colors.White);
	            }
	            else
	            {
		            mainStatusCommand.Text = Properties.Resources.ResourceManager.GetString("STATUS_OFF");
		            mainStatusCommand.Foreground = new SolidColorBrush(Colors.White);
		            mainStatusCommandBlock.Background = new SolidColorBrush(Colors.OrangeRed);
		            mainStatusCommandTitle.Foreground = new SolidColorBrush(Colors.White);
		            mainStatusCommandTitleBlock.Background = new SolidColorBrush(Colors.OrangeRed);
	            }
            });
            */
		}
		
		public void OnCommandModuleStatusChanged(bool serverPower, bool isRunning)
		{
			serverApplication.Dispatcher?.Invoke(() => {
				if (!serverPower)
				{
					mainStatusCommand.Text = Properties.Resources.ResourceManager.GetString("STATUS_DEFAULT");
					mainStatusCommand.Foreground = new SolidColorBrush(Colors.Black);
					mainStatusCommandBlock.Background = new SolidColorBrush(Colors.White);
					mainStatusCommandTitle.Foreground = new SolidColorBrush(Colors.Black);
					mainStatusCommandTitleBlock.Background = new SolidColorBrush(Colors.White);
					return;
				}
				if (isRunning)
				{
					mainStatusCommand.Text = Properties.Resources.ResourceManager.GetString("STATUS_ON");
					mainStatusCommand.Foreground = new SolidColorBrush(Colors.ForestGreen);
					mainStatusCommandBlock.Background = new SolidColorBrush(Colors.White);
					mainStatusCommandTitle.Foreground = new SolidColorBrush(Colors.Black);
					mainStatusCommandTitleBlock.Background = new SolidColorBrush(Colors.White);
				}
				else
				{
					mainStatusCommand.Text = Properties.Resources.ResourceManager.GetString("STATUS_OFF");
					mainStatusCommand.Foreground = new SolidColorBrush(Colors.White);
					mainStatusCommandBlock.Background = new SolidColorBrush(Colors.OrangeRed);
					mainStatusCommandTitle.Foreground = new SolidColorBrush(Colors.White);
					mainStatusCommandTitleBlock.Background = new SolidColorBrush(Colors.OrangeRed);
				}
			});
		}

		public void OnUserCountChanged(bool serverPower, bool isRunning, int userCount, int totalCount)
		{
            serverApplication.Dispatcher?.Invoke(() => {
	            if (!serverPower)
	            {
		            mainStatusUser.Text = Properties.Resources.ResourceManager.GetString("STATUS_DEFAULT");
		            mainStatusUser.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusUserBlock.Background = new SolidColorBrush(Colors.White);
		            return;
	            }
	            if (isRunning)
	            {
		            mainStatusUser.Text = userCount.ToString() + " / " + totalCount.ToString();
		            if (userCount != 0)
		            {
			            mainStatusUser.Foreground = new SolidColorBrush(Colors.ForestGreen);
			            mainStatusUserBlock.Background = new SolidColorBrush(Colors.White);
		            }
		            else
		            {
			            mainStatusUser.Foreground = new SolidColorBrush(Colors.OrangeRed);
			            mainStatusUserBlock.Background = new SolidColorBrush(Colors.White);
		            }
	            } else
	            {
		            mainStatusUser.Text = Properties.Resources.ResourceManager.GetString("STATUS_OFF");
		            mainStatusUser.Foreground = new SolidColorBrush(Colors.White);
		            mainStatusUserBlock.Background = new SolidColorBrush(Colors.OrangeRed);
	            }
            });
		}

		public void OnRoomCountChanged(bool serverPower, bool isRunning, int roomCount)
		{
            serverApplication.Dispatcher?.Invoke(() => {
	            if (!serverPower)
	            {
		            mainStatusRoom.Text = Properties.Resources.ResourceManager.GetString("STATUS_DEFAULT");
		            mainStatusRoom.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusRoomBlock.Background = new SolidColorBrush(Colors.White);
		            return;
	            }
	            if (isRunning)
	            {
		            mainStatusRoom.Text = roomCount.ToString();
		            if (roomCount != 0)
		            {
			            mainStatusRoom.Foreground = new SolidColorBrush(Colors.ForestGreen);
			            mainStatusRoomBlock.Background = new SolidColorBrush(Colors.White);
		            }
		            else
		            {
			            mainStatusRoom.Foreground = new SolidColorBrush(Colors.OrangeRed);
			            mainStatusRoomBlock.Background = new SolidColorBrush(Colors.White);
		            }
	            } else
	            {
		            mainStatusRoom.Text = Properties.Resources.ResourceManager.GetString("STATUS_OFF");
		            mainStatusRoom.Foreground = new SolidColorBrush(Colors.White);
		            mainStatusRoomBlock.Background = new SolidColorBrush(Colors.OrangeRed);
	            }
            });
		}

		public void OnPingStatusChanged(bool serverPower, bool isRunning, string message)
		{
            serverApplication.Dispatcher?.Invoke(() => {
	            if (!serverPower)
	            {
		            mainStatusPing.Text = Properties.Resources.ResourceManager.GetString("STATUS_DEFAULT");
		            mainStatusPing.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusPingBlock.Background = new SolidColorBrush(Colors.White);
		            return;
	            }
	            if (isRunning)
	            {
		            mainStatusPing.Text = message;
		            mainStatusPing.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusPingBlock.Background = new SolidColorBrush(Colors.White);
	            } else
	            {
		            mainStatusPing.Text = Properties.Resources.ResourceManager.GetString("STATUS_OFF");
		            mainStatusPing.Foreground = new SolidColorBrush(Colors.White);
		            mainStatusPingBlock.Background = new SolidColorBrush(Colors.OrangeRed);
	            }
            });
		}

		public void OnUptimeStatusChanged(bool serverPower, bool isRunning, string message)
		{
            serverApplication.Dispatcher?.Invoke(() => {
	            if (!serverPower)
	            {
		            mainStatusUptime.Text = Properties.Resources.ResourceManager.GetString("STATUS_DEFAULT");
		            mainStatusUptime.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusUptimeBlock.Background = new SolidColorBrush(Colors.White);
		            return;
	            }
	            if (isRunning)
	            {
		            mainStatusUptime.Text = message;
		            mainStatusUptime.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusUptimeBlock.Background = new SolidColorBrush(Colors.White);
	            } else
	            {
		            mainStatusUptime.Text = Properties.Resources.ResourceManager.GetString("STATUS_OFF");
		            mainStatusUptime.Foreground = new SolidColorBrush(Colors.White);
		            mainStatusUptimeBlock.Background = new SolidColorBrush(Colors.OrangeRed);
	            }
            });
		}

		public void OnCpuStatusChanged(bool serverPower, bool isRunning, bool isDanger, string message)
		{
            serverApplication.Dispatcher?.Invoke(() => {
	            if (!serverPower)
	            {
		            mainStatusCpu.Text = Properties.Resources.ResourceManager.GetString("STATUS_DEFAULT");
		            mainStatusCpu.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusCpuBlock.Background = new SolidColorBrush(Colors.White);
		            mainStatusCpuTitle.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusCpuTitleBlock.Background = new SolidColorBrush(Colors.White);
		            return;
	            }
	            if (isRunning)
	            {
		            mainStatusCpu.Text = message;
		            if (!isDanger)
		            {
			            mainStatusCpu.Foreground = new SolidColorBrush(Colors.ForestGreen);
			            mainStatusCpuBlock.Background = new SolidColorBrush(Colors.White);
			            mainStatusCpuTitle.Foreground = new SolidColorBrush(Colors.Black);
			            mainStatusCpuTitleBlock.Background = new SolidColorBrush(Colors.White);
		            }
		            else
		            {
			            mainStatusCpu.Foreground = new SolidColorBrush(Colors.White);
			            mainStatusCpuBlock.Background = new SolidColorBrush(Colors.OrangeRed);
			            mainStatusCpuTitle.Foreground = new SolidColorBrush(Colors.White);
			            mainStatusCpuTitleBlock.Background = new SolidColorBrush(Colors.OrangeRed);
		            }
	            } else
	            {
		            mainStatusCpu.Text = Properties.Resources.ResourceManager.GetString("STATUS_OFF");
		            mainStatusCpu.Foreground = new SolidColorBrush(Colors.White);
		            mainStatusCpuBlock.Background = new SolidColorBrush(Colors.OrangeRed);
		            mainStatusCpuTitle.Foreground = new SolidColorBrush(Colors.White);
		            mainStatusCpuTitleBlock.Background = new SolidColorBrush(Colors.OrangeRed);
	            }
            });
		}

		public void OnRamStatusChanged(bool serverPower, bool isRunning, bool isDanger, string message)
		{
            serverApplication.Dispatcher?.Invoke(() => {
	            if (!serverPower)
	            {
		            mainStatusRam.Text = Properties.Resources.ResourceManager.GetString("STATUS_DEFAULT");
		            mainStatusRam.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusRamBlock.Background = new SolidColorBrush(Colors.White);
		            mainStatusRamTitle.Foreground = new SolidColorBrush(Colors.Black);
		            mainStatusRamTitleBlock.Background = new SolidColorBrush(Colors.White);
		            return;
	            }
	            if (isRunning)
	            {
		            mainStatusRam.Text = message;
		            if (!isDanger)
		            {
			            mainStatusRam.Foreground = new SolidColorBrush(Colors.ForestGreen);
			            mainStatusRamBlock.Background = new SolidColorBrush(Colors.White);
			            mainStatusRamTitle.Foreground = new SolidColorBrush(Colors.Black);
			            mainStatusRamTitleBlock.Background = new SolidColorBrush(Colors.White);
		            }
		            else
		            {
			            mainStatusRam.Foreground = new SolidColorBrush(Colors.White);
			            mainStatusRamBlock.Background = new SolidColorBrush(Colors.OrangeRed);
			            mainStatusRamTitle.Foreground = new SolidColorBrush(Colors.White);
			            mainStatusRamTitleBlock.Background = new SolidColorBrush(Colors.OrangeRed);
		            }
	            } else
	            {
		            mainStatusRam.Text = Properties.Resources.ResourceManager.GetString("STATUS_OFF");
		            mainStatusRam.Foreground = new SolidColorBrush(Colors.White);
		            mainStatusRamBlock.Background = new SolidColorBrush(Colors.OrangeRed);
		            mainStatusRamTitle.Foreground = new SolidColorBrush(Colors.White);
		            mainStatusRamTitleBlock.Background = new SolidColorBrush(Colors.OrangeRed);
	            }
            });
		}

		public void OnGameStatusUserSync(bool serverPower, bool isRunning, string status)
		{
            serverApplication.Dispatcher?.Invoke(() => {
	            if (!serverPower)
	            {
		            mainUserLogBox.Clear();
		            return;
	            }
	            if (isRunning)
	            {
		            mainUserLogBox.Text = status;
	            } else
	            {
		            mainUserLogBox.Clear();
	            }
            });
		}

		public void OnGameStatusRoomSync(bool serverPower, bool isRunning, string status)
		{
            serverApplication.Dispatcher?.Invoke(() => {
	            if (!serverPower)
	            {
		            mainRoomLogBox.Clear();
		            return;
	            }
	            if (isRunning)
	            {
		            mainRoomLogBox.Text = status;
	            } else
	            {
		            mainRoomLogBox.Clear();
	            }
            });
		}

    }
}
