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
    using DofusBot.Protocol.Network.Types.Game.Look;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class GameContextRefreshEntityLookMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5637;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private EntityLook m_look;
        
        public virtual EntityLook Look
        {
            get
            {
                return m_look;
            }
            set
            {
                m_look = value;
            }
        }
        
        private double m_ObjectId;
        
        public virtual double ObjectId
        {
            get
            {
                return m_ObjectId;
            }
            set
            {
                m_ObjectId = value;
            }
        }
        
        public GameContextRefreshEntityLookMessage(EntityLook look, double objectId)
        {
            m_look = look;
            m_ObjectId = objectId;
        }
        
        public GameContextRefreshEntityLookMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_look.Serialize(writer);
            writer.WriteDouble(m_ObjectId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_look = new EntityLook();
            m_look.Deserialize(reader);
            m_ObjectId = reader.ReadDouble();
        }
    }
}
