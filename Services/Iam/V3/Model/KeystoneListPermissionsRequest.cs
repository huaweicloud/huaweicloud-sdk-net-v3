using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class KeystoneListPermissionsRequest 
    {

        /// <summary>
        /// 权限名，获取方式请参见：[获取权限名、权限ID](https://support.huaweicloud.com/api-iam/iam_10_0001.html)。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 账号ID，获取方式请参见：[获取账号ID](https://support.huaweicloud.com/api-iam/iam_17_0002.html)。    &gt; - 如果填写此参数，则返回账号下所有自定义策略。 &gt; - 如果不填写此参数，则返回所有系统权限（包含系统策略和系统角色）。
        /// </summary>
        [SDKProperty("domain_id", IsQuery = true)]
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 分页查询时数据的页数，查询值最小为1，默认值为1。需要与per_page同时使用。
        /// </summary>
        [SDKProperty("page", IsQuery = true)]
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// 分页查询时每页的数据个数，取值范围为[1,300], 默认值为300。需要与page同时使用。
        /// </summary>
        [SDKProperty("per_page", IsQuery = true)]
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneListPermissionsRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  perPage: ").Append(PerPage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneListPermissionsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneListPermissionsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                return hashCode;
            }
        }
    }
}
