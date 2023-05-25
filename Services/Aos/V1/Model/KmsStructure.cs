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
    /// 如果用户给与的var_value是经过KMS加密的，可以通过传递相关加密信息，资源编排服务在使用的时候会帮助用户进行KMS解密  更多关于KMS加密以及KMS加密的样例代码请见：[[KMS加密使用场景介绍](https://support.huaweicloud.com/productdesc-dew/dew_01_0006.html)](tag:hws)[[KMS加密使用场景介绍](https://support.huaweicloud.com/intl/zh-cn/productdesc-dew/dew_01_0006.html)](tag:hws_hk)[[KMS加密使用场景介绍](https://support.huaweicloud.com/eu/productdesc-dew/dew_01_0006.html)](tag:hws_eu)   **注意：**   * 请确保用户给予资源编排服务的委托中包含对指定秘钥ID的操作权限   * KMS每个月有免费试用的额度，如果超过，则KMS需要收费，此费用不是资源编排服务收取，具体标准见：[[https://www.huaweicloud.com/pricing.html?tab&#x3D;detail#/dew](https://www.huaweicloud.com/pricing.html?tab&#x3D;detail#/dew)](tag:hws)[[https://www.huaweicloud.com/intl/zh-cn/pricing/index.html#/kms](https://www.huaweicloud.com/intl/zh-cn/pricing/index.html#/kms)](tag:hws_hk)[[https://www.huaweicloud.com/eu/pricing/index.html#/dew](https://www.huaweicloud.com/eu/pricing/index.html#/dew)](tag:hws_eu)   * KMS加密只代表资源编排服务在存储和传输的时候传递的是密文，但是在stack-events中依然是明文，如果希望在log中以密文形式对待，请在模板中声名sensitive，更多关于sensitive的介绍见：[https://learn.hashicorp.com/tutorials/terraform/sensitive-variables](https://learn.hashicorp.com/tutorials/terraform/sensitive-variables)
    /// </summary>
    public class KmsStructure 
    {

        /// <summary>
        /// 解密时，资源编排服务应该使用的KMS秘钥的ID，通常是加密时所使用的秘钥ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 数据加密秘钥所对应的密文
        /// </summary>
        [JsonProperty("cipher_text", NullValueHandling = NullValueHandling.Ignore)]
        public string CipherText { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KmsStructure {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  cipherText: ").Append(CipherText).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KmsStructure);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KmsStructure input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CipherText == input.CipherText ||
                    (this.CipherText != null &&
                    this.CipherText.Equals(input.CipherText))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CipherText != null)
                    hashCode = hashCode * 59 + this.CipherText.GetHashCode();
                return hashCode;
            }
        }
    }
}
