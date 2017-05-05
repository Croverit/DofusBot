//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Connection.Search
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class AcquaintanceSearchMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6144;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_nickname;
        
        public virtual string Nickname
        {
            get
            {
                return m_nickname;
            }
            set
            {
                m_nickname = value;
            }
        }
        
        public AcquaintanceSearchMessage(string nickname)
        {
            m_nickname = nickname;
        }
        
        public AcquaintanceSearchMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_nickname);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_nickname = reader.ReadUTF();
        }
    }
}