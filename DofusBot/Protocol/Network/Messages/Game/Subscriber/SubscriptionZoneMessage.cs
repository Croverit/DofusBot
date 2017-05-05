//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Subscriber
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class SubscriptionZoneMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5573;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_active;
        
        public virtual bool Active
        {
            get
            {
                return m_active;
            }
            set
            {
                m_active = value;
            }
        }
        
        public SubscriptionZoneMessage(bool active)
        {
            m_active = active;
        }
        
        public SubscriptionZoneMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_active);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_active = reader.ReadBoolean();
        }
    }
}
