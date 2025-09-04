using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ChangeEnterpriseRealnameAuthsReq 
    {

        /// <summary>
        /// 客户账号ID。您可以调用查询客户列表接口获取customer_id。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 认证方案： 1：单位证件扫描
        /// </summary>
        [JsonProperty("identify_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? IdentifyType { get; set; }

        /// <summary>
        /// 单位证件类型： 0：企业营业执照 1：事业单位法人证书 2：社会团体法人登记证书 3：行政执法主体资格证 4：组织机构代码证 99：其他
        /// </summary>
        [JsonProperty("certificate_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateType { get; set; }

        /// <summary>
        /// 单位证件认证时证件附件的文件URL。 附件地址必须按照顺序填写，先填写单位证件的附件，如果存在单位人员信息，再填写单位人员的身份证附件。 单位证件顺序为： 第1张单位证件照正面， 第2张单位证件照反面， 个人证件顺序为： 第1张个人证件的人像面 第2张个人证件的国徽面 假设不存在法人的情况下，第1张上传的是单位证件正面扫描件abc.023，第2张上传的是单位证件反面扫描件def004，那么上传顺序需要是： abc023 def004 的顺序填写URL（文件名称区分大小写） 证件附件目前仅仅支持jpg、jpeg、bmp、png、gif、pdf格式，单个文件最大不超过10M。 这个URL是相对URL，不需要包含桶名和download目录，只要包含download目录下的子目录和对应文件名称即可。举例如下： 如果上传的证件附件在桶中的位置是： https://bucketname.obs.Endpoint.myhuaweicloud.com/download/abc023.jpg，该字段填写abc023.jpg； 如果上传的证件附件在桶中的位置是： https://bucketname.obs.Endpoint.myhuaweicloud.com/download/test/abc023.jpg，该字段填写test/abc023.jpg。
        /// </summary>
        [JsonProperty("verified_file_url", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VerifiedFileUrl { get; set; }

        /// <summary>
        /// 单位名称。 不能全是数字、特殊字符、空格。
        /// </summary>
        [JsonProperty("corp_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CorpName { get; set; }

        /// <summary>
        /// 单位证件号码。
        /// </summary>
        [JsonProperty("verified_number", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifiedNumber { get; set; }

        /// <summary>
        /// 实名认证填写的注册国家。国家的两位字母简码。 例如：注册国家为“中国”请填写“CN”。
        /// </summary>
        [JsonProperty("reg_country", NullValueHandling = NullValueHandling.Ignore)]
        public string RegCountry { get; set; }

        /// <summary>
        /// 实名认证企业注册地址。
        /// </summary>
        [JsonProperty("reg_address", NullValueHandling = NullValueHandling.Ignore)]
        public string RegAddress { get; set; }

        /// <summary>
        /// 变更类型： 1：个人变企业
        /// </summary>
        [JsonProperty("change_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChangeType { get; set; }

        /// <summary>
        /// 华为分给合作伙伴的平台标识。 该标识的具体值由华为分配。获取方法请参见如何获取xaccountType的取值。
        /// </summary>
        [JsonProperty("xaccount_type", NullValueHandling = NullValueHandling.Ignore)]
        public string XaccountType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enterprise_person", NullValueHandling = NullValueHandling.Ignore)]
        public EnterprisePersonNew EnterprisePerson { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeEnterpriseRealnameAuthsReq {\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  identifyType: ").Append(IdentifyType).Append("\n");
            sb.Append("  certificateType: ").Append(CertificateType).Append("\n");
            sb.Append("  verifiedFileUrl: ").Append(VerifiedFileUrl).Append("\n");
            sb.Append("  corpName: ").Append(CorpName).Append("\n");
            sb.Append("  verifiedNumber: ").Append(VerifiedNumber).Append("\n");
            sb.Append("  regCountry: ").Append(RegCountry).Append("\n");
            sb.Append("  regAddress: ").Append(RegAddress).Append("\n");
            sb.Append("  changeType: ").Append(ChangeType).Append("\n");
            sb.Append("  xaccountType: ").Append(XaccountType).Append("\n");
            sb.Append("  enterprisePerson: ").Append(EnterprisePerson).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeEnterpriseRealnameAuthsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeEnterpriseRealnameAuthsReq input)
        {
            if (input == null) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.IdentifyType != input.IdentifyType || (this.IdentifyType != null && !this.IdentifyType.Equals(input.IdentifyType))) return false;
            if (this.CertificateType != input.CertificateType || (this.CertificateType != null && !this.CertificateType.Equals(input.CertificateType))) return false;
            if (this.VerifiedFileUrl != input.VerifiedFileUrl || (this.VerifiedFileUrl != null && input.VerifiedFileUrl != null && !this.VerifiedFileUrl.SequenceEqual(input.VerifiedFileUrl))) return false;
            if (this.CorpName != input.CorpName || (this.CorpName != null && !this.CorpName.Equals(input.CorpName))) return false;
            if (this.VerifiedNumber != input.VerifiedNumber || (this.VerifiedNumber != null && !this.VerifiedNumber.Equals(input.VerifiedNumber))) return false;
            if (this.RegCountry != input.RegCountry || (this.RegCountry != null && !this.RegCountry.Equals(input.RegCountry))) return false;
            if (this.RegAddress != input.RegAddress || (this.RegAddress != null && !this.RegAddress.Equals(input.RegAddress))) return false;
            if (this.ChangeType != input.ChangeType || (this.ChangeType != null && !this.ChangeType.Equals(input.ChangeType))) return false;
            if (this.XaccountType != input.XaccountType || (this.XaccountType != null && !this.XaccountType.Equals(input.XaccountType))) return false;
            if (this.EnterprisePerson != input.EnterprisePerson || (this.EnterprisePerson != null && !this.EnterprisePerson.Equals(input.EnterprisePerson))) return false;

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
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.IdentifyType != null) hashCode = hashCode * 59 + this.IdentifyType.GetHashCode();
                if (this.CertificateType != null) hashCode = hashCode * 59 + this.CertificateType.GetHashCode();
                if (this.VerifiedFileUrl != null) hashCode = hashCode * 59 + this.VerifiedFileUrl.GetHashCode();
                if (this.CorpName != null) hashCode = hashCode * 59 + this.CorpName.GetHashCode();
                if (this.VerifiedNumber != null) hashCode = hashCode * 59 + this.VerifiedNumber.GetHashCode();
                if (this.RegCountry != null) hashCode = hashCode * 59 + this.RegCountry.GetHashCode();
                if (this.RegAddress != null) hashCode = hashCode * 59 + this.RegAddress.GetHashCode();
                if (this.ChangeType != null) hashCode = hashCode * 59 + this.ChangeType.GetHashCode();
                if (this.XaccountType != null) hashCode = hashCode * 59 + this.XaccountType.GetHashCode();
                if (this.EnterprisePerson != null) hashCode = hashCode * 59 + this.EnterprisePerson.GetHashCode();
                return hashCode;
            }
        }
    }
}
