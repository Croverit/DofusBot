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
    
    
    public class ExchangeSellMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5778;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_objectToSellId;
        
        public virtual uint ObjectToSellId
        {
            get
            {
                return m_objectToSellId;
            }
            set
            {
                m_objectToSellId = value;
            }
        }
        
        private uint m_quantity;
        
        public virtual uint Quantity
        {
            get
            {
                return m_quantity;
            }
            set
            {
                m_quantity = value;
            }
        }
        
        public ExchangeSellMessage(uint objectToSellId, uint quantity)
        {
            m_objectToSellId = objectToSellId;
            m_quantity = quantity;
        }
        
        public ExchangeSellMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhInt(m_objectToSellId);
            writer.WriteVarUhInt(m_quantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_objectToSellId = reader.ReadVarUhInt();
            m_quantity = reader.ReadVarUhInt();
        }
    }
}