using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateSqlLimitRuleReqV3 
    {

        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// SQL限流ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 同时执行的sql数量，小于等于0表示不限制，默认为0，取值范围（-1~50000）。
        /// </summary>
        [JsonProperty("max_concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// 最大等待时间，单位为秒。
        /// </summary>
        [JsonProperty("max_waiting", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxWaiting { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSqlLimitRuleReqV3 {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  maxConcurrency: ").Append(MaxConcurrency).Append("\n");
            sb.Append("  maxWaiting: ").Append(MaxWaiting).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSqlLimitRuleReqV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSqlLimitRuleReqV3 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DbName == input.DbName ||
                    (this.DbName != null &&
                    this.DbName.Equals(input.DbName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MaxConcurrency == input.MaxConcurrency ||
                    (this.MaxConcurrency != null &&
                    this.MaxConcurrency.Equals(input.MaxConcurrency))
                ) && 
                (
                    this.MaxWaiting == input.MaxWaiting ||
                    (this.MaxWaiting != null &&
                    this.MaxWaiting.Equals(input.MaxWaiting))
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
                if (this.DbName != null)
                    hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MaxConcurrency != null)
                    hashCode = hashCode * 59 + this.MaxConcurrency.GetHashCode();
                if (this.MaxWaiting != null)
                    hashCode = hashCode * 59 + this.MaxWaiting.GetHashCode();
                return hashCode;
            }
        }
    }
}
