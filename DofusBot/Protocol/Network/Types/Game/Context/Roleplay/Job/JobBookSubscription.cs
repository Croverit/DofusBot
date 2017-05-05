//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Context.Roleplay.Job
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class JobBookSubscription : NetworkType
    {
        
        public const int ProtocolId = 500;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_jobId;
        
        public virtual byte JobId
        {
            get
            {
                return m_jobId;
            }
            set
            {
                m_jobId = value;
            }
        }
        
        private bool m_subscribed;
        
        public virtual bool Subscribed
        {
            get
            {
                return m_subscribed;
            }
            set
            {
                m_subscribed = value;
            }
        }
        
        public JobBookSubscription(byte jobId, bool subscribed)
        {
            m_jobId = jobId;
            m_subscribed = subscribed;
        }
        
        public JobBookSubscription()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_jobId);
            writer.WriteBoolean(m_subscribed);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_jobId = reader.ReadByte();
            m_subscribed = reader.ReadBoolean();
        }
    }
}
