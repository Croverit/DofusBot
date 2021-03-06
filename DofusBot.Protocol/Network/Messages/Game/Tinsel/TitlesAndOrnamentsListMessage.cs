//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Tinsel
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class TitlesAndOrnamentsListMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6367;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_titles;
        
        public virtual List<System.UInt16> Titles
        {
            get
            {
                return m_titles;
            }
            set
            {
                m_titles = value;
            }
        }
        
        private List<System.UInt16> m_ornaments;
        
        public virtual List<System.UInt16> Ornaments
        {
            get
            {
                return m_ornaments;
            }
            set
            {
                m_ornaments = value;
            }
        }
        
        private ushort m_activeTitle;
        
        public virtual ushort ActiveTitle
        {
            get
            {
                return m_activeTitle;
            }
            set
            {
                m_activeTitle = value;
            }
        }
        
        private ushort m_activeOrnament;
        
        public virtual ushort ActiveOrnament
        {
            get
            {
                return m_activeOrnament;
            }
            set
            {
                m_activeOrnament = value;
            }
        }
        
        public TitlesAndOrnamentsListMessage(List<System.UInt16> titles, List<System.UInt16> ornaments, ushort activeTitle, ushort activeOrnament)
        {
            m_titles = titles;
            m_ornaments = ornaments;
            m_activeTitle = activeTitle;
            m_activeOrnament = activeOrnament;
        }
        
        public TitlesAndOrnamentsListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_titles.Count)));
            int titlesIndex;
            for (titlesIndex = 0; (titlesIndex < m_titles.Count); titlesIndex = (titlesIndex + 1))
            {
                writer.WriteVarUhShort(m_titles[titlesIndex]);
            }
            writer.WriteShort(((short)(m_ornaments.Count)));
            int ornamentsIndex;
            for (ornamentsIndex = 0; (ornamentsIndex < m_ornaments.Count); ornamentsIndex = (ornamentsIndex + 1))
            {
                writer.WriteVarUhShort(m_ornaments[ornamentsIndex]);
            }
            writer.WriteVarUhShort(m_activeTitle);
            writer.WriteVarUhShort(m_activeOrnament);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int titlesCount = reader.ReadUShort();
            int titlesIndex;
            m_titles = new System.Collections.Generic.List<ushort>();
            for (titlesIndex = 0; (titlesIndex < titlesCount); titlesIndex = (titlesIndex + 1))
            {
                m_titles.Add(reader.ReadVarUhShort());
            }
            int ornamentsCount = reader.ReadUShort();
            int ornamentsIndex;
            m_ornaments = new System.Collections.Generic.List<ushort>();
            for (ornamentsIndex = 0; (ornamentsIndex < ornamentsCount); ornamentsIndex = (ornamentsIndex + 1))
            {
                m_ornaments.Add(reader.ReadVarUhShort());
            }
            m_activeTitle = reader.ReadVarUhShort();
            m_activeOrnament = reader.ReadVarUhShort();
        }
    }
}
