//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Inventory.Preset
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class InventoryPresetDeleteResultMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6173;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_presetId;
        
        public virtual byte PresetId
        {
            get
            {
                return m_presetId;
            }
            set
            {
                m_presetId = value;
            }
        }
        
        private byte m_code;
        
        public virtual byte Code
        {
            get
            {
                return m_code;
            }
            set
            {
                m_code = value;
            }
        }
        
        public InventoryPresetDeleteResultMessage(byte presetId, byte code)
        {
            m_presetId = presetId;
            m_code = code;
        }
        
        public InventoryPresetDeleteResultMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_presetId);
            writer.WriteByte(m_code);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_presetId = reader.ReadByte();
            m_code = reader.ReadByte();
        }
    }
}
