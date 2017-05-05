//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Inventory.Exchanges
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class ExchangeObjectTransfertListWithQuantityToInvMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6470;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt32> m_ids;
        
        public virtual List<System.UInt32> Ids
        {
            get
            {
                return m_ids;
            }
            set
            {
                m_ids = value;
            }
        }
        
        private List<System.UInt32> m_qtys;
        
        public virtual List<System.UInt32> Qtys
        {
            get
            {
                return m_qtys;
            }
            set
            {
                m_qtys = value;
            }
        }
        
        public ExchangeObjectTransfertListWithQuantityToInvMessage(List<System.UInt32> ids, List<System.UInt32> qtys)
        {
            m_ids = ids;
            m_qtys = qtys;
        }
        
        public ExchangeObjectTransfertListWithQuantityToInvMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_ids.Count)));
            int idsIndex;
            for (idsIndex = 0; (idsIndex < m_ids.Count); idsIndex = (idsIndex + 1))
            {
                writer.WriteVarUhInt(m_ids[idsIndex]);
            }
            writer.WriteShort(((short)(m_qtys.Count)));
            int qtysIndex;
            for (qtysIndex = 0; (qtysIndex < m_qtys.Count); qtysIndex = (qtysIndex + 1))
            {
                writer.WriteVarUhInt(m_qtys[qtysIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int idsCount = reader.ReadUShort();
            int idsIndex;
            m_ids = new System.Collections.Generic.List<uint>();
            for (idsIndex = 0; (idsIndex < idsCount); idsIndex = (idsIndex + 1))
            {
                m_ids.Add(reader.ReadVarUhInt());
            }
            int qtysCount = reader.ReadUShort();
            int qtysIndex;
            m_qtys = new System.Collections.Generic.List<uint>();
            for (qtysIndex = 0; (qtysIndex < qtysCount); qtysIndex = (qtysIndex + 1))
            {
                m_qtys.Add(reader.ReadVarUhInt());
            }
        }
    }
}
