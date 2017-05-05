//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Context.Roleplay.Houses
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    
    
    using DofusBot.Protocol;
    
    
    public class HouseBuyRequestMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5738;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_proposedPrice;
        
        public virtual ulong ProposedPrice
        {
            get
            {
                return m_proposedPrice;
            }
            set
            {
                m_proposedPrice = value;
            }
        }
        
        public HouseBuyRequestMessage(ulong proposedPrice)
        {
            m_proposedPrice = proposedPrice;
        }
        
        public HouseBuyRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhLong(m_proposedPrice);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_proposedPrice = reader.ReadVarUhLong();
        }
    }
}
