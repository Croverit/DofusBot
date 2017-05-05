//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Inventory.Items
{
    using DofusBot.Protocol.Network.Messages.Game.Inventory.Exchanges;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class ExchangeObjectsRemovedMessage : ExchangeObjectMessage
    {
        
        public const int ProtocolId = 6532;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt32> m_objectUID;
        
        public virtual List<System.UInt32> ObjectUID
        {
            get
            {
                return m_objectUID;
            }
            set
            {
                m_objectUID = value;
            }
        }
        
        public ExchangeObjectsRemovedMessage(List<System.UInt32> objectUID)
        {
            m_objectUID = objectUID;
        }
        
        public ExchangeObjectsRemovedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_objectUID.Count)));
            int objectUIDIndex;
            for (objectUIDIndex = 0; (objectUIDIndex < m_objectUID.Count); objectUIDIndex = (objectUIDIndex + 1))
            {
                writer.WriteVarUhInt(m_objectUID[objectUIDIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int objectUIDCount = reader.ReadUShort();
            int objectUIDIndex;
            m_objectUID = new System.Collections.Generic.List<uint>();
            for (objectUIDIndex = 0; (objectUIDIndex < objectUIDCount); objectUIDIndex = (objectUIDIndex + 1))
            {
                m_objectUID.Add(reader.ReadVarUhInt());
            }
        }
    }
}
