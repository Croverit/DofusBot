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
    
    
    public class ExchangeModifiedPaymentForCraftMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5832;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_onlySuccess;
        
        public virtual bool OnlySuccess
        {
            get
            {
                return m_onlySuccess;
            }
            set
            {
                m_onlySuccess = value;
            }
        }
        
        private ObjectItemNotInContainer m_object;
        
        public virtual ObjectItemNotInContainer Object
        {
            get
            {
                return m_object;
            }
            set
            {
                m_object = value;
            }
        }
        
        public ExchangeModifiedPaymentForCraftMessage(bool onlySuccess, ObjectItemNotInContainer @object)
        {
            m_onlySuccess = onlySuccess;
            m_object = @object;
        }
        
        public ExchangeModifiedPaymentForCraftMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_onlySuccess);
            m_object.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_onlySuccess = reader.ReadBoolean();
            m_object = new ObjectItemNotInContainer();
            m_object.Deserialize(reader);
        }
    }
}
