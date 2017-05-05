//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Paddock
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    
    
    using DofusBot.Protocol;
    
    
    public class PaddockInformationsForSell : NetworkType
    {
        
        public const int ProtocolId = 222;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_guildOwner;
        
        public virtual string GuildOwner
        {
            get
            {
                return m_guildOwner;
            }
            set
            {
                m_guildOwner = value;
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
        
        private byte m_nbMount;
        
        public virtual byte NbMount
        {
            get
            {
                return m_nbMount;
            }
            set
            {
                m_nbMount = value;
            }
        }
        
        private byte m_nbObject;
        
        public virtual byte NbObject
        {
            get
            {
                return m_nbObject;
            }
            set
            {
                m_nbObject = value;
            }
        }
        
        private ulong m_price;
        
        public virtual ulong Price
        {
            get
            {
                return m_price;
            }
            set
            {
                m_price = value;
            }
        }
        
        public PaddockInformationsForSell(string guildOwner, short worldX, short worldY, ushort subAreaId, byte nbMount, byte nbObject, ulong price)
        {
            m_guildOwner = guildOwner;
            m_worldX = worldX;
            m_worldY = worldY;
            m_subAreaId = subAreaId;
            m_nbMount = nbMount;
            m_nbObject = nbObject;
            m_price = price;
        }
        
        public PaddockInformationsForSell()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_guildOwner);
            writer.WriteShort(m_worldX);
            writer.WriteShort(m_worldY);
            writer.WriteVarUhShort(m_subAreaId);
            writer.WriteByte(m_nbMount);
            writer.WriteByte(m_nbObject);
            writer.WriteVarUhLong(m_price);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_guildOwner = reader.ReadUTF();
            m_worldX = reader.ReadShort();
            m_worldY = reader.ReadShort();
            m_subAreaId = reader.ReadVarUhShort();
            m_nbMount = reader.ReadByte();
            m_nbObject = reader.ReadByte();
            m_price = reader.ReadVarUhLong();
        }
    }
}
