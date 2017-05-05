//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Dare
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class DareWonMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6681;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_dareId;
        
        public virtual double DareId
        {
            get
            {
                return m_dareId;
            }
            set
            {
                m_dareId = value;
            }
        }
        
        public DareWonMessage(double dareId)
        {
            m_dareId = dareId;
        }
        
        public DareWonMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(m_dareId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_dareId = reader.ReadDouble();
        }
    }
}