//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Updater.Parts
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class DownloadPartMessage : NetworkMessage
    {
        
        public const int ProtocolId = 1503;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_ObjectId;
        
        public virtual string ObjectId
        {
            get
            {
                return m_ObjectId;
            }
            set
            {
                m_ObjectId = value;
            }
        }
        
        public DownloadPartMessage(string objectId)
        {
            m_ObjectId = objectId;
        }
        
        public DownloadPartMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_ObjectId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_ObjectId = reader.ReadUTF();
        }
    }
}
