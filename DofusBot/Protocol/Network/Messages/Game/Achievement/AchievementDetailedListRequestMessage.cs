//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Achievement
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class AchievementDetailedListRequestMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6357;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_categoryId;
        
        public virtual ushort CategoryId
        {
            get
            {
                return m_categoryId;
            }
            set
            {
                m_categoryId = value;
            }
        }
        
        public AchievementDetailedListRequestMessage(ushort categoryId)
        {
            m_categoryId = categoryId;
        }
        
        public AchievementDetailedListRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhShort(m_categoryId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_categoryId = reader.ReadVarUhShort();
        }
    }
}
