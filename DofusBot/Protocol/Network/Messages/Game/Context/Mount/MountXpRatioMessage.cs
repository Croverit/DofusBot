//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Context.Mount
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class MountXpRatioMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5970;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_ratio;
        
        public virtual byte Ratio
        {
            get
            {
                return m_ratio;
            }
            set
            {
                m_ratio = value;
            }
        }
        
        public MountXpRatioMessage(byte ratio)
        {
            m_ratio = ratio;
        }
        
        public MountXpRatioMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_ratio);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_ratio = reader.ReadByte();
        }
    }
}
