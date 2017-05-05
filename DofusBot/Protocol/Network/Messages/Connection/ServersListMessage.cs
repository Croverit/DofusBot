//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Connection
{
    using DofusBot.Protocol.Network.Types.Connection;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class ServersListMessage : NetworkMessage
    {
        
        public const int ProtocolId = 30;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<GameServerInformations> m_servers;
        
        public virtual List<GameServerInformations> Servers
        {
            get
            {
                return m_servers;
            }
            set
            {
                m_servers = value;
            }
        }
        
        private ushort m_alreadyConnectedToServerId;
        
        public virtual ushort AlreadyConnectedToServerId
        {
            get
            {
                return m_alreadyConnectedToServerId;
            }
            set
            {
                m_alreadyConnectedToServerId = value;
            }
        }
        
        private bool m_canCreateNewCharacter;
        
        public virtual bool CanCreateNewCharacter
        {
            get
            {
                return m_canCreateNewCharacter;
            }
            set
            {
                m_canCreateNewCharacter = value;
            }
        }
        
        public ServersListMessage(List<GameServerInformations> servers, ushort alreadyConnectedToServerId, bool canCreateNewCharacter)
        {
            m_servers = servers;
            m_alreadyConnectedToServerId = alreadyConnectedToServerId;
            m_canCreateNewCharacter = canCreateNewCharacter;
        }
        
        public ServersListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_servers.Count)));
            int serversIndex;
            for (serversIndex = 0; (serversIndex < m_servers.Count); serversIndex = (serversIndex + 1))
            {
                GameServerInformations objectToSend = m_servers[serversIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteVarUhShort(m_alreadyConnectedToServerId);
            writer.WriteBoolean(m_canCreateNewCharacter);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int serversCount = reader.ReadUShort();
            int serversIndex;
            m_servers = new System.Collections.Generic.List<GameServerInformations>();
            for (serversIndex = 0; (serversIndex < serversCount); serversIndex = (serversIndex + 1))
            {
                GameServerInformations objectToAdd = new GameServerInformations();
                objectToAdd.Deserialize(reader);
                m_servers.Add(objectToAdd);
            }
            m_alreadyConnectedToServerId = reader.ReadVarUhShort();
            m_canCreateNewCharacter = reader.ReadBoolean();
        }
    }
}
