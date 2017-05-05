//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Inventory.Exchanges
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class ExchangeMountFreeFromPaddockMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6055;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_name;
        
        public virtual string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }
        
        private short m_worldX;
        
        public virtual short WorldX
        {
            get
            {
                return m_worldX;
            }
            set
            {
                m_worldX = value;
            }
        }
        
        private short m_worldY;
        
        public virtual short WorldY
        {
            get
            {
                return m_worldY;
            }
            set
            {
                m_worldY = value;
            }
        }
        
        private string m_liberator;
        
        public virtual string Liberator
        {
            get
            {
                return m_liberator;
            }
            set
            {
                m_liberator = value;
            }
        }
        
        public ExchangeMountFreeFromPaddockMessage(string name, short worldX, short worldY, string liberator)
        {
            m_name = name;
            m_worldX = worldX;
            m_worldY = worldY;
            m_liberator = liberator;
        }
        
        public ExchangeMountFreeFromPaddockMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_name);
            writer.WriteShort(m_worldX);
            writer.WriteShort(m_worldY);
            writer.WriteUTF(m_liberator);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_name = reader.ReadUTF();
            m_worldX = reader.ReadShort();
            m_worldY = reader.ReadShort();
            m_liberator = reader.ReadUTF();
        }
    }
}
