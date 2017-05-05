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
    
    
    public class ExchangeRequestOnTaxCollectorMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5779;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_taxCollectorId;
        
        public virtual int TaxCollectorId
        {
            get
            {
                return m_taxCollectorId;
            }
            set
            {
                m_taxCollectorId = value;
            }
        }
        
        public ExchangeRequestOnTaxCollectorMessage(int taxCollectorId)
        {
            m_taxCollectorId = taxCollectorId;
        }
        
        public ExchangeRequestOnTaxCollectorMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_taxCollectorId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_taxCollectorId = reader.ReadInt();
        }
    }
}
