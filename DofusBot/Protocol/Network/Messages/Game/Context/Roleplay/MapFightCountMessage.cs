//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Context.Roleplay
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class MapFightCountMessage : NetworkMessage
    {
        
        public const int ProtocolId = 210;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_fightCount;
        
        public virtual ushort FightCount
        {
            get
            {
                return m_fightCount;
            }
            set
            {
                m_fightCount = value;
            }
        }
        
        public MapFightCountMessage(ushort fightCount)
        {
            m_fightCount = fightCount;
        }
        
        public MapFightCountMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhShort(m_fightCount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_fightCount = reader.ReadVarUhShort();
        }
    }
}
