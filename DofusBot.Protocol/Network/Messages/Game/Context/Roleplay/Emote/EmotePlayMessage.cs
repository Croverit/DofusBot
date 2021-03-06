//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Context.Roleplay.Emote
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class EmotePlayMessage : EmotePlayAbstractMessage
    {
        
        public const int ProtocolId = 5683;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_actorId;
        
        public virtual double ActorId
        {
            get
            {
                return m_actorId;
            }
            set
            {
                m_actorId = value;
            }
        }
        
        private int m_accountId;
        
        public virtual int AccountId
        {
            get
            {
                return m_accountId;
            }
            set
            {
                m_accountId = value;
            }
        }
        
        public EmotePlayMessage(double actorId, int accountId)
        {
            m_actorId = actorId;
            m_accountId = accountId;
        }
        
        public EmotePlayMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(m_actorId);
            writer.WriteInt(m_accountId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_actorId = reader.ReadDouble();
            m_accountId = reader.ReadInt();
        }
    }
}
