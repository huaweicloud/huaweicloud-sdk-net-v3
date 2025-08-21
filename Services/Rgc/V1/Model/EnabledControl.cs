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
    /// 开启控制策略信息。
    /// </summary>
    public class EnabledControl 
    {

        /// <summary>
        /// 管理员账号ID。
        /// </summary>
        [JsonProperty("manage_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManageAccountId { get; set; }

        /// <summary>
        /// 控制策略标识。
        /// </summary>
        [JsonProperty("control_identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string ControlIdentifier { get; set; }

        /// <summary>
        /// 控制策略名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 控制策略描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 控制策略目标。
        /// </summary>
        [JsonProperty("control_objective", NullValueHandling = NullValueHandling.Ignore)]
        public string ControlObjective { get; set; }

        /// <summary>
        /// 控制策略类型。包括主动性控制策略Proactive、检测性控制策略Detective、预防性控制策略Preventive。
        /// </summary>
        [JsonProperty("behavior", NullValueHandling = NullValueHandling.Ignore)]
        public string Behavior { get; set; }

        /// <summary>
        /// 控制策略来源。
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 区域选项，取值有两种分别是：区域的regional和全局的global。
        /// </summary>
        [JsonProperty("regional_preference", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionalPreference { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnabledControl {\n");
            sb.Append("  manageAccountId: ").Append(ManageAccountId).Append("\n");
            sb.Append("  controlIdentifier: ").Append(ControlIdentifier).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  controlObjective: ").Append(ControlObjective).Append("\n");
            sb.Append("  behavior: ").Append(Behavior).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  regionalPreference: ").Append(RegionalPreference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnabledControl);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnabledControl input)
        {
            if (input == null) return false;
            if (this.ManageAccountId != input.ManageAccountId || (this.ManageAccountId != null && !this.ManageAccountId.Equals(input.ManageAccountId))) return false;
            if (this.ControlIdentifier != input.ControlIdentifier || (this.ControlIdentifier != null && !this.ControlIdentifier.Equals(input.ControlIdentifier))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ControlObjective != input.ControlObjective || (this.ControlObjective != null && !this.ControlObjective.Equals(input.ControlObjective))) return false;
            if (this.Behavior != input.Behavior || (this.Behavior != null && !this.Behavior.Equals(input.Behavior))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.RegionalPreference != input.RegionalPreference || (this.RegionalPreference != null && !this.RegionalPreference.Equals(input.RegionalPreference))) return false;

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
                if (this.ManageAccountId != null) hashCode = hashCode * 59 + this.ManageAccountId.GetHashCode();
                if (this.ControlIdentifier != null) hashCode = hashCode * 59 + this.ControlIdentifier.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ControlObjective != null) hashCode = hashCode * 59 + this.ControlObjective.GetHashCode();
                if (this.Behavior != null) hashCode = hashCode * 59 + this.Behavior.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.RegionalPreference != null) hashCode = hashCode * 59 + this.RegionalPreference.GetHashCode();
                return hashCode;
            }
        }
    }
}
