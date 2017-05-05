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
    
    
    public class ExchangeClearPaymentForCraftMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6145;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_paymentType;
        
        public virtual byte PaymentType
        {
            get
            {
                return m_paymentType;
            }
            set
            {
                m_paymentType = value;
            }
        }
        
        public ExchangeClearPaymentForCraftMessage(byte paymentType)
        {
            m_paymentType = paymentType;
        }
        
        public ExchangeClearPaymentForCraftMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_paymentType);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_paymentType = reader.ReadByte();
        }
    }
}
