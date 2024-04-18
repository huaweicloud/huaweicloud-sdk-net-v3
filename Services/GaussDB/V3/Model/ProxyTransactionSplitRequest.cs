using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProxyTransactionSplitRequest 
    {

        /// <summary>
        /// 开启/关闭事务拆分，取值范围是[ON/OFF]
        /// </summary>
        [JsonProperty("transaction_split", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionSplit { get; set; }

        /// <summary>
        /// 实例的数据库代理列表，仅支持单proxy使用。
        /// </summary>
        [JsonProperty("proxy_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProxyIdList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProxyTransactionSplitRequest {\n");
            sb.Append("  transactionSplit: ").Append(TransactionSplit).Append("\n");
            sb.Append("  proxyIdList: ").Append(ProxyIdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProxyTransactionSplitRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProxyTransactionSplitRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionSplit == input.TransactionSplit ||
                    (this.TransactionSplit != null &&
                    this.TransactionSplit.Equals(input.TransactionSplit))
                ) && 
                (
                    this.ProxyIdList == input.ProxyIdList ||
                    this.ProxyIdList != null &&
                    input.ProxyIdList != null &&
                    this.ProxyIdList.SequenceEqual(input.ProxyIdList)
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
                if (this.TransactionSplit != null)
                    hashCode = hashCode * 59 + this.TransactionSplit.GetHashCode();
                if (this.ProxyIdList != null)
                    hashCode = hashCode * 59 + this.ProxyIdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
