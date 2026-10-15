using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 流量回放源数据库配置返回体
    /// </summary>
    public class ReplaySourceConfigResp 
    {

        /// <summary>
        /// 流量回放源数据库引擎类型
        /// </summary>
        [JsonProperty("engine_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineType { get; set; }

        /// <summary>
        /// 流量回放源数据库类型
        /// </summary>
        [JsonProperty("source_endpoint_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceEndpointType { get; set; }

        /// <summary>
        /// 流量回放源数据库来源
        /// </summary>
        [JsonProperty("source_db_origin", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDbOrigin { get; set; }

        /// <summary>
        /// 流量回放流量文件来源
        /// </summary>
        [JsonProperty("traffic_source", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficSource { get; set; }

        /// <summary>
        /// 流量回放流量类型
        /// </summary>
        [JsonProperty("support_traffic_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportTrafficTypes { get; set; }

        /// <summary>
        /// 流量回放agent支持的操作系统
        /// </summary>
        [JsonProperty("support_os_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportOsTypes { get; set; }

        /// <summary>
        /// 流量回放引擎支持的镜像库
        /// </summary>
        [JsonProperty("support_mirror_database_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportMirrorDatabaseTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplaySourceConfigResp {\n");
            sb.Append("  engineType: ").Append(EngineType).Append("\n");
            sb.Append("  sourceEndpointType: ").Append(SourceEndpointType).Append("\n");
            sb.Append("  sourceDbOrigin: ").Append(SourceDbOrigin).Append("\n");
            sb.Append("  trafficSource: ").Append(TrafficSource).Append("\n");
            sb.Append("  supportTrafficTypes: ").Append(SupportTrafficTypes).Append("\n");
            sb.Append("  supportOsTypes: ").Append(SupportOsTypes).Append("\n");
            sb.Append("  supportMirrorDatabaseTypes: ").Append(SupportMirrorDatabaseTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplaySourceConfigResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplaySourceConfigResp input)
        {
            if (input == null) return false;
            if (this.EngineType != input.EngineType || (this.EngineType != null && !this.EngineType.Equals(input.EngineType))) return false;
            if (this.SourceEndpointType != input.SourceEndpointType || (this.SourceEndpointType != null && !this.SourceEndpointType.Equals(input.SourceEndpointType))) return false;
            if (this.SourceDbOrigin != input.SourceDbOrigin || (this.SourceDbOrigin != null && !this.SourceDbOrigin.Equals(input.SourceDbOrigin))) return false;
            if (this.TrafficSource != input.TrafficSource || (this.TrafficSource != null && !this.TrafficSource.Equals(input.TrafficSource))) return false;
            if (this.SupportTrafficTypes != input.SupportTrafficTypes || (this.SupportTrafficTypes != null && input.SupportTrafficTypes != null && !this.SupportTrafficTypes.SequenceEqual(input.SupportTrafficTypes))) return false;
            if (this.SupportOsTypes != input.SupportOsTypes || (this.SupportOsTypes != null && input.SupportOsTypes != null && !this.SupportOsTypes.SequenceEqual(input.SupportOsTypes))) return false;
            if (this.SupportMirrorDatabaseTypes != input.SupportMirrorDatabaseTypes || (this.SupportMirrorDatabaseTypes != null && input.SupportMirrorDatabaseTypes != null && !this.SupportMirrorDatabaseTypes.SequenceEqual(input.SupportMirrorDatabaseTypes))) return false;

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
                if (this.EngineType != null) hashCode = hashCode * 59 + this.EngineType.GetHashCode();
                if (this.SourceEndpointType != null) hashCode = hashCode * 59 + this.SourceEndpointType.GetHashCode();
                if (this.SourceDbOrigin != null) hashCode = hashCode * 59 + this.SourceDbOrigin.GetHashCode();
                if (this.TrafficSource != null) hashCode = hashCode * 59 + this.TrafficSource.GetHashCode();
                if (this.SupportTrafficTypes != null) hashCode = hashCode * 59 + this.SupportTrafficTypes.GetHashCode();
                if (this.SupportOsTypes != null) hashCode = hashCode * 59 + this.SupportOsTypes.GetHashCode();
                if (this.SupportMirrorDatabaseTypes != null) hashCode = hashCode * 59 + this.SupportMirrorDatabaseTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
