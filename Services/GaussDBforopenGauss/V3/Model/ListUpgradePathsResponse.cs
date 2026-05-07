using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListUpgradePathsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 版本信息详情 
        /// </summary>
        [JsonProperty("version_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<VersionInfosResult> VersionInfos { get; set; }

        /// <summary>
        /// **参数解释**: 支持的升级路径列表 
        /// </summary>
        [JsonProperty("version_edges", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpgradePathsResult> VersionEdges { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUpgradePathsResponse {\n");
            sb.Append("  versionInfos: ").Append(VersionInfos).Append("\n");
            sb.Append("  versionEdges: ").Append(VersionEdges).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUpgradePathsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUpgradePathsResponse input)
        {
            if (input == null) return false;
            if (this.VersionInfos != input.VersionInfos || (this.VersionInfos != null && input.VersionInfos != null && !this.VersionInfos.SequenceEqual(input.VersionInfos))) return false;
            if (this.VersionEdges != input.VersionEdges || (this.VersionEdges != null && input.VersionEdges != null && !this.VersionEdges.SequenceEqual(input.VersionEdges))) return false;

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
                if (this.VersionInfos != null) hashCode = hashCode * 59 + this.VersionInfos.GetHashCode();
                if (this.VersionEdges != null) hashCode = hashCode * 59 + this.VersionEdges.GetHashCode();
                return hashCode;
            }
        }
    }
}
