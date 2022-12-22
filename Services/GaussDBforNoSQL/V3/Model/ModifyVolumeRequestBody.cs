using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyVolumeRequestBody 
    {

        /// <summary>
        /// 待变更到的磁盘容量。单位GB，取值为整数。 扩容场景下，必须大于当前磁盘容量。 缩容场景下，必须大于已用量的125%，向上取整。 磁盘容量的上下限与所选引擎类型以及规格相关。   - [GaussDB(for Cassandra)请参见[数据库实例规格](https://support.huaweicloud.com/cassandraug-nosql/nosql_05_0017.html)。](tag:hc)   - [GaussDB(for Cassandra)请参见[数据库实例规格。](https://support.huaweicloud.com/intl/zh-cn/cassandraug-nosql/nosql_05_0017.html)](tag:hk)   - [GaussDB(for Redis)请参见[数据库实例规格。](https://support.huaweicloud.com/redisug-nosql/nosql_05_0059.html)](tag:hc)   - [GaussDB(for Redis)请参见[数据库实例规格。](https://support.huaweicloud.com/intl/zh-cn/redisug-nosql/nosql_05_0059.html)](tag:hk)
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 扩容包年包月实例存储容量时可指定，表示是否自动从账户中支付，此字段不影响自动续订的支付方式。   - true，表示自动从账户中支付。   - false，表示手动从账户中支付，默认为该方式。
        /// </summary>
        [JsonProperty("is_auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoPay { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyVolumeRequestBody {\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyVolumeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyVolumeRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.IsAutoPay == input.IsAutoPay ||
                    (this.IsAutoPay != null &&
                    this.IsAutoPay.Equals(input.IsAutoPay))
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
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.IsAutoPay != null)
                    hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                return hashCode;
            }
        }
    }
}
