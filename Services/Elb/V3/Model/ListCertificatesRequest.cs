using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListCertificatesRequest 
    {

        /// <summary>
        /// 上一页最后一条记录的ID。  使用说明： - 必须与limit一起使用。 - 不指定时表示查询第一页。 - 该字段不允许为空或无效的ID。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 参数解释：每页返回的个数。  取值范围：0-2000  默认取值：2000
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 是否反向查询。  取值： - true：查询上一页。 - false：查询下一页，默认。  使用说明： - 必须与limit一起使用。 - 当page_reverse&#x3D;true时，若要查询上一页，marker取值为当前页返回值的previous_marker。
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 证书ID。  支持多值查询，查询条件格式：*id&#x3D;xxx&amp;id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 证书的名称。  支持多值查询，查询条件格式：*name&#x3D;xxx&amp;name&#x3D;xxx*。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// 证书的描述。  支持多值查询，查询条件格式：*description&#x3D;xxx&amp;description&#x3D;xxx*。
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Description { get; set; }

        /// <summary>
        /// 证书的管理状态。  不支持该字段，请勿使用。
        /// </summary>
        [SDKProperty("admin_state_up", IsQuery = true)]
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 服务器证书所签域名。该字段仅type为server时有效。  支持多值查询，查询条件格式：domain&#x3D;xxx&amp;domain&#x3D;xxx。
        /// </summary>
        [SDKProperty("domain", IsQuery = true)]
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Domain { get; set; }

        /// <summary>
        /// 证书的类型。分为服务器证书(server)和CA证书(client)。  支持多值查询，查询条件格式：type&#x3D;xxx&amp;type&#x3D;xxx。
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Type { get; set; }

        /// <summary>
        /// SCM证书ID。  支持多值查询，查询条件格式：scm_certificate_id&#x3D;xxx&amp;scm_certificate_id&#x3D;xxx。
        /// </summary>
        [SDKProperty("scm_certificate_id", IsQuery = true)]
        [JsonProperty("scm_certificate_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ScmCertificateId { get; set; }

        /// <summary>
        /// 证书的主域名。  支持多值查询，查询条件格式：common_name&#x3D;xxx&amp;common_name&#x3D;xxx。
        /// </summary>
        [SDKProperty("common_name", IsQuery = true)]
        [JsonProperty("common_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CommonName { get; set; }

        /// <summary>
        /// 证书的指纹。  支持多值查询，查询条件格式：fingerprint&#x3D;xxx&amp;fingerprint&#x3D;xxx。
        /// </summary>
        [SDKProperty("fingerprint", IsQuery = true)]
        [JsonProperty("fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fingerprint { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCertificatesRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  scmCertificateId: ").Append(ScmCertificateId).Append("\n");
            sb.Append("  commonName: ").Append(CommonName).Append("\n");
            sb.Append("  fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCertificatesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCertificatesRequest input)
        {
            if (input == null) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.PageReverse != input.PageReverse || (this.PageReverse != null && !this.PageReverse.Equals(input.PageReverse))) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && input.Name != null && !this.Name.SequenceEqual(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && input.Description != null && !this.Description.SequenceEqual(input.Description))) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && input.Domain != null && !this.Domain.SequenceEqual(input.Domain))) return false;
            if (this.Type != input.Type || (this.Type != null && input.Type != null && !this.Type.SequenceEqual(input.Type))) return false;
            if (this.ScmCertificateId != input.ScmCertificateId || (this.ScmCertificateId != null && input.ScmCertificateId != null && !this.ScmCertificateId.SequenceEqual(input.ScmCertificateId))) return false;
            if (this.CommonName != input.CommonName || (this.CommonName != null && input.CommonName != null && !this.CommonName.SequenceEqual(input.CommonName))) return false;
            if (this.Fingerprint != input.Fingerprint || (this.Fingerprint != null && input.Fingerprint != null && !this.Fingerprint.SequenceEqual(input.Fingerprint))) return false;

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
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.PageReverse != null) hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ScmCertificateId != null) hashCode = hashCode * 59 + this.ScmCertificateId.GetHashCode();
                if (this.CommonName != null) hashCode = hashCode * 59 + this.CommonName.GetHashCode();
                if (this.Fingerprint != null) hashCode = hashCode * 59 + this.Fingerprint.GetHashCode();
                return hashCode;
            }
        }
    }
}
