using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListCorpConfigInfoResponse : SdkResponse
    {

        /// <summary>
        /// 批量配置项列表。
        /// </summary>
        [JsonProperty("config_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<CorpConfigInfo> ConfigInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCorpConfigInfoResponse {\n");
            sb.Append("  configInfos: ").Append(ConfigInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCorpConfigInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCorpConfigInfoResponse input)
        {
            if (input == null) return false;
            if (this.ConfigInfos != input.ConfigInfos || (this.ConfigInfos != null && input.ConfigInfos != null && !this.ConfigInfos.SequenceEqual(input.ConfigInfos))) return false;

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
                if (this.ConfigInfos != null) hashCode = hashCode * 59 + this.ConfigInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
