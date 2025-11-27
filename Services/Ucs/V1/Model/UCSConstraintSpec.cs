using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UCSConstraintSpec 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("constraint", NullValueHandling = NullValueHandling.Ignore)]
        public Constraint Constraint { get; set; }

        /// <summary>
        /// 约束模板ID
        /// </summary>
        [JsonProperty("constraintTemplateID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConstraintTemplateID { get; set; }

        /// <summary>
        /// 用户的domainID
        /// </summary>
        [JsonProperty("domainID", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainID { get; set; }

        /// <summary>
        /// 策略实例下发范围，当前cluster和fleet二选一
        /// </summary>
        [JsonProperty("targetScope", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetScope { get; set; }

        /// <summary>
        /// 策略实例下发对象，当前为clusterID或clustergroupID
        /// </summary>
        [JsonProperty("targetID", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UCSConstraintSpec {\n");
            sb.Append("  constraint: ").Append(Constraint).Append("\n");
            sb.Append("  constraintTemplateID: ").Append(ConstraintTemplateID).Append("\n");
            sb.Append("  domainID: ").Append(DomainID).Append("\n");
            sb.Append("  targetScope: ").Append(TargetScope).Append("\n");
            sb.Append("  targetID: ").Append(TargetID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UCSConstraintSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UCSConstraintSpec input)
        {
            if (input == null) return false;
            if (this.Constraint != input.Constraint || (this.Constraint != null && !this.Constraint.Equals(input.Constraint))) return false;
            if (this.ConstraintTemplateID != input.ConstraintTemplateID || (this.ConstraintTemplateID != null && !this.ConstraintTemplateID.Equals(input.ConstraintTemplateID))) return false;
            if (this.DomainID != input.DomainID || (this.DomainID != null && !this.DomainID.Equals(input.DomainID))) return false;
            if (this.TargetScope != input.TargetScope || (this.TargetScope != null && !this.TargetScope.Equals(input.TargetScope))) return false;
            if (this.TargetID != input.TargetID || (this.TargetID != null && !this.TargetID.Equals(input.TargetID))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Constraint != null) hashCode = hashCode * 59 + this.Constraint.GetHashCode();
                if (this.ConstraintTemplateID != null) hashCode = hashCode * 59 + this.ConstraintTemplateID.GetHashCode();
                if (this.DomainID != null) hashCode = hashCode * 59 + this.DomainID.GetHashCode();
                if (this.TargetScope != null) hashCode = hashCode * 59 + this.TargetScope.GetHashCode();
                if (this.TargetID != null) hashCode = hashCode * 59 + this.TargetID.GetHashCode();
                return hashCode;
            }
        }
    }
}
