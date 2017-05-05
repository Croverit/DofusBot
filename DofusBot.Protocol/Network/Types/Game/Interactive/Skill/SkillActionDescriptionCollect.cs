//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Interactive.Skill
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    
    
    using DofusBot.Protocol;
    
    
    public class SkillActionDescriptionCollect : SkillActionDescriptionTimed
    {
        
        public const int ProtocolId = 99;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_min;
        
        public virtual ushort Min
        {
            get
            {
                return m_min;
            }
            set
            {
                m_min = value;
            }
        }
        
        private ushort m_max;
        
        public virtual ushort Max
        {
            get
            {
                return m_max;
            }
            set
            {
                m_max = value;
            }
        }
        
        public SkillActionDescriptionCollect(ushort min, ushort max)
        {
            m_min = min;
            m_max = max;
        }
        
        public SkillActionDescriptionCollect()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhShort(m_min);
            writer.WriteVarUhShort(m_max);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_min = reader.ReadVarUhShort();
            m_max = reader.ReadVarUhShort();
        }
    }
}