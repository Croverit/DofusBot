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
    
    
    public class GameActionFightExchangePositionsMessage : AbstractGameActionMessage
    {
        
        public const int ProtocolId = 5527;
        
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
        
        private short m_casterCellId;
        
        public virtual short CasterCellId
        {
            get
            {
                return m_casterCellId;
            }
            set
            {
                m_casterCellId = value;
            }
        }
        
        private short m_targetCellId;
        
        public virtual short TargetCellId
        {
            get
            {
                return m_targetCellId;
            }
            set
            {
                m_targetCellId = value;
            }
        }
        
        public GameActionFightExchangePositionsMessage(double targetId, short casterCellId, short targetCellId)
        {
            m_targetId = targetId;
            m_casterCellId = casterCellId;
            m_targetCellId = targetCellId;
        }
        
        public GameActionFightExchangePositionsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(m_targetId);
            writer.WriteShort(m_casterCellId);
            writer.WriteShort(m_targetCellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_targetId = reader.ReadDouble();
            m_casterCellId = reader.ReadShort();
            m_targetCellId = reader.ReadShort();
        }
    }
}
