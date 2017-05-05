//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Context.Fight.Challenge
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class ChallengeInfoMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6022;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_challengeId;
        
        public virtual ushort ChallengeId
        {
            get
            {
                return m_challengeId;
            }
            set
            {
                m_challengeId = value;
            }
        }
        
        private double m_targetId;
        
        public virtual double TargetId
        {
            get
            {
                return m_targetId;
            }
            set
            {
                m_targetId = value;
            }
        }
        
        private uint m_xpBonus;
        
        public virtual uint XpBonus
        {
            get
            {
                return m_xpBonus;
            }
            set
            {
                m_xpBonus = value;
            }
        }
        
        private uint m_dropBonus;
        
        public virtual uint DropBonus
        {
            get
            {
                return m_dropBonus;
            }
            set
            {
                m_dropBonus = value;
            }
        }
        
        public ChallengeInfoMessage(ushort challengeId, double targetId, uint xpBonus, uint dropBonus)
        {
            m_challengeId = challengeId;
            m_targetId = targetId;
            m_xpBonus = xpBonus;
            m_dropBonus = dropBonus;
        }
        
        public ChallengeInfoMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhShort(m_challengeId);
            writer.WriteDouble(m_targetId);
            writer.WriteVarUhInt(m_xpBonus);
            writer.WriteVarUhInt(m_dropBonus);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_challengeId = reader.ReadVarUhShort();
            m_targetId = reader.ReadDouble();
            m_xpBonus = reader.ReadVarUhInt();
            m_dropBonus = reader.ReadVarUhInt();
        }
    }
}
