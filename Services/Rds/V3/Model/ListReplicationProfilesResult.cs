using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 发布订配置文件响应信息。
    /// </summary>
    public class ListReplicationProfilesResult 
    {

        /// <summary>
        /// 配置文件id。
        /// </summary>
        [JsonProperty("profile_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileId { get; set; }

        /// <summary>
        /// 配置文件名。
        /// </summary>
        [JsonProperty("profile_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileName { get; set; }

        /// <summary>
        /// 代理类型。  snapshot：快照代理 log_reader：日志读取器代理 distribution：分发代理 merge:合并代理 queue_reader：队列读取器代理。
        /// </summary>
        [JsonProperty("agent_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentType { get; set; }

        /// <summary>
        /// 配置文件说明。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 是否为默认配置。  true：是默认配置。 false：不是默认配置。
        /// </summary>
        [JsonProperty("is_def_profile", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefProfile { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListReplicationProfilesResult {\n");
            sb.Append("  profileId: ").Append(ProfileId).Append("\n");
            sb.Append("  profileName: ").Append(ProfileName).Append("\n");
            sb.Append("  agentType: ").Append(AgentType).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isDefProfile: ").Append(IsDefProfile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListReplicationProfilesResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListReplicationProfilesResult input)
        {
            if (input == null) return false;
            if (this.ProfileId != input.ProfileId || (this.ProfileId != null && !this.ProfileId.Equals(input.ProfileId))) return false;
            if (this.ProfileName != input.ProfileName || (this.ProfileName != null && !this.ProfileName.Equals(input.ProfileName))) return false;
            if (this.AgentType != input.AgentType || (this.AgentType != null && !this.AgentType.Equals(input.AgentType))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IsDefProfile != input.IsDefProfile || (this.IsDefProfile != null && !this.IsDefProfile.Equals(input.IsDefProfile))) return false;

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
                if (this.ProfileId != null) hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                if (this.ProfileName != null) hashCode = hashCode * 59 + this.ProfileName.GetHashCode();
                if (this.AgentType != null) hashCode = hashCode * 59 + this.AgentType.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsDefProfile != null) hashCode = hashCode * 59 + this.IsDefProfile.GetHashCode();
                return hashCode;
            }
        }
    }
}
