using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListVirsubnetCidrReservationsRequest 
    {

        /// <summary>
        /// **参数解释**： 每页返回的资源个数。 **取值范围**： 0~2000
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**： 分页查询起始的资源ID，为空时查询第一页。 **取值范围**： 子网预留网段的资源ID。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// **参数解释**： 子网预留网段的资源ID。可以使用该字段过滤子网预留网段，支持传入多个ID过滤。 **取值范围**： 不涉及。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// **参数解释**： 子网预留网段所在的子网ID。可以使用该字段过滤子网预留网段，支持传入多个ID过滤。 **取值范围**： 不涉及。
        /// </summary>
        [SDKProperty("virsubnet_id", IsQuery = true)]
        [JsonProperty("virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VirsubnetId { get; set; }

        /// <summary>
        /// **参数解释**： 子网预留网段的IP网段。可以使用该字段过滤子网预留网段，支持传入多个IP网段过滤。 **取值范围**： 不涉及。
        /// </summary>
        [SDKProperty("cidr", IsQuery = true)]
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Cidr { get; set; }

        /// <summary>
        /// **参数解释**： 子网预留网段所在子网的IP版本。可以使用该字段过滤子网预留网段，支持传入多个IP版本过滤。 **取值范围**： - 4：过滤出IPv4子网预留网段。 - 6：过滤出IPv6子网预留网段。
        /// </summary>
        [SDKProperty("ip_version", IsQuery = true)]
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> IpVersion { get; set; }

        /// <summary>
        /// **参数解释**： 子网预留网段的名称。可以使用该字段过滤满足条件的子网预留网段，支持传入多个名称过滤。 **取值范围**： 不涉及。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// **参数解释**： 子网预留网段的描述信息。可以使用该字段过滤子网预留网段，支持传入多个描述信息进行过滤。 **取值范围**： 不涉及。
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Description { get; set; }

        /// <summary>
        /// **参数解释**： 子网预留网段所属的企业项目ID。可以使用该字段过滤某个企业项目下的子网预留网段。 **取值范围**： - 最大长度36字节，带“-”连字符的UUID格式，或者是字符串“0”。“0”表示默认企业项目。 - 若需要查询当前用户所有有权限查看企业项目绑定的子网预留网段，请传参all_granted_eps。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListVirsubnetCidrReservationsRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  virsubnetId: ").Append(VirsubnetId).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListVirsubnetCidrReservationsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListVirsubnetCidrReservationsRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.VirsubnetId != input.VirsubnetId || (this.VirsubnetId != null && input.VirsubnetId != null && !this.VirsubnetId.SequenceEqual(input.VirsubnetId))) return false;
            if (this.Cidr != input.Cidr || (this.Cidr != null && input.Cidr != null && !this.Cidr.SequenceEqual(input.Cidr))) return false;
            if (this.IpVersion != input.IpVersion || (this.IpVersion != null && input.IpVersion != null && !this.IpVersion.SequenceEqual(input.IpVersion))) return false;
            if (this.Name != input.Name || (this.Name != null && input.Name != null && !this.Name.SequenceEqual(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && input.Description != null && !this.Description.SequenceEqual(input.Description))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.VirsubnetId != null) hashCode = hashCode * 59 + this.VirsubnetId.GetHashCode();
                if (this.Cidr != null) hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.IpVersion != null) hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
