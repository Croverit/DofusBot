//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Context.Roleplay.Houses
{
    using DofusBot.Protocol.Network.Types.Game.House;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class AccountHouseMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6315;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<AccountHouseInformations> m_houses;
        
        public virtual List<AccountHouseInformations> Houses
        {
            get
            {
                return m_houses;
            }
            set
            {
                m_houses = value;
            }
        }
        
        public AccountHouseMessage(List<AccountHouseInformations> houses)
        {
            m_houses = houses;
        }
        
        public AccountHouseMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_houses.Count)));
            int housesIndex;
            for (housesIndex = 0; (housesIndex < m_houses.Count); housesIndex = (housesIndex + 1))
            {
                AccountHouseInformations objectToSend = m_houses[housesIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int housesCount = reader.ReadUShort();
            int housesIndex;
            m_houses = new System.Collections.Generic.List<AccountHouseInformations>();
            for (housesIndex = 0; (housesIndex < housesCount); housesIndex = (housesIndex + 1))
            {
                AccountHouseInformations objectToAdd = new AccountHouseInformations();
                objectToAdd.Deserialize(reader);
                m_houses.Add(objectToAdd);
            }
        }
    }
}
