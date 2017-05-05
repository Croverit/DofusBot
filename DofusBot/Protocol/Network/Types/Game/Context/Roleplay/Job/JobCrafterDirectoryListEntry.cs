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
    
    
    public class JobCrafterDirectoryListEntry : NetworkType
    {
        
        public const int ProtocolId = 196;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private JobCrafterDirectoryEntryPlayerInfo m_playerInfo;
        
        public virtual JobCrafterDirectoryEntryPlayerInfo PlayerInfo
        {
            get
            {
                return m_playerInfo;
            }
            set
            {
                m_playerInfo = value;
            }
        }
        
        private JobCrafterDirectoryEntryJobInfo m_jobInfo;
        
        public virtual JobCrafterDirectoryEntryJobInfo JobInfo
        {
            get
            {
                return m_jobInfo;
            }
            set
            {
                m_jobInfo = value;
            }
        }
        
        public JobCrafterDirectoryListEntry(JobCrafterDirectoryEntryPlayerInfo playerInfo, JobCrafterDirectoryEntryJobInfo jobInfo)
        {
            m_playerInfo = playerInfo;
            m_jobInfo = jobInfo;
        }
        
        public JobCrafterDirectoryListEntry()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_playerInfo.Serialize(writer);
            m_jobInfo.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_playerInfo = new JobCrafterDirectoryEntryPlayerInfo();
            m_playerInfo.Deserialize(reader);
            m_jobInfo = new JobCrafterDirectoryEntryJobInfo();
            m_jobInfo.Deserialize(reader);
        }
    }
}
