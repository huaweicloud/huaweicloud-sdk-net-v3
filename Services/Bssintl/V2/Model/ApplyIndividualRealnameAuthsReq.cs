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
    public class ApplyIndividualRealnameAuthsReq 
    {

        /// <summary>
        /// 客户账号ID。您可以调用查询客户列表接口获取customer_id。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 认证方案： 0：个人证件认证
        /// </summary>
        [JsonProperty("identify_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? IdentifyType { get; set; }

        /// <summary>
        /// |参数名称：证件类型：0：身份证，上传的附件为3张，第1张是身份证人像面，第2张是身份证国徽面，第3张是个人手持身份证人像面；3：护照，上传的附件为3张，第1张是护照个人资料页，第2张是，护照入境盖章页，第3张是手持护照个人资料页；3：护照，上传的附件为2张，第1张是护照个人资料页，第2张是手持护照个人资料页；5：港澳通行证，上传的附件为3张，第1张是港澳居民来往内地通行证正面（人像面），第2张是港澳居民来往内地通行证反面，第3张是手持港澳居民来往内地通行证人像面；6：台湾通行证，上传的附件为3张，第1张是台湾居民来往大陆通行证正面（人像面），第2张是台湾居民来往大陆通行证反面，第3张是手持台湾居民来往大陆通行证人像面；9：港澳居民居住证，上传的附件为3张，第1张是港澳居民居住证人像面，第2张是，港澳居民居住证国徽面，第3张是手持港澳居民居住证人像面照片；10：台湾居民居住证，上传的附件为3张，第1张是台湾居民居住证人像面，第2张是台湾居民居住证国徽面，第3张是手持台湾居民居住证人像面照片。当identifyType&#x3D;0的时候，该字段需要填写，否则忽略该字段的取值。| |参数的约束及描述：证件类型：0：身份证，上传的附件为3张，第1张是身份证人像面，第2张是身份证国徽面，第3张是个人手持身份证人像面；3：护照，上传的附件为3张，第1张是护照个人资料页，第2张是，护照入境盖章页，第3张是手持护照个人资料页；3：护照，上传的附件为2张，第1张是护照个人资料页，第2张是手持护照个人资料页；5：港澳通行证，上传的附件为3张，第1张是港澳居民来往内地通行证正面（人像面），第2张是港澳居民来往内地通行证反面，第3张是手持港澳居民来往内地通行证人像面；6：台湾通行证，上传的附件为3张，第1张是台湾居民来往大陆通行证正面（人像面），第2张是台湾居民来往大陆通行证反面，第3张是手持台湾居民来往大陆通行证人像面；7：海外驾照，上传的附件为2张，第1张是中国以外驾照正面照片（人像面），第2张是手持中国以外驾照人像面照片；9：港澳居民居住证，上传的附件为3张，第1张是港澳居民居住证人像面，第2张是，港澳居民居住证国徽面，第3张是手持港澳居民居住证人像面照片；10：台湾居民居住证，上传的附件为3张，第1张是台湾居民居住证人像面，第2张是台湾居民居住证国徽面，第3张是手持台湾居民居住证人像面照片。当identifyType&#x3D;0的时候，该字段需要填写，否则忽略该字段的取值。|
        /// </summary>
        [JsonProperty("verified_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? VerifiedType { get; set; }

        /// <summary>
        /// 个人证件认证时证件附件的文件URL，该URL地址必须按照顺序填写。以护照举例，譬如护照个人资料页文件名称是abc023，手持护照个人资料页是def004，那么这个地方需要按照 abc023 def004 的顺序填写URL（文件名称区分大小写）。 证件附件目前仅仅支持jpg、jpeg、bmp、png、gif、pdf格式，单个文件最大不超过10M。这个URL是相对URL，不需要包含桶名和download目录，只要包含download目录下的子目录和对应文件名称即可。举例如下：如果上传的证件附件在桶中的位置是：https://bucketname.obs.Endpoint.myhuaweicloud.com/download/abc023.jpg，该字段填写abc023.jpg； 如果上传的证件附件在桶中的位置是：https://bucketname.obs.Endpoint.myhuaweicloud.com/download/test/abc023.jpg，该字段填写test/abc023.jpg。
        /// </summary>
        [JsonProperty("verified_file_url", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VerifiedFileUrl { get; set; }

        /// <summary>
        /// 姓名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 证件号码。
        /// </summary>
        [JsonProperty("verified_number", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifiedNumber { get; set; }

        /// <summary>
        /// 变更类型： -1：首次实名认证
        /// </summary>
        [JsonProperty("change_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChangeType { get; set; }

        /// <summary>
        /// 华为分给合作伙伴的平台标识。 该标识的具体值由华为分配。获取方法请参见如何获取xaccountType的取值。
        /// </summary>
        [JsonProperty("xaccount_type", NullValueHandling = NullValueHandling.Ignore)]
        public string XaccountType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyIndividualRealnameAuthsReq {\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  identifyType: ").Append(IdentifyType).Append("\n");
            sb.Append("  verifiedType: ").Append(VerifiedType).Append("\n");
            sb.Append("  verifiedFileUrl: ").Append(VerifiedFileUrl).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  verifiedNumber: ").Append(VerifiedNumber).Append("\n");
            sb.Append("  changeType: ").Append(ChangeType).Append("\n");
            sb.Append("  xaccountType: ").Append(XaccountType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyIndividualRealnameAuthsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyIndividualRealnameAuthsReq input)
        {
            if (input == null) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.IdentifyType != input.IdentifyType || (this.IdentifyType != null && !this.IdentifyType.Equals(input.IdentifyType))) return false;
            if (this.VerifiedType != input.VerifiedType || (this.VerifiedType != null && !this.VerifiedType.Equals(input.VerifiedType))) return false;
            if (this.VerifiedFileUrl != input.VerifiedFileUrl || (this.VerifiedFileUrl != null && input.VerifiedFileUrl != null && !this.VerifiedFileUrl.SequenceEqual(input.VerifiedFileUrl))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.VerifiedNumber != input.VerifiedNumber || (this.VerifiedNumber != null && !this.VerifiedNumber.Equals(input.VerifiedNumber))) return false;
            if (this.ChangeType != input.ChangeType || (this.ChangeType != null && !this.ChangeType.Equals(input.ChangeType))) return false;
            if (this.XaccountType != input.XaccountType || (this.XaccountType != null && !this.XaccountType.Equals(input.XaccountType))) return false;

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
                if (this.VerifiedType != null) hashCode = hashCode * 59 + this.VerifiedType.GetHashCode();
                if (this.VerifiedFileUrl != null) hashCode = hashCode * 59 + this.VerifiedFileUrl.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.VerifiedNumber != null) hashCode = hashCode * 59 + this.VerifiedNumber.GetHashCode();
                if (this.ChangeType != null) hashCode = hashCode * 59 + this.ChangeType.GetHashCode();
                if (this.XaccountType != null) hashCode = hashCode * 59 + this.XaccountType.GetHashCode();
                return hashCode;
            }
        }
    }
}
