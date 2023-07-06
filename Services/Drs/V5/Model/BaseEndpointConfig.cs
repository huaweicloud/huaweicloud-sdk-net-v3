using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 数据库基本设置信息体，当源库或者目标库在特定场景下需要额外设置时填写。例如： - 实时迁移入云场景：云数据库（RDS for MySQL）、云数据库 GaussDB(for MySQL) 主备版作为目标库（target_endpoint）时，需要设置“只读”或者“读写”（is_target_readonly)。 - 实时迁移入云场景：分布式数据库中间件DDM作为目标库，源库为MySQL分库分表时，需要设置“端数据库实例个数”。 - 实时迁移入云场景：MongoDB作为源库时，需要设置“源数据库实例类型”为非集群、集群或者集群(MongoDB 4.0+)，并且实例类型为“集群”时，还需要设置“源端分片个数”（source_shard_num)。 - 实时灾备场景：单主灾备且本云为备时，云数据库（RDS for MySQL）、云数据库 GaussDB(for MySQL) 主备版、分布式数据库中间件DDM、文档数据库服务DDS等作为目标库（target_endpoint）时，需要设置“只读”或者“读写”（is_target_readonly)。 - 实时灾备场景：云数据库GaussDB(for Cassandra) 灾备时，需要设置“是否迁移TTL”，如果参数为true时，还需要设置TTL列名。
    /// </summary>
    public class BaseEndpointConfig 
    {

        /// <summary>
        /// 目标实例是否设置为为只读。 - MySQL迁移和灾备，且job_direction为up时设置有效。（灾备场景下，单主灾备且本云为备为必填且为true，不填默认设置为true）。
        /// </summary>
        [JsonProperty("is_target_readonly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTargetReadonly { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseEndpointConfig {\n");
            sb.Append("  isTargetReadonly: ").Append(IsTargetReadonly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BaseEndpointConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BaseEndpointConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsTargetReadonly == input.IsTargetReadonly ||
                    (this.IsTargetReadonly != null &&
                    this.IsTargetReadonly.Equals(input.IsTargetReadonly))
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
                if (this.IsTargetReadonly != null)
                    hashCode = hashCode * 59 + this.IsTargetReadonly.GetHashCode();
                return hashCode;
            }
        }
    }
}
