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
    
    
    public class ExchangeBidHouseGenericItemAddedMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5947;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_objGenericId;
        
        public virtual ushort ObjGenericId
        {
            get
            {
                return m_objGenericId;
            }
            set
            {
                m_objGenericId = value;
            }
        }
        
        public ExchangeBidHouseGenericItemAddedMessage(ushort objGenericId)
        {
            m_objGenericId = objGenericId;
        }
        
        public ExchangeBidHouseGenericItemAddedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhShort(m_objGenericId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_objGenericId = reader.ReadVarUhShort();
        }
    }
}
