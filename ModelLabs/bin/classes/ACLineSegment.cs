//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FTN {
    using System;
    using FTN;
    
    
    /// A wire or combination of wires, with consistent electrical characteristics, building a single electrical system, used to carry alternating current between points in the power system.
    public class ACLineSegment : Conductor {
        
        /// True if the section belongs to the feeder cable (cable exiting the Substation)
        private System.Boolean? cim_feederCable;
        
        private const bool isFeederCableMandatory = true;
        
        private const string _feederCablePrefix = "tdms";
        
        /// Rated current [A]
        private System.Single? cim_ratedCurrent;
        
        private const bool isRatedCurrentMandatory = true;
        
        private const string _ratedCurrentPrefix = "tdms";
        
        public virtual bool FeederCable {
            get {
                return this.cim_feederCable.GetValueOrDefault();
            }
            set {
                this.cim_feederCable = value;
            }
        }
        
        public virtual bool FeederCableHasValue {
            get {
                return this.cim_feederCable != null;
            }
        }
        
        public static bool IsFeederCableMandatory {
            get {
                return isFeederCableMandatory;
            }
        }
        
        public static string FeederCablePrefix {
            get {
                return _feederCablePrefix;
            }
        }
        
        public virtual float RatedCurrent {
            get {
                return this.cim_ratedCurrent.GetValueOrDefault();
            }
            set {
                this.cim_ratedCurrent = value;
            }
        }
        
        public virtual bool RatedCurrentHasValue {
            get {
                return this.cim_ratedCurrent != null;
            }
        }
        
        public static bool IsRatedCurrentMandatory {
            get {
                return isRatedCurrentMandatory;
            }
        }
        
        public static string RatedCurrentPrefix {
            get {
                return _ratedCurrentPrefix;
            }
        }
    }
}
