//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Interactive.Zaap
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class TeleportDestinationsListMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5960;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.Int32> m_mapIds;
        
        public virtual List<System.Int32> MapIds
        {
            get
            {
                return m_mapIds;
            }
            set
            {
                m_mapIds = value;
            }
        }
        
        private List<System.UInt16> m_subAreaIds;
        
        public virtual List<System.UInt16> SubAreaIds
        {
            get
            {
                return m_subAreaIds;
            }
            set
            {
                m_subAreaIds = value;
            }
        }
        
        private List<System.UInt16> m_costs;
        
        public virtual List<System.UInt16> Costs
        {
            get
            {
                return m_costs;
            }
            set
            {
                m_costs = value;
            }
        }
        
        private List<System.Byte> m_destTeleporterType;
        
        public virtual List<System.Byte> DestTeleporterType
        {
            get
            {
                return m_destTeleporterType;
            }
            set
            {
                m_destTeleporterType = value;
            }
        }
        
        private byte m_teleporterType;
        
        public virtual byte TeleporterType
        {
            get
            {
                return m_teleporterType;
            }
            set
            {
                m_teleporterType = value;
            }
        }
        
        public TeleportDestinationsListMessage(List<System.Int32> mapIds, List<System.UInt16> subAreaIds, List<System.UInt16> costs, List<System.Byte> destTeleporterType, byte teleporterType)
        {
            m_mapIds = mapIds;
            m_subAreaIds = subAreaIds;
            m_costs = costs;
            m_destTeleporterType = destTeleporterType;
            m_teleporterType = teleporterType;
        }
        
        public TeleportDestinationsListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_mapIds.Count)));
            int mapIdsIndex;
            for (mapIdsIndex = 0; (mapIdsIndex < m_mapIds.Count); mapIdsIndex = (mapIdsIndex + 1))
            {
                writer.WriteInt(m_mapIds[mapIdsIndex]);
            }
            writer.WriteShort(((short)(m_subAreaIds.Count)));
            int subAreaIdsIndex;
            for (subAreaIdsIndex = 0; (subAreaIdsIndex < m_subAreaIds.Count); subAreaIdsIndex = (subAreaIdsIndex + 1))
            {
                writer.WriteVarUhShort(m_subAreaIds[subAreaIdsIndex]);
            }
            writer.WriteShort(((short)(m_costs.Count)));
            int costsIndex;
            for (costsIndex = 0; (costsIndex < m_costs.Count); costsIndex = (costsIndex + 1))
            {
                writer.WriteVarUhShort(m_costs[costsIndex]);
            }
            writer.WriteShort(((short)(m_destTeleporterType.Count)));
            int destTeleporterTypeIndex;
            for (destTeleporterTypeIndex = 0; (destTeleporterTypeIndex < m_destTeleporterType.Count); destTeleporterTypeIndex = (destTeleporterTypeIndex + 1))
            {
                writer.WriteByte(m_destTeleporterType[destTeleporterTypeIndex]);
            }
            writer.WriteByte(m_teleporterType);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int mapIdsCount = reader.ReadUShort();
            int mapIdsIndex;
            m_mapIds = new System.Collections.Generic.List<int>();
            for (mapIdsIndex = 0; (mapIdsIndex < mapIdsCount); mapIdsIndex = (mapIdsIndex + 1))
            {
                m_mapIds.Add(reader.ReadInt());
            }
            int subAreaIdsCount = reader.ReadUShort();
            int subAreaIdsIndex;
            m_subAreaIds = new System.Collections.Generic.List<ushort>();
            for (subAreaIdsIndex = 0; (subAreaIdsIndex < subAreaIdsCount); subAreaIdsIndex = (subAreaIdsIndex + 1))
            {
                m_subAreaIds.Add(reader.ReadVarUhShort());
            }
            int costsCount = reader.ReadUShort();
            int costsIndex;
            m_costs = new System.Collections.Generic.List<ushort>();
            for (costsIndex = 0; (costsIndex < costsCount); costsIndex = (costsIndex + 1))
            {
                m_costs.Add(reader.ReadVarUhShort());
            }
            int destTeleporterTypeCount = reader.ReadUShort();
            int destTeleporterTypeIndex;
            m_destTeleporterType = new System.Collections.Generic.List<byte>();
            for (destTeleporterTypeIndex = 0; (destTeleporterTypeIndex < destTeleporterTypeCount); destTeleporterTypeIndex = (destTeleporterTypeIndex + 1))
            {
                m_destTeleporterType.Add(reader.ReadByte());
            }
            m_teleporterType = reader.ReadByte();
        }
    }
}
