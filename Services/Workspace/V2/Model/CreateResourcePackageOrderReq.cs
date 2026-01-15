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
    /// 创建资源包订单请求体。
    /// </summary>
    public class CreateResourcePackageOrderReq 
    {

        /// <summary>
        /// 企业项目ID，上传则指定企业项目，不上传则表示所有企业项目。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 资源包。
        /// </summary>
        [JsonProperty("resource_packages", NullValueHandling = NullValueHandling.Ignore)]
        public List<DesktopResourcePackage> ResourcePackages { get; set; }

        /// <summary>
        /// 购买资源包数量。
        /// </summary>
        [JsonProperty("resource_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extend_param", NullValueHandling = NullValueHandling.Ignore)]
        public OrderExtendParam ExtendParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateResourcePackageOrderReq {\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  resourcePackages: ").Append(ResourcePackages).Append("\n");
            sb.Append("  resourceSize: ").Append(ResourceSize).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateResourcePackageOrderReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateResourcePackageOrderReq input)
        {
            if (input == null) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ResourcePackages != input.ResourcePackages || (this.ResourcePackages != null && input.ResourcePackages != null && !this.ResourcePackages.SequenceEqual(input.ResourcePackages))) return false;
            if (this.ResourceSize != input.ResourceSize || (this.ResourceSize != null && !this.ResourceSize.Equals(input.ResourceSize))) return false;
            if (this.ExtendParam != input.ExtendParam || (this.ExtendParam != null && !this.ExtendParam.Equals(input.ExtendParam))) return false;

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
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ResourcePackages != null) hashCode = hashCode * 59 + this.ResourcePackages.GetHashCode();
                if (this.ResourceSize != null) hashCode = hashCode * 59 + this.ResourceSize.GetHashCode();
                if (this.ExtendParam != null) hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
