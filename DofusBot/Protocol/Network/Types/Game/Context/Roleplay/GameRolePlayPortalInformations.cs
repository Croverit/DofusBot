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
    using DofusBot.Protocol;
    using DofusBot.Protocol.Network.Types.Game.Context.Roleplay.TreasureHunt;


    public class GameRolePlayPortalInformations : GameRolePlayActorInformations
    {
        
        public const int ProtocolId = 467;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private PortalInformation m_portal;
        
        public virtual PortalInformation Portal
        {
            get
            {
                return m_portal;
            }
            set
            {
                m_portal = value;
            }
        }
        
        public GameRolePlayPortalInformations(PortalInformation portal)
        {
            m_portal = portal;
        }
        
        public GameRolePlayPortalInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUShort(((ushort)(m_portal.TypeID)));
            m_portal.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_portal = ProtocolManager.GetTypeInstance<PortalInformation>(reader.ReadUShort());
            m_portal.Deserialize(reader);
        }
    }
}
