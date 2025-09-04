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
    public class RateOnPeriodReq 
    {

        /// <summary>
        /// 项目ID。  说明： 获取方法： 步骤1：调用IAM获取委托Token接口，获取客户Token。步骤2：参见如何将合作伙伴Token置换为客户Token的步骤2，获取项目ID。IAM子用户调用此接口，需要IAM主账号授权，具体请参考创建用户组并授权。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 产品信息列表，询价时要询价产品的信息的列表，具体参见表1。
        /// </summary>
        [JsonProperty("product_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<PeriodProductInfo> ProductInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RateOnPeriodReq {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  productInfos: ").Append(ProductInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RateOnPeriodReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RateOnPeriodReq input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
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
                if (this.ProductInfos != null) hashCode = hashCode * 59 + this.ProductInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
