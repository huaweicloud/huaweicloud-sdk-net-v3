using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 简单配额资源。
    /// </summary>
    public class SimpleResource 
    {

        /// <summary>
        /// 资源类别。 general_instances：普通桌面 Memory：内存 cores：CPU volumes：磁盘数量 volume_gigabytes：磁盘容量 gpu_instances：GPU桌面 deh：云办公主机 users：用户 policy_groups: 策略组 Cores: CPU(配额工具使用)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 配额数。
        /// </summary>
        [JsonProperty("quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quota { get; set; }

        /// <summary>
        /// 配额已用值。
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public int? Used { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleResource {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  quota: ").Append(Quota).Append("\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SimpleResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SimpleResource input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Quota != input.Quota || (this.Quota != null && !this.Quota.Equals(input.Quota))) return false;
            if (this.Used != input.Used || (this.Used != null && !this.Used.Equals(input.Used))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Quota != null) hashCode = hashCode * 59 + this.Quota.GetHashCode();
                if (this.Used != null) hashCode = hashCode * 59 + this.Used.GetHashCode();
                return hashCode;
            }
        }
    }
}
