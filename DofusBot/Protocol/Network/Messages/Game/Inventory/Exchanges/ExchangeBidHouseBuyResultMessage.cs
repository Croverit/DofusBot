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
    
    
    public class ExchangeBidHouseBuyResultMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6272;
        
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
        
        private bool m_bought;
        
        public virtual bool Bought
        {
            get
            {
                return m_bought;
            }
            set
            {
                m_bought = value;
            }
        }
        
        public ExchangeBidHouseBuyResultMessage(uint uid, bool bought)
        {
            m_uid = uid;
            m_bought = bought;
        }
        
        public ExchangeBidHouseBuyResultMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhInt(m_uid);
            writer.WriteBoolean(m_bought);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_uid = reader.ReadVarUhInt();
            m_bought = reader.ReadBoolean();
        }
    }
}
