//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Action.Fight
{
    using DofusBot.Protocol.Network.Types.Game.Actions.Fight;
    using DofusBot.Protocol.Network;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class FightDispellableEffectExtendedInformations : NetworkType
    {
        
        public const int ProtocolId = 208;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private AbstractFightDispellableEffect m_effect;
        
        public virtual AbstractFightDispellableEffect Effect
        {
            get
            {
                return m_effect;
            }
            set
            {
                m_effect = value;
            }
        }
        
        private ushort m_actionId;
        
        public virtual ushort ActionId
        {
            get
            {
                return m_actionId;
            }
            set
            {
                m_actionId = value;
            }
        }
        
        private double m_sourceId;
        
        public virtual double SourceId
        {
            get
            {
                return m_sourceId;
            }
            set
            {
                m_sourceId = value;
            }
        }
        
        public FightDispellableEffectExtendedInformations(AbstractFightDispellableEffect effect, ushort actionId, double sourceId)
        {
            m_effect = effect;
            m_actionId = actionId;
            m_sourceId = sourceId;
        }
        
        public FightDispellableEffectExtendedInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(((ushort)(m_effect.TypeID)));
            m_effect.Serialize(writer);
            writer.WriteVarUhShort(m_actionId);
            writer.WriteDouble(m_sourceId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_effect = ProtocolManager.GetTypeInstance<AbstractFightDispellableEffect>(reader.ReadUShort());
            m_effect.Deserialize(reader);
            m_actionId = reader.ReadVarUhShort();
            m_sourceId = reader.ReadDouble();
        }
    }
}
