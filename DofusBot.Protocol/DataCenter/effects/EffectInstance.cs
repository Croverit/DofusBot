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
    public class EffectInstance : IData
    {
        
        public virtual uint EffectUid
        {
            get
            {
                return mEffectUid;
            }
            set
            {
                mEffectUid = value;
            }
        }
        
        private uint mEffectUid;
        
        public virtual uint EffectId
        {
            get
            {
                return mEffectId;
            }
            set
            {
                mEffectId = value;
            }
        }
        
        private uint mEffectId;
        
        public virtual int TargetId
        {
            get
            {
                return mTargetId;
            }
            set
            {
                mTargetId = value;
            }
        }
        
        private int mTargetId;
        
        public virtual string TargetMask
        {
            get
            {
                return mTargetMask;
            }
            set
            {
                mTargetMask = value;
            }
        }
        
        private string mTargetMask;
        
        public virtual int Duration
        {
            get
            {
                return mDuration;
            }
            set
            {
                mDuration = value;
            }
        }
        
        private int mDuration;
        
        public virtual int Delay
        {
            get
            {
                return mDelay;
            }
            set
            {
                mDelay = value;
            }
        }
        
        private int mDelay;
        
        public virtual int Random
        {
            get
            {
                return mRandom;
            }
            set
            {
                mRandom = value;
            }
        }
        
        private int mRandom;
        
        public virtual int Group
        {
            get
            {
                return mGroup;
            }
            set
            {
                mGroup = value;
            }
        }
        
        private int mGroup;
        
        public virtual int Modificator
        {
            get
            {
                return mModificator;
            }
            set
            {
                mModificator = value;
            }
        }
        
        private int mModificator;
        
        public virtual bool Trigger
        {
            get
            {
                return mTrigger;
            }
            set
            {
                mTrigger = value;
            }
        }
        
        private bool mTrigger;
        
        public virtual string Triggers
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
        
        private string mTriggers;
        
        public virtual Object ZoneSize
        {
            get
            {
                return mZoneSize;
            }
            set
            {
                mZoneSize = value;
            }
        }
        
        private Object mZoneSize;
        
        public virtual uint ZoneShape
        {
            get
            {
                return mZoneShape;
            }
            set
            {
                mZoneShape = value;
            }
        }
        
        private uint mZoneShape;
        
        public virtual Object ZoneMinSize
        {
            get
            {
                return mZoneMinSize;
            }
            set
            {
                mZoneMinSize = value;
            }
        }
        
        private Object mZoneMinSize;
        
        public virtual Object ZoneEfficiencyPercent
        {
            get
            {
                return mZoneEfficiencyPercent;
            }
            set
            {
                mZoneEfficiencyPercent = value;
            }
        }
        
        private Object mZoneEfficiencyPercent;
        
        public virtual Object ZoneMaxEfficiency
        {
            get
            {
                return mZoneMaxEfficiency;
            }
            set
            {
                mZoneMaxEfficiency = value;
            }
        }
        
        private Object mZoneMaxEfficiency;
        
        public virtual Object ZoneStopAtTarget
        {
            get
            {
                return mZoneStopAtTarget;
            }
            set
            {
                mZoneStopAtTarget = value;
            }
        }
        
        private Object mZoneStopAtTarget;
        
        public virtual int EffectElement
        {
            get
            {
                return mEffectElement;
            }
            set
            {
                mEffectElement = value;
            }
        }
        
        private int mEffectElement;
        
        public EffectInstance()
        {
        }
    }
}