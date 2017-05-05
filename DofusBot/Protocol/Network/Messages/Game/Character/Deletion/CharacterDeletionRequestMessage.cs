//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Character.Deletion
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class CharacterDeletionRequestMessage : NetworkMessage
    {
        
        public const int ProtocolId = 165;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
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
        
        private string m_secretAnswerHash;
        
        public virtual string SecretAnswerHash
        {
            get
            {
                return m_secretAnswerHash;
            }
            set
            {
                m_secretAnswerHash = value;
            }
        }
        
        public CharacterDeletionRequestMessage(ulong characterId, string secretAnswerHash)
        {
            m_characterId = characterId;
            m_secretAnswerHash = secretAnswerHash;
        }
        
        public CharacterDeletionRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhLong(m_characterId);
            writer.WriteUTF(m_secretAnswerHash);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_characterId = reader.ReadVarUhLong();
            m_secretAnswerHash = reader.ReadUTF();
        }
    }
}
