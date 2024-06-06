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
    /// 设置serverless配置策略请求体。
    /// </summary>
    public class UpdateServerlessPolicy 
    {

        /// <summary>
        /// 单节点VCPUs伸缩下限，取值范围可根据[查询数据库规格](https://support.huaweicloud.com/api-gaussdb/ShowGaussMySqlFlavors.html)接口获取。
        /// </summary>
        [JsonProperty("min_vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinVcpus { get; set; }

        /// <summary>
        /// 单节点VCPUs伸缩上限，取值范围可根据[查询数据库规格](https://support.huaweicloud.com/api-gaussdb/ShowGaussMySqlFlavors.html)接口获取。
        /// </summary>
        [JsonProperty("max_vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxVcpus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateServerlessPolicy {\n");
            sb.Append("  minVcpus: ").Append(MinVcpus).Append("\n");
            sb.Append("  maxVcpus: ").Append(MaxVcpus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateServerlessPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateServerlessPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MinVcpus == input.MinVcpus ||
                    (this.MinVcpus != null &&
                    this.MinVcpus.Equals(input.MinVcpus))
                ) && 
                (
                    this.MaxVcpus == input.MaxVcpus ||
                    (this.MaxVcpus != null &&
                    this.MaxVcpus.Equals(input.MaxVcpus))
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
                if (this.MinVcpus != null)
                    hashCode = hashCode * 59 + this.MinVcpus.GetHashCode();
                if (this.MaxVcpus != null)
                    hashCode = hashCode * 59 + this.MaxVcpus.GetHashCode();
                return hashCode;
            }
        }
    }
}
