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
    public class SlowlogResult 
    {

        /// <summary>
        /// 节点名称。
        /// </summary>
        [JsonProperty("node_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }

        /// <summary>
        /// 所属数据库。
        /// </summary>
        [JsonProperty("database", NullValueHandling = NullValueHandling.Ignore)]
        public string Database { get; set; }

        /// <summary>
        /// 执行语法。
        /// </summary>
        [JsonProperty("query_sample", NullValueHandling = NullValueHandling.Ignore)]
        public string QuerySample { get; set; }

        /// <summary>
        /// 语句类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 发生时间，UTC时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlowlogResult {\n");
            sb.Append("  nodeName: ").Append(NodeName).Append("\n");
            sb.Append("  database: ").Append(Database).Append("\n");
            sb.Append("  querySample: ").Append(QuerySample).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SlowlogResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SlowlogResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeName == input.NodeName ||
                    (this.NodeName != null &&
                    this.NodeName.Equals(input.NodeName))
                ) && 
                (
                    this.Database == input.Database ||
                    (this.Database != null &&
                    this.Database.Equals(input.Database))
                ) && 
                (
                    this.QuerySample == input.QuerySample ||
                    (this.QuerySample != null &&
                    this.QuerySample.Equals(input.QuerySample))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
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
                if (this.NodeName != null)
                    hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.Database != null)
                    hashCode = hashCode * 59 + this.Database.GetHashCode();
                if (this.QuerySample != null)
                    hashCode = hashCode * 59 + this.QuerySample.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
