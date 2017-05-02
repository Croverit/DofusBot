﻿using DofusBot.Core.Network;
using System.Collections.Generic;

namespace DofusBot.Packet.Messages.Game.Basic
{
    class TextInformationMessage : NetworkMessage
    {
        public ServerPacketEnum PacketType
        {
            get { return ServerPacketEnum.TextInformationMessage; }
        }

        public byte MsgType;
        public ushort MsgId;
        public List<string> Parameters;

        public const uint ProtocolId = 780;
        public override uint MessageID { get { return ProtocolId; } }

        public TextInformationMessage() { }

        public TextInformationMessage(byte msgType, ushort msgId, List<string> parameters)
        {
            MsgType = msgType;
            MsgId = msgId;
            Parameters = parameters;
        }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(MsgType);
            writer.WriteVarShort(MsgId);
            writer.WriteShort((short)Parameters.Count);
            for (int i = 0; i < Parameters.Count; i++)
            {
                writer.WriteUTF(Parameters[i]);
            }
        }

        public override void Deserialize(IDataReader reader)
        {
            MsgType = reader.ReadByte();
            MsgId = reader.ReadVarUhShort();
            ushort length = reader.ReadUShort();
            Parameters = new List<string>();
            for (int i = 0; i < length; i++)
            {
                Parameters.Add(reader.ReadUTF());
            }
        }
    }
}
