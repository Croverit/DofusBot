//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Character.Creation
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class CharacterCanBeCreatedResultMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6733;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_yesYouCan;
        
        public virtual bool YesYouCan
        {
            get
            {
                return m_yesYouCan;
            }
            set
            {
                m_yesYouCan = value;
            }
        }
        
        public CharacterCanBeCreatedResultMessage(bool yesYouCan)
        {
            m_yesYouCan = yesYouCan;
        }
        
        public CharacterCanBeCreatedResultMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_yesYouCan);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_yesYouCan = reader.ReadBoolean();
        }
    }
}
