//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Guild.Tax
{
    using DofusBot.Protocol.Network.Types.Game.Context.Roleplay;
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class TaxCollectorGuildInformations : TaxCollectorComplementaryInformations
    {
        
        public const int ProtocolId = 446;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private BasicGuildInformations m_guild;
        
        public virtual BasicGuildInformations Guild
        {
            get
            {
                return m_guild;
            }
            set
            {
                m_guild = value;
            }
        }
        
        public TaxCollectorGuildInformations(BasicGuildInformations guild)
        {
            m_guild = guild;
        }
        
        public TaxCollectorGuildInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_guild.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_guild = new BasicGuildInformations();
            m_guild.Deserialize(reader);
        }
    }
}
