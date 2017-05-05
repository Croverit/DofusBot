//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Actions.Fight
{
    using DofusBot.Protocol.Network.Messages.Game.Actions;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class GameActionFightSlideMessage : AbstractGameActionMessage
    {
        
        public const int ProtocolId = 5525;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_targetId;
        
        public virtual double TargetId
        {
            get
            {
                return m_targetId;
            }
            set
            {
                m_targetId = value;
            }
        }
        
        private short m_startCellId;
        
        public virtual short StartCellId
        {
            get
            {
                return m_startCellId;
            }
            set
            {
                m_startCellId = value;
            }
        }
        
        private short m_endCellId;
        
        public virtual short EndCellId
        {
            get
            {
                return m_endCellId;
            }
            set
            {
                m_endCellId = value;
            }
        }
        
        public GameActionFightSlideMessage(double targetId, short startCellId, short endCellId)
        {
            m_targetId = targetId;
            m_startCellId = startCellId;
            m_endCellId = endCellId;
        }
        
        public GameActionFightSlideMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(m_targetId);
            writer.WriteShort(m_startCellId);
            writer.WriteShort(m_endCellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_targetId = reader.ReadDouble();
            m_startCellId = reader.ReadShort();
            m_endCellId = reader.ReadShort();
        }
    }
}
