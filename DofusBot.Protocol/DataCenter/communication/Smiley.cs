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
    public class Smiley : IData
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
        
        public virtual uint Order
        {
            get
            {
                return mOrder;
            }
            set
            {
                mOrder = value;
            }
        }
        
        private uint mOrder;
        
        public virtual string GfxId
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
        
        private string mGfxId;
        
        public virtual bool ForPlayers
        {
            get
            {
                return mForPlayers;
            }
            set
            {
                mForPlayers = value;
            }
        }
        
        private bool mForPlayers;
        
        public virtual List<String> Triggers
        {
            get
            {
                return mTriggers;
            }
            set
            {
                mTriggers = value;
            }
        }
        
        private List<String> mTriggers = new List<String>();
        
        public virtual uint ReferenceId
        {
            get
            {
                return mReferenceId;
            }
            set
            {
                mReferenceId = value;
            }
        }
        
        private uint mReferenceId;
        
        public virtual uint CategoryId
        {
            get
            {
                return mCategoryId;
            }
            set
            {
                mCategoryId = value;
            }
        }
        
        private uint mCategoryId;
        
        public Smiley()
        {
        }
    }
}
