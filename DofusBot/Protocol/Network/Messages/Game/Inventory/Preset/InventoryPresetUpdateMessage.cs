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
    using DofusBot.Protocol.Network.Types.Game.Inventory.Preset;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class InventoryPresetUpdateMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6171;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private Preset m_preset;
        
        public virtual Preset Preset
        {
            get
            {
                return m_preset;
            }
            set
            {
                m_preset = value;
            }
        }
        
        public InventoryPresetUpdateMessage(Preset preset)
        {
            m_preset = preset;
        }
        
        public InventoryPresetUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_preset.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_preset = new Preset();
            m_preset.Deserialize(reader);
        }
    }
}
