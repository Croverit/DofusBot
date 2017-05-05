//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Character.Stats
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class CharacterExperienceGainMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6321;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_experienceCharacter;
        
        public virtual ulong ExperienceCharacter
        {
            get
            {
                return m_experienceCharacter;
            }
            set
            {
                m_experienceCharacter = value;
            }
        }
        
        private ulong m_experienceMount;
        
        public virtual ulong ExperienceMount
        {
            get
            {
                return m_experienceMount;
            }
            set
            {
                m_experienceMount = value;
            }
        }
        
        private ulong m_experienceGuild;
        
        public virtual ulong ExperienceGuild
        {
            get
            {
                return m_experienceGuild;
            }
            set
            {
                m_experienceGuild = value;
            }
        }
        
        private ulong m_experienceIncarnation;
        
        public virtual ulong ExperienceIncarnation
        {
            get
            {
                return m_experienceIncarnation;
            }
            set
            {
                m_experienceIncarnation = value;
            }
        }
        
        public CharacterExperienceGainMessage(ulong experienceCharacter, ulong experienceMount, ulong experienceGuild, ulong experienceIncarnation)
        {
            m_experienceCharacter = experienceCharacter;
            m_experienceMount = experienceMount;
            m_experienceGuild = experienceGuild;
            m_experienceIncarnation = experienceIncarnation;
        }
        
        public CharacterExperienceGainMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhLong(m_experienceCharacter);
            writer.WriteVarUhLong(m_experienceMount);
            writer.WriteVarUhLong(m_experienceGuild);
            writer.WriteVarUhLong(m_experienceIncarnation);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_experienceCharacter = reader.ReadVarUhLong();
            m_experienceMount = reader.ReadVarUhLong();
            m_experienceGuild = reader.ReadVarUhLong();
            m_experienceIncarnation = reader.ReadVarUhLong();
        }
    }
}
