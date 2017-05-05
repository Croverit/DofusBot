//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Context.Roleplay.Houses
{
    using DofusBot.Protocol.Network.Types.Game.House;
    using DofusBot.Protocol.Network;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class HousePropertiesMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5734;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.Int32> m_doorsOnMap;
        
        public virtual List<System.Int32> DoorsOnMap
        {
            get
            {
                return m_doorsOnMap;
            }
            set
            {
                m_doorsOnMap = value;
            }
        }
        
        private HouseInstanceInformations m_properties;
        
        public virtual HouseInstanceInformations Properties
        {
            get
            {
                return m_properties;
            }
            set
            {
                m_properties = value;
            }
        }
        
        private uint m_houseId;
        
        public virtual uint HouseId
        {
            get
            {
                return m_houseId;
            }
            set
            {
                m_houseId = value;
            }
        }
        
        public HousePropertiesMessage(List<System.Int32> doorsOnMap, HouseInstanceInformations properties, uint houseId)
        {
            m_doorsOnMap = doorsOnMap;
            m_properties = properties;
            m_houseId = houseId;
        }
        
        public HousePropertiesMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_doorsOnMap.Count)));
            int doorsOnMapIndex;
            for (doorsOnMapIndex = 0; (doorsOnMapIndex < m_doorsOnMap.Count); doorsOnMapIndex = (doorsOnMapIndex + 1))
            {
                writer.WriteInt(m_doorsOnMap[doorsOnMapIndex]);
            }
            writer.WriteUShort(((ushort)(m_properties.TypeID)));
            m_properties.Serialize(writer);
            writer.WriteVarUhInt(m_houseId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int doorsOnMapCount = reader.ReadUShort();
            int doorsOnMapIndex;
            m_doorsOnMap = new System.Collections.Generic.List<int>();
            for (doorsOnMapIndex = 0; (doorsOnMapIndex < doorsOnMapCount); doorsOnMapIndex = (doorsOnMapIndex + 1))
            {
                m_doorsOnMap.Add(reader.ReadInt());
            }
            m_properties = ProtocolManager.GetTypeInstance<HouseInstanceInformations>(reader.ReadUShort());
            m_properties.Deserialize(reader);
            m_houseId = reader.ReadVarUhInt();
        }
    }
}
