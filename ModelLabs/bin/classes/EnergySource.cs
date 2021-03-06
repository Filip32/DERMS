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
    
    
    /// A generic equivalent for an energy supplier on a transmission or distribution voltage level.
    public class EnergySource : ConductingEquipment {
        
        /// High voltage source load
        private System.Single? cim_activePower;
        
        private const bool isActivePowerMandatory = true;
        
        private const string _activePowerPrefix = "cim";
        
        /// Phase-to-phase nominal voltage.
        private System.Single? cim_nominalVoltage;
        
        private const bool isNominalVoltageMandatory = true;
        
        private const string _nominalVoltagePrefix = "cim";
        
        /// Type of energy source, depending on its location
        private EnergySourceType? cim_sourceType;
        
        private const bool isSourceTypeMandatory = true;
        
        private const string _sourceTypePrefix = "tdms";
        
        /// Phase-to-phase open circuit voltage magnitude.
        private System.Single? cim_voltageMagnitude;
        
        private const bool isVoltageMagnitudeMandatory = true;
        
        private const string _voltageMagnitudePrefix = "cim";
        
        public virtual float ActivePower {
            get {
                return this.cim_activePower.GetValueOrDefault();
            }
            set {
                this.cim_activePower = value;
            }
        }
        
        public virtual bool ActivePowerHasValue {
            get {
                return this.cim_activePower != null;
            }
        }
        
        public static bool IsActivePowerMandatory {
            get {
                return isActivePowerMandatory;
            }
        }
        
        public static string ActivePowerPrefix {
            get {
                return _activePowerPrefix;
            }
        }
        
        public virtual float NominalVoltage {
            get {
                return this.cim_nominalVoltage.GetValueOrDefault();
            }
            set {
                this.cim_nominalVoltage = value;
            }
        }
        
        public virtual bool NominalVoltageHasValue {
            get {
                return this.cim_nominalVoltage != null;
            }
        }
        
        public static bool IsNominalVoltageMandatory {
            get {
                return isNominalVoltageMandatory;
            }
        }
        
        public static string NominalVoltagePrefix {
            get {
                return _nominalVoltagePrefix;
            }
        }
        
        public virtual EnergySourceType SourceType {
            get {
                return this.cim_sourceType.GetValueOrDefault();
            }
            set {
                this.cim_sourceType = value;
            }
        }
        
        public virtual bool SourceTypeHasValue {
            get {
                return this.cim_sourceType != null;
            }
        }
        
        public static bool IsSourceTypeMandatory {
            get {
                return isSourceTypeMandatory;
            }
        }
        
        public static string SourceTypePrefix {
            get {
                return _sourceTypePrefix;
            }
        }
        
        public virtual float VoltageMagnitude {
            get {
                return this.cim_voltageMagnitude.GetValueOrDefault();
            }
            set {
                this.cim_voltageMagnitude = value;
            }
        }
        
        public virtual bool VoltageMagnitudeHasValue {
            get {
                return this.cim_voltageMagnitude != null;
            }
        }
        
        public static bool IsVoltageMagnitudeMandatory {
            get {
                return isVoltageMagnitudeMandatory;
            }
        }
        
        public static string VoltageMagnitudePrefix {
            get {
                return _voltageMagnitudePrefix;
            }
        }
    }
}
