//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Interactive.Zaap
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class TeleportRequestMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5961;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_teleporterType;
        
        public virtual byte TeleporterType
        {
            get
            {
                return m_teleporterType;
            }
            set
            {
                m_teleporterType = value;
            }
        }
        
        private int m_mapId;
        
        public virtual int MapId
        {
            get
            {
                return m_mapId;
            }
            set
            {
                m_mapId = value;
            }
        }
        
        public TeleportRequestMessage(byte teleporterType, int mapId)
        {
            m_teleporterType = teleporterType;
            m_mapId = mapId;
        }
        
        public TeleportRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_teleporterType);
            writer.WriteInt(m_mapId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_teleporterType = reader.ReadByte();
            m_mapId = reader.ReadInt();
        }
    }
}