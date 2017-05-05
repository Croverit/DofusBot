//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Context.Roleplay.Party
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class PartyNameUpdateMessage : AbstractPartyMessage
    {
        
        public const int ProtocolId = 6502;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_partyName;
        
        public virtual string PartyName
        {
            get
            {
                return m_partyName;
            }
            set
            {
                m_partyName = value;
            }
        }
        
        public PartyNameUpdateMessage(string partyName)
        {
            m_partyName = partyName;
        }
        
        public PartyNameUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(m_partyName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_partyName = reader.ReadUTF();
        }
    }
}