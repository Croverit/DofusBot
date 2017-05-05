//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Context
{
    using DofusBot.Protocol.Network.Types.Game.Context;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class GameContextMoveMultipleElementsMessage : NetworkMessage
    {
        
        public const int ProtocolId = 254;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<EntityMovementInformations> m_movements;
        
        public virtual List<EntityMovementInformations> Movements
        {
            get
            {
                return m_movements;
            }
            set
            {
                m_movements = value;
            }
        }
        
        public GameContextMoveMultipleElementsMessage(List<EntityMovementInformations> movements)
        {
            m_movements = movements;
        }
        
        public GameContextMoveMultipleElementsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_movements.Count)));
            int movementsIndex;
            for (movementsIndex = 0; (movementsIndex < m_movements.Count); movementsIndex = (movementsIndex + 1))
            {
                EntityMovementInformations objectToSend = m_movements[movementsIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int movementsCount = reader.ReadUShort();
            int movementsIndex;
            m_movements = new System.Collections.Generic.List<EntityMovementInformations>();
            for (movementsIndex = 0; (movementsIndex < movementsCount); movementsIndex = (movementsIndex + 1))
            {
                EntityMovementInformations objectToAdd = new EntityMovementInformations();
                objectToAdd.Deserialize(reader);
                m_movements.Add(objectToAdd);
            }
        }
    }
}
