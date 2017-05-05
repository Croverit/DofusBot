//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Types.Game.Data.Items
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    
    
    using DofusBot.Protocol;
    
    
    public class GoldItem : Item
    {
        
        public const int ProtocolId = 123;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_sum;
        
        public virtual ulong Sum
        {
            get
            {
                return m_sum;
            }
            set
            {
                m_sum = value;
            }
        }
        
        public GoldItem(ulong sum)
        {
            m_sum = sum;
        }
        
        public GoldItem()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhLong(m_sum);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_sum = reader.ReadVarUhLong();
        }
    }
}
