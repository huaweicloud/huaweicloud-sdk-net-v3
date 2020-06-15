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
        /// 与指定弹性云服务器满足反亲和性。当前不支持该功能。
        /// </summary>
        [JsonProperty("different_host", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DifferentHost { get; set; }

        /// <summary>
        /// 与指定的弹性云服务器满足亲和性。当前不支持该功能。
        /// </summary>
        [JsonProperty("same_host", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SameHost { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerSchedulerHints {\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  differentHost: ").Append(DifferentHost).Append("\n");
            sb.Append("  sameHost: ").Append(SameHost).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.Group == input.Group ||
                    this.Group != null &&
                    input.Group != null &&
                    this.Group.SequenceEqual(input.Group)
                ) && 
                (
                    this.DifferentHost == input.DifferentHost ||
                    this.DifferentHost != null &&
                    input.DifferentHost != null &&
                    this.DifferentHost.SequenceEqual(input.DifferentHost)
                ) && 
                (
                    this.SameHost == input.SameHost ||
                    this.SameHost != null &&
                    input.SameHost != null &&
                    this.SameHost.SequenceEqual(input.SameHost)
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
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.DifferentHost != null)
                    hashCode = hashCode * 59 + this.DifferentHost.GetHashCode();
                if (this.SameHost != null)
                    hashCode = hashCode * 59 + this.SameHost.GetHashCode();
                return hashCode;
            }
        }
    }
}
