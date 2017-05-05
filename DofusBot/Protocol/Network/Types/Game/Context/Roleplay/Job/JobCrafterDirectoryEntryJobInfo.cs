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
    
    
    public class JobCrafterDirectoryEntryJobInfo : NetworkType
    {
        
        public const int ProtocolId = 195;
        
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
        
        private sbyte m_jobLevel;
        
        public virtual sbyte JobLevel
        {
            get
            {
                return m_jobLevel;
            }
            set
            {
                m_jobLevel = value;
            }
        }
        
        private bool m_free;
        
        public virtual bool Free
        {
            get
            {
                return m_free;
            }
            set
            {
                m_free = value;
            }
        }
        
        private sbyte m_minLevel;
        
        public virtual sbyte MinLevel
        {
            get
            {
                return m_minLevel;
            }
            set
            {
                m_minLevel = value;
            }
        }
        
        public JobCrafterDirectoryEntryJobInfo(byte jobId, sbyte jobLevel, bool free, sbyte minLevel)
        {
            m_jobId = jobId;
            m_jobLevel = jobLevel;
            m_free = free;
            m_minLevel = minLevel;
        }
        
        public JobCrafterDirectoryEntryJobInfo()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_jobId);
            writer.WriteSByte(m_jobLevel);
            writer.WriteBoolean(m_free);
            writer.WriteSByte(m_minLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_jobId = reader.ReadByte();
            m_jobLevel = reader.ReadSByte();
            m_free = reader.ReadBoolean();
            m_minLevel = reader.ReadSByte();
        }
    }
}
