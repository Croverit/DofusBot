//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Context.Roleplay.Job
{
    using DofusBot.Protocol.Network.Types.Game.Context.Roleplay.Job;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class JobDescriptionMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5655;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<JobDescription> m_jobsDescription;
        
        public virtual List<JobDescription> JobsDescription
        {
            get
            {
                return m_jobsDescription;
            }
            set
            {
                m_jobsDescription = value;
            }
        }
        
        public JobDescriptionMessage(List<JobDescription> jobsDescription)
        {
            m_jobsDescription = jobsDescription;
        }
        
        public JobDescriptionMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_jobsDescription.Count)));
            int jobsDescriptionIndex;
            for (jobsDescriptionIndex = 0; (jobsDescriptionIndex < m_jobsDescription.Count); jobsDescriptionIndex = (jobsDescriptionIndex + 1))
            {
                JobDescription objectToSend = m_jobsDescription[jobsDescriptionIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int jobsDescriptionCount = reader.ReadUShort();
            int jobsDescriptionIndex;
            m_jobsDescription = new System.Collections.Generic.List<JobDescription>();
            for (jobsDescriptionIndex = 0; (jobsDescriptionIndex < jobsDescriptionCount); jobsDescriptionIndex = (jobsDescriptionIndex + 1))
            {
                JobDescription objectToAdd = new JobDescription();
                objectToAdd.Deserialize(reader);
                m_jobsDescription.Add(objectToAdd);
            }
        }
    }
}
