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
    public class NamingRule : IData
    {
        
        public virtual uint Id
        {
            get
            {
                return mId;
            }
            set
            {
                mId = value;
            }
        }
        
        private uint mId;
        
        public virtual uint MinLength
        {
            get
            {
                return mMinLength;
            }
            set
            {
                mMinLength = value;
            }
        }
        
        private uint mMinLength;
        
        public virtual uint MaxLength
        {
            get
            {
                return mMaxLength;
            }
            set
            {
                mMaxLength = value;
            }
        }
        
        private uint mMaxLength;
        
        public virtual string Regexp
        {
            get
            {
                return mRegexp;
            }
            set
            {
                mRegexp = value;
            }
        }
        
        private string mRegexp;
        
        public NamingRule()
        {
        }
    }
}