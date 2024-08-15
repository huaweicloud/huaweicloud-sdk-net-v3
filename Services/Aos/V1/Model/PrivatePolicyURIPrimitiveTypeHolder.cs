using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PrivatePolicyURIPrimitiveTypeHolder 
    {

        /// <summary>
        /// 策略文件的OBS地址。内容仅支持OPA开源引擎识别的，以Rego（https://www.openpolicyagent.org/docs/latest/policy-language/）语言编写的策略模板。  OBS地址支持同类型Region之间进行互相访问（Region分为通用Region和专属Region，通用Region指面向公共租户提供通用云服务的Region；专属Region指只承载同一类业务或只面向特定租户提供业务服务的专用Region）  策略文件当前支持单文件或zip压缩包，单文件需要以\&quot;.rego\&quot;结尾，压缩包当前只支持zip格式，文件需要以&#x60;.zip&#x60;结尾。  关于策略文件的校验要求如下：   * 文件必须是UTF8编码   * 创建时会对大小、格式、语法等进行校验   * 策略文件必须是UTF-8编码   * 单文件或压缩包解压前后的大小应控制在1MB以内   * 压缩包内的文件数量不能超过100个   * 压缩包内的文件路径最长为2048   * 压缩包内的文件名最长为255个字节  policy_uri和policy_body必须有且只有一个存在
        /// </summary>
        [JsonProperty("policy_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivatePolicyURIPrimitiveTypeHolder {\n");
            sb.Append("  policyUri: ").Append(PolicyUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivatePolicyURIPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivatePolicyURIPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PolicyUri == input.PolicyUri ||
                    (this.PolicyUri != null &&
                    this.PolicyUri.Equals(input.PolicyUri))
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
                if (this.PolicyUri != null)
                    hashCode = hashCode * 59 + this.PolicyUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
