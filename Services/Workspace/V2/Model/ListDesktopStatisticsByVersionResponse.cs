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
    /// Response Object
    /// </summary>
    public class ListDesktopStatisticsByVersionResponse : SdkResponse
    {

        /// <summary>
        /// 按版本分组的桌面统计信息列表。
        /// </summary>
        [JsonProperty("version_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<DesktopVersionStatistic> VersionStatistics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDesktopStatisticsByVersionResponse {\n");
            sb.Append("  versionStatistics: ").Append(VersionStatistics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDesktopStatisticsByVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDesktopStatisticsByVersionResponse input)
        {
            if (input == null) return false;
            if (this.VersionStatistics != input.VersionStatistics || (this.VersionStatistics != null && input.VersionStatistics != null && !this.VersionStatistics.SequenceEqual(input.VersionStatistics))) return false;

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
                if (this.VersionStatistics != null) hashCode = hashCode * 59 + this.VersionStatistics.GetHashCode();
                return hashCode;
            }
        }
    }
}
