//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Social
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class AllianceVersatileInformations : NetworkType
    {
        
        public const int ProtocolId = 432;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_allianceId;
        
        public virtual uint AllianceId
        {
            get
            {
                return m_allianceId;
            }
            set
            {
                m_allianceId = value;
            }
        }
        
        private ushort m_nbGuilds;
        
        public virtual ushort NbGuilds
        {
            get
            {
                return m_nbGuilds;
            }
            set
            {
                m_nbGuilds = value;
            }
        }
        
        private ushort m_nbMembers;
        
        public virtual ushort NbMembers
        {
            get
            {
                return m_nbMembers;
            }
            set
            {
                m_nbMembers = value;
            }
        }
        
        private ushort m_nbSubarea;
        
        public virtual ushort NbSubarea
        {
            get
            {
                return m_nbSubarea;
            }
            set
            {
                m_nbSubarea = value;
            }
        }
        
        public AllianceVersatileInformations(uint allianceId, ushort nbGuilds, ushort nbMembers, ushort nbSubarea)
        {
            m_allianceId = allianceId;
            m_nbGuilds = nbGuilds;
            m_nbMembers = nbMembers;
            m_nbSubarea = nbSubarea;
        }
        
        public AllianceVersatileInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhInt(m_allianceId);
            writer.WriteVarUhShort(m_nbGuilds);
            writer.WriteVarUhShort(m_nbMembers);
            writer.WriteVarUhShort(m_nbSubarea);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_allianceId = reader.ReadVarUhInt();
            m_nbGuilds = reader.ReadVarUhShort();
            m_nbMembers = reader.ReadVarUhShort();
            m_nbSubarea = reader.ReadVarUhShort();
        }
    }
}
