using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowPluginConfigDefaultInfoResponse : SdkResponse
    {

        /// <summary>
        /// 默认插件支持列表
        /// </summary>
        [JsonProperty("default_plugin_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DefaultPluginInfo> DefaultPluginList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPluginConfigDefaultInfoResponse {\n");
            sb.Append("  defaultPluginList: ").Append(DefaultPluginList).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPluginConfigDefaultInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPluginConfigDefaultInfoResponse input)
        {
            if (input == null) return false;
            if (this.DefaultPluginList != input.DefaultPluginList || (this.DefaultPluginList != null && input.DefaultPluginList != null && !this.DefaultPluginList.SequenceEqual(input.DefaultPluginList))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.DefaultPluginList != null) hashCode = hashCode * 59 + this.DefaultPluginList.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
