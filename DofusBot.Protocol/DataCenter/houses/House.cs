//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.DataCenter
{
    using System.Collections.Generic;
    using DofusBot.Protocol;
    using System;
    
    
    [Serializable()]
    public class House : IData
    {
        
        public virtual int TypeId
        {
            get
            {
                return mTypeId;
            }
            set
            {
                mTypeId = value;
            }
        }
        
        private int mTypeId;
        
        public virtual uint DefaultPrice
        {
            get
            {
                return mDefaultPrice;
            }
            set
            {
                mDefaultPrice = value;
            }
        }
        
        private uint mDefaultPrice;
        
        public virtual int NameId
        {
            get
            {
                return mNameId;
            }
            set
            {
                mNameId = value;
            }
        }
        
        private int mNameId;
        
        public virtual int DescriptionId
        {
            get
            {
                return mDescriptionId;
            }
            set
            {
                mDescriptionId = value;
            }
        }
        
        private int mDescriptionId;
        
        public virtual int GfxId
        {
            get
            {
                return mGfxId;
            }
            set
            {
                mGfxId = value;
            }
        }
        
        private int mGfxId;
        
        public House()
        {
        }
    }
}
