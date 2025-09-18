using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 有向连接
    /// </summary>
    public class DirectionalConnection 
    {

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 功能说明：本端接入点的编码。
        /// </summary>
        [JsonProperty("local_site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalSiteCode { get; set; }

        /// <summary>
        /// 功能说明：远端接入点的编码。
        /// </summary>
        [JsonProperty("remote_site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteSiteCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DirectionalConnection {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  localSiteCode: ").Append(LocalSiteCode).Append("\n");
            sb.Append("  remoteSiteCode: ").Append(RemoteSiteCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DirectionalConnection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DirectionalConnection input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.LocalSiteCode != input.LocalSiteCode || (this.LocalSiteCode != null && !this.LocalSiteCode.Equals(input.LocalSiteCode))) return false;
            if (this.RemoteSiteCode != input.RemoteSiteCode || (this.RemoteSiteCode != null && !this.RemoteSiteCode.Equals(input.RemoteSiteCode))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LocalSiteCode != null) hashCode = hashCode * 59 + this.LocalSiteCode.GetHashCode();
                if (this.RemoteSiteCode != null) hashCode = hashCode * 59 + this.RemoteSiteCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
