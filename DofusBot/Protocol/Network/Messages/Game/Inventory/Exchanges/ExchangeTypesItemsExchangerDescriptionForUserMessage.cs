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
    using DofusBot.Protocol.Network.Types.Game.Data.Items;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class ExchangeTypesItemsExchangerDescriptionForUserMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5752;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<BidExchangerObjectInfo> m_itemTypeDescriptions;
        
        public virtual List<BidExchangerObjectInfo> ItemTypeDescriptions
        {
            get
            {
                return m_itemTypeDescriptions;
            }
            set
            {
                m_itemTypeDescriptions = value;
            }
        }
        
        public ExchangeTypesItemsExchangerDescriptionForUserMessage(List<BidExchangerObjectInfo> itemTypeDescriptions)
        {
            m_itemTypeDescriptions = itemTypeDescriptions;
        }
        
        public ExchangeTypesItemsExchangerDescriptionForUserMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_itemTypeDescriptions.Count)));
            int itemTypeDescriptionsIndex;
            for (itemTypeDescriptionsIndex = 0; (itemTypeDescriptionsIndex < m_itemTypeDescriptions.Count); itemTypeDescriptionsIndex = (itemTypeDescriptionsIndex + 1))
            {
                BidExchangerObjectInfo objectToSend = m_itemTypeDescriptions[itemTypeDescriptionsIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int itemTypeDescriptionsCount = reader.ReadUShort();
            int itemTypeDescriptionsIndex;
            m_itemTypeDescriptions = new System.Collections.Generic.List<BidExchangerObjectInfo>();
            for (itemTypeDescriptionsIndex = 0; (itemTypeDescriptionsIndex < itemTypeDescriptionsCount); itemTypeDescriptionsIndex = (itemTypeDescriptionsIndex + 1))
            {
                BidExchangerObjectInfo objectToAdd = new BidExchangerObjectInfo();
                objectToAdd.Deserialize(reader);
                m_itemTypeDescriptions.Add(objectToAdd);
            }
        }
    }
}
