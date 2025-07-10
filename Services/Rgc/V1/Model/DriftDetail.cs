using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// 漂移详细信息。
    /// </summary>
    public class DriftDetail 
    {

        /// <summary>
        /// 管理纳管账号ID。
        /// </summary>
        [JsonProperty("managed_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedAccountId { get; set; }

        /// <summary>
        /// 漂移类型。
        /// </summary>
        [JsonProperty("drift_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DriftType { get; set; }

        /// <summary>
        /// 漂移发生的纳管账号ID或注册OU ID。
        /// </summary>
        [JsonProperty("drift_target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DriftTargetId { get; set; }

        /// <summary>
        /// 漂移目标类型，类型有account、ou和policy。
        /// </summary>
        [JsonProperty("drift_target_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DriftTargetType { get; set; }

        /// <summary>
        /// 漂移信息。
        /// </summary>
        [JsonProperty("drift_message", NullValueHandling = NullValueHandling.Ignore)]
        public string DriftMessage { get; set; }

        /// <summary>
        /// 父注册OU ID。
        /// </summary>
        [JsonProperty("parent_organizational_unit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentOrganizationalUnitId { get; set; }

        /// <summary>
        /// 漂移修复方法。
        /// </summary>
        [JsonProperty("solve_solution", NullValueHandling = NullValueHandling.Ignore)]
        public string SolveSolution { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DriftDetail {\n");
            sb.Append("  managedAccountId: ").Append(ManagedAccountId).Append("\n");
            sb.Append("  driftType: ").Append(DriftType).Append("\n");
            sb.Append("  driftTargetId: ").Append(DriftTargetId).Append("\n");
            sb.Append("  driftTargetType: ").Append(DriftTargetType).Append("\n");
            sb.Append("  driftMessage: ").Append(DriftMessage).Append("\n");
            sb.Append("  parentOrganizationalUnitId: ").Append(ParentOrganizationalUnitId).Append("\n");
            sb.Append("  solveSolution: ").Append(SolveSolution).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DriftDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DriftDetail input)
        {
            if (input == null) return false;
            if (this.ManagedAccountId != input.ManagedAccountId || (this.ManagedAccountId != null && !this.ManagedAccountId.Equals(input.ManagedAccountId))) return false;
            if (this.DriftType != input.DriftType || (this.DriftType != null && !this.DriftType.Equals(input.DriftType))) return false;
            if (this.DriftTargetId != input.DriftTargetId || (this.DriftTargetId != null && !this.DriftTargetId.Equals(input.DriftTargetId))) return false;
            if (this.DriftTargetType != input.DriftTargetType || (this.DriftTargetType != null && !this.DriftTargetType.Equals(input.DriftTargetType))) return false;
            if (this.DriftMessage != input.DriftMessage || (this.DriftMessage != null && !this.DriftMessage.Equals(input.DriftMessage))) return false;
            if (this.ParentOrganizationalUnitId != input.ParentOrganizationalUnitId || (this.ParentOrganizationalUnitId != null && !this.ParentOrganizationalUnitId.Equals(input.ParentOrganizationalUnitId))) return false;
            if (this.SolveSolution != input.SolveSolution || (this.SolveSolution != null && !this.SolveSolution.Equals(input.SolveSolution))) return false;

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
                if (this.ManagedAccountId != null) hashCode = hashCode * 59 + this.ManagedAccountId.GetHashCode();
                if (this.DriftType != null) hashCode = hashCode * 59 + this.DriftType.GetHashCode();
                if (this.DriftTargetId != null) hashCode = hashCode * 59 + this.DriftTargetId.GetHashCode();
                if (this.DriftTargetType != null) hashCode = hashCode * 59 + this.DriftTargetType.GetHashCode();
                if (this.DriftMessage != null) hashCode = hashCode * 59 + this.DriftMessage.GetHashCode();
                if (this.ParentOrganizationalUnitId != null) hashCode = hashCode * 59 + this.ParentOrganizationalUnitId.GetHashCode();
                if (this.SolveSolution != null) hashCode = hashCode * 59 + this.SolveSolution.GetHashCode();
                return hashCode;
            }
        }
    }
}
