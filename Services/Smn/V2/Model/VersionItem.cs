using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VersionItem 
    {

        /// <summary>
        /// 版本ID（版本号），如v2。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 若该版本API支持微版本，则返回支持的最小微版本号；若不支持微版本，则返回空。
        /// </summary>
        [JsonProperty("min_version", NullValueHandling = NullValueHandling.Ignore)]
        public string MinVersion { get; set; }

        /// <summary>
        /// 版本状态，为如下3种：  CURRENT：表示该版本为主推版本。  SUPPORTED：表示为老版本，但是现在还继续支持。  DEPRECATED：表示为废弃版本，存在后续删除的可能。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 版本发布时间，要求用UTC时间格式表示。如v2发布的时间2014-06-28T12:20:21Z。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 若该版本API支持微版本，则返回支持的最大微版本号；若不支持微版本，则返回空。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// API的URL地址。
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<LinksItem> Links { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionItem {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  minVersion: ").Append(MinVersion).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VersionItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VersionItem input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.MinVersion != input.MinVersion || (this.MinVersion != null && !this.MinVersion.Equals(input.MinVersion))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Links != input.Links || (this.Links != null && input.Links != null && !this.Links.SequenceEqual(input.Links))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MinVersion != null) hashCode = hashCode * 59 + this.MinVersion.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Links != null) hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }
}
