//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Actions.Fight
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class GameActionMark : NetworkType
    {
        
        public const int ProtocolId = 351;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<GameActionMarkedCell> m_cells;
        
        public virtual List<GameActionMarkedCell> Cells
        {
            get
            {
                return m_cells;
            }
            set
            {
                m_cells = value;
            }
        }
        
        private double m_markAuthorId;
        
        public virtual double MarkAuthorId
        {
            get
            {
                return m_markAuthorId;
            }
            set
            {
                m_markAuthorId = value;
            }
        }
        
        private byte m_markTeamId;
        
        public virtual byte MarkTeamId
        {
            get
            {
                return m_markTeamId;
            }
            set
            {
                m_markTeamId = value;
            }
        }
        
        private int m_markSpellId;
        
        public virtual int MarkSpellId
        {
            get
            {
                return m_markSpellId;
            }
            set
            {
                m_markSpellId = value;
            }
        }
        
        private short m_markSpellLevel;
        
        public virtual short MarkSpellLevel
        {
            get
            {
                return m_markSpellLevel;
            }
            set
            {
                m_markSpellLevel = value;
            }
        }
        
        private short m_markId;
        
        public virtual short MarkId
        {
            get
            {
                return m_markId;
            }
            set
            {
                m_markId = value;
            }
        }
        
        private byte m_markType;
        
        public virtual byte MarkType
        {
            get
            {
                return m_markType;
            }
            set
            {
                m_markType = value;
            }
        }
        
        private short m_markimpactCell;
        
        public virtual short MarkimpactCell
        {
            get
            {
                return m_markimpactCell;
            }
            set
            {
                m_markimpactCell = value;
            }
        }
        
        private bool m_active;
        
        public virtual bool Active
        {
            get
            {
                return m_active;
            }
            set
            {
                m_active = value;
            }
        }
        
        public GameActionMark(List<GameActionMarkedCell> cells, double markAuthorId, byte markTeamId, int markSpellId, short markSpellLevel, short markId, byte markType, short markimpactCell, bool active)
        {
            m_cells = cells;
            m_markAuthorId = markAuthorId;
            m_markTeamId = markTeamId;
            m_markSpellId = markSpellId;
            m_markSpellLevel = markSpellLevel;
            m_markId = markId;
            m_markType = markType;
            m_markimpactCell = markimpactCell;
            m_active = active;
        }
        
        public GameActionMark()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_cells.Count)));
            int cellsIndex;
            for (cellsIndex = 0; (cellsIndex < m_cells.Count); cellsIndex = (cellsIndex + 1))
            {
                GameActionMarkedCell objectToSend = m_cells[cellsIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteDouble(m_markAuthorId);
            writer.WriteByte(m_markTeamId);
            writer.WriteInt(m_markSpellId);
            writer.WriteShort(m_markSpellLevel);
            writer.WriteShort(m_markId);
            writer.WriteByte(m_markType);
            writer.WriteShort(m_markimpactCell);
            writer.WriteBoolean(m_active);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int cellsCount = reader.ReadUShort();
            int cellsIndex;
            m_cells = new System.Collections.Generic.List<GameActionMarkedCell>();
            for (cellsIndex = 0; (cellsIndex < cellsCount); cellsIndex = (cellsIndex + 1))
            {
                GameActionMarkedCell objectToAdd = new GameActionMarkedCell();
                objectToAdd.Deserialize(reader);
                m_cells.Add(objectToAdd);
            }
            m_markAuthorId = reader.ReadDouble();
            m_markTeamId = reader.ReadByte();
            m_markSpellId = reader.ReadInt();
            m_markSpellLevel = reader.ReadShort();
            m_markId = reader.ReadShort();
            m_markType = reader.ReadByte();
            m_markimpactCell = reader.ReadShort();
            m_active = reader.ReadBoolean();
        }
    }
}
