//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Context.Roleplay
{
    using DofusBot.Protocol.Network.Types.Game.Look;
    using DofusBot.Protocol.Network.Types.Game.Context;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    
    
    using DofusBot.Protocol;
    
    
    public class GameRolePlayNamedActorInformations : GameRolePlayActorInformations
    {
        
        public const int ProtocolId = 154;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_name;
        
        public virtual string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }
        
        public GameRolePlayNamedActorInformations(string name)
        {
            m_name = name;
        }
        
        public GameRolePlayNamedActorInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(m_name);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_name = reader.ReadUTF();
        }
    }
}
