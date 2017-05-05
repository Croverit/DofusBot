//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Guild.Tax
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    
    
    using DofusBot.Protocol;
    
    
    public class GuildFightLeaveRequestMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5715;
        
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
        
        private ulong m_characterId;
        
        public virtual ulong CharacterId
        {
            get
            {
                return m_characterId;
            }
            set
            {
                m_characterId = value;
            }
        }
        
        public GuildFightLeaveRequestMessage(int taxCollectorId, ulong characterId)
        {
            m_taxCollectorId = taxCollectorId;
            m_characterId = characterId;
        }
        
        public GuildFightLeaveRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_taxCollectorId);
            writer.WriteVarUhLong(m_characterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_taxCollectorId = reader.ReadInt();
            m_characterId = reader.ReadVarUhLong();
        }
    }
}
