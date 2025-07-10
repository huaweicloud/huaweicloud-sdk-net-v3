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
    /// 根据不同的任务，显示不同的内容。
    /// </summary>
    public class GetJobInfoResponseBodyJobEntities 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("instance", NullValueHandling = NullValueHandling.Ignore)]
        public GetJobInfoResponseBodyJobEntitiesInstance Instance { get; set; }

        /// <summary>
        /// 创建实例，单转主备，创建只读实例，调整实例容量任务时等任务时返回。
        /// </summary>
        [JsonProperty("resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public GetJobInfoResponseBodyJobEntitiesVolume Volume { get; set; }

        /// <summary>
        /// 绑定/解绑弹性IP，开启远程连接等任务时返回。
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 主备倒换任务时返回。
        /// </summary>
        [JsonProperty("switch_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchStrategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetJobInfoResponseBodyJobEntities {\n");
            sb.Append("  instance: ").Append(Instance).Append("\n");
            sb.Append("  resourceIds: ").Append(ResourceIds).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  switchStrategy: ").Append(SwitchStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetJobInfoResponseBodyJobEntities);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetJobInfoResponseBodyJobEntities input)
        {
            if (input == null) return false;
            if (this.Instance != input.Instance || (this.Instance != null && !this.Instance.Equals(input.Instance))) return false;
            if (this.ResourceIds != input.ResourceIds || (this.ResourceIds != null && input.ResourceIds != null && !this.ResourceIds.SequenceEqual(input.ResourceIds))) return false;
            if (this.Volume != input.Volume || (this.Volume != null && !this.Volume.Equals(input.Volume))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.SwitchStrategy != input.SwitchStrategy || (this.SwitchStrategy != null && !this.SwitchStrategy.Equals(input.SwitchStrategy))) return false;

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
                if (this.Instance != null) hashCode = hashCode * 59 + this.Instance.GetHashCode();
                if (this.ResourceIds != null) hashCode = hashCode * 59 + this.ResourceIds.GetHashCode();
                if (this.Volume != null) hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.SwitchStrategy != null) hashCode = hashCode * 59 + this.SwitchStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
