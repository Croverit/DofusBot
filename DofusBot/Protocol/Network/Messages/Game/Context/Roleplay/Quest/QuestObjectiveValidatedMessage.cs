//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Context.Roleplay.Quest
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class QuestObjectiveValidatedMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6098;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_questId;
        
        public virtual ushort QuestId
        {
            get
            {
                return m_questId;
            }
            set
            {
                m_questId = value;
            }
        }
        
        private ushort m_objectiveId;
        
        public virtual ushort ObjectiveId
        {
            get
            {
                return m_objectiveId;
            }
            set
            {
                m_objectiveId = value;
            }
        }
        
        public QuestObjectiveValidatedMessage(ushort questId, ushort objectiveId)
        {
            m_questId = questId;
            m_objectiveId = objectiveId;
        }
        
        public QuestObjectiveValidatedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhShort(m_questId);
            writer.WriteVarUhShort(m_objectiveId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_questId = reader.ReadVarUhShort();
            m_objectiveId = reader.ReadVarUhShort();
        }
    }
}
