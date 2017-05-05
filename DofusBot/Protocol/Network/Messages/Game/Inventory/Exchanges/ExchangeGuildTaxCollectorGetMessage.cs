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
    using DofusBot.Protocol.Network.Types.Game.Data.Items;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    
    
    using DofusBot.Protocol;
    
    
    public class ExchangeGuildTaxCollectorGetMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5762;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<ObjectItemGenericQuantity> m_objectsInfos;
        
        public virtual List<ObjectItemGenericQuantity> ObjectsInfos
        {
            get
            {
                return m_objectsInfos;
            }
            set
            {
                m_objectsInfos = value;
            }
        }
        
        private string m_collectorName;
        
        public virtual string CollectorName
        {
            get
            {
                return m_collectorName;
            }
            set
            {
                m_collectorName = value;
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
        
        private int m_mapId;
        
        public virtual int MapId
        {
            get
            {
                return m_mapId;
            }
            set
            {
                m_mapId = value;
            }
        }
        
        private ushort m_subAreaId;
        
        public virtual ushort SubAreaId
        {
            get
            {
                return m_subAreaId;
            }
            set
            {
                m_subAreaId = value;
            }
        }
        
        private string m_userName;
        
        public virtual string UserName
        {
            get
            {
                return m_userName;
            }
            set
            {
                m_userName = value;
            }
        }
        
        private ulong m_callerId;
        
        public virtual ulong CallerId
        {
            get
            {
                return m_callerId;
            }
            set
            {
                m_callerId = value;
            }
        }
        
        private string m_callerName;
        
        public virtual string CallerName
        {
            get
            {
                return m_callerName;
            }
            set
            {
                m_callerName = value;
            }
        }
        
        private double m_experience;
        
        public virtual double Experience
        {
            get
            {
                return m_experience;
            }
            set
            {
                m_experience = value;
            }
        }
        
        private ushort m_pods;
        
        public virtual ushort Pods
        {
            get
            {
                return m_pods;
            }
            set
            {
                m_pods = value;
            }
        }
        
        public ExchangeGuildTaxCollectorGetMessage(List<ObjectItemGenericQuantity> objectsInfos, string collectorName, short worldX, short worldY, int mapId, ushort subAreaId, string userName, ulong callerId, string callerName, double experience, ushort pods)
        {
            m_objectsInfos = objectsInfos;
            m_collectorName = collectorName;
            m_worldX = worldX;
            m_worldY = worldY;
            m_mapId = mapId;
            m_subAreaId = subAreaId;
            m_userName = userName;
            m_callerId = callerId;
            m_callerName = callerName;
            m_experience = experience;
            m_pods = pods;
        }
        
        public ExchangeGuildTaxCollectorGetMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_objectsInfos.Count)));
            int objectsInfosIndex;
            for (objectsInfosIndex = 0; (objectsInfosIndex < m_objectsInfos.Count); objectsInfosIndex = (objectsInfosIndex + 1))
            {
                ObjectItemGenericQuantity objectToSend = m_objectsInfos[objectsInfosIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteUTF(m_collectorName);
            writer.WriteShort(m_worldX);
            writer.WriteShort(m_worldY);
            writer.WriteInt(m_mapId);
            writer.WriteVarUhShort(m_subAreaId);
            writer.WriteUTF(m_userName);
            writer.WriteVarUhLong(m_callerId);
            writer.WriteUTF(m_callerName);
            writer.WriteDouble(m_experience);
            writer.WriteVarUhShort(m_pods);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int objectsInfosCount = reader.ReadUShort();
            int objectsInfosIndex;
            m_objectsInfos = new System.Collections.Generic.List<ObjectItemGenericQuantity>();
            for (objectsInfosIndex = 0; (objectsInfosIndex < objectsInfosCount); objectsInfosIndex = (objectsInfosIndex + 1))
            {
                ObjectItemGenericQuantity objectToAdd = new ObjectItemGenericQuantity();
                objectToAdd.Deserialize(reader);
                m_objectsInfos.Add(objectToAdd);
            }
            m_collectorName = reader.ReadUTF();
            m_worldX = reader.ReadShort();
            m_worldY = reader.ReadShort();
            m_mapId = reader.ReadInt();
            m_subAreaId = reader.ReadVarUhShort();
            m_userName = reader.ReadUTF();
            m_callerId = reader.ReadVarUhLong();
            m_callerName = reader.ReadUTF();
            m_experience = reader.ReadDouble();
            m_pods = reader.ReadVarUhShort();
        }
    }
}
