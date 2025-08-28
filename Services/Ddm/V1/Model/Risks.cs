using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Risks 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 引擎名称。
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// 当前引擎版本。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 风险等级。
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }

        /// <summary>
        /// 建议升级原因。
        /// </summary>
        [JsonProperty("suggest", NullValueHandling = NullValueHandling.Ignore)]
        public string Suggest { get; set; }

        /// <summary>
        /// 升级影响。
        /// </summary>
        [JsonProperty("influence", NullValueHandling = NullValueHandling.Ignore)]
        public string Influence { get; set; }

        /// <summary>
        /// 指导连接。
        /// </summary>
        [JsonProperty("guidance", NullValueHandling = NullValueHandling.Ignore)]
        public string Guidance { get; set; }

        /// <summary>
        /// 业务影响时长。
        /// </summary>
        [JsonProperty("service_impact_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceImpactDuration { get; set; }

        /// <summary>
        /// 升级时长。
        /// </summary>
        [JsonProperty("upgrade_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Risks {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  suggest: ").Append(Suggest).Append("\n");
            sb.Append("  influence: ").Append(Influence).Append("\n");
            sb.Append("  guidance: ").Append(Guidance).Append("\n");
            sb.Append("  serviceImpactDuration: ").Append(ServiceImpactDuration).Append("\n");
            sb.Append("  upgradeDuration: ").Append(UpgradeDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Risks);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Risks input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.EngineName != input.EngineName || (this.EngineName != null && !this.EngineName.Equals(input.EngineName))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.Suggest != input.Suggest || (this.Suggest != null && !this.Suggest.Equals(input.Suggest))) return false;
            if (this.Influence != input.Influence || (this.Influence != null && !this.Influence.Equals(input.Influence))) return false;
            if (this.Guidance != input.Guidance || (this.Guidance != null && !this.Guidance.Equals(input.Guidance))) return false;
            if (this.ServiceImpactDuration != input.ServiceImpactDuration || (this.ServiceImpactDuration != null && !this.ServiceImpactDuration.Equals(input.ServiceImpactDuration))) return false;
            if (this.UpgradeDuration != input.UpgradeDuration || (this.UpgradeDuration != null && !this.UpgradeDuration.Equals(input.UpgradeDuration))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.EngineName != null) hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Suggest != null) hashCode = hashCode * 59 + this.Suggest.GetHashCode();
                if (this.Influence != null) hashCode = hashCode * 59 + this.Influence.GetHashCode();
                if (this.Guidance != null) hashCode = hashCode * 59 + this.Guidance.GetHashCode();
                if (this.ServiceImpactDuration != null) hashCode = hashCode * 59 + this.ServiceImpactDuration.GetHashCode();
                if (this.UpgradeDuration != null) hashCode = hashCode * 59 + this.UpgradeDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
