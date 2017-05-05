//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Context.Roleplay
{
    using DofusBot.Protocol.Network.Types.Game.Character.Restriction;
    using DofusBot.Protocol.Network;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class HumanInformations : NetworkType
    {
        
        public const int ProtocolId = 157;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ActorRestrictionsInformations m_restrictions;
        
        public virtual ActorRestrictionsInformations Restrictions
        {
            get
            {
                return m_restrictions;
            }
            set
            {
                m_restrictions = value;
            }
        }
        
        private List<HumanOption> m_options;
        
        public virtual List<HumanOption> Options
        {
            get
            {
                return m_options;
            }
            set
            {
                m_options = value;
            }
        }
        
        private bool m_sex;
        
        public virtual bool Sex
        {
            get
            {
                return m_sex;
            }
            set
            {
                m_sex = value;
            }
        }
        
        public HumanInformations(ActorRestrictionsInformations restrictions, List<HumanOption> options, bool sex)
        {
            m_restrictions = restrictions;
            m_options = options;
            m_sex = sex;
        }
        
        public HumanInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_restrictions.Serialize(writer);
            writer.WriteShort(((short)(m_options.Count)));
            int optionsIndex;
            for (optionsIndex = 0; (optionsIndex < m_options.Count); optionsIndex = (optionsIndex + 1))
            {
                HumanOption objectToSend = m_options[optionsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteBoolean(m_sex);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_restrictions = new ActorRestrictionsInformations();
            m_restrictions.Deserialize(reader);
            int optionsCount = reader.ReadUShort();
            int optionsIndex;
            m_options = new System.Collections.Generic.List<HumanOption>();
            for (optionsIndex = 0; (optionsIndex < optionsCount); optionsIndex = (optionsIndex + 1))
            {
                HumanOption objectToAdd = ProtocolManager.GetTypeInstance<HumanOption>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_options.Add(objectToAdd);
            }
            m_sex = reader.ReadBoolean();
        }
    }
}