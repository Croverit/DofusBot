//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Interactive
{
    using DofusBot.Protocol.Network.Types.Game.Interactive;
    using DofusBot.Protocol.Network;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class InteractiveMapUpdateMessage : NetworkMessage
    {
        
        public const int ProtocolId = 5002;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<InteractiveElement> m_interactiveElements;
        
        public virtual List<InteractiveElement> InteractiveElements
        {
            get
            {
                return m_interactiveElements;
            }
            set
            {
                m_interactiveElements = value;
            }
        }
        
        public InteractiveMapUpdateMessage(List<InteractiveElement> interactiveElements)
        {
            m_interactiveElements = interactiveElements;
        }
        
        public InteractiveMapUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_interactiveElements.Count)));
            int interactiveElementsIndex;
            for (interactiveElementsIndex = 0; (interactiveElementsIndex < m_interactiveElements.Count); interactiveElementsIndex = (interactiveElementsIndex + 1))
            {
                InteractiveElement objectToSend = m_interactiveElements[interactiveElementsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int interactiveElementsCount = reader.ReadUShort();
            int interactiveElementsIndex;
            m_interactiveElements = new System.Collections.Generic.List<InteractiveElement>();
            for (interactiveElementsIndex = 0; (interactiveElementsIndex < interactiveElementsCount); interactiveElementsIndex = (interactiveElementsIndex + 1))
            {
                InteractiveElement objectToAdd = ProtocolManager.GetTypeInstance<InteractiveElement>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_interactiveElements.Add(objectToAdd);
            }
        }
    }
}