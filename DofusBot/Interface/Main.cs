﻿using DofusBot.Network;
using DofusBot.Protocol;
using DofusBot.Protocol.Enums;
using DofusBot.Protocol.Network.Messages.Connection;
using DofusBot.Protocol.Network.Messages.Game.Approach;
using DofusBot.Protocol.Network.Messages.Game.Basic;
using DofusBot.Protocol.Network.Messages.Game.Character.Choice;
using DofusBot.Protocol.Network.Messages.Game.Chat.Channel;
using DofusBot.Protocol.Network.Messages.Game.Context;
using DofusBot.Protocol.Network.Messages.Game.Context.Roleplay;
using DofusBot.Protocol.Network.Messages.Game.Context.Roleplay.Job;
using DofusBot.Protocol.Network.Messages.Game.Friend;
using DofusBot.Protocol.Network.Messages.Game.Inventory.Items;
using DofusBot.Protocol.Network.Messages.Game.Inventory.Spells;
using DofusBot.Protocol.Network.Messages.Queues;
using DofusBot.Protocol.Network.Messages.Security;
using DofusBot.Protocol.Network.Types;
using DofusBot.Protocol.Network.Types.Connection;
using DofusBot.Protocol.Network.Types.Game.Character.Choice;
using DofusBot.Protocol.Network.Types.Game.Context.Roleplay.Job;
using DofusBot.Protocol.Network.Types.Game.Data.Items;
using DofusBot.Protocol.Network.Types.Game.Friend;
using DofusBot.Protocol.Network.Types.Game.Interactive.Skill;
using DofusBot.Utilities;
using DofusBot.Utilities.Extensions;
using DofusBot.Utilities.Random;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace DofusBot.Interface
{
    public partial class Main : MaterialForm
    {
        #region Properties
        private DofusBotSocket _ServerSocket;
        private DofusBotSocket _GameSocket;
        private DofusBotPacketDeserializer _deserializer;
        private dynamic _ticket;

        private ToolTip PodsToolTip = new ToolTip();
        private uint PodsProgressValue = 0;
        private uint PodsProgressMinimum = 0;
        private uint PodsProgressMaximum = 100;
        #endregion

        public Main()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            _deserializer = new DofusBotPacketDeserializer();
            _deserializer.ReceivePacket += OnReceivedPacket;
            _deserializer.ReceiveNullPacket += OnReceivedNullPacket;

            logTextBox.Font = new Font("Tahoma", 8, FontStyle.Bold);
        }

        private void Log(LogMessageType type, string Text)
        {
            Action log_callback = delegate
            {
                Console.WriteLine(Text);

                switch (type)
                {
                    case LogMessageType.Global:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#E9E9E9");
                        break;
                    case LogMessageType.Team:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#FF006C");
                        break;
                    case LogMessageType.Guild:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#975FFF");
                        break;
                    case LogMessageType.Alliance:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#FFAD42");
                        break;
                    case LogMessageType.Party:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#00E4FF");
                        break;
                    case LogMessageType.Sales:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#B3783E");
                        break;
                    case LogMessageType.Seek:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#E4A0D5");
                        break;
                    case LogMessageType.Noob:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#D3AA07");
                        break;
                    case LogMessageType.Admin:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#FF00FF");
                        break;
                    case LogMessageType.Private:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#7EC3FF");
                        break;
                    case LogMessageType.Info:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#46A324");
                        break;
                    case LogMessageType.FightLog:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#9DFF00");
                        break;
                    case LogMessageType.Public:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#EF3A3E");
                        break;
                    case LogMessageType.Arena:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#F16392");
                        break;
                    case LogMessageType.Community:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#9EC79D");
                        break;
                    case LogMessageType.Sender:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#1B96FF");
                        break;
                    case LogMessageType.Default:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#E8890D");
                        break;
                    default:
                        logTextBox.SelectionColor = ColorTranslator.FromHtml("#E8890D");
                        break;
                }

                logTextBox.AppendText("[");
                logTextBox.AppendText(DateTime.Now.ToLongTimeString());
                logTextBox.AppendText("] " + Text + "\r\n");
                logTextBox.SelectionColor = logTextBox.ForeColor;
                logTextBox.Select(logTextBox.Text.Length, 0);
                logTextBox.ScrollToCaret();
            };
            Invoke(log_callback);
        }

        public void OnReceivedNullPacket(object source, NullPacketEventArg e)
        {
            Log(LogMessageType.Admin, "Packet: [" + e.PacketType + "] is not implemented.");
        }

        public void OnReceivedPacket(object source, PacketEventArg e)
        {
            ServerPacketEnum PacketType = (ServerPacketEnum)e.Packet.MessageID;
            switch (PacketType)
            {
                case ServerPacketEnum.ProtocolRequired: break;
                case ServerPacketEnum.CredentialsAcknowledgementMessage: break;
                case ServerPacketEnum.BasicAckMessage: break;
                case ServerPacketEnum.TextInformationMessage:
                    TextInformationMessage text = (TextInformationMessage)e.Packet;
                    Log(LogMessageType.Arena, ((TextInformationTypeEnum)text.MsgType).ToString() + "ID = " + text.MsgId);
                    for (int i = 0; i < text.Parameters.Count; i++)
                    {
                        string t = text.Parameters[i];
                        Log(LogMessageType.Arena, "Parameter[" + i + "] " + t);
                    }
                    break;
                case ServerPacketEnum.HelloGameMessage:
                    Log(LogMessageType.Info, "Connecté au serveur de jeu.");
                    HelloGameMessage helloGame = (HelloGameMessage)e.Packet;
                    AuthenticationTicketMessage ATM = new AuthenticationTicketMessage("fr", _ticket.ToString());
                    _GameSocket.Send(ATM);
                    break;
                case ServerPacketEnum.RawDataMessage:
                    List<int> tt = new List<int>();
                    for (int i = 0; i <= 255; i++)
                    {
                        Random random = new Random();
                        int test = random.Next(-127, 127);
                    }
                    CheckIntegrityMessage rawData = new CheckIntegrityMessage(tt);
                    _GameSocket.Send(rawData);
                    break;
                case ServerPacketEnum.HelloConnectMessage:
                    Log(LogMessageType.Info, "Connecté au serveur d'authentification.");
                    HelloConnectMessage helloConnectMessage = (HelloConnectMessage)e.Packet;
                    sbyte[] credentials = RSA.RSAKey.Encrypt(helloConnectMessage.key, accountNameTextField.Text, accountPasswordTextField.Text, helloConnectMessage.salt);
                    VersionExtended version = new VersionExtended(2, 41, 1, 120264, 1, (sbyte)BuildTypeEnum.RELEASE, 1, 1);
                    IdentificationMessage idm = new IdentificationMessage(autoConnectCheckBox.Checked, false, false, version, "fr", credentials, 0, 0, new ushort[0]);
                    Log(LogMessageType.Info, "Envois des informations d'identification...");
                    _ServerSocket.Send(idm);
                    break;
                case ServerPacketEnum.LoginQueueStatusMessage:
                    LoginQueueStatusMessage loginQueueStatusMessage = (LoginQueueStatusMessage)e.Packet;
                    if (loginQueueStatusMessage.Position != 0 && loginQueueStatusMessage.Total != 0)
                        Log(LogMessageType.Info, "Vous êtes en position " + loginQueueStatusMessage.Position + " sur " + loginQueueStatusMessage.Total + " dans la file d'attente.");
                    break;
                case ServerPacketEnum.CurrentMapMessage:
                    CurrentMapMessage currentMap = (CurrentMapMessage)e.Packet;
                    _GameSocket.Send(new MapInformationsRequestMessage(currentMap.MapId));
                    break;
                case ServerPacketEnum.QueueStatusMessage:
                    QueueStatusMessage queueStatusMessage = (QueueStatusMessage)e.Packet;
                    if (queueStatusMessage.Position != 0 && queueStatusMessage.Total != 0)
                        Log(LogMessageType.Info, "Vous êtes en position " + queueStatusMessage.Position + " sur " + queueStatusMessage.Total + " dans la file d'attente.");
                    break;
                case ServerPacketEnum.IdentificationFailedMessage:
                    IdentificationFailedMessage msg = (IdentificationFailedMessage)e.Packet;
                    Log(LogMessageType.Public, "Identification échouée !");
                    Log(LogMessageType.Public, ((IdentificationFailureReasonEnum)msg.Reason).ToString());
                    DisconnectHandler();
                    break;
                case ServerPacketEnum.IdentificationSuccessMessage: break;
                case ServerPacketEnum.ServerListMessage:
                    ServersListMessage servers = (ServersListMessage)e.Packet;
                    foreach(GameServerInformations i in servers.Servers ){
                        if (i.CharactersCount > 0 && i.IsSelectable && (ServerStatusEnum)i.Status == ServerStatusEnum.ONLINE)
                        {
                            _ServerSocket.Send(new ServerSelectionMessage(i.ObjectID));
                            break;
                        }
                    }
                    break;
                case ServerPacketEnum.SelectedServerDataMessage:
                    SelectedServerDataMessage selected = (SelectedServerDataMessage)e.Packet;
                    Log(LogMessageType.Info, "Connexion au serveur " + (ServerNameEnum)selected.ServerId + "...");     
                    _ticket = AES.AES.TicketTrans(selected.Ticket);
                    _GameSocket = new DofusBotSocket(_deserializer, new IPEndPoint(IPAddress.Parse(selected.Address), selected.Port));
                    Log(LogMessageType.Info, "Connexion en cours <" + selected.Address + ":" + selected.Port + ">");
                    _GameSocket.ConnectEndListen();
                    _ServerSocket.CloseSocket();
                    _ServerSocket = null;
                    break;
                case ServerPacketEnum.SelectedServerDataExtendedMessage:
                    SelectedServerDataExtendedMessage selectedExtended = (SelectedServerDataExtendedMessage)e.Packet;
                    Log(LogMessageType.Info, "Connecté au serveur : " + (ServerNameEnum)selectedExtended.ServerId + "...");
                    _ticket = AES.AES.TicketTrans(selectedExtended.Ticket);
                    _GameSocket = new DofusBotSocket(_deserializer, new IPEndPoint(IPAddress.Parse(selectedExtended.Address), selectedExtended.Port));
                    Log(LogMessageType.Info, "Connexion en cours <" + selectedExtended.Address + ":" + selectedExtended.Port + ">");
                    _GameSocket.ConnectEndListen();
                    _ServerSocket.CloseSocket();
                    _ServerSocket = null;
                    break;
                case ServerPacketEnum.AuthenticationTicketAcceptedMessage:
                    AuthenticationTicketAcceptedMessage accepted = (AuthenticationTicketAcceptedMessage)e.Packet;
                    Thread.Sleep(500);
                    _GameSocket.Send(new CharactersListRequestMessage());
                    break;
                case ServerPacketEnum.AuthenticationTicketRefusedMessage: break;
                case ServerPacketEnum.GameContextCreateMessage: break;
                case ServerPacketEnum.SetCharacterRestrictionsMessage: break;
                case ServerPacketEnum.BasicNoOperationMessage: break;
                case ServerPacketEnum.NotificationListMessage: break;
                case ServerPacketEnum.CharacterSelectedSuccessMessage: break;
                case ServerPacketEnum.InventoryContentMessage:
                    InventoryContentMessage inventory = (InventoryContentMessage)e.Packet;
                    Invoke((MethodInvoker)delegate
                    {
                        kamasLabel.Text = inventory.Kamas.ToString();
                    });
                    break;
                case ServerPacketEnum.SetUpdateMessage: break;
                case ServerPacketEnum.ShortcutBarContentMessage: break;
                case ServerPacketEnum.RoomAvailableUpdateMessage: break;
                case ServerPacketEnum.HavenBagPackListMessage: break;
                case ServerPacketEnum.EmoteListMessage: break;
                case ServerPacketEnum.JobDescriptionMessage:
                    JobDescriptionMessage jobs = (JobDescriptionMessage)e.Packet;
                    foreach (JobDescription j in jobs.JobsDescription)
                    {
                        foreach (SkillActionDescription s in j.Skills)
                        {
                            //Log(LogMessageType.Noob, "Métier: " + j.JobId + " | Skill: " + s.SkillId);
                        }
                    }
                    break;
                case ServerPacketEnum.JobExperienceMultiUpdateMessage: break;
                case ServerPacketEnum.JobCrafterDirectorySettingsMessage: break;
                case ServerPacketEnum.AlignmentRankUpdateMessage: break;
                case ServerPacketEnum.ServerExperienceModificatorMessage: break;
                case ServerPacketEnum.DareCreatedListMessage: break;
                case ServerPacketEnum.AlmanachCalendarDateMessage: break;
                case ServerPacketEnum.CharacterCapabilitiesMessage: break;
                case ServerPacketEnum.GameRolePlayArenaUpdatePlayerInfosAllQueuesMessage: break;
                case ServerPacketEnum.AchievementListMessage: break;
                case ServerPacketEnum.BasicLatencyStatsRequestMessage: break;
                case ServerPacketEnum.GameContextRemoveElementMessage: break;
                case ServerPacketEnum.GameMapChangeOrientationMessage: break;
                case ServerPacketEnum.GameRolePlayShowActorMessage: break;
                case ServerPacketEnum.SpouseStatusMessage: break;
                case ServerPacketEnum.SequenceNumberRequestMessage: break;
                case ServerPacketEnum.GuildMemberWarnOnConnectionStateMessage: break;
                case ServerPacketEnum.WarnOnPermaDeathStateMessage: break;
                case ServerPacketEnum.FriendGuildWarnOnAchievementCompleteStateMessage: break;
                case ServerPacketEnum.FriendWarnOnLevelGainStateMessage: break;
                case ServerPacketEnum.FriendWarnOnConnectionStateMessage: break;
                case ServerPacketEnum.BasicTimeMessage: break;
                case ServerPacketEnum.ServerSettingsMessage: break;
                case ServerPacketEnum.ServerOptionalFeaturesMessage: break;
                case ServerPacketEnum.ServerSessionConstantsMessage: break;
                case ServerPacketEnum.StatedElementUpdatedMessage: break;
                case ServerPacketEnum.InteractiveElementUpdatedMessage: break;
                case ServerPacketEnum.InteractiveUsedMessage: break;
                case ServerPacketEnum.AccountCapabilitiesMessage: break;
                case ServerPacketEnum.TrustStatusMessage: break;
                case ServerPacketEnum.PrismsListMessage: break;
                case ServerPacketEnum.CharacterExperienceGainMessage: break;
                case ServerPacketEnum.IdolListMessage: break;
                case ServerPacketEnum.SpellListMessage:break; break;
                case ServerPacketEnum.EnabledChannelsMessage: break;
                case ServerPacketEnum.GameMapMovementMessage: break;
                case ServerPacketEnum.DareSubscribedListMessage: break;
                case ServerPacketEnum.UpdateMapPlayersAgressableStatusMessage: break;
                case ServerPacketEnum.CharacterStatsListMessage: break;
                case ServerPacketEnum.MapComplementaryInformationsDataMessage:
                    MapComplementaryInformationsDataMessage mapInfos = (MapComplementaryInformationsDataMessage)e.Packet;
                    Invoke((MethodInvoker)delegate
                    {
                        currentMapIdLabel.Text = mapInfos.MapId.ToString();
                    });
                    break;
                case ServerPacketEnum.LifePointsRegenBeginMessage: break;
                case ServerPacketEnum.GameContextDestroyMessage: break;
                case ServerPacketEnum.IgnoredListMessage: break;
                case ServerPacketEnum.FriendsListMessage:
                    FriendsListMessage friendsList = (FriendsListMessage)e.Packet;
                    foreach (FriendInformations f in friendsList.FriendsList)
                    {
                        Log(LogMessageType.Noob, "Amis: " + f.AccountName + " | Dernière Connexion: " + DateExtensions.UnixTimestampToDateTime(f.LastConnection).ToLongDateString() + " | Points de Succès: " + f.AchievementPoints);
                    }
                    break;
                case ServerPacketEnum.AccountHouseMessage: break;
                case ServerPacketEnum.StartupActionsListMessage:  break;
                case ServerPacketEnum.ChatCommunityChannelCommunityMessage: break;
                case ServerPacketEnum.DareRewardsListMessage: break;
                case ServerPacketEnum.DareWonListMessage: break;
                case ServerPacketEnum.MailStatusMessage: break;
                case ServerPacketEnum.ChannelEnablingChangeMessage: break;
                case ServerPacketEnum.InventoryWeightMessage:
                    InventoryWeightMessage IWM = (InventoryWeightMessage)e.Packet;
                    Invoke((MethodInvoker)delegate
                    {
                        PodsProgressValue = IWM.Weight;
                        PodsProgressMaximum = IWM.WeightMax;
                        PodsProgress.Refresh();
                    });
                    break;
                case ServerPacketEnum.CharacterLoadingCompleteMessage:
                    _GameSocket.Send(new FriendsGetListMessage());
                    _GameSocket.Send(new IgnoredGetListMessage());
                    _GameSocket.Send(new SpouseGetInformationsMessage());
                    _GameSocket.Send(new ClientKeyMessage(FlashKeyGenerator.GetRandomFlashKey(accountNameTextField.Text)));
                    _GameSocket.Send(new GameContextCreateRequestMessage());
                    _GameSocket.Send(new ChannelEnablingMessage(7, false));
                    break;
                case ServerPacketEnum.CharactersListMessage:
                    CharactersListMessage charactersList = (CharactersListMessage)e.Packet;
                    List<CharacterBaseInformations> characters = charactersList.Characters;
                    for (int i = 0; i < characters.Count; i++)
                    {
                        CharacterBaseInformations c = characters[i];
                        Log(LogMessageType.Info, "Connexion sur le personnage " + c.Name);
                        _GameSocket.Send(new CharacterSelectionMessage((ulong)c.ObjectID));
                        break;
                    }
                    break;
                default:
                    Log(LogMessageType.Admin, "Packet: [" + (ServerPacketEnum)e.Packet.MessageID + "] is not handled.");
                    break;
            }
        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            if (_ServerSocket != null || _GameSocket != null)
            {
                if (MessageBox.Show("Une connexion est en cours. Voulez-vous vraiment fermer le bot? Si oui, la déconnexion s'effectuera automatiquement.", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (_ServerSocket != null)
                    {
                        _ServerSocket.CloseSocket();
                        _ServerSocket = null;
                    }
                    if (_GameSocket != null)
                    {
                        _GameSocket.CloseSocket();
                        _GameSocket = null;
                    }
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ProtocolManager.Initialize();
        }

        private void DisconnectHandler()
        {
            Invoke((MethodInvoker)delegate
            {
                if (_ServerSocket != null)
                {
                    _ServerSocket.CloseSocket();
                    _ServerSocket = null;
                }

                if (_GameSocket != null)
                {
                    _GameSocket.CloseSocket();
                    _GameSocket = null;
                }

                currentMapIdLabel.Text = "0";

                kamasLabel.Text = "0";

                PodsProgressMaximum = 100;
                PodsProgressValue = 0;
                PodsProgress.Refresh();

                connectionButton.Text = "Connexion";
                Log(LogMessageType.Info, "Déconnecté.");
            });
        }

        // Show the Progress.
        private void PodsProgress_Paint(object sender, PaintEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                // Clear the background.
                e.Graphics.Clear(PodsProgress.BackColor);

                // Draw the progress bar.
                float fraction =
                    (float)(PodsProgressValue - PodsProgressMinimum) /
                    (PodsProgressMaximum - PodsProgressMinimum);
                int wid = (int)(fraction * PodsProgress.ClientSize.Width);
                e.Graphics.FillRectangle(
                    Brushes.Chocolate, 0, 0, wid,
                    PodsProgress.ClientSize.Height);

                // Draw the text.
                e.Graphics.TextRenderingHint =
                    TextRenderingHint.AntiAliasGridFit;
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    int percent = (int)(fraction * 100);
                    e.Graphics.DrawString(
                        percent.ToString() + "%",
                        this.Font, Brushes.Black,
                        PodsProgress.ClientRectangle, sf);
                }
            });
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            string Connect = "Connexion";
            string Disconnect = "Deconnexion";

            Invoke((MethodInvoker)delegate
            {
                if (connectionButton.Text == Connect)
                {
                    if (string.IsNullOrWhiteSpace(accountNameTextField.Text) || string.IsNullOrWhiteSpace(accountPasswordTextField.Text))
                        Log(LogMessageType.Admin, "Vous devez rentrer vos identifiants.");
                    else
                    {
                        string DofusIP = "213.248.126.40";
                        int DofusPort = 5555;
                        _ServerSocket = new DofusBotSocket(_deserializer, new IPEndPoint(IPAddress.Parse(DofusIP), DofusPort));
                        Log(LogMessageType.Info, "Connexion en cours <" + DofusIP + ":" + DofusPort + ">");
                        _ServerSocket.ConnectEndListen();

                        connectionButton.Text = Disconnect;
                    }
                }
                else
                {
                    DisconnectHandler();
                }
            });
        }

        private void MouseHover_PodsProgress(object sender, EventArgs e)
        {
            PodsToolTip.SetToolTip(PodsProgress, PodsProgressValue + " / " + PodsProgressMaximum);
            PodsToolTip.ToolTipTitle = "Pods";
            PodsToolTip.IsBalloon = false;
            PodsToolTip.ToolTipIcon = ToolTipIcon.None;
            PodsToolTip.UseAnimation = true;
        }
    }
}
