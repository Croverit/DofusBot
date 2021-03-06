﻿using DofusBot.Protocol.Network.Types.Game.Social;

namespace DofusBot.Protocol.Network.Types.Game.Context.Roleplay
{
    public class BasicAllianceInformations : AbstractSocialGroupInfos
    {
        public new const int ProtocolId = 419;
        public override int TypeID { get { return ProtocolId; } }

        public uint AllianceId;
        public string AllianceTag;

        public BasicAllianceInformations() { }

        public BasicAllianceInformations(uint allianceId, string allianceTag)
        {
            AllianceId = allianceId;
            AllianceTag = allianceTag;
        }

        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt(AllianceId);
            writer.WriteUTF(AllianceTag);
        }

        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            AllianceId = reader.ReadVarUhInt();
            AllianceTag = reader.ReadUTF();
        }
    }
}
