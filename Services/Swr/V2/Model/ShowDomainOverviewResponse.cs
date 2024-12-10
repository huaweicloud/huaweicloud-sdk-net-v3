using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDomainOverviewResponse : SdkResponse
    {

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 租户名称
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 当前租户的命名空间个数
        /// </summary>
        [JsonProperty("namspace_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? NamspaceNum { get; set; }

        /// <summary>
        /// 当前租户的仓库个数
        /// </summary>
        [JsonProperty("repo_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? RepoNum { get; set; }

        /// <summary>
        /// 当前租户的镜像个数
        /// </summary>
        [JsonProperty("image_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? ImageNum { get; set; }

        /// <summary>
        /// 当前租户存储大小
        /// </summary>
        [JsonProperty("store_space", NullValueHandling = NullValueHandling.Ignore)]
        public double? StoreSpace { get; set; }

        /// <summary>
        /// 当前租户下载流量大小
        /// </summary>
        [JsonProperty("downflow_size", NullValueHandling = NullValueHandling.Ignore)]
        public double? DownflowSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainOverviewResponse {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  namspaceNum: ").Append(NamspaceNum).Append("\n");
            sb.Append("  repoNum: ").Append(RepoNum).Append("\n");
            sb.Append("  imageNum: ").Append(ImageNum).Append("\n");
            sb.Append("  storeSpace: ").Append(StoreSpace).Append("\n");
            sb.Append("  downflowSize: ").Append(DownflowSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainOverviewResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainOverviewResponse input)
        {
            if (input == null) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.NamspaceNum != input.NamspaceNum || (this.NamspaceNum != null && !this.NamspaceNum.Equals(input.NamspaceNum))) return false;
            if (this.RepoNum != input.RepoNum || (this.RepoNum != null && !this.RepoNum.Equals(input.RepoNum))) return false;
            if (this.ImageNum != input.ImageNum || (this.ImageNum != null && !this.ImageNum.Equals(input.ImageNum))) return false;
            if (this.StoreSpace != input.StoreSpace || (this.StoreSpace != null && !this.StoreSpace.Equals(input.StoreSpace))) return false;
            if (this.DownflowSize != input.DownflowSize || (this.DownflowSize != null && !this.DownflowSize.Equals(input.DownflowSize))) return false;

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
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.NamspaceNum != null) hashCode = hashCode * 59 + this.NamspaceNum.GetHashCode();
                if (this.RepoNum != null) hashCode = hashCode * 59 + this.RepoNum.GetHashCode();
                if (this.ImageNum != null) hashCode = hashCode * 59 + this.ImageNum.GetHashCode();
                if (this.StoreSpace != null) hashCode = hashCode * 59 + this.StoreSpace.GetHashCode();
                if (this.DownflowSize != null) hashCode = hashCode * 59 + this.DownflowSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
