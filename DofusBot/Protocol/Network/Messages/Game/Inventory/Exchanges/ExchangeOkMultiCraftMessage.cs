//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Inventory.Exchanges
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    
    
    using DofusBot.Protocol;
    
    
    public class ExchangeOkMultiCraftMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5768;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_initiatorId;
        
        public virtual ulong InitiatorId
        {
            get
            {
                return m_initiatorId;
            }
            set
            {
                m_initiatorId = value;
            }
        }
        
        private ulong m_otherId;
        
        public virtual ulong OtherId
        {
            get
            {
                return m_otherId;
            }
            set
            {
                m_otherId = value;
            }
        }
        
        private byte m_role;
        
        public virtual byte Role
        {
            get
            {
                return m_role;
            }
            set
            {
                m_role = value;
            }
        }
        
        public ExchangeOkMultiCraftMessage(ulong initiatorId, ulong otherId, byte role)
        {
            m_initiatorId = initiatorId;
            m_otherId = otherId;
            m_role = role;
        }
        
        public ExchangeOkMultiCraftMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhLong(m_initiatorId);
            writer.WriteVarUhLong(m_otherId);
            writer.WriteByte(m_role);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_initiatorId = reader.ReadVarUhLong();
            m_otherId = reader.ReadVarUhLong();
            m_role = reader.ReadByte();
        }
    }
}
