using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 环境基本信息
    /// </summary>
    public class EnvironmentBaseInfo 
    {

        /// <summary>
        /// 环境名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 操作系统：windows|linux
        /// </summary>
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        /// <summary>
        /// 主机集群id
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 环境下主机数量
        /// </summary>
        [JsonProperty("host_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? HostCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvironmentBaseInfo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  uuid: ").Append(Uuid).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  hostCount: ").Append(HostCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnvironmentBaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnvironmentBaseInfo input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Os != input.Os || (this.Os != null && !this.Os.Equals(input.Os))) return false;
            if (this.Uuid != input.Uuid || (this.Uuid != null && !this.Uuid.Equals(input.Uuid))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.HostCount != input.HostCount || (this.HostCount != null && !this.HostCount.Equals(input.HostCount))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Os != null) hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.Uuid != null) hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.HostCount != null) hashCode = hashCode * 59 + this.HostCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
