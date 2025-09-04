using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 安全态势感知配置
    /// </summary>
    public class UpdateSecurityProfileDTO 
    {

        /// <summary>
        /// 安全态势感知告警级别，CRITICAL：严重告警，MAJOR：重要告警，MINOR：一般告警
        /// </summary>
        [JsonProperty("alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmLevel { get; set; }

        /// <summary>
        /// 安全态势感知项所属安全风险级别；BASIC_SECURITY：基础安全，ADVANCE_SECURITY：高级安全，ULTIMATE_SECURITY：极致安全
        /// </summary>
        [JsonProperty("security_level", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityLevel { get; set; }

        /// <summary>
        /// 安全态势感知项是否开启
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 安全态势感知项配置结构体，用于设备侧检测项下发给设备
        /// </summary>
        [JsonProperty("profile", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityProfile> Profile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("profile_targets", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityTarget ProfileTargets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSecurityProfileDTO {\n");
            sb.Append("  alarmLevel: ").Append(AlarmLevel).Append("\n");
            sb.Append("  securityLevel: ").Append(SecurityLevel).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  profile: ").Append(Profile).Append("\n");
            sb.Append("  profileTargets: ").Append(ProfileTargets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSecurityProfileDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSecurityProfileDTO input)
        {
            if (input == null) return false;
            if (this.AlarmLevel != input.AlarmLevel || (this.AlarmLevel != null && !this.AlarmLevel.Equals(input.AlarmLevel))) return false;
            if (this.SecurityLevel != input.SecurityLevel || (this.SecurityLevel != null && !this.SecurityLevel.Equals(input.SecurityLevel))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.Profile != input.Profile || (this.Profile != null && input.Profile != null && !this.Profile.SequenceEqual(input.Profile))) return false;
            if (this.ProfileTargets != input.ProfileTargets || (this.ProfileTargets != null && !this.ProfileTargets.Equals(input.ProfileTargets))) return false;

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
                if (this.AlarmLevel != null) hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                if (this.SecurityLevel != null) hashCode = hashCode * 59 + this.SecurityLevel.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.Profile != null) hashCode = hashCode * 59 + this.Profile.GetHashCode();
                if (this.ProfileTargets != null) hashCode = hashCode * 59 + this.ProfileTargets.GetHashCode();
                return hashCode;
            }
        }
    }
}
