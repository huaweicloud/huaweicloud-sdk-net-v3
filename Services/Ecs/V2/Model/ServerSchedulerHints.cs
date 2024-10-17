using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 弹性云服务器调度信息。
    /// </summary>
    public class ServerSchedulerHints 
    {

        /// <summary>
        /// 反亲和性组信息。  UUID格式。
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Group { get; set; }

        /// <summary>
        /// 在专属主机或共享池中创建弹性云服务器。默认为在共享池创建。值为： shared或dedicated。  - shared：表示共享池。 - dedicated:表示专属主机。  创建与查询此值均有效。
        /// </summary>
        [JsonProperty("tenancy", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tenancy { get; set; }

        /// <summary>
        /// 专属主机ID。  此属性仅在tenancy值为dedicated时有效。  不指定此属性，系统将自动分配租户可自动放置弹性云服务器的专属主机。  创建与查询此值均有效。
        /// </summary>
        [JsonProperty("dedicated_host_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DedicatedHostId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerSchedulerHints {\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  tenancy: ").Append(Tenancy).Append("\n");
            sb.Append("  dedicatedHostId: ").Append(DedicatedHostId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerSchedulerHints);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerSchedulerHints input)
        {
            if (input == null) return false;
            if (this.Group != input.Group || (this.Group != null && input.Group != null && !this.Group.SequenceEqual(input.Group))) return false;
            if (this.Tenancy != input.Tenancy || (this.Tenancy != null && input.Tenancy != null && !this.Tenancy.SequenceEqual(input.Tenancy))) return false;
            if (this.DedicatedHostId != input.DedicatedHostId || (this.DedicatedHostId != null && input.DedicatedHostId != null && !this.DedicatedHostId.SequenceEqual(input.DedicatedHostId))) return false;

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
                if (this.Group != null) hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Tenancy != null) hashCode = hashCode * 59 + this.Tenancy.GetHashCode();
                if (this.DedicatedHostId != null) hashCode = hashCode * 59 + this.DedicatedHostId.GetHashCode();
                return hashCode;
            }
        }
    }
}
