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
        /// 系统内部呈现的权限名称。如云目录服务CCS普通用户权限CCS User的name为ccs_user。 建议您传参display_name，不传name参数。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 账号ID，获取方式请参见：[获取账号ID](https://support.huaweicloud.com/api-iam/iam_17_0002.html)。 &gt; - 如果填写此参数，则返回账号下所有自定义策略。 &gt; - 如果不填写此参数，则返回所有系统权限（包含系统策略和系统角色）。
        /// </summary>
        [SDKProperty("domain_id", IsQuery = true)]
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 分页查询时数据的页数，查询值最小为1。需要与per_page同时存在。传入domain_id参数查询自定义策略时，可配套使用。
        /// </summary>
        [SDKProperty("page", IsQuery = true)]
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// 分页查询时每页的数据个数，取值范围为[1,300]，默认值为300。需要与page同时存在。不传page和per_page参数时，每页最多返回300个权限。
        /// </summary>
        [SDKProperty("per_page", IsQuery = true)]
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }

        /// <summary>
        /// 区分系统权限类型的参数。当domain_id参数为空时生效。 &gt; - policy：返回系统策略。 &gt; - role：返回系统角色。
        /// </summary>
        [SDKProperty("permission_type", IsQuery = true)]
        [JsonProperty("permission_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PermissionType { get; set; }

        /// <summary>
        /// 过滤权限名称。如传参为Administrator，则返回满足条件的所有管理员权限。
        /// </summary>
        [SDKProperty("display_name", IsQuery = true)]
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 过滤权限的显示模式。取值范围：domain,project,all。type为domain时，返回type&#x3D;AA或AX的权限；type为project时，返回type&#x3D;AA或XA的权限；type为all时返回type为AA、AX、XA的权限。 &gt; - AX表示在domain层显示。 &gt; - XA表示在project层显示。 &gt; - AA表示在domain和project层均显示。 &gt; - XX表示在domain和project层均不显示。
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 权限所在目录。catalog值精确匹配策略的catalog字段(可以过滤服务的策略、或者自定义策略)。
        /// </summary>
        [SDKProperty("catalog", IsQuery = true)]
        [JsonProperty("catalog", NullValueHandling = NullValueHandling.Ignore)]
        public string Catalog { get; set; }


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
            sb.Append("  permissionType: ").Append(PermissionType).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  catalog: ").Append(Catalog).Append("\n");
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
                ) && 
                (
                    this.PermissionType == input.PermissionType ||
                    (this.PermissionType != null &&
                    this.PermissionType.Equals(input.PermissionType))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Catalog == input.Catalog ||
                    (this.Catalog != null &&
                    this.Catalog.Equals(input.Catalog))
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
                if (this.PermissionType != null)
                    hashCode = hashCode * 59 + this.PermissionType.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Catalog != null)
                    hashCode = hashCode * 59 + this.Catalog.GetHashCode();
                return hashCode;
            }
        }
    }
}
