//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.Friend
{
    using DofusBot.Protocol.Network.Types.Game.Friend;
    using DofusBot.Protocol.Network;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class FriendsListMessage : NetworkMessage
    {
        
        public const int ProtocolId = 4002;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<FriendInformations> m_friendsList;
        
        public virtual List<FriendInformations> FriendsList
        {
            get
            {
                return m_friendsList;
            }
            set
            {
                m_friendsList = value;
            }
        }
        
        public FriendsListMessage(List<FriendInformations> friendsList)
        {
            m_friendsList = friendsList;
        }
        
        public FriendsListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_friendsList.Count)));
            int friendsListIndex;
            for (friendsListIndex = 0; (friendsListIndex < m_friendsList.Count); friendsListIndex = (friendsListIndex + 1))
            {
                FriendInformations objectToSend = m_friendsList[friendsListIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int friendsListCount = reader.ReadUShort();
            int friendsListIndex;
            m_friendsList = new System.Collections.Generic.List<FriendInformations>();
            for (friendsListIndex = 0; (friendsListIndex < friendsListCount); friendsListIndex = (friendsListIndex + 1))
            {
                FriendInformations objectToAdd = ProtocolManager.GetTypeInstance<FriendInformations>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_friendsList.Add(objectToAdd);
            }
        }
    }
}
