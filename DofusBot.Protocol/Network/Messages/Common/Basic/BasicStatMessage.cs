//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Common.Basic
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class BasicStatMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6530;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_timeSpent;
        
        public virtual double TimeSpent
        {
            get
            {
                return m_timeSpent;
            }
            set
            {
                m_timeSpent = value;
            }
        }
        
        private ushort m_statId;
        
        public virtual ushort StatId
        {
            get
            {
                return m_statId;
            }
            set
            {
                m_statId = value;
            }
        }
        
        public BasicStatMessage(double timeSpent, ushort statId)
        {
            m_timeSpent = timeSpent;
            m_statId = statId;
        }
        
        public BasicStatMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(m_timeSpent);
            writer.WriteVarUhShort(m_statId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_timeSpent = reader.ReadDouble();
            m_statId = reader.ReadVarUhShort();
        }
    }
}
