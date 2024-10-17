using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// 操作事件列表，目前最多支持对100服务的1000个关键操作进行配置。
    /// </summary>
    public class Operations 
    {

        /// <summary>
        /// 标识云服务类型。必须为已对接CTS的云服务的英文缩写，且服务类型一般为大写字母。 已对接的云服务列表参见《云审计服务用户指南》“支持的服务”章节。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 标识资源类型。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 标识事件名称。
        /// </summary>
        [JsonProperty("trace_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TraceNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Operations {\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  traceNames: ").Append(TraceNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Operations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Operations input)
        {
            if (input == null) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.TraceNames != input.TraceNames || (this.TraceNames != null && input.TraceNames != null && !this.TraceNames.SequenceEqual(input.TraceNames))) return false;

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
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.TraceNames != null) hashCode = hashCode * 59 + this.TraceNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
