//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Dare
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class DareVersatileInformations : NetworkType
    {
        
        public const int ProtocolId = 504;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_dareId;
        
        public virtual double DareId
        {
            get
            {
                return m_dareId;
            }
            set
            {
                m_dareId = value;
            }
        }
        
        private int m_countEntrants;
        
        public virtual int CountEntrants
        {
            get
            {
                return m_countEntrants;
            }
            set
            {
                m_countEntrants = value;
            }
        }
        
        private int m_countWinners;
        
        public virtual int CountWinners
        {
            get
            {
                return m_countWinners;
            }
            set
            {
                m_countWinners = value;
            }
        }
        
        public DareVersatileInformations(double dareId, int countEntrants, int countWinners)
        {
            m_dareId = dareId;
            m_countEntrants = countEntrants;
            m_countWinners = countWinners;
        }
        
        public DareVersatileInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(m_dareId);
            writer.WriteInt(m_countEntrants);
            writer.WriteInt(m_countWinners);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_dareId = reader.ReadDouble();
            m_countEntrants = reader.ReadInt();
            m_countWinners = reader.ReadInt();
        }
    }
}
