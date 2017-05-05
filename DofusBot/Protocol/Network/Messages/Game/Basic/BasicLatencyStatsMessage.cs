//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Basic
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class BasicLatencyStatsMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5663;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_latency;
        
        public virtual ushort Latency
        {
            get
            {
                return m_latency;
            }
            set
            {
                m_latency = value;
            }
        }
        
        private ushort m_sampleCount;
        
        public virtual ushort SampleCount
        {
            get
            {
                return m_sampleCount;
            }
            set
            {
                m_sampleCount = value;
            }
        }
        
        private ushort m_max;
        
        public virtual ushort Max
        {
            get
            {
                return m_max;
            }
            set
            {
                m_max = value;
            }
        }
        
        public BasicLatencyStatsMessage(ushort latency, ushort sampleCount, ushort max)
        {
            m_latency = latency;
            m_sampleCount = sampleCount;
            m_max = max;
        }
        
        public BasicLatencyStatsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(m_latency);
            writer.WriteVarUhShort(m_sampleCount);
            writer.WriteVarUhShort(m_max);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_latency = reader.ReadUShort();
            m_sampleCount = reader.ReadVarUhShort();
            m_max = reader.ReadVarUhShort();
        }
    }
}
