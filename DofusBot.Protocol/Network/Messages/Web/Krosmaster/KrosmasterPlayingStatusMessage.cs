//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Web.Krosmaster
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class KrosmasterPlayingStatusMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6347;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_playing;
        
        public virtual bool Playing
        {
            get
            {
                return m_playing;
            }
            set
            {
                m_playing = value;
            }
        }
        
        public KrosmasterPlayingStatusMessage(bool playing)
        {
            m_playing = playing;
        }
        
        public KrosmasterPlayingStatusMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_playing);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_playing = reader.ReadBoolean();
        }
    }
}
