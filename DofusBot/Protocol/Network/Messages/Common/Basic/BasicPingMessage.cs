//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Common.Basic
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class BasicPingMessage : NetworkMessage
    {
        
        public const int ProtocolId = 182;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_quiet;
        
        public virtual bool Quiet
        {
            get
            {
                return m_quiet;
            }
            set
            {
                m_quiet = value;
            }
        }
        
        public BasicPingMessage(bool quiet)
        {
            m_quiet = quiet;
        }
        
        public BasicPingMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_quiet);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_quiet = reader.ReadBoolean();
        }
    }
}
