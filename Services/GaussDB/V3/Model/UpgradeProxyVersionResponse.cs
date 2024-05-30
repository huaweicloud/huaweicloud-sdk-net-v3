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
    /// Response Object
    /// </summary>
    public class UpgradeProxyVersionResponse : SdkResponse
    {

        /// <summary>
        /// 数据库代理升级信息列表。
        /// </summary>
        [JsonProperty("update_result", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProxyUpgradeVersionDetail> UpdateResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeProxyVersionResponse {\n");
            sb.Append("  updateResult: ").Append(UpdateResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeProxyVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeProxyVersionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UpdateResult == input.UpdateResult ||
                    this.UpdateResult != null &&
                    input.UpdateResult != null &&
                    this.UpdateResult.SequenceEqual(input.UpdateResult)
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
                if (this.UpdateResult != null)
                    hashCode = hashCode * 59 + this.UpdateResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
