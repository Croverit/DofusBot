//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Prism
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class PrismFightJoinLeaveRequestMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5843;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_subAreaId;
        
        public virtual ushort SubAreaId
        {
            get
            {
                return m_subAreaId;
            }
            set
            {
                m_subAreaId = value;
            }
        }
        
        private bool m_join;
        
        public virtual bool Join
        {
            get
            {
                return m_join;
            }
            set
            {
                m_join = value;
            }
        }
        
        public PrismFightJoinLeaveRequestMessage(ushort subAreaId, bool join)
        {
            m_subAreaId = subAreaId;
            m_join = join;
        }
        
        public PrismFightJoinLeaveRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhShort(m_subAreaId);
            writer.WriteBoolean(m_join);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_subAreaId = reader.ReadVarUhShort();
            m_join = reader.ReadBoolean();
        }
    }
}
