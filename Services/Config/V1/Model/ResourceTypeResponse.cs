using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 资源类型详情
    /// </summary>
    public class ResourceTypeResponse 
    {

        /// <summary>
        /// 资源类型名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 资源类型显示名称，可以通过请求中 &#39;X-Language&#39;设置语言
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 是否是全局类型的资源
        /// </summary>
        [JsonProperty("global", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Global { get; set; }

        /// <summary>
        /// 支持的region列表
        /// </summary>
        [JsonProperty("regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// console终端id
        /// </summary>
        [JsonProperty("console_endpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsoleEndpointId { get; set; }

        /// <summary>
        /// console列表页地址
        /// </summary>
        [JsonProperty("console_list_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsoleListUrl { get; set; }

        /// <summary>
        /// console详情页地址
        /// </summary>
        [JsonProperty("console_detail_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsoleDetailUrl { get; set; }

        /// <summary>
        /// 资源是否默认收集，\&quot;tracked\&quot;表示默认收集，\&quot;untracked\&quot;表示默认不收集
        /// </summary>
        [JsonProperty("track", NullValueHandling = NullValueHandling.Ignore)]
        public string Track { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceTypeResponse {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  global: ").Append(Global).Append("\n");
            sb.Append("  regions: ").Append(Regions).Append("\n");
            sb.Append("  consoleEndpointId: ").Append(ConsoleEndpointId).Append("\n");
            sb.Append("  consoleListUrl: ").Append(ConsoleListUrl).Append("\n");
            sb.Append("  consoleDetailUrl: ").Append(ConsoleDetailUrl).Append("\n");
            sb.Append("  track: ").Append(Track).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceTypeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceTypeResponse input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.Global != input.Global || (this.Global != null && !this.Global.Equals(input.Global))) return false;
            if (this.Regions != input.Regions || (this.Regions != null && input.Regions != null && !this.Regions.SequenceEqual(input.Regions))) return false;
            if (this.ConsoleEndpointId != input.ConsoleEndpointId || (this.ConsoleEndpointId != null && !this.ConsoleEndpointId.Equals(input.ConsoleEndpointId))) return false;
            if (this.ConsoleListUrl != input.ConsoleListUrl || (this.ConsoleListUrl != null && !this.ConsoleListUrl.Equals(input.ConsoleListUrl))) return false;
            if (this.ConsoleDetailUrl != input.ConsoleDetailUrl || (this.ConsoleDetailUrl != null && !this.ConsoleDetailUrl.Equals(input.ConsoleDetailUrl))) return false;
            if (this.Track != input.Track || (this.Track != null && !this.Track.Equals(input.Track))) return false;

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
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Global != null) hashCode = hashCode * 59 + this.Global.GetHashCode();
                if (this.Regions != null) hashCode = hashCode * 59 + this.Regions.GetHashCode();
                if (this.ConsoleEndpointId != null) hashCode = hashCode * 59 + this.ConsoleEndpointId.GetHashCode();
                if (this.ConsoleListUrl != null) hashCode = hashCode * 59 + this.ConsoleListUrl.GetHashCode();
                if (this.ConsoleDetailUrl != null) hashCode = hashCode * 59 + this.ConsoleDetailUrl.GetHashCode();
                if (this.Track != null) hashCode = hashCode * 59 + this.Track.GetHashCode();
                return hashCode;
            }
        }
    }
}
