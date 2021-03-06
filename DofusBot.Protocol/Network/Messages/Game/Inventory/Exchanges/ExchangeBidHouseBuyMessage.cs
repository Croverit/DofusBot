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
    
    
    public class ExchangeBidHouseBuyMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5804;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_uid;
        
        public virtual uint Uid
        {
            get
            {
                return m_uid;
            }
            set
            {
                m_uid = value;
            }
        }
        
        private uint m_qty;
        
        public virtual uint Qty
        {
            get
            {
                return m_qty;
            }
            set
            {
                m_qty = value;
            }
        }
        
        private ulong m_price;
        
        public virtual ulong Price
        {
            get
            {
                return m_price;
            }
            set
            {
                m_price = value;
            }
        }
        
        public ExchangeBidHouseBuyMessage(uint uid, uint qty, ulong price)
        {
            m_uid = uid;
            m_qty = qty;
            m_price = price;
        }
        
        public ExchangeBidHouseBuyMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhInt(m_uid);
            writer.WriteVarUhInt(m_qty);
            writer.WriteVarUhLong(m_price);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_uid = reader.ReadVarUhInt();
            m_qty = reader.ReadVarUhInt();
            m_price = reader.ReadVarUhLong();
        }
    }
}
