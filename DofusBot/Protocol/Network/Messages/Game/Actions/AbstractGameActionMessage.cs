//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Actions
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class AbstractGameActionMessage : NetworkMessage
    {
        
        public const int ProtocolId = 1000;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_actionId;
        
        public virtual ushort ActionId
        {
            get
            {
                return m_actionId;
            }
            set
            {
                m_actionId = value;
            }
        }
        
        private double m_sourceId;
        
        public virtual double SourceId
        {
            get
            {
                return m_sourceId;
            }
            set
            {
                m_sourceId = value;
            }
        }
        
        public AbstractGameActionMessage(ushort actionId, double sourceId)
        {
            m_actionId = actionId;
            m_sourceId = sourceId;
        }
        
        public AbstractGameActionMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhShort(m_actionId);
            writer.WriteDouble(m_sourceId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_actionId = reader.ReadVarUhShort();
            m_sourceId = reader.ReadDouble();
        }
    }
}
