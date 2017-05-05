//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Context.Roleplay.TreasureHunt
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class TreasureHuntFinishedMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6483;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_questType;
        
        public virtual byte QuestType
        {
            get
            {
                return m_questType;
            }
            set
            {
                m_questType = value;
            }
        }
        
        public TreasureHuntFinishedMessage(byte questType)
        {
            m_questType = questType;
        }
        
        public TreasureHuntFinishedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_questType);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_questType = reader.ReadByte();
        }
    }
}
