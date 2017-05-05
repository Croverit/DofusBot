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
    
    
    public class ExchangeBidHouseInListRemovedMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5950;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_itemUID;
        
        public virtual int ItemUID
        {
            get
            {
                return m_itemUID;
            }
            set
            {
                m_itemUID = value;
            }
        }
        
        public ExchangeBidHouseInListRemovedMessage(int itemUID)
        {
            m_itemUID = itemUID;
        }
        
        public ExchangeBidHouseInListRemovedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_itemUID);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_itemUID = reader.ReadInt();
        }
    }
}