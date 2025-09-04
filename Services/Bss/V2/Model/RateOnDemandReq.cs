using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RateOnDemandReq 
    {

        /// <summary>
        /// 项目ID。  说明： 使用客户Token，可以调用[通过assume_role方式获取用户token](https://support.huaweicloud.com/api-iam/iam_30_0003.html)接口获取“regionId”的取值对应的“project id”。具体请参见[如何将合作伙伴Token置换为客户Token](https://support.huaweicloud.com/bpconsole_faq/bpconsole_apifaq_00001.html)的步骤2。IAM子用户调用此接口，需要IAM主账号授权，具体请参考[创建用户组并授权](https://support.huaweicloud.com/usermanual-iam/iam_03_0001.html)。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 查询价格结果的精度模式。 0：询价结果默认精度截取，即最长保留到元后6位小数点，如0.000001元1：询价结果保留10位精度，即最长保留到元后10位小数点，如1.0000000001元  说明： 如果询价结果只到元后2位或者3位，那么价格也只到元后2位或者3位，不管传0或者传1都一样，只有询价结果到了小数点后面6位以上，传0和传1才有区别。
        /// </summary>
        [JsonProperty("inquiry_precision", NullValueHandling = NullValueHandling.Ignore)]
        public int? InquiryPrecision { get; set; }

        /// <summary>
        /// 产品信息列表，询价时要询价产品的信息的列表，具体参见表1。
        /// </summary>
        [JsonProperty("product_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<DemandProductInfo> ProductInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RateOnDemandReq {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  inquiryPrecision: ").Append(InquiryPrecision).Append("\n");
            sb.Append("  productInfos: ").Append(ProductInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RateOnDemandReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RateOnDemandReq input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.InquiryPrecision != input.InquiryPrecision || (this.InquiryPrecision != null && !this.InquiryPrecision.Equals(input.InquiryPrecision))) return false;
            if (this.ProductInfos != input.ProductInfos || (this.ProductInfos != null && input.ProductInfos != null && !this.ProductInfos.SequenceEqual(input.ProductInfos))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.InquiryPrecision != null) hashCode = hashCode * 59 + this.InquiryPrecision.GetHashCode();
                if (this.ProductInfos != null) hashCode = hashCode * 59 + this.ProductInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
