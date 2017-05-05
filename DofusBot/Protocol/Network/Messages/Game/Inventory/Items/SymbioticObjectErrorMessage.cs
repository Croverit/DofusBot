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
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class SymbioticObjectErrorMessage : ObjectErrorMessage
    {
        
        public const int ProtocolId = 6526;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_errorCode;
        
        public virtual byte ErrorCode
        {
            get
            {
                return m_errorCode;
            }
            set
            {
                m_errorCode = value;
            }
        }
        
        public SymbioticObjectErrorMessage(byte errorCode)
        {
            m_errorCode = errorCode;
        }
        
        public SymbioticObjectErrorMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_errorCode);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_errorCode = reader.ReadByte();
        }
    }
}
