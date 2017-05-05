//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Context.Roleplay.Party
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class NamedPartyTeam : NetworkType
    {
        
        public const int ProtocolId = 469;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_teamId;
        
        public virtual byte TeamId
        {
            get
            {
                return m_teamId;
            }
            set
            {
                m_teamId = value;
            }
        }
        
        private string m_partyName;
        
        public virtual string PartyName
        {
            get
            {
                return m_partyName;
            }
            set
            {
                m_partyName = value;
            }
        }
        
        public NamedPartyTeam(byte teamId, string partyName)
        {
            m_teamId = teamId;
            m_partyName = partyName;
        }
        
        public NamedPartyTeam()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_teamId);
            writer.WriteUTF(m_partyName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_teamId = reader.ReadByte();
            m_partyName = reader.ReadUTF();
        }
    }
}
