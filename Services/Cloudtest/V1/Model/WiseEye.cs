using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WiseEye 
    {

        /// <summary>
        /// 是否开启云眼告警配置
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public string Enable { get; set; }

        /// <summary>
        /// 云眼告警级别
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        /// 云眼告警区域，目前取值有：china（中国区），asiaAfricaLatin（亚非拉），europe（欧洲）
        /// </summary>
        [JsonProperty("region_key", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionKey { get; set; }

        /// <summary>
        /// 云眼告警id，对应云眼信息中的name
        /// </summary>
        [JsonProperty("scope_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScopeId { get; set; }

        /// <summary>
        /// 云眼告警范围，对应云眼信息中的label
        /// </summary>
        [JsonProperty("scope_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScopeName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WiseEye {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  regionKey: ").Append(RegionKey).Append("\n");
            sb.Append("  scopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  scopeName: ").Append(ScopeName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WiseEye);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WiseEye input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.RegionKey != input.RegionKey || (this.RegionKey != null && !this.RegionKey.Equals(input.RegionKey))) return false;
            if (this.ScopeId != input.ScopeId || (this.ScopeId != null && !this.ScopeId.Equals(input.ScopeId))) return false;
            if (this.ScopeName != input.ScopeName || (this.ScopeName != null && !this.ScopeName.Equals(input.ScopeName))) return false;

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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.RegionKey != null) hashCode = hashCode * 59 + this.RegionKey.GetHashCode();
                if (this.ScopeId != null) hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
                if (this.ScopeName != null) hashCode = hashCode * 59 + this.ScopeName.GetHashCode();
                return hashCode;
            }
        }
    }
}
