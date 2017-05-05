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
    using DofusBot.Protocol.Network.Types.Game.Data.Items.Effects;
    using DofusBot.Protocol.Network;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    
    
    using DofusBot.Protocol;
    
    
    public class ExchangeBidHouseInListAddedMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5949;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<ObjectEffect> m_effects;
        
        public virtual List<ObjectEffect> Effects
        {
            get
            {
                return m_effects;
            }
            set
            {
                m_effects = value;
            }
        }
        
        private List<System.UInt64> m_prices;
        
        public virtual List<System.UInt64> Prices
        {
            get
            {
                return m_prices;
            }
            set
            {
                m_prices = value;
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
        
        private int m_objGenericId;
        
        public virtual int ObjGenericId
        {
            get
            {
                return m_objGenericId;
            }
            set
            {
                m_objGenericId = value;
            }
        }
        
        public ExchangeBidHouseInListAddedMessage(List<ObjectEffect> effects, List<System.UInt64> prices, int itemUID, int objGenericId)
        {
            m_effects = effects;
            m_prices = prices;
            m_itemUID = itemUID;
            m_objGenericId = objGenericId;
        }
        
        public ExchangeBidHouseInListAddedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_effects.Count)));
            int effectsIndex;
            for (effectsIndex = 0; (effectsIndex < m_effects.Count); effectsIndex = (effectsIndex + 1))
            {
                ObjectEffect objectToSend = m_effects[effectsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteShort(((short)(m_prices.Count)));
            int pricesIndex;
            for (pricesIndex = 0; (pricesIndex < m_prices.Count); pricesIndex = (pricesIndex + 1))
            {
                writer.WriteVarUhLong(m_prices[pricesIndex]);
            }
            writer.WriteInt(m_itemUID);
            writer.WriteInt(m_objGenericId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int effectsCount = reader.ReadUShort();
            int effectsIndex;
            m_effects = new System.Collections.Generic.List<ObjectEffect>();
            for (effectsIndex = 0; (effectsIndex < effectsCount); effectsIndex = (effectsIndex + 1))
            {
                ObjectEffect objectToAdd = ProtocolManager.GetTypeInstance<ObjectEffect>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_effects.Add(objectToAdd);
            }
            int pricesCount = reader.ReadUShort();
            int pricesIndex;
            m_prices = new System.Collections.Generic.List<ulong>();
            for (pricesIndex = 0; (pricesIndex < pricesCount); pricesIndex = (pricesIndex + 1))
            {
                m_prices.Add(reader.ReadVarUhLong());
            }
            m_itemUID = reader.ReadInt();
            m_objGenericId = reader.ReadInt();
        }
    }
}
