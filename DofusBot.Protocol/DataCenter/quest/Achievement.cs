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
    public class Achievement : IData
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
        
        public virtual uint NameId
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
        
        private uint mNameId;
        
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
        
        public virtual uint DescriptionId
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
        
        private uint mDescriptionId;
        
        public virtual uint IconId
        {
            get
            {
                return mIconId;
            }
            set
            {
                mIconId = value;
            }
        }
        
        private uint mIconId;
        
        public virtual uint Points
        {
            get
            {
                return mPoints;
            }
            set
            {
                mPoints = value;
            }
        }
        
        private uint mPoints;
        
        public virtual uint Level
        {
            get
            {
                return mLevel;
            }
            set
            {
                mLevel = value;
            }
        }
        
        private uint mLevel;
        
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
        
        public virtual double KamasRatio
        {
            get
            {
                return mKamasRatio;
            }
            set
            {
                mKamasRatio = value;
            }
        }
        
        private double mKamasRatio;
        
        public virtual double ExperienceRatio
        {
            get
            {
                return mExperienceRatio;
            }
            set
            {
                mExperienceRatio = value;
            }
        }
        
        private double mExperienceRatio;
        
        public virtual bool KamasScaleWithPlayerLevel
        {
            get
            {
                return mKamasScaleWithPlayerLevel;
            }
            set
            {
                mKamasScaleWithPlayerLevel = value;
            }
        }
        
        private bool mKamasScaleWithPlayerLevel;
        
        public virtual List<int> ObjectiveIds
        {
            get
            {
                return mObjectiveIds;
            }
            set
            {
                mObjectiveIds = value;
            }
        }
        
        private List<int> mObjectiveIds = new List<int>();
        
        public virtual List<int> RewardIds
        {
            get
            {
                return mRewardIds;
            }
            set
            {
                mRewardIds = value;
            }
        }
        
        private List<int> mRewardIds = new List<int>();
        
        public Achievement()
        {
        }
    }
}
