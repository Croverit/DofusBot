//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Interactive.Meeting
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    
    
    using DofusBot.Protocol;
    
    
    public class TeleportToBuddyAnswerMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6293;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_dungeonId;
        
        public virtual ushort DungeonId
        {
            get
            {
                return m_dungeonId;
            }
            set
            {
                m_dungeonId = value;
            }
        }
        
        private ulong m_buddyId;
        
        public virtual ulong BuddyId
        {
            get
            {
                return m_buddyId;
            }
            set
            {
                m_buddyId = value;
            }
        }
        
        private bool m_accept;
        
        public virtual bool Accept
        {
            get
            {
                return m_accept;
            }
            set
            {
                m_accept = value;
            }
        }
        
        public TeleportToBuddyAnswerMessage(ushort dungeonId, ulong buddyId, bool accept)
        {
            m_dungeonId = dungeonId;
            m_buddyId = buddyId;
            m_accept = accept;
        }
        
        public TeleportToBuddyAnswerMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhShort(m_dungeonId);
            writer.WriteVarUhLong(m_buddyId);
            writer.WriteBoolean(m_accept);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_dungeonId = reader.ReadVarUhShort();
            m_buddyId = reader.ReadVarUhLong();
            m_accept = reader.ReadBoolean();
        }
    }
}
