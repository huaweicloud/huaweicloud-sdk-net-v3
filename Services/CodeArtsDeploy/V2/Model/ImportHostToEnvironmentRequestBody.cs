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
    /// 环境下导入主机请求体
    /// </summary>
    public class ImportHostToEnvironmentRequestBody 
    {

        /// <summary>
        /// 主机集群id
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 要导入的主机id列表
        /// </summary>
        [JsonProperty("host_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HostIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportHostToEnvironmentRequestBody {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  hostIds: ").Append(HostIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportHostToEnvironmentRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportHostToEnvironmentRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.HostIds == input.HostIds ||
                    this.HostIds != null &&
                    input.HostIds != null &&
                    this.HostIds.SequenceEqual(input.HostIds)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.HostIds != null)
                    hashCode = hashCode * 59 + this.HostIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
