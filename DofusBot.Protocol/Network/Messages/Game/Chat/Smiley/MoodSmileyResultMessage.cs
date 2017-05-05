//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Chat.Smiley
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class MoodSmileyResultMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6196;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_resultCode;
        
        public virtual byte ResultCode
        {
            get
            {
                return m_resultCode;
            }
            set
            {
                m_resultCode = value;
            }
        }
        
        private ushort m_smileyId;
        
        public virtual ushort SmileyId
        {
            get
            {
                return m_smileyId;
            }
            set
            {
                m_smileyId = value;
            }
        }
        
        public MoodSmileyResultMessage(byte resultCode, ushort smileyId)
        {
            m_resultCode = resultCode;
            m_smileyId = smileyId;
        }
        
        public MoodSmileyResultMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_resultCode);
            writer.WriteVarUhShort(m_smileyId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_resultCode = reader.ReadByte();
            m_smileyId = reader.ReadVarUhShort();
        }
    }
}